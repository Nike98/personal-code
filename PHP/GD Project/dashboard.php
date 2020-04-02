

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="author" content="Nikhil Agarwal">
    <title>Home Page</title>
    <link rel="stylesheet" href="js/jquery-3.3.1.js">
    <link rel="stylesheet" href="js/bootstrap.min.js">
    <link rel="stylesheet" href="css/bootstrap.css">
    <link rel="stylesheet" href="css/dataTables.bootstrap.min.css">
    <script type="text/javascript" src="js/jquery-3.3.1.js"></script>
    <script type="text/javascript" src="js/bootstrap.min.js"></script>
    <script type="text/javascript" src="js/dataTables.bootstrap.min.js"></script>
    <script type="text/javascript" src="js/jquery.dataTables.min.js"></script>
</head>
<body>
    <div class="container" style="margin-top: 30px;">

        <div id="dataTable" class="modal fade">
            <div class="modal-dialog">
                <div class="modal-content">
                    <div class="modal-header">
                        <h2 class="modal-title">Add Student Info</h2>
                    </div>
                    <div class="modal-body">
                        <input type="text" id="stuName" class="form-control" placeholder="Student Name"><br>
                        <input type="text" id="stuDob" class="form-control" placeholder="Student DOB"><br>
                        <input type="text" id="stuCity" class="form-control" placeholder="Student City"><br>
                        <input type="text" id="stuCourse" class="form-control" placeholder="Student Course"><br>
                        <input type="hidden" id="editRow" value="0">
                    </div>
                    <div class="modal-footer">
                        <input type="button" value="Save" id="saveClick" onclick="manageData('addNew')" class="btn btn-success">
                    </div>
                </div>
            </div>
        </div>

        <div class="row">
            <div class="col-md-12 col-md-offset-2">
                <h2>My SQL Table</h2>

                <input type="button" value="Add New" id="addNew" style="float: right" class="btn btn-success">
                <br><br><br>
                <table class="table table-hover table-bordered">
                    <thead>
                        <tr>
                            <td>ID</td>
                            <td>Name</td>
                            <td>DOB</td>
                            <td>City</td>
                            <td>Course</td>
                            <td>Option</td>
                        </tr>
                    </thead>
                    <tbody>

                    </tbody>
                </table>
                <br><br><br><br>
                <center>
                    <input type="button" value="Logout" class="btn btn-danger" id="btnLogout" onclick="logout()">
                </center>
            </div>
        </div>
    </div>

    <script type="text/javascript">
    // JQuery code to make the form drop down to enter data
    $(document).ready(function(){
        $("#addNew").on('click',function () { 
            $("#dataTable").modal('show');
        });

        getData(0, 10);
    });

    function logout(){
        $("#btnLogout").on('click',function () { 
            window.location = 'logout.php';
        });
    }

    // JavaScript code for AJAX calling (initially)
    // If all the fields are filled then it will work else not
    function manageData(key) {
        var name = $("#stuName");
        var dob = $("#stuDob");
        var city = $("#stuCity");
        var course = $("#stuCourse");
        var editRow = $("#editRow");

        if (isNotEmpty(name) && isNotEmpty(dob) && isNotEmpty(city) && isNotEmpty(course)){
            $.ajax({
                url: "CRUD.php",
                method: "POST",
                dataType: "text",
                data: {
                    key: key,
                    name: name.val(),
                    dob: dob.val(),
                    city: city.val(),
                    course: course.val(),
                    rowId: editRow.val()
                },
                success: function (response) {
                    alert(response);
                    closeModal();
                }
            });
        }
    }

    // To Edit any Student particular Student Record
    function edit(rowId) {
        $.ajax({
                url: "CRUD.php",
                method: "POST",
                dataType: "json",
                data: {
                    key: 'getRowData',
                    rowId: rowId
                },
                success: function (response) {
                    $("#editRow").val(rowId);
                    $("#stuName").val(response.name);
                    $("#stuDob").val(response.dob);
                    $("#stuCity").val(response.city);
                    $("#stuCourse").val(response.course);
                    $("#dataTable").modal('show');
                    $("#saveClick").attr('value', 'Save Changes').attr('onclick', "manageData('updateRow')");
                }
            });
    }

    function deleteRow(rowId){
        if (confirm('Are you sure you want to Delete this Record from the Database ?')){
            $.ajax({
                url: "CRUD.php",
                method: "POST",
                dataType: "text",
                data: {
                    key: 'deleteRow',
                    rowId: rowId
                },
                success: function (response) {
                    $("#student_"+rowId).parent().remove();
                    alert(response);
                }
            });
        }
    }

    // To get all the data populated within the Table
    function getData(start, limit){
        $.ajax({
            url: "CRUD.php",
            method: "POST",
            dataType: "text",
            data: {
                key: 'getData',
                start: start,
                limit: limit,
            },
            success: function (response) {
                if (response != "Reached Max"){
                    $("tbody").append(response);
                    start += limit;
                    getData(start, limit);
                } else
                    $('.table').DataTable();
            }
        });
    }

    // JavaScript function to check if a field is empty or not
    function isNotEmpty(field){
        if (field.val() == ''){
            field.css('border', '1px solid red');
            return;
        } else
            field.css('border', '');

        return true;
    }

    // To close the Modal(drop down) that takes the inputs from the User
    function closeModal(){
        $("#dataTable").modal('hide');
    }
    </script>
</body>
</html>