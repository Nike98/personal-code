<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta content="text/html; charset=iso-8859-1" http-equiv="Content-Type"/>
    <meta name="viewport" content="width=device-width, initial-scale=1"/>
    <link href='http://fonts.googleapis.com/css?family=Roboto:400,700,300' rel='stylesheet' type='text/css'>
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/bootstrap-theme.min.css"/>
    <link rel="stylesheet" href="css/font.css"/>
    <link rel="stylesheet" href="css/main.css"/>
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>

    <title>DASHBOARD</title>

    <script>
        $(function () {
            $(document).on('scroll', function () {
                console.log('scroll top : ' + $(window).scrollTop());
                if ($(window).scrollTop() >= $(".logo").height()){
                    $(".navbar").addClass(("navbar-fixed-top"));
                }

                if ($(window).scrollTop() < $(".logo").height()){
                    $(".navbar").removeClass("navbar-fixed-top");
                }
            });
        });
    </script>
</head>
<body style="background: #eee;">
    <div class="header">
        <div class="row">
            <div class="col-lg-6">
                <span class="logo">Test Your Skills</span>
            </div> <!-- / .col-lg-6 -->
            <?php
                include_once 'dbConnection.php';
                session_start();
                $email = $_SESSION['email'];
                if (!(isset($_SESSION['email']))){
                    header("location:index.php");
                } else {
                    $name = $_SESSION['name'];
                    include_once 'dbConnection.php';
                    echo '<span class="pull-right top title1">
                            <span class="log1">
                                <span class="glyphicon glyphicon-user" aria-hidden="true">&emsp;Hello,</span>
                                <a href="account.php" class="log log1"' .$name.'</a>&nbsp;|&nbsp;
                                <a href="logout.php?q=account.php" class="log"></a>
                                <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                                </span></span>';
                }
            ?>
            ?>
        </div> <!-- / .row -->
    </div> <!-- / .header -->
</body>
</html>