<?php
if (isset($_POST['faren'])){
    $faren = $_POST['faren'];
    $celsius = (int)(($faren - 32) * (5/9));
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Temperature Converter</title>
</head>
<body>
<form method="post" action="">
    <table cellspacing="10" cellpadding="10">
        <tr>
            <td><b>F<sup>o</sup>:</b></td>
            <td><input name="faren"></td>
            <td></td>
            <td><b>C<sup>o</sup>:</b></td>
            <td><input name="celsius" value="<?php echo $celsius; ?>"></td>
            <td></td>
            <td><input type="submit" name="convert" value="Convert"></td>
        </tr>
    </table>
</form>
</body>
</html>
