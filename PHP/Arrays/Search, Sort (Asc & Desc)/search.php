<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Array Topic &nbsp;|&nbsp; Search</title>
</head>
<body>
    <h1>Search</h1>
    <form action="" method="post">
        <p>
            <b>Input String for Search : </b>
            <span style="margin-left: 50px;"><input type="text" name="string"></span>
            <span style="margin-left: 50px;"><input type="submit" name="sub_search" value="Search"></span>
        </p>
        <br />
        <?php
        include "array_data.php";
        if (isset($_POST['sub_search'])){
            $input = $_POST['string'];
            if (in_array($input, $string_arr))
                $result = "Found";
            else
                $result = "Not Fount";

            echo "<p> <b>Result : </b> &emsp; $result";
        }
        ?>
    </form>
</body>
</html>