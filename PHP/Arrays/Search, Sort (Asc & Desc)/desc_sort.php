<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Array Topic &nbsp;|&nbsp; Descending Sort</title>
</head>
<body>
    <h1>Descending Sort</h1>
    <form action="" method="post">
        <input type="submit" name="desc_sort" value="Descending Sort">
    </form>
    <br /><br />
    <?php
    include "array_data.php";

    if (isset($_POST['desc_sort'])){
        krsort($string_arr);

        foreach ($string_arr as $item => $item_val) {
            echo "Key = ".$item.", Value = ".$item_val;
            echo "<br/>";
        }
    }
    ?>
</body>
</html>