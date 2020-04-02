<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1" />
    <link rel="stylesheet" href="css/bootstrap.min.css" />
    <link rel="stylesheet" href="css/bootstrap-theme.min.css" />
    <link rel="stylesheet" href="css/main.css" />
    <link rel="stylesheet" href="css/font.css" />
    <link rel="stylesheet" type="text/css" href="http://fonts.googleapis.com/css?family=Roboto:400,700,300" />
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <title>FEEDBACK</title>

    <!-- Alert Message -->
    <?php if (@$_GET['w']){echo'<script>alert("'.@$_GET['w'].'");</script>';} ?>
    <!-- Alert Message End -->
</head>
<body>
<!-- Header Start -->
<div class="row header">
    <div class="col-lg-6">
        <span class="logo">Test Your Skill</span>
    </div>  <!-- / .col-lg-6 -->
    <div class="col-md-2"></div>
    <div class="col-md-4">
        <?php
        include_once 'dbConnection.php';
        session_start();
        if (!(isset($_SESSION['email']))){
            echo'
            <a href="#" class="pull-right sub1 btn title2" data-toggle="modal" data-target="#myModal">
                <span class="glyphicon glyphicon-log-in" aria-hidden="true"></span>
                &nbsp;Signin
            </a>&nbsp;
            ';
        }
        else {
            echo'
            <a href="logout.php?q=feedback.php" class="pull-right sub1 title2">
                <span class="glyphicon glyphicon-log-out" aria-hidden="true"></span>
                &nbsp;Signout
            </a>&nbsp;
            ';
        }
        ?>
        <a href="index.php" class="pull-right btn sub1 title2">
            <span class="glyphicon glyphicon-home" aria-hidden="true"></span>
            &nbsp;Home
        </a>&nbsp;
    </div>  <!-- / .col-md-4 -->
</div>  <!-- / .row .header -->

<!-- SIGN-IN Modal starts here -->
<div class="modal fade" id="signInModal">
    <div class="modal-dialog">
        <div class="modal-content title1">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                    <span aria-hidden="true">&times;</span>
                    <h4 class="modal-title title1"><span style="color: orange;"></span></h4>
                </button>
            </div>  <!-- / .modal-header -->
            <div class="modal-body">
                <form class="form-horizontal" action="login.php?q=index.php" method="POST">
                    <fieldset>
                        <div class="form-group">    <!-- EMAIL ID Text Input -->
                            <label class="col-md-3 control-label" for="email"></label>
                            <div class="col-md-6">
                                <input id="email" name="email" placeholder="Enter your Email-Id" class="form-control input-md" type="email"/>
                            </div>
                        </div>  <!-- End of EMAIL ID Text Input -->
                        <div class="form-group">    <!-- PASSWORD Input -->
                            <label class="col-md-3 control-label" for="password"></label>
                            <div class="col-md-6">
                                <input id="password" name="password" placeholder="Enter your Password" class="form-control input-md" type="password"/>
                            </div>
                        </div>  <!-- End of PASSWORD Input -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                            <button type="submit" class="btn btn-primary">Log In</button>
                        </div>  <!-- / .modal-footer -->
                    </fieldset>
                </form>
            </div>  <!-- / .modal-body -->
        </div>  <!-- / .modal-content .title1 -->
    </div>  <!-- / .modal-dialog -->
</div>  <!-- / #signInModal .modal .fade -->
<!-- SIGN-IN Modal ends here -->

<!-- Header End -->

<div class="bg1">
    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-6 panel" style="background-image: url(image/bg1.jpg); min-height: 430px;">
            <h2 align="center" style="font-family: 'typo'; color: #000066;">FEEDBACK/REPORT A PROBLEM</h2>
            <div style="font-size: 14px">
                <?php
                if (@$_GET['q'])
                    echo'
                    <span style="font-size: 18px;">
                        <span class="glyphicon glyphicon-ok" aria-hidden="true"></span>
                        &nbsp;'.@$_GET['q'].'
                    </span>
                    ';
                else {
                    echo'
                    You can send us your Feedback on the following E-mail ID: <br />
                    <div class="row">
                        <div class="col-md-1"></div>
                        <div class="col-md-10">
                            <a href="mailto:nikhilagarweal20@yahoo.com" style="color: #000000;">nikhilagarwal20@yahoo.com</a><br /><br />
                        </div>  <!-- / .col-md-10 -->
                        <div class="col-md-1"></div>
                    </div>  <!-- / .row -->
                    
                    <p>Or you can directly submit your feedback by filling the entries below:-</p>
                    <form role="form" method="post" action="feed.php?q=feedback.php">
                        <div class="row">
                            <div class="col-md-3"><b>Name:</b><br /><br /><br /><b>Subject:</b></div>
                            <div class="col-md-9">
                                <div class="form-group">    <!-- NAME Text Input -->
                                    <input id="name" name="name" placeholder="Enter your Name" class="form-control input-md" type="text"><br />
                                    <input id="name" name="subject" placeholder="Enter the Subject" class="form-control inout-md" type="text">
                                </div>  <!-- / NAME Text Input -->
                            </div>
                        </div>  <!-- / .row -->
                        
                        <div class="row">
                            <div class="col-md-3"><b>E-mail Address:</b></div>
                            <div class="col-md-9">  <!-- EMAIL ID Text Input -->
                                <div class="form-group">
                                    <input id-="email" name="email" placeholder="Enter your E-mail ID" class="form-control input-md" type="email">
                                </div>
                            </div>  <!-- / EMAIL ID Text Input -->
                        </div>  <!-- / .row -->
                            
                        <div class="form-group">    <!-- MAIN FEEDBACK TEXT AREA -->
                            <textarea rows="5" cols="8" name="feedback" class="form-control" placeholder="Write your feedback here...."></textarea>
                        </div>  <!-- / MAIN FEEDBACK TEXT AREA -->
                        <div class="form-group" align="center">
                            <input type="submit" name="submit" value="Submit" class="btn btn-primary">
                        </div>
                    </form>
                    ';
                }
                ?>
            </div>  <!-- / style -> font-size: 14px -->
        </div>  <!-- / .col-md-6 .panel -->
        <div class="col-md-3"></div>
    </div>  <!-- / .row -->
</div>  <!-- / .bf1 -->

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