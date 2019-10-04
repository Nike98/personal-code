<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Various Math Functions</title>
</head>
<body>
    <h1>Math Functions</h1>
    <form action="" method="post">
        <span><b>Enter the Number : </b></span>
        <span style="margin-left: 50px;"><input type="text" name="num"></span>
        <br /><br />
        <span style="margin-left: 50px;"><input type="submit" name="sqrt" value="Square Root"></span>
        <span style="margin-left: 50px;"><input type="submit" name="abs" value="Absolute Value"></span>
        <span style="margin-left: 50px;"><input type="submit" name="round" value="Round Number"></span>
        <span style="margin-left: 50px;"><input type="submit" name="ceil" value="Ceil"></span>
    </form>
    <br /><br />

    <?php
    if (isset($_POST['sqrt'])){
        $num = $_POST['num'];
        echo "<b>Square Root: ".sqrt($num)."</b>";
    }

    if (isset($_POST['abs'])){
        $num = $_POST['num'];
        echo "<b>Absolute Value: ".abs($num)."</b>";
    }

    if (isset($_POST['round'])){
        $num = $_POST['num'];
        echo "<b>Rounded Value: ".round($num)."</b>";
    }

    if (isset($_POST['ceil'])){
        $num = $_POST['num'];
        echo "<b>Ceil Value: ".ceil($num)."</b>";
    }
    ?>
</body>
</html>