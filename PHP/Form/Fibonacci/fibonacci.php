<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Fibonacci Series</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Number of lines : </b></span>
    <span style="margin-left: 50px;"><input name="limit" value="<?php echo $limit; ?>"></span>
    <span style="margin-left: 50px;"><input type="submit" name="submit" value="Generate"></span>
    <br /><br/>
    <span><b>The Series will be Displayed below</b></span>
    <br/><br/>
    <?php
    if (isset($_POST['submit'])){
        $limit = $_POST['limit'];
        $first = 0;
        $second = 1;

        echo ''.$first.'<br/>'.$second.'<br/>';

        for ($i = 0; $i < $limit; $i++){
            $next = $first + $second;
            $first = $second;
            $second = $next;

            echo''.$next.'<br/>';
        }
    }
    ?>
</form>
</body>
</html>
