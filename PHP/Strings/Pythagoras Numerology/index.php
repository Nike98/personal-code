<?php
    $num = 0;
    $result = "";
    if (isset($_POST['submit'])){
        $name = $_POST['name'];
        $input = str_split($name);

        foreach ($input as $item => $value) {
            if (is_numeric(luckyNum($value)))
                $num += luckyNum($value);
        }
        $result = $num;
    }

    function luckyNum($string){
        $string = strtoupper($string);
        $numbers = array('A' => 1, 'B' => 2, 'C' => 3, 'D' => 4,
                            'E' => 5, 'F' => 6, 'G' => 7, 'H' => 8,
                            'I' => 9, 'J' => 1, 'K' => 2, 'L' => 3,
                            'M' => 4, 'N' => 5, 'O' => 6, 'P' => 7,
                            'Q' => 8, 'R' => 9, 'S' => 1, 'T' => 2,
                            'U' => 3, 'V' => 4, 'W' => 5, 'X' => 6,
                            'Y' => 7, 'Z' => 8, ' ' => 0);
        return $numbers[$string];
    }
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Pythagoras Numerology</title>
</head>
<body>
    <h1>Lucky Number</h1>
    <h3>Pythagoras Numerology</h3>
    <form method="post">
        <span><b>Enter Name:</b></span>
        <span style="margin-left: 50px;"><input type="text" name="name"></span>
        <span style="margin-left: 50px;"><input type="submit" name="submit"></span>
    </form>
    <br /><br />
    <?php echo "Lucky Number: ".$result; ?>
</body>
</html>