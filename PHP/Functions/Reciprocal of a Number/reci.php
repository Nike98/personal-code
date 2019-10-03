
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Reciprocal of a Number</title>
</head>
<body>
    <form action="" method="post">
        <span><b>Enter the Number : </b></span>
        <span style="margin-left: 50px;"><input type="text" name="inp" value="<?php echo $num; ?>"></span>
        <br /><br />
        <span style="margin-left: 100px;"><input type="submit" name="submit" value="Submit"></span>
    </form>
    <?php
    if (isset($_POST['submit'])){
        reciprocal();
    }

    function reciprocal(){
        $num = $_POST['inp'];
        if ($num == 0)
            echo '<b>'. die("FALSE"). '</b>';
        else{
            echo'<b>TRUE</b><br /><br />';
            echo'<b>&nbsp;1</b><br />';
            echo'<b>---</b><br />';
            echo'<b>&nbsp;'.$num.'</b>';
        }
    }
    ?>
</body>
</html>
