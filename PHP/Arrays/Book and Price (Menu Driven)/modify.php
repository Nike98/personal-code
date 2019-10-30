<?php include "bg_task.php"; ?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>BOOK&nbsp;|&nbsp;Modify</title>
</head>
<body>
<ul>
    <li><a href="index.php">Search Book</a></li>
    <li><a href="modify.php" >Modify Record</a></li>
    <li><a href="delete.php">Delete Record</a></li>
</ul>
<br /><br />
<h1>Modify Book Record</h1>
<form action="" method="post">
    <p>
        <span><b>Input the Book Name for Search : </b></span>
        <span style="margin-left: 50px;"><input type="text" name="book_name"></span>
        <br /><br />
        <span><b>Input the Book Price : </b></span>
        <span style="margin-left: 50px;"><input type="text" name="price"></span>
        <br /><br />
        <span style="margin-left: 100px;"><input type="submit" name="sub_update" value="Update"></span>
    </p>
    <br />
    <?php echo $result; ?>
</form>
</body>
</html>
