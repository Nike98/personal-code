<?php
if (isset($_POST['num1']) && isset($_POST['num2'])){

    $val1 = $_POST['num1'];
    $val2 = $_POST['num2'];
    $opr = $_POST['oprtn'];

    if ($opr == '+')
        $res = $val1 + $val2;
    else if ($opr == '-')
        $res = $val1 - $val2;
    else if ($opr == '*')
        $res = $val1 * $val2;
    else if ($opr == '/')
        $res = $val1 / $val2;
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Simple Arithmetic Operations</title>
</head>
<body>
<form method="post" action="" name="main_form">
    <table cellspacing="10" cellpadding="10">
        <tr>
            <td><b>Enter the 1st Number : </b></td>
            <td><input name="num1" /></td>
        </tr>
        <tr>
            <td><b>Enter the 2nd Number : </b></td>
            <td><input name="num2" /></td>
        </tr>
        <tr>
            <td><b>Result:</b></td>
            <td><input name="res" value="<?php echo $res; ?>" /></td>
        </tr>
        <tr>
            <td><input type="submit" value="+" name="oprtn" id="add"></td>
            <td><input type="submit" value="-" name="oprtn" id="sub"></td>
            <td><input type="submit" value="x" name="oprtn" id="mul"></td>
            <td><input type="submit" value="/" name="oprtn" id="div"></td>
        </tr>
    </table>
</form>
</body>
</html>
