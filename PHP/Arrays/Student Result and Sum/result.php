<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Student Result Calculator</title>
</head>
<body>
<form action="" method="post">
    <table cellpadding="10" cellspacing="10">
        <tr style="font-weight: bolder;">
            <th>Category</th>
            <th></th>
            <th>Marks</th>
        </tr>
        <tr>
            <td><b>Student Name</b></td>
            <td><b>:</b></td>
            <td><input type="text" name="name"></td>
        </tr>
        <tr>
            <td><b>Statistics & Probability (SnP)</b></td>
            <td><b>:</b></td>
            <td><input type="number" name="snp"></td>
        </tr>
        <tr>
            <td><b>Object Oriented Programming (OOP)</b></td>
            <td><b>:</b></td>
            <td><input type="number" name="oop"></td>
        </tr>
        <tr>
            <td><b>Software Engineering and Project Management (SEPM)</b></td>
            <td><b>:</b></td>
            <td><input type="number" name="sepm"></td>
        </tr>
        <tr>
            <td><b>IT in Management (ITM)</b></td>
            <td><b>:</b></td>
            <td><input type="number" name="itm"></td>
        </tr>
        <tr>
            <td><b>Computer Organization and Architecture (COA)</b></td>
            <td><b>:</b></td>
            <td><input type="number" name="coa"></td>
        </tr>
        <tr></tr>
        <tr>
            <td></td>
            <td><input type="submit" name="submit" value="Submit"></td>
            <td></td>
        </tr>
    </table>
    <br /><br />
    <br /><br />
    <?php
    if (isset($_POST['submit'])){
        $name = $_POST['name'];

        $marks1 = $_POST['snp'];
        $marks2 = $_POST['oop'];
        $marks3 = $_POST['sepm'];
        $marks4 = $_POST['itm'];
        $marks5 = $_POST['coa'];

        $array = array($marks1, $marks2, $marks3, $marks4, $marks5);
        $sum = array_sum($array);

        echo'
        <table cellspacing="10" cellpadding="10">
            <tr style="font-weight: bolder">
                <th>Student Name</th>
                <th>Total Marks</th>
            </tr>
            <tr>
                <td><b>'.$name.'</b></td>
                <td>'.$sum.'</td>
            </tr>
        </table>
        ';
    }
    ?>
</form>
</body>
</html>