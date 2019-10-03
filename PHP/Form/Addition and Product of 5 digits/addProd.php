<?php
if (isset($_POST['inp'])){
    $inp = $_POST['inp'];
    $disp = $inp;
    $inp_copy = $inp;
    $count = 0;
    $res_add = 0;
    $res_prod = 1;

    while($inp != 0){
        $inp = (int)($inp / 10);
        $count++;
    }

    if ($count >= 5){
        while ($inp_copy > 0) {
            $remainder = $inp_copy % 10;
            $res_add += $remainder;
            $res_prod *= $remainder;
            $inp_copy = (int)($inp_copy / 10);
        }
    }

    else
        echo'<h2>The count of the Digits is Less than 5</h2>';
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Addition and Product of Numbers</title>
</head>
<body>
<form action="" method="post">
    <table cellspacing="10" cellpadding="10">
        <tr>
            <td><b>Enter a Number(more than 5 digits):</b></td>
            <td><input name="inp" value="<?php echo $disp; ?>" /></td>
        </tr>
        <tr>
            <td><b>Addition: </b></td>
            <td><input name="add" value="<?php echo $res_add; ?>"></td>
        </tr>
        <tr>
            <td><b>Product:</b></td>
            <td><input name="prod" value="<?php echo $res_prod; ?>"></td>
        </tr>
        <tr>
            <td></td>
            <td><input type="submit" name="submit" value="Calculate"></td>
        </tr>
    </table>
</form>
</body>
</html>
