<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
    <link rel="stylesheet" href="css/bootstrap.min.css"/>
    <link rel="stylesheet" href="css/bootstrap-theme.min.css"/>
    <link rel="stylesheet" href="css/main.css"/>
    <link rel="stylesheet" href="css/font.css"/>
    <link rel='stylesheet' type='text/css' href='http://fonts.googleapis.com/css?family=Roboto:400,700,300'/>
    <script type="text/javascript" src="js/jquery.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"</script>

    <title>Test Your Skills</title>

    <?php if(@$_GET['w']){
        echo '<script>alert("'.@$_GET['w'].'");</script>';
    }?>
    <script>
        function validateForm() {
            var y = document.forms["form"]["name"].value;
            var letters = /^[A-Za-z]+$/;
            if (y == null || y == ""){
                alert("Name must be filled out!");
                return false;
            }

            var z = document.forms["form"]["college"].value;
            if (z == null || z == ""){
                alert("College must be filled out!");
                return false;
            }

            var x = document.forms["form"]["email"].value;
            var atpos = x.indexOf("@");
            var dotpos = x.lastIndexOf(".");
            if (atpos < 1 || dotpos < atpos + 2 || dotpos + 2 >= x.length){
                alert("Not a valid E-mail address!");
                return false;
            }

            var a = document.forms["form"]["password"].value;
            if (a == null || a == ""){
                alert("Password must be filled up!");
                return false;
            }
            if (a.length < 5 || a.length > 25){
                alert("Passwords must be between 5 to 25 characters only!");
                return false;
            }

            var b = document.forms["form"]["confPassword"].value;
            if (a != b){
                alert("Passwords must match!");
                return false;
            }
        }
    </script>
</head>
<body>
    <div class="header">
        <div class="row">
            <div class="col-lg-8">
                <span class="logo">Test Your Skill</span>
            </div> <!-- / .col-lg-8 -->
            <div class="col-md-2 col-md-offset-4">
                <a href="#" class="pull-right btn sub1" data-toggle="modal" data-target="#myModal">
                    <span class="glyphicon glyphicon-log-in" aria-hidden="true"></span>&nbsp;
                    <span class="title1"><b>Sign In</b></span>
                </a>
            </div> <!-- col-md-2 col-md-offset-4 -->
            <!-- Log In modal start -->
            <div class="modal fade" id="myModal">
                <div class="modal-dialog">
                    <div class="modal-content title1">
                        <div class="modal-header">
                            <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                <span aria-hidden="true">&times;</span>
                            </button> <!-- Modal close Button -->
                            <h4 class="modal-title title1">
                                <span style="color:orange">Login</span>
                            </h4>
                        </div> <!-- / .modal-header -->
                        <div class="modal-body">
                            <form class="form-horizontal" action="login.php?q=index.php" method="POST">
                                <fieldset>
                                    <div class="form-group"> <!-- Login Email id input -->
                                        <label class="col-md-3 control-label" for="email"></label>
                                        <div class="col-md-6">
                                            <input id="email" name="email" placeholder="Enter your E-mail Id" class="form-control input-md" type="email">
                                        </div>
                                    </div> <!-- End of Login Email Input -->
                                    <div class="form-group"> <!-- Login Password field -->
                                        <label class="col-md-3 control-label" for="passowrd"></label>
                                        <div class="col-md-6">
                                            <input id="passowrd" name="password" placeholder="Enter your Password" class="form-control input-md" type="password">
                                        </div> <!-- End of Password Input-->
                                    </div>
                                </fieldset>
                            </form>
                        </div> <!-- End of Modal Body -->
                        <div class="modal-footer">
                            <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                            <button type="submit" class="btn btn-primary">Login</button>
                        </div> <!-- End of Modal Footer -->
                    </div> <!-- / .modal-content -->
                </div> <!-- / .modal-dialog -->
            </div> <!-- / #myModal -->
        </div> <!-- / .row -->
    </div> <!-- / .header -->

    <div class="bg1">
        <div class="row">
            <div class="col-md-7"></div>
            <div class="col=md-4 panel">
                <form class="form-horizontal" name="form" action="sign.php?q=account.php" onSubmit="return validateForm()" method="POST">
                    <fieldset>
                        <div class="form-group"> <!-- 1. Text Input for Name -->
                            <label class="col-md-12 control-label" for="name"></label>
                            <div class="col-md-12">
                                <input id="name" name="name" placeholder="Enter your Name" class="form-control input-md" type="text">
                            </div>
                        </div> <!-- End of Name Input -->
                        <div class="form-group"> <!-- 2. Text Input for Gender -->
                            <label class="col-md-12 control-label" for="gender"></label>
                            <div class="col-md-12">
                                <select id="gender" name="gender" placeholder="Select your Gender" class="form-control input-md">
                                    <option value="Male">Select Gender</option>
                                    <option value="M">Male</option>
                                    <option value="F">Female</option>
                                </select>
                            </div>
                        </div> <!-- End of Gender Input -->
                        <div class="form-group"> <!-- 3. Text Input for College -->
                            <label class="col-md-12 control-label" for="college"></label>
                            <div class="col-md-12">
                                <input id="college" name="college" placeholder="Enter your College Name" class="form-control input-md" type="text">
                            </div>
                        </div> <!-- End of College Input -->
                        <div class="form-control"> <!-- 4. E-mail Id value input -->
                            <label class="col-md-12 control-label" for="email"></label>
                            <div class="col-md-12">
                                <input id="email" name="email" placeholder="Enter your E-mail Id" class="form-control input-md" type="email">
                            </div>
                        </div> <!-- End of E-mail Id value input -->
                        <div class="form-control"> <!-- 5. Mobile Number Input -->
                            <label class="col-md-12 control-label" for="mobile"></label>
                            <div class="col-md-12">
                                <input id="mobile" name="mobile" placeholder="Enter your Mobile Number" class="form-control input-md" text="number">
                            </div>
                        </div> <!-- End of Mobile Number Input -->
                        <div class="form-control"> <!-- 6. Input field for Password -->
                            <label class="col-md-12 control-label" for="password"></label>
                            <div class="col-md-12">
                                <input id="password" name="password" placeholder="Enter your Password" class="form-control input-md" type="password">
                            </div>
                        </div> <!-- End of Input field for Password -->
                        <div class="form-control"> <!-- 7. Input field to Confirm the Password -->
                            <label class="col-md-12 control-label" for="cpassword"></label>
                            <div class="col-md-12">
                                <input id="cpassword" name="cpassword" placeholder="Confirm Password" class="form-control input-md" type="password">
                            </div>
                        </div> <!-- End of Confirm Password input field -->
                        <?php if (@$_GET['q7']){echo '<p style="color:red;font-size:15px;"></p>'.@$_GET['q7'];}?>
                        <div class="form-group"> <!-- Submit button -->
                            <label class="col-md-12 control-label" for=""></label>
                            <div class="col-md-12">
                                <input type="submit" class="sub btn btn-primary" value="sign-up">
                            </div>
                        </div> <!-- End of Submit Button -->
                    </fieldset>
                </form>
            </div> <!-- .col-md-4 .panel -->
        </div> <!-- .row -->
    </div> <!-- .bg1 -->

    <!-- Footer Start -->
    <div class="row footer">
        <div class="col-md-3 box"> <!-- About Us -->
            <a href="https://github.com/Nike98" target="_blank">About Us</a>
        </div>
        <div class="col-md-3 box"> <!-- Admin Login-->
            <a href="#" data-toggle="modal" data-target="#login">Admin Login</a>
        </div>
        <div class="col-md-3 box"> <!-- Developers Section link -->
            <a href="#" data-toggle="modal" data-target="#developers">Developers</a>
        </div>
        <div class="col-md-3"> <!-- Feedback Link -->
            <a href="feedback.php" target="_blank">Feedback</a>
        </div>
    </div> <!-- .row .footer -->

    <!-- Modal for Developers -->
    <div class="modal fade title1" id="developers">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span>
                        <span class="sr-only">Close</span>
                        <h4 class="modal-title" style="font-family: 'typo'"><span style="color: orange">Developers</span></h4>
                    </button>
                </div> <!-- / .modal-header -->
                <div class="modal-body">
                    <p>
                        <div class="row">
                            <div class="col-md-4">
                                <img src="image/dev_warren_high.jpg" width="100" height="100" alt="Warren D'Souza" class="img-rounded">
                            </div> <!-- / .col-md-4 -->
                            <div class="col-md-5">
                                <a href="https://github.com/Nike98" style="color: #202020; font-family: 'typo'; font-size: 18px;" title="Find on Github">Nikhil and Warren</a>
                                <h4 style="color: #202020; font-family: 'typo'; font-size: 16px;" class="title1">+91 9989897575</h4>
                                <h4 style="font-family: 'typo'">nikhilagarwal20@yahoo.com</h4>
                                <h4 style="font-family: 'typo'">Just an enthusiastic Developer</h4>
                            </div> <!-- .col-md-5 -->
                        </div> <!-- / .row -->
                    </p>
                </div> <!-- / .modal-body -->
            </div> <!-- / .modal-content -->
        </div> <!-- / .modal-dialog -->
    </div> <!-- / .modal #developers -->

    <!-- Modal for Admin Login -->
    <div class="modal fade" id="login">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span>
                        <span class="sr-only">Close</span>
                        <h4 class="modal-title"><span style="color: orange; font-family: 'typo';">Login</span></h4>
                    </button>
                </div> <!-- / .modal-header -->
                <div class="modal-body title1">
                    <div class="row">
                        <div class="col-md-3"></div>
                        <div class="col-md-6">
                            <form role="form" method="post" action="admin.php?q=index.php">
                                <div class="form-group"> <!-- Admin User Id input -->
                                    <input type="text" name="uname" maxlength="20" placeholder="Admin User Id" class="form-control">
                                </div> <!-- End of Admin User Id input -->
                                <div class="form-group"> <!-- Admin Password input -->
                                    <input type="password" name="password" maxlength="15" placeholder="Password" class="form-control">
                                </div> <!-- End of Admin Password input -->
                                <div class="form-group" align="center"> <!-- Submit Button -->
                                    <input type="submit" name="login" class="btn btn-primary">
                                </div> <!-- End of Submit Button -->
                            </form>
                        </div> <!-- / .col-md-6 -->
                        <div class="col-md-3"></div>
                    </div> <!-- / .row -->
                </div> <!-- / .modal-body #title1 -->
            </div> <!-- / .modal-content -->
        </div> <!-- / .modal-dialog -->
    </div> <!-- / .modal .fade #login -->
    <!-- Footer End -->
</body>
</html>