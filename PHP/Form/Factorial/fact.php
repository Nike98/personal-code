
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Number : </b></span>
    <span style="margin-left: 50px;"><input name="num" value="<?php echo $num; ?>"></span>
    <span style="margin-left: 50px;"><input type="submit" name="submit" value="Generate"></span>
    <br /><br/><br/><br/>
    <?php
    if (isset($_POST['submit'])){
        $num = $_POST['num'];
        $fact = 1;

        for ($i = $num; $i > 0; $i--)
            $fact *= $i;

        echo '<b>The Factorial is : </b>'.$fact.'';
    }
    ?>
</form>
</body>
</html>
