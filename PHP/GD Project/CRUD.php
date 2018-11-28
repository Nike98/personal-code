<?php



    if (isset($_POST['key'])){

        // Making a connection to the Databse once for all the Operations to be performed
        $servername = "localhost";
        $username = "root";
        $password = "newpass";
        $dbname = "nikhil";
        $conn = new mysqli($servername, $username, $password, $dbname);

        // Tried using name, dob rtc values globally but some problem occured so had to use all of them locally
        // Same happened with rowId

        // Insert Operation
        if ($_POST['key'] == 'addNew'){
            $name = $conn->real_escape_string($_POST['name']);
            $dob = $conn->real_escape_string($_POST['dob']);
            $city = $conn->real_escape_string($_POST['city']);
            $course = $conn->real_escape_string($_POST['course']);
            if (mysqli_connect_errno()){
                echo "Failed to connect to MySQL" . mysqli_connect_errno();
            } else{
                $sql = $conn->query("SELECT name, dob FROM student WHERE name = '$name' AND dob = '$dob'");
                if ($sql->num_rows > 0){
                    exit("Student with such Record already exists");
                } else{
                    $conn->query("INSERT INTO student (name, dob, city, course) 
                    VALUES ('$name', '$dob', '$city', '$course')");
                    exit('Student Record has been Inserted Successfully');
                }
                
            }
        }

        // Fetching values to update a particular row in the table
        if ($_POST['key'] == 'getRowData'){
            $rowId = $conn->real_escape_string($_POST['rowId']);
            $sql = $conn->query("SELECT name, dob, city, course FROM student WHERE id = '$rowId'");
            $data = $sql->fetch_array();
            $jsonArray = array(
                'name' => $data['name'],
                'dob' => $data['dob'],
                'city' => $data['city'],
                'course' => $data['course'],
            );
            exit(json_encode($jsonArray));
        }

        // Updating values in the Database
        if ($_POST['key'] == 'updateRow'){
            $name = $conn->real_escape_string($_POST['name']);
            $dob = $conn->real_escape_string($_POST['dob']);
            $city = $conn->real_escape_string($_POST['city']);
            $course = $conn->real_escape_string($_POST['course']);
            $rowId = $conn->real_escape_string($_POST['rowId']);
            $conn->query("UPDATE student SET
                name = '$name',
                dob = '$dob',
                city = '$city',
                course = '$course'
                WHERE id = '$rowId'
            ");
            exit("Update Successfull");
        }

        if ($_POST['key'] == 'deleteRow'){
            $rowId = $conn->real_escape_string($_POST['rowId']);
            $conn->query("DELETE FROM student WHERE id = '$rowId'");
            exit('The Record has been Deleted');
        }

        // Read Operation
        if ($_POST['key'] == 'getData'){
            $start = $conn->real_escape_string($_POST['start']);
            $limit = $conn->real_escape_string($_POST['limit']);

            $sql = $conn->query("SELECT id, name, dob, city, course FROM student LIMIT $start, $limit");
            if ($sql->num_rows > 0){
                $response = "";
                while ($data = $sql->fetch_array()){
                    $response .= '
                        <tr>
                            <td>'.$data["id"].'</td>
                            <td id="student_'.$data["id"].'">'.$data["name"].'</td>
                            <td>'.$data["dob"].'</td>
                            <td>'.$data["city"].'</td>
                            <td>'.$data["course"].'</td>
                            <td>
                                <input type="button" onclick="edit('.$data["id"].')" value="Edit" class="btn btn-primary">
                                <input type="button" onclick="deleteRow('.$data["id"].')" value="Delete" class="btn btn-danger" style="margin-left: 40px">
                            </td>
                        </tr>
                    ';
                }
                exit($response);
            } else
                exit('Reached Max');
        } 
    }

?>