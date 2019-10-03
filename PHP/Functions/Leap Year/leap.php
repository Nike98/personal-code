<?php
if (isset($_POST['submit'])){
    $year = $_POST['year'];

    $ans = leapYear($year);
}

function leapYear($yr){
    if ($yr % 4 == 0)
        return 'It is a Leap Year';
    else
        return 'It is Not a Leap Year';
}
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Leap Year</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Year:</b></span>
    <span style="margin-left: 50px;"><input type="text" name="year" value="<?php echo $year; ?>"></span>
    <br /><br />
    <span style="margin-left: 100px;"><input type="submit" name="submit" value="Submit"></span>
    <br /><br />
    <?php echo '<b>'.$ans.'</b>'; ?>
</form>
</body>
</html>
