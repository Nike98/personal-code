<?php
if (isset($_POST['usd'])){
    $usd = $_POST['usd'];
    $inr = (float)($usd * 70.84);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Currency Converter</title>
</head>
<body>
<form method="post" action="" name="frm">
    <table cellpadding="10" cellspacing="10">
        <tr>
            <td><b>USD:</b></td>
            <td><input name="usd"></td>
            <td></td>
            <td><b>INR:</b></td>
            <td><input name="inr" value="<?php echo $inr; ?>"></td>
            <td></td>
            <td><input type="submit" name="convert" value="Convert"></td>
        </tr>
</form>
</body>
</html>