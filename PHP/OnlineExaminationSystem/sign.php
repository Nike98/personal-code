<?php
include_once 'dbConnection.php';
ob_start();
$name = $_POST['name'];
$name = ucwords(strtolower($name));
$gender = $_POST['gender'];
$email = $_POST['email'];
$college = $_POST['college'];
$mobile = $_POST['mobile'];
$password = $_POST['password'];

$name = stripslashes($name);        // NAME
$name = addslashes($name);
$name = ucwords(strtolower($name));
$gender = stripslashes($gender);    // GENDER
$gender = addslashes($gender);
$email = stripslashes($email);      // EMAIL
$email = addslashes($email);
$college = stripslashes($college);  // COLLEGE
$college = addslashes($college);
$mobile = stripslashes($mobile);    // MOBILE
$mobile = addslashes($mobile);
$password = stripslashes($password);// PASSWORD
$password = addslashes($password);
$password = md5($password);

$q3 = mysqli_query($con, "INSERT INTO user VALUES ('$name', '$gender', '$college', '$email', '$mobile', '$password')");
if ($q3){
    session_start();
    $_SESSION["email"] = $email;
    $_SESSION["name"] = $name;

    header("location:account.php?q=1");
} else
    header("location:index.php?q7=Email Already Registered");

ob_end_flush();
?>