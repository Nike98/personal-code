<?php
if (isset($_POST['submit'])){
    $num = $_POST['inp'];
    $selection = $_POST['rad'];

    if ($selection == 'square')
        $ans = square($num);
    else
        $ans = double($num);
}

function square($num){
    return $num * $num;
}

function double($num){
    return $num * 2;
}
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Square and Double</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Number:</b></span>
    <span style="margin-left: 50px;"><input type="text" name="inp" value="<?php echo $num; ?>" /></span>
    <br /><br />
    <div style="margin-left: 50px;">
        <span><input type="radio" name="rad" value="square"><b>Square</b></span>
        <br /><br />
        <span><input type="radio" name="rad" value="double"><b>Double</b></span>
    </div>
    <br /><br />
    <span style="margin-left: 100px;"><input type="submit" name="submit" value="Submit"></span>
    <br /><br />
    <span><b>The Result is : </b>&emsp;<?php echo $ans; ?></span>
</form>
</body>
</html>
