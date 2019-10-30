<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Vowel or Consonant Check</title>
</head>
<body>
    <h1>Vowel or Consonant Check</h1>
    <br />
    <form action="" method="post">
        <span><b>Enter a Character:</b></span>
        <span><input type="text" name="char" style="margin-left: 50px;"></span>
        <span><input type="submit" name="check" value="Check" style="margin-left: 50px;"></span>
    </form>
    <br /><br />
    <?php
    if (isset($_POST['check'])){
        $char = $_POST['char'];

        if (strlen($char) > 1)
            $result = "Length is Greater than 1";
        else{
            if ($char == 'a' or $char == 'A' or $char == 'e' or $char == 'E' or
                $char == 'i' or $char == 'I' or $char == 'o' or $char == 'O' or
                $char == 'u' or $char == 'U')
                $result = "It is a Vowel.";
            else
                $result = "It is a Consonant.";
        }

        echo $result;
    }
    ?>
</body>
</html>