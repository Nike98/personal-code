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
                    $correct = $row['correct'];
                    $time = $row['time'];
                    $eid = $row['eid'];
                    $q12 = mysqli_query($con, "SELECT score FROM history WHERE eid='$eid' AND email='$email'") or die('Error98');
                    $rowcount = mysqli_num_rows($q12);
                    if ($rowcount == 0){
                        echo'<tr>
                                <td>'.$c++.'</td>
                                <td>'.$title.'</td>
                                <td>'.$total.'</td>
                                <td>'.$correct * $total.'</td>
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
                                <td>'.$correct * $total.'</td>
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

            // Ranking code in Home starts here
            if (@$_GET['q'] == 2){
                $query = mysqli_query($con, "SELECT * FROM rank ORDER BY score DESC") or die('Error223');
                echo'<div class="panel title">
                        <div class="table-responsive">
                            <table class="table table-striped title1">
                                <tr style="color:red">
                                    <td><b>Rank</b></td>
                                    <td><b>Name</b></td>
                                    <td><b>Gender</b></td>
                                    <td><b>College</b></td>
                                    <td><b>Score</b></td>
                                </tr>';
                                $c = 0;
                                while($row = mysqli_fetch_array($query)){
                                    $email = $row['email']; // IF THERE IS ANY PROBLEM DUE TO EMAIL CHANGE NAME OF EMAIL HERE
                                    $score = $row['score'];
                                    $query1 = mysqli_query($con, "SELECT * FROM user WHERE email='$email'") or die('Error231');

                                    while($row = mysqli_fetch_array($query1)){
                                        $name = $row['name'];
                                        $gender = $row['gender'];
                                        $college = $row['college'];
                                    }
                                    $c++;
                                    echo'<tr>
                                            <td style="color: #99cc32;"><b>'.$c.'</b></td>
                                            <td>'.$name.'</td>
                                            <td>'.$gender.'</td>
                                            <td>'.$college.'</td>
                                            <td>'.$score.'</td>
                                         </tr>';
                                }
                            echo '</table>
                        </div>
                     </div>';
            }
            // Ranking code ends here
            ?>
            <!-- Home PHP code Ends here -->

            <!-- User PHP code starts here -- >
            <?php
            if (@$_GET['q'] == 1){
                $result = mysqli_query($con,"SELECT * FROM user") or die('Error');
                echo'<div class="panel">
                        <div class="table-responsive">
                            <table class="table table-striped title1">
                                <tr>
                                    <td><b>Sr.No.</b></td>
                                    <td><b>Name</b></td>
                                    <td><b>Gender</b></td>
                                    <td><b>College</b></td>
                                    <td><b>Email</b></td>
                                    <td><b>Mobile</b></td>
                                </tr>';
                $c = 1;
                while($row = mysqli_fetch_array($result)){
                    $name = $row['name'];
                    $gender = $row['gender'];
                    $college = $row['college'];
                    $email = $row['email'];
                    $mobile = $row['mobile'];   // MOBILE AND THE REST OF THE COLUMNS NAMES SHOULD BE CLEAR WITH THE DB

                    echo'<tr>
                            <td>'.$c++.'</td>
                            <td>'.$name.'</td>
                            <td>'.$gender.'</td>
                            <td>'.$college.'</td>
                            <td>'.$email.'</td>
                            <td>'.$mobile.'</td>
                            <td><a title="Delete User" href="update.php?del_email='.$email.'">
                                <b><span class="glyphicon glyphicon-trash" aria-hidden="true"></span></b>
                            </a></td>
                         </tr>';
                }
                $c = 0;
                echo'</table></div></div>';
            }
            ?>
            <!-- User PHP code Ends here -->

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

            <!-- Feedback Reading portion PHP code starts here -->
            <?php
            if (@$_GET['fid']){
                echo'<br />';

                $id = @$_GET['fid'];
                $result = mysqli_query($con,"SELECT * FROM feedback WHERE id='$id'")or die('Error');
                while ($row = mysqli_fetch_array($result)){
                    $name = $row['name'];
                    $subject = $row['subject'];
                    $date = date("d-m-y", strtotime($date));
                    $time = $row['time'];
                    $feedback = $row['feedback'];

                    echo'<div class="panel">
                            <a title="Back to Archive" href="update.php?q1=2">
                                <b><span class="glyphicon-level-up" aria-hidden="true"></span></b>
                            </a>
                            <h2 style="text-align: center;margin-top: -15px;font-family: "Ubuntu", sans-serif;">
                                <b>'.$subject.'</b>
                            </h2>';

                    echo'<div class="mCustomScrollbar" data-mcs-theme="dark" style="margin-left: 10px; margin-right: 10px; max-height: 450px; line-height: 35px; padding: 5px;">
                            <span style="line-height: 35px; padding: 5px;">&nbsp;<b>&nbsp;'.$date.'</b></span>
                            <span style="line-height: 35px; padding: 5px;">&nbsp;<b>&nbsp;'.$time.'</b></span>
                            <span style="line-height: 35px; padding: 5px;">&nbsp;<b>By:</b>'.$name.'</span>
                            <br />'.$feedback.'
                         </div></div>';
                }
            }
            ?>
            <!-- Feedback Reading portion PHP code Ends here -->

            <!-- Add Quiz PHP code starts here -->
            <?php
            if (@$_GET['q'] == 4 && !(@$_GET['step'])){
                echo'
                <div class="row"> 
                    <span class="title1" style="margin-left: 40%; font-size: 30px;">
                        <b>Enter Quiz Details</b>
                    </span>
                    <br /><br />
                    <div class="col-md-3"></div>
                    <div class="col-md-6">
                        <form class="form-horizontal title1" name="form" action="update.php?q=addquiz" method="post">
                        <fieldset>
                            <div class="form-group"> <!-- Text Input for NAME -->
                                <label class="col-md-12 control-label" for="name"></label>
                                <div class="col-md-12">
                                    <input id="name" name="name" placeholder="Enter Quiz Title" class="form-control input-md" type="text">
                                </div>
                            </div>  <!-- End of Text Input for NAME -->
                            <div class="form-group">    <!-- Text Input TOTAL -->
                                <label class="col-md-4 control-label" for="total"></label>
                                <div class="col-md-12">
                                    <input id="total" name="total" placeholder="Enter the Total number of Questions" class="form-control input-md" type="number">
                                </div> 
                            </div>  <!-- End of Text Input for TOTAL -->
                            <div class="form-group">    <!-- Text Input RIGHT ANSWER -->
                                <label class="col-md-4 control-label" for="right_answer"></label>
                                <div class="col-md-12">
                                    <input id="right_answer" name="right_answer" placeholder="Enter marks on the Right Answer" class="form-control input-md" min="0" type="number">
                                </div> 
                            </div>  <!-- End of Text Input for RIGHT ANSWER -->
                            <div class="form-group">    <!-- Text Input for WRONG ANSWER -->
                                <label class="col-md-4 control-label" for="wrong_answer"></label>
                                <div class="col-md-12">
                                    <input id="wrong_answer" name="wrong_answer" placeholder="Enter minus marks on wrong answer without sign" class="form-control input-md" min="0" type="number">
                                </div> 
                            </div>  <!-- End of Text Input for WRONG ANSWER -->
                            <div class="form-group">    <!-- Text Input for TIME -->
                                <label class="col-md-4 control-label" for="time"></label>
                                <div class="col-md-12">
                                    <input id="time" name="time" placeholder="Enter the time limit for test in minutes" class="form-control input-md" min="1" type="number">
                                </div> 
                            </div>  <!-- End of Text Input for TIME -->
                            <div class="form-group">    <!-- Text Input for #TAG For Searching -->
                                <label class="col-md-4 control-label" for="tag"></label>
                                <div class="col-md-12">
                                    <input id="tag" name="tag" placeholder="Enter the #tag which is used for searching" class="form-control input-md" type="text">
                                </div> 
                            </div>  <!-- End of Text Input for #TAG For Searching -->
                            <div class="form-group">    <!-- Text Input for DESCRIPTION -->
                                <label class="col-md-4 control-label" for="desc"></label>
                                <div class="col-md-12">
                                    <textarea rows="8" cols="8" name="desc" class="form-control" placeholder="Write description here..."></textarea>
                                </div> 
                            </div>  <!-- End of Text Input for DESCRIPTION -->
                            <div class="form-group">
                                <label class="col-md-12 control-label" for=""></label>
                                <div class="col-md-12">
                                    <input type="submit" style="margin-left: 45%;" class="btn btn-primary" value="Submit" />
                                </div>
                            </div>
                        </fieldset>
                        </form>
                    </div>  <!-- / .col-md-6 -->
                </div> <!-- / .row -->
                ';
            }
            ?>
            <!-- Add Quiz PHP code Ends Here -->

            <!-- Add Quiz Step2 PHP code starts here -->
            <?php
            if (@$_GET['q'] == 4 && @$_GET['step'] == 2){
                echo'
                <div class="row">
                    <span class="title1" style="margin-left: 40%; font-size: 30px;">
                        <b>Enter Question Details</b>
                    </span>
                    <br /><br />
                    <div class="col-md-3"></div>
                    <div class="col-md-6">
                        <form class="form-horizontal title1" name="form" action="update.php?q=addqns&n='.@$_GET['n'].'&eid='.@$_GET['eid'].'&ch=4" method="post">
                        <fieldset>';
                        for ($i = 1; $i <= @$_GET['n']; $i++) {
                        echo'
                        <b>Question Number&nbsp;'.$i.'</b>
                        <br />
                        <div class="form-group">    <!-- Text Input for QUESTION NUMBER -->
                            <label class="col-md-12 control-label" for="ques_no'.$i.'"></label>
                            <div class="col-md-12">
                                <textarea rows="3" cols="5" name="ques_no'.$i.'" class="form-control" placeholder="Write question number '.$i.' here..."></textarea>
                            </div>
                        </div>  <!-- End of Text Input for QUESTION NUMBER -->
                        <div class="form-group">    <!-- Text Input for OPTION A -->
                            <label class="col-md-12 control-label" for="'.$i.'"></label>
                            <div class="col-md-12">
                                <input id="'.$i.'" name="'.$i.'1" placeholder="Enter option A" class="form-control input-md" type="text">
                            </div>
                        </div>  <!-- End of Text Input for OPTION A -->
                        <div class="form-group">    <!-- Text Input for OPTION B -->
                            <label class="col-md-12 control-label" for="'.$i.'"></label>
                            <div class="col-md-12">
                                <input id="'.$i.'" name="'.$i.'2" placeholder="Enter option B" class="form-control input-md" type="text">
                            </div>
                        </div>  <!-- End of Text Input for OPTION B -->
                        <div class="form-group">    <!-- Text Input for OPTION C -->
                            <label class="col-md-12 control-label" for="'.$i.'"></label>
                            <div class="col-md-12">
                                <input id="'.$i.'" name="'.$i.'3" placeholder="Enter option C" class="form-control input-md" type="text">
                            </div>
                        </div>  <!-- End of Text Input for OPTION C -->
                        <div class="form-group">    <!-- Text Input for OPTION D -->
                            <label class="col-md-12 control-label" for="'.$i.'"></label>
                            <div class="col-md-12">
                                <input id="'.$i.'" name="'.$i.'4" placeholder="Enter option D" class="form-control input-md" type="text">
                            </div>
                        </div>  <!-- End of Text Input for OPTION D -->
                        <br />
                        <b>Correct Answer</b>:<br />
                        <select id="ans'.$i.'" name="ans'.$i.'" placeholder="Choose correct answer" class="form-control input-md">
                            <option value="A">Select answer for question '.$i.'</option>
                            <option value="A">Option A</option>
                            <option value="B">Option B</option>
                            <option value="C">Option C</option>
                            <option value="D">Option D</option>
                        </select>
                        <br /><br />
                        ';
                        }
                echo'   </fieldset>
                        </form>
                    </div> <!-- / .col-md-6 -->
                </div> <!-- / .row -->
                ';
            }
            ?>
            <!-- Add Quiz Step2 PHP code Ends here -->

            <!-- Remove Quiz PHP code starts here -->
            <?php
            if (@$_GET['q'] == 5){
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
                    echo'
                    <tr>
                        <td>'.$c++.'</td>
                        <td>'.$title.'</td>
                        <td>'.$total.'</td>
                        <td>'.$correct * $total.'</td>
                        <td>'.$time.'&nbsp;min</td>
                        <td><b>
                            <a href="update.php?q=rem_quiz&eid='.$eid.'" class="pull-right btn sub1" style="margin: 0px; background: red;">
                                <span class="glyphicon glyphicon-trash" aria-hidden="true"></span> &nbsp;
                                <span class="title1"><b>Remove</b></span>
                            </a>
                        </b></td>
                    </tr>
                    ';
                }
                $c = 0;
                echo'   </table>
                    </div>
                </div>
                ';
            }
            ?>
            <!-- Remove Quiz PHP code Ends here -->
        </div> <!-- / .col-md-12 -->
    </div> <!-- / .row -->
</div> <!-- / .container -->
</body>
</html>