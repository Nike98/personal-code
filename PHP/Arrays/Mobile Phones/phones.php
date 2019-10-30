<?php
    $result = "";
    $number = array("IPHONE", "ONE PLUS", "PIXEL", "SAMSUNG", "HTC", "MOTOROLA","LENOVO", "VIVO", "XIAOMI", "NOKIA");
    static $i = 0;
    $count = count($number);

    if (isset($_POST['current']))
        $result = current($number);

    if (isset($_POST['next'])){
        $num = $_POST['num'];
        $i = array_search($num, $number);
        $i = $i + 1;

        if ($i < $count)
            $result = $number[$i];
        else
            $result = $number[$count + 1];
    }

    if (isset($_POST['prev'])){
        $num = $_POST['num'];
        $i = array_search($num, $number);
        $i -= 1;

        if ($i >= 0)
            $result = $number[$i];
        else
            $result = $number[0];
    }

    if (isset($_POST['end']))
        $result = end($number);
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Mobile Phones</title>
</head>
<body>
    <form action="" method="post">
        <label for="res"><b>Result</b></label>
        <input type="text" name="num" style="margin-left: 50px;" value="<?php echo $result; ?>">
        <br /><br />
        <input type="submit" name="current" value="Current" style="margin-left: 50px;">
        <input type="submit" name="next" value="Next" style="margin-left: 50px;">
        <input type="submit" name="prev" value="Previous" style="margin-left: 50px;">
        <input type="submit" name="end" value="End" style="margin-left: 50px;">
    </form>
</body>
</html>
