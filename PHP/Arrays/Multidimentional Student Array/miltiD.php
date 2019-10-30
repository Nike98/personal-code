<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Student Record</title>
</head>
<body>
    <h1>Student Search</h1>
    <br /><br />
    <form action="" method="post">
        <span style="margin-left: 50px;"><b>Enter Student Name:</b></span>
        <input type="text" name="stud_name" style="margin-left: 100px;">
        <input type="submit" name="search" value="Search" style="margin-left: 100px;">
    </form>
    <br /><br />
    <?php
    $students = array(
        "Nikhil" => array("Roll No" => "022", "Student Full Name" => "Nikhil Agarwal", "Attendance" => "100%"),
        "Pranav" => array("Roll No" => "028", "Student Full Name" => "Pranav Raman", "Attendance" => "100%"),
        "Sumeet" => array("Roll No" => "008", "Student Full Name" => "Sumeet Jadhav", "Attendance" => "74.99%"),
        "Sai" => array("Roll No" => "019", "Student Full Name" => "Saisamarth More", "Attendance" => "99.99%"),
    );
    
    if (isset($_POST['search'])){
        $stud_name = $_POST['stud_name'];
        if (array_key_exists($stud_name, $students)){
            echo "
                <table border='3'>
                    <tr>
                        <th>Roll No</th>
                        <th>Student Full Name</th>
                        <th>Attendance</th>
                    </tr>
                    <tr>";
            foreach ($students[$stud_name] as $student) {
                echo "<td>$student</td>";
            }
                "</tr></table>";
        }
        else
            echo "Student Record Not Found";
    }
    ?>
</body>
</html>