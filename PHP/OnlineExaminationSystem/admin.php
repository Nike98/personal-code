<?php
    include_once 'dbConnection.php';
    $ref = @$_GET['q'];
    $email = $_POST['uname'];
    $password = $_POST['password'];

    $email = stripcslashes($email);
    $email = addslashes($email);
    $password = stripcslashes($password);
    $password = addslashes($password);
    $result = mysqli_query($con, "SELECT email FROM admin WHERE email = '$email' and password = '$password'")
                            or die('Error');
    $count = mysqli_num_rows($result);

    if ($count == 1) {
        if (isset($_SESSION['email'])) {
            session_unset();
        }

        $_SESSION["name"] = 'Admin';
        $_SESSION["key"] = 'nikhil123456';
        $_SESSION["email"] = $email;
        header("location:dash.php?q=0");
    } else header("location:$ref?w=Warning : Access Denied");
 ?>