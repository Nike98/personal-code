
<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Multiplication Tables</title>
</head>
<body>
<form action="" method="post">
    <span><b>Enter the Number: </b></span>
    <span style="margin-left: 50px;"><input type="text" name="num"></span><br /><br />
    <span><b>Enter the Limit: </b></span>
    <span style="margin-left: 50px;"><input type="text" name="limit"></span><br /><br />
    <span style="margin-left: 100px;"><input type="submit" name="submit" value="Submit"></span>
    <br /><br /><br />
    <?php
    if (isset($_POST['submit'])){
        $num = $_POST['num'];
        $limit;

        if (empty($_POST['limit']))
            $limit = 10;

        else
            $limit = $_POST['limit'];
        table($num, $limit);
    }

    function table($num, $limit){
        for ($i = 1; $i <= $limit; $i++)
            echo '&emsp;'.$num.'&nbsp;x&nbsp;'.$i.'&nbsp;=&nbsp; <b>'.$num * $i.'</b><br />';
    }
    ?>
</form>
</body>
</html>
