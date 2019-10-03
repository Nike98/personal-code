<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Employee Tax Calculation</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Employee Salary: </b></span>
    <span style="margin-left: 50px;"><input type="text" name="sal" value="<?php echo $inp; ?>"></span>
    <span style="margin-left: 50px;"><input type="submit" name="submit" value="Calculate Tax"></span>
    <br /><br />
    <?php
    if (isset($_POST['submit'])){
        $inp = $_POST['sal'];
        tax($inp);
    }

    function tax($num){
        if ($num <= 190000)
            echo '<b> No Tax </b>';
        else if ($num <= 500000){
            $emp_tax = $num * 0.1;
            echo '<b>Tax on Salary is : '.$emp_tax.'</b>';
        }
        else if ($num >= 500000 or $num <= 1000000){
            $emp_tax = $num * 0.2;
            echo '<b>Tax on Salary is : '.$emp_tax.'</b>';
        }
        else if ($num > 1000000){
            $emp_tax = $num * 0.3;
            echo '<b>Tax on Salary is : '.$emp_tax.'</b>';
        }
    }
    ?>
</form>
</body>
</html>
