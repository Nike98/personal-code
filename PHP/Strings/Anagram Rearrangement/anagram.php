<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Anagram Strings</title>
</head>
<body>
    <h1>Anagram Strings</h1>
    <form method="post">
        <span><b>String 1:</b></span>
        <span style="margin-left: 50px;"><input type="text" name="str1"></span>
        <br /><br />
        <span><b>String 2:</b></span>
        <span style="margin-left: 50px;"><input type="text" name="str2"></span>
        <br /><br />
        <span style="margin-left: 100px;"><input type="submit" value="Check" name="submit"></span>
    </form>
    <br /><br />
    <?php
    if (isset($_POST['submit'])){
        $string1 = $_POST['str1'];
        $string2 = $_POST['str2'];

        if (isAnagram($string1, $string2))
            echo "<b>Anagram</b>";
        else
            echo "<b>Not Anagram</b>";
    }

    function isAnagram($string_1, $string_2){
        $string1 = str_replace(' ', '', $string_1);
        $string2 = str_replace(' ', '', $string_2);

        $string1 = strtolower($string1);
        $string2 = strtolower($string2);

        if (count_chars($string_1, 1) == count_chars($string_2, 1))
            return true;
        else
            return false;
    }
    ?>
</body>
</html>