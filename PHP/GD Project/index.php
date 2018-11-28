<?php

$servername = "localhost";
$username = "root";
$password = "newpass";
$dbname = "nikhil";
$conn = new mysqli($servername, $username, $password, $dbname);

session_start();

if (isset($_SESSION['loggedIn'])){
    header('Location: dashboard.php');
    exit();
}

//For Login
    if (isset($_POST['login'])){
        $email = $conn->real_escape_string($_POST['email']);
        $pass = $conn->real_escape_string($_POST['password']);

        $loginData = $conn->query("SELECT id FROM users WHERE email = '$email' AND password = '$pass'");
        if ($loginData->num_rows > 0){
            $_SESSION['loggedIn'] = '1';
            exit("Success");
        }
        else
            exit("Failed");
    }

?>

<!DOCTYPE html>
<html lang="en">
<head>
    <link rel="stylesheet" href="js/jquery-3.3.1.js">
    <link rel="stylesheet" href="js/bootstrap.min.js">
    <link rel="stylesheet" href="css/bootstrap.css">
    <script type="text/javascript" src="js/jquery-3.3.1.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <title>Login</title>
</head>
<body>
    <div class="container" style="margin-top: 150px; margin-left: 500px;">
        <div class="row">
            <div class="col-md-4 col-md-offset-2">
                <form method="post" action="index.php">
                    <h1>Login</h1><br>
                    <input type="text" id="email" class="form-control" placeholder="Email"><br>
                    <input type="password" id="password" class="form-control" placeholder="Password..."><br>
                    <input type="submit" value="Log In" id="login" class="btn btn-success">
                    <input type="file">
                </form>
            </div>
        </div>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("#login").on('click', function () {
                var email = $("#email").val();
                var password = $("#password").val();
                
                // To check if any of the fields are empty
                if (email == "" || password == "")
                    alert('Please check your inputs');
                else{
                    $.ajax({
                        url: "index.php",
                        method: 'POST',
                        datatype: 'text',
                        data: {
                            login: 1,
                            email: email,
                            password: password,
                        },
                        success: function (response) {
                            console.log(response);

                            if (response.indexOf('Success') >= 0){
                                window.location = 'dashboard.php';
                            }
                        }
                    });
                }
            });
        });
    </script>
</body>
</html>