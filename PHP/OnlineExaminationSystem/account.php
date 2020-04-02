<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html charset-iso-8859-1" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/bootstrap-theme.min.css" />
    <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/font.css" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Roboto:400,700,300" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>

    <title>TEST YOUR SKILL</title>

    <?php
    // For Alert Message
    if (@$_GET['w'])
        echo'<script>alert("'.@$_GET['w'].'");</script';
    ?>
</head>
<body>
<div class="header">
    <div class="row">
        <div class="col-lg-8">
            <span class="logo">Test Your Skill</span>
        </div> <!-- / .col-lg-8 -->
        <div class="col-md-4 col-md-offset-2">
            <?php
            include_once 'dbConnection.php';
            session_start();
            if (!(isset($_SESSION['email'])))
                header("location:index.php");
            else {
                $name = $_SESSION['name'];
                $email = $_SESSION['email'];

                echo '
                   <span class="pull-right top title1">
                       <span class="log1">
                           <span class="glyphicon glyphicon-user" aria-hidden="true"></span>
                           &emsp;Hello,
                       </span>
                       <a href="account.php?q=1" class="log log1">'.$name.'</a>&nbsp;|&nbsp;
                       <a href="logout.php?q=account.php" class="log">
                           <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                           &nbsp;Signout
                       </a>
                   </span>';
            }
            ?>
        </div> <!-- / .col-md-4 .col-md-offset-2 -->
    </div> <!-- / .row -->
</div> <!-- / .header -->

<div class="bg">
    <!-- Navigation Menu Starts here -->
    <nav class="navbar navbar-default title1">
        <div class="container-fluid">
            <!-- Grouping Brand and toggle for better mobile display -->
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#bs-example-navbar-collapse-1" aria-expanded="false">
                    <span class="sr-only">Toggle Navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>   <!-- / .navbar-toggle collapsed -->
                <a class="navbar-brand" href="#"><b>Netcamp</b></a>
            </div>  <!-- / .navbar-header -->
            <!-- Collecting all the nav links, forms and other content for getting toggled -->
            <div id="bs-example-navbar-collapse-1" class="collapse navbar-collapse">
                <ul class="nav navbar-nav">
                    <li <?php if(@$_GET['q']==1) echo'class="active"'; ?>>
                        <a href="account.php?q=1">
                            <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
                            &nbsp;Home
                            <span class="sr-only">(current)</span>
                        </a>
                    </li>
                    <li <?php if(@$_GET['q']==2) echo'class="active"'; ?>>
                        <a href="account.php?q=1">
                            <span class="glyphicon glyphicon-list-alt" aria-hidden="true"></span>
                            &nbsp;History
                            <span>(current)</span>
                        </a>
                    </li>
                    <li <?php if(@$_GET['q']==3) echo'class="active"'; ?>>
                        <a href="account.php?q=1">
                            <span class="glyphicon glyphicon-stats" aria-hidden="true"></span>
                            &nbsp;Ranking
                            <span>(current)</span>
                        </a>
                    </li>
                    <li class="pull-right">
                        <a href="logout.php?q=account.php">
                            <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                            &emsp;Signout
                        </a>
                    </li>
                </ul>   <!-- / .nav .navbar-nav -->
                <form class="navbar-form navbar-left" role="search">
                    <div class="form-group">
                        <input type="text" class="form-control" placeholder="Enter tag"/>
                    </div>  <!-- / .form-group -->
                    <button type="submit" class="btn btn-default">
                        <span class="glyphicon glyphicon-search" aria-hidden="true"></span>
                        &nbsp;Search
                    </button>
                </form> <!-- / .navbar-from . navbar-left -->
            </div>  <!-- / #bs-example-navbar-collapse-1 -->
        </div>  <!-- / .container-fluid -->
    </nav>  <!-- / .navbar .navbar-default .title1 -->
    <!-- End of Navigation Menu -->
    <!-- HOME starts here -->
    <?php
    if (@$_GET['q']==1){
        $result = mysqli_query($con, "SELECT * FROM quiz ORDER BY date DESC") or die('Error');
        echo'
        <div class="panel">
            <div class="table-responsive">
                <table class="table table-striped title1">
                    <tr>
                        <td><b>Sr.No.</b></td>
                        <td><b>Topic</b></td>
                        <td><b>Total Questions</b></td>
                        <td><b>Marks</b></td>
                        <td><b>Time Limit</b></td>
                    </tr>';
        $c = 1;
        while ($row = mysqli_fetch_array($result)){
            $title = $row['title'];
            $total = $row['total'];
            $correct = $row['correct'];
            $time = $row['time'];
            $eid = $row['eid'];
            // IF THIS MODULE DOES NOT WORK, SIMPLY ADD A LINE TO FETCH THE EMAIL ID FIRST
            $query = mysqli_query($con, "SELECT score FROM history WHERE eid='$eid' AND email='$email'") or die('Error98');
            $rowcount = mysqli_num_rows($query);

            if ($rowcount == 0){
                echo'
                <tr>
                    <td>'.$c++.'</td>
                    <td>'.$title.'</td>
                    <td>'.$total.'</td>
                    <td>'.$correct*$total.'</td>
                    <td>'.$time.'&nbsp;min</td>
                    <td><b>
                        <a href="account.php?q=quiz&step=2&eid='.$eid.'&n=1&t='.$total.'" class="pull-right btn sub1" style="margin-top: 0px; background: #99cc32;">
                            <span class="glyphicon glyphicon-new-window" aria-hidden="true"></span>&nbsp;
                            <span class="title1"><b>Start</b></span>
                        </a>
                    </b></td>
                </tr>
                ';
            }
            else {
                echo'
                <tr style="color: #99cc32;">
                    <td>'.$c++.'</td>
                    <td>'.$title.'&nbsp;
                        <span title="This quiz is already solved by you" class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                    </td>
                    <td>'.$total.'</td>
                    <td>'.$correct*$total.'</td>
                    <td>'.$time.'&nbsp;min</td>
                    <td><b>
                        <a href="update.php?q=requiz&step=25&eid='.$eid.'&n=1&t='.$total.'" class="pull-right btn sub1" style="margin-top: 0px;background: red;">
                            <span class="glyphicon glyphicon-repeat" aria-hidden="true"></span>&nbsp;
                            <span class="title1"><b>Restart</b></span>
                        </a>
                    </b></td>
                </tr>
                ';
            }
        }
        $c = 0;
        echo'</table></div></div>';
    }
    ?>
    <!-- HOME ends here -->

    <!-- QUIZ starts here -->
    <?php
    if (@$_GET['q'] == 'quiz' && @$_GET['step'] == 2){
        $eid = @$_GET['eid'];
        $srn = @$_GET['n'];
        $total = @$_GET['t'];
        $query = mysqli_query($con, "SELECT * FROM questions WHERE eid='$eid' AND srn='$srn'");
        echo'<div class="panel" style="margin: 5%;">';

        while ($row = mysqli_fetch_array($query)){
            $qns = $row['qns'];
            $qid = $row['qid'];
            echo'<b>Question &nbsp;'.$srn.'&nbsp;::<br/>'.$qns.'</b><br/><br/>';
        }

        $fetch_options = mysqli_query($con, "SELECT * FROM options WHERE qid='$qid'");
        echo'<form action="update.php?q=quiz&step=2&eid='.$eid.'&n='.$srn.'&t='.$total.'&qid='.$qid.'" method="POST class="form-horizontal"> <br/>';

        while ($row = mysqli_fetch_array($fetch_options)){
            $option = $row['option'];
            $optionid = $row['optionid'];
            echo'
            <input type="radio" name="ans" value="'.$optionid.'"/>'.$optionid.'<br/><br/>';
        }
        echo'
        <br/>
        <button>
            <span class="glyphicon glyphicon-lock" aria-hidden="true"></span>
            &nbsp;Submit
        </button>
        </form></div>';
    }
    //Display Result
    if (@$_GET['q'] == 'result' && @$_GET['eid']){
        $eid = @$_GET['eid'];
        $query = mysqli_query($con, "SELECT * FROM history WHERE eid='$eid' AND email='$email'") or die('Error157');
        echo'
        <div class="panel">
            <center>
                <h1 class="title" style="color: #660033">Result</h1>
                <br/>
            </center>
            <table class="table table-striped title1" style="font-size: 20px; font-weight: 1000;">
        ';
        while ($row = mysqli_fetch_array($query)){
            $score = $row['score'];
            $wrong = $row['wrong'];
            $correct = $row['correct'];
            $level = $row['level'];
            echo'
            <tr style="color: #66CCFF;">
                <td>Total Questions</td>
                <td>'.$level.'</td>
            </tr>
            <tr style="color: #99CC32;">
                <td>Right Answer&nbsp;<span class="glyphicon glyphicon-ok-circle" aria-hidden="true"></span></td>
                <td>'.$correct.'</td>
            </tr>
            <tr style="color: red;">
                <td>Wrong Answer&nbsp;<span class="glyphicon glyphicon-remove-circle"aria-hidden="true"></span></td>
                <td>'.$wrong.'</td>
            </tr>
            <tr style="color: #66CCFF;">
                <td>Wrong Answer&nbsp;<span class="glyphicon glyphicon-star"aria-hidden="true"></span></td>
                <td>'.$score.'</td>
            </tr>
            ';
        }
        $fetch_rank = mysqli_query($con, "SELECT * FROM rank WHERE email='$email'") or die('Error157');

        while ($row = mysqli_fetch_array($fetch_rank)){
            $score = $row['score'];
            echo'
            <tr style="color: #990000;">
                <td>Overall Score&nbsp;<span class="glyphicon glyphicon-stats" aria-hidden="true"></span></td>
                <td>'.$score.'</td>
            </tr>
            ';
        }
        echo'</table></div>';
    }
    ?>
    <!-- QUIZ ends here -->

    <?php
    // History starts here
    if (@$_GET['q'] == 2){
        $query = mysqli_query($con, "SELECT * FROM history WHERE email='$email' ORDER BY date DESC") or die('Error197');
        echo'
        <div class="panel title">
            <table class="table table-striped title1">
                <tr style="color: red;">
                    <td><b>Sr.No.</b></td>
                    <td><b>Quiz</b></td>
                    <td><b>Questions Solved</b></td>
                    <td><b>Right</b></td>
                    <td><b>Wrong</b></td>
                    <td><b>Score</b></td>
                </tr>
        ';
        $c = 0;
        while ($row = mysqli_fetch_array($query)){
            $eid = $row['eid'];
            $score = $row['score'];
            $wrong = $row['wrong'];
            $correct = $row['correct'];
            $level = $row['level'];
            $fetch_title = mysqli_query($con, "SELECT title FROM quiz WHERE eid='$eid'") or die('Error208');
            while ($row = mysqli_fetch_array($fetch_title))
                $title = $row['title'];
            $c++;
            echo '
            <tr>
                <td>'.$c.'</td>
                <td>'.$title.'</td>
                <td>'.$level.'</td>
                <td>'.$correct.'</td>
                <td>'.$wrong.'</td>
                <td>'.$score.'</td>
            </tr>
            ';
        }
        echo'</table</div>';
    }
    // History ends here

    // Ranking starts here
    if (@$_GET['q'] == 3){
        $query = mysqli_query($con, "SELECT * FROM rank ORDER BY score DESC") or die('Error223');
        echo'
        <div class="panel title">
            <div class="table-responsive">
                <table class="table table-striped title1">
                    <tr style="color: red;">
                        <td><b>Rank</b></td>
                        <td><b>Name</b></td>
                        <td><b>Gender</b></td>
                        <td><b>College</b></td>
                        <td><b>Score</b></td>
                    </tr>
        ';
        $c = 0;
        while ($row = mysqli_fetch_array($query)){
            $email = $row['email'];
            $score = $row['score'];
            $fetch_user_details = mysqli_query($con, "SELECT * FROM user WHERE email-'$email'") or die('Error231');
            while ($row = mysqli_fetch_array($fetch_user_details)){
                $name = $row['name'];
                $gender = $row['gender'];
                $college = $row['college'];
            }
            $c++;
            echo'
            <tr>
                <td style="color: #99cc32;"><b>'.$c.'</b></td>
                <td style="color: #99cc32;"><b>'.$name.'</b></td>
                <td style="color: #99cc32;"><b>'.$gender.'</b></td>
                <td style="color: #99cc32;"><b>'.$college.'</b></td>
                <td style="color: #99cc32;"><b>'.$score.'</b></td>
            </tr>
            ';
        }
        echo'</table></div></div>';
    }
    // Ranking ends here
    ?>
</div>  <!-- / .bg -->
<!-- Footer Starts here -->
<div class="row footer">
    <div class="col-md-3 box">
        <a href="about.php" target="_blank">About Us</a>
    </div>  <!-- / .col-md-3 .box -->
    <div class="col-md-3 box">
        <a href="#" data-toggle="modal" data-target="#login">Admin Login</a>
    </div>  <!-- / .col-md-3 .box -->
    <div class="col-md-3 box">
        <a href="#" data-toggle="modal" data-target="#developers">Developers</a>
    </div>  <!-- / .col-md-3 .box -->
    <div class="col-md-3 box">
        <a href="feedback.php" target="_blank">Feedback</a>
    </div>  <!-- / .col-md-3 .box -->
    <!-- Commence Modal for DEVELOPERS -->
    <div class="modal fade title1" id="developers">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span>
                        <span class="sr-only">Close</span>
                    </button>
                    <h4 class="modal-title" style="font-family: 'typo';">
                        <span style="color: orange;">Developers</span>
                    </h4>
                </div>  <!-- / .modal-header -->
                <div class="modal-body">
                    <p>
                        <div class="row">
                            <div class="col-md-4">
                                <img src="image/Nikhil.jpg" width="100" height="100" alt="Nikhil Agarwal" class="img-rounded"/>
                            </div>  <!-- / .col-md-4 -->
                        <div class="col-md-5">
                            <a href="https://github.com/Nike98/personal-code" style="color: #202020; font-family: 'typo'; font-size: 18px;" title="Find on Github">Nikhil Agarwal</a>
                            <h4 style="font-family: 'typo';">nikhilagarwal20@yahoo.com</h4>
                            <h4 style="font-family: 'typo';">SIES College of Management, Navi Mumbai</h4>
                        </div>  <!-- / .col-md-5 -->
                        </div>  <!-- / .row -->
                    </p>
                </div>  <!-- / .modal-body -->
            </div>  <!-- / .modal-content -->
        </div>  <!-- / .modal-dialog -->
    </div>  <!-- / #developers .modal .fade .title1 -->
    <!-- End Modal for DEVELOPERS -->

    <!-- Commence Modal for ADMIN LOGIN -->
    <div class="modal fade" id="login">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span>
                        <span class="sr-only">Close</span>
                    </button>
                    <h4 class="modal-title" style="font-family: 'typo';">
                        <span style="color: orange;">Login</span>
                    </h4>
                </div>  <!-- / .modal-header -->
                <div class="modal-body title1">
                    <div class="row">
                        <div class="col-md-3"></div>
                        <div class="col-md-6">
                            <form role="form" method="post" action="admin.php?q=index.php">
                                <div class="form-group">
                                    <input type="text" name="uname" maxlength="20" placeholder="Admin User Id" class="form-control"/>
                                </div>  <!-- / .form-group -->
                                <div class="form-group">
                                    <input type="password" name="password" maxlength="15" placeholder="Password" class="form-control"/>
                                </div>  <!-- / .form-group -->
                                <div class="form-group" align="center">
                                    <input type="submit" name="login" value="Login" class="btn btn-primary"/>
                                </div>  <!-- / .form-group -->
                            </form>
                        </div>  <!-- / .col-md-6 -->
                        <div class="col-md-3"></div>
                    </div>  <!-- / .row -->
                </div>  <!-- / .modal-body .title1 -->
            </div>  <!-- / .modal-content-->
        </div>  <!-- / .modal-diaog -->
    </div>  <!-- / .modal .fade #login -->
    <!-- End Modal for ADMIN LOGIN -->
</div>  <!-- / .row .footer -->
<!-- Footer Ends here -->
</body>
</html>