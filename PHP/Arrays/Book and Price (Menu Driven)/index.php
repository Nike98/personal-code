<?php include "bg_task.php"; ?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>BOOK&nbsp;|&nbsp;Search</title>
</head>
<body>
    <ul>
        <li><a href="index.php">Search Book</a></li>
        <li><a href="modify.php">Modify Record</a></li>
        <li><a href="delete.php">Delete Record</a></li>
    </ul>
    <br /><br />
    <h1>Book Search</h1>
    <form action="" method="post">
        <p>
            <span><b>Input the Name for Search : </b></span>
            <span style="margin-left: 50px;"><input type="text" name="book_name"></span>
            <span style="margin-left: 50px;"><input type="submit" name="sub_search" value="Search"></span>
        </p>
        <br />
        <?php echo $result; ?>
    </form>
</body>
</html>
