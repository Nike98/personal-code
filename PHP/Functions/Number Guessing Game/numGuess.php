<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Number Guessing Game</title>
</head>
<body>
    <h1>Guess the Number Game</h1>
    <form action="" method="post">
        <span><b>Enter the Number : </b></span>
        <span style="margin-left: 50px;"><input type="number" name="num" required=""></span>
        <br />
        <span style="margin-left: 50px;"><input type="hidden" name="num_hid" value="10"></span>
        <br /><br />
        <span style="margin-left: 100px;"><input type="submit" name="submit" value="Guess the Number"></span>
    </form>
    <br /><br />

    <?php
    session_start();
    $result = "";

    function try_count(){
        if (!isset($_SESSION['c']))
            $_SESSION['c'] = 0;

        $count = $_SESSION['c'];
        $count++;

        $_SESSION['c'] = $count;

        return $count;
    }

    if (isset($_POST['submit'])){
        if ($_POST['num'] == $_POST['num_hid']){
            $result = try_count();
            unset($_SESSION['c']);
        } else {
            echo '<b>Wrong</b>';
            try_count();
        }
    }

    if (!empty($result)){
        echo '
        <b>
            Correct Guess. <br />
            Total no. of tries for guessing : '.$result.'   
        </b>';
    }
    ?>
</body>
</html>