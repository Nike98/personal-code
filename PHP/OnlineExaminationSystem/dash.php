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
                                <span class="glyphicon glyphicon-user" aria-hidden="true">&emsp;Hello,
                            </span>
                            <a href="account.php" class="log log1"' .$name.'</a>&nbsp;|&nbsp;
                            <a href="logout.php?q=account.php" class="log"></a>
                            <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                          </span>';
                }
            ?>
        </div> <!-- / .row -->
    </div> <!-- / .header -->

    <!-- Navigation Menu Code Starts here -->
    <nav class="navbar navbar-default title1">
        <div class="container-fluid">
            <!-- Brand and toggle get grouped for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle Navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="dash.php?q=0"><b>Dashboard</b></a>
            </div> <!-- / .navbar-header -->
            <!-- Collect the nav links, forms and other content for toggling -->
            <div class="collapse navbar-collapse" id="bs-example-navbar-collapse-1">
                <ul class="nav navbar-nav">
                    <li <?php if (@$_GET['q'] == 0) echo 'class="active"';?>>
                        <a href="dash.php?q=0">
                            Home<span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li <?php if (@$_GET['q'] == 1) echo 'class="active"';?>>
                        <a href="dash.php?q=1">User</a>
                    </li>
                    <li <?php if (@$_GET['q'] == 2) echo 'class="active"';?>>
                        <a href="dash.php?q=2">Ranking</a>
                    </li>
                    <li <?php if (@$_GET['q'] == 3) echo 'class="active"';?>>
                        <a href="dash.php?q=3">Feedback</a>
                    </li>
                    <li class="dropdown <?php if (@$_GET['q'] == 4 || @$_GET['q'] == 5) echo 'active';?>">
                        <a href="#" calss="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-exapnded="false">
                            Quiz
                            <span class="caret"></span>
                        </a> <!-- / .dropdown-toggle -->
                        <ul class="dropdown-menu">
                            <li><a href="dash.php?q=4">Remove Quiz</a></li>
                            <li><a href="dash.php?q=5"></a>Add Quiz</li>
                        </ul>
                    </li>
                    <li class="pull-right">
                        <a href="logout.php?q=account.php">
                            <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                            &emsp;Signout
                        </a>
                    </li>
                </ul> <!-- / .nav navbar-nav -->
            </div> <!-- / #bs-example-navbar-collapse-1 -->
        </div> <!-- / .container-fluid -->
    </nav>
    <!-- Navigation Menu Code Ends here -->

<div class="container">
    <div class="row">
        <div class="col-md-12">
            <!-- Home PHP code starts here -->
            <?php
            if (@$_GET['q'] == 0){
                $result = mysqli_query($con, "SELECT * FROM 'quiz' ORDER BY date DESC") or die('Error');
                echo '<div class="panel">
                      <div class="table-responsive">
                      <table class="table table-striped title1">
                        <tr>
                            <td>Sr.No.</td>
                            <td><b>Topic</b></td>
                            <td><b>Total Questions</b></td>
                            <td><b>Marks</b></td>
                            <td><b>Time Limit</b></td>
                        </tr>';
                $c = 1;
                while ($row = mysqli_fetch_array($result)){
                    $title = $row['title'];
                    $total = $row['total'];
                    $sahi = $row['sahi'];
                    $time = $row['time'];
                    $eid = $row['eid'];
                    $q12 = mysqli_query($con, "SELECT score FROM history WHERE eid='$eid' AND email='$email'") or die('Error98');
                    $rowcount = mysqli_num_rows($q12);
                    if ($rowcount == 0){
                        echo'<tr>
                                <td>'.$c++.'</td>
                                <td>'.$title.'</td>
                                <td>'.$total.'</td>
                                <td>'.$sahi * $total.'</td>
                                <td>'.$time.'&nbsp;min</td>
                                <td><b>
                                    <a href="account.php?q=quiz&step=2&eid="'.$eid.'&n=1&t='.$total.'" class="pull-right btn sub1" style="margin:0px;background:#99cc32">
                                        <span class="glyphicon glyphicon-new-window" aria-hidden="true"></span>&nbsp;
                                        <span class="title1"><b>Start</b></span>
                                    </a>
                                </b></td>
                             </tr>';
                    } else {
                        echo'<tr>
                                <td>'.$c++.'</td>
                                <td>'.$title.'&nbsp;<span title="This Quiz is already solved by you!" class="glyphicon glyphicon-ok" aria-hidden="true"></span></td>
                                <td>'.$total.'</td>
                                <td>'.$sahi * $total.'</td>
                                <td>'.$time.'&nbsp;min</td>
                                <td><b>
                                    <a href="update.php?q=quizre&step=25&eid="'.$eid.'&n=1&t='.$total.'" class="pull-right btn sub1" style="margin:0px;background:red">
                                        <span class="glyphicon glyphicon-repeat" aria-hidden="true"></span>&nbsp;
                                        <span class="title1"><b>Restart</b></span>
                                    </a>
                                </b></td>
                             </tr>';
                    }
                }
                $c=0;
                echo'</table></div></div>';
            }
            ?>
            <!-- Home PHP code Ends here -->

            <!-- Feedback PHP code starts here -->
            <?php
            if (@$_GET['q'] == 3){
                $result = mysqli_query($con, "SELECT * FROM 'feedback' ORDER BY 'feedback'.'date' DESC") or die('Error');
                echo '<div class="panel">
                      <div class="table-responsive">
                      <table class="table table-striped title1">
                        <tr>
                            <td><b>Sr.No.</b></td>
                            <td><b>Subject</b></td>
                            <td><b>Email</b></td>
                            <td><b>Date</b></td>
                            <td><b>Time</b></td>
                            <td><b>By</b></td>
                            <td></td>
                        </tr>';
                $c = 1;
                while ($row = mysqli_fetch_array($result)){
                    $date = $row['date'];
                    $date = date("d-m-y", strtotime($date));
                    $time = $row['time'];
                    $subject = $row['subject'];
                    $name = $rwo['name'];
                    $email = $row['email'];
                    $id = $row['id'];
                    echo'<tr><td>'.$c++.'</td>';
                    echo'<td><a title="Click to open Feedback" href="dash.php?q=3&fid="'.$id.'">'.$subject.'</a></td>
                         <td>'.$email.'</td>
                         <td>'.$date.'</td>
                         <td>'.$time.'</td>
                         <td>'.$name.'</td>
                         <td><a title="Open Feedback" href="dash.php?q=3&fid="'.$id.'>
                            <b><span class="glyphicon glyphicon-trash" aria-hidden="true"></span></b></a>
                         </td>';
                    echo'<td><a title="Delete Feedback" href="update.php?fid="'.$id.'">
                            <b><span class="glyphicon glyphicon-trash" aria-hidden="true"></span></b></a>
                         </td>
                         </tr>';
                }
                echo'</table></div></div>';
            }
            ?>
            <!-- Feedback PHP code Ends here -->
        </div> <!-- / .col-md-12 -->
    </div> <!-- / .row -->
</div> <!-- / .container -->
</body>
</html>