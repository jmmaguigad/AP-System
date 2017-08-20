<?php
/*Set of functions*/
// itexmo sms sending script
// do not touch
function itexmo($number,$message,$apicode){
	$ch = curl_init();
	$itexmo = array('1' => $number, '2' => $message, '3' => $apicode);
	curl_setopt($ch, CURLOPT_URL,"https://www.itexmo.com/php_api/api.php");
	curl_setopt($ch, CURLOPT_POST, 1);
	 curl_setopt($ch, CURLOPT_POSTFIELDS, 
	          http_build_query($itexmo));
	curl_setopt($ch, CURLOPT_RETURNTRANSFER, true);
	return curl_exec ($ch);
	curl_close ($ch);
}

function createCode($digits) {
	$code = str_pad(rand(0,pow(10,$digits)-1),$digits,'0',STR_PAD_LEFT);
	return $code;
}
// end itexmo
/*End of Set of functions*/

// start of database manipulation
$servername = "localhost";
$username = "jologs_hrmnew";
$password = "cYtology28";
$dbname = "jologs_hrmnew";

try {
	$conn = new PDO("mysql:host=$servername;dbname=$dbname",$username,$password);
	$conn->setAttribute(PDO::ATTR_ERRMODE,PDO::ERRMODE_EXCEPTION);

	//bug #3 fix 
	//reset table
	$conn->exec("DELETE FROM attendancecredentials");

	//start of selecting employees
	$selStmt = $conn->prepare("SELECT id, mobile_phone, first_name FROM employees");
	$selStmt->execute();
	$result = $selStmt->fetchAll();

	foreach ($result as $row) {
		// variables
		$employee = $row['id'];
		$att_code = createCode(4);
		$att_date = date("Y-m-d",strtotime($stop_date . ' +1 day'));

		//trap if there is double code for the day
		$stmt_checker = $conn->prepare("SELECT COUNT(*) as cntChecker FROM attendancecredentials WHERE employee= :employeeid AND att_date = CURRENT_DATE"); //:att_date
		$stmt_checker->bindValue(':employeeid',$employee);		
		//$stmt_checker->bindValue(':att_date',$att_date);		
		$stmt_checker->execute();
		$count_checker=$stmt_checker->fetch(PDO::FETCH_ASSOC);

		if ($count_checker['cntChecker'] == 0) {
			echo "Wew";
			echo $att_date;
			$stmt = $conn->prepare("INSERT INTO attendancecredentials (employee,att_code,att_date) VALUES (?,?,?)");
			$stmt->execute(array($employee,$att_code,$att_date));

			$employee_no = $row['mobile_phone'];
			$attendance_code = "Good Morning ".$row['first_name'].", your attendance code is ".$att_code;

			$result = itexmo($employee_no,$attendance_code,"ST-MUREY276378_UW1PG");
			if ($result == ""){
				echo "No response from server.";	
			}else if ($result == 0){
				echo "Message Sent!";
			}
			else{	
				echo "Error Num ". $result . " was encountered!";
			}
		} else {
			echo "Error: Code was sent already! Duplication detected!";
			echo $att_date;
		}
	}
} catch (PDOException $e) {
	echo "Error: ". $e->getMessage();
}
$conn = null;