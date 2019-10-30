<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Array Topic &nbsp;|&nbsp; Ascending Sort</title>
</head>
<body>
    <h1>Ascending Sort</h1>
    <form action="" method="post">
        <input type="submit" name="asc_sort" value="Ascending Sort">
    </form>
    <br /><br />
    <?php
    include "array_data.php";

    if (isset($_POST['asc_sort'])){
        ksort($string_arr);

        foreach ($string_arr as $item => $item_val) {
            echo "Key = ".$item.", Value = ".$item_val;
            echo "<br/>";
        }
    }
    ?>
</body>
</html>