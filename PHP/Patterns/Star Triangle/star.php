
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Star Triangle</title>
</head>
<body>
<form action="" method="post">
    <br /><br />
    <span><b>Enter the Number of Lines to print: </b></span>
    <span><input name="inp" style="margin-left: 30px;"></span>
</form>
<br /><br />
<?php
if (isset($_POST['inp'])){
    $inp = $_POST['inp'];

    for ($i = 1; $i <= $inp; $i++) {
        for ($j = 1; $j <= $i; $j++)
            echo '* ';
        echo '<br />';
    }
}
?>
</body>
</html>
