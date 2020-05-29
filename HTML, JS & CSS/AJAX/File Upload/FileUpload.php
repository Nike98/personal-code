<?php

$filename = $_FILES["file"]["name"];
$fileTmpLoc = $_FILES["file"]["tmp_name"];
$fileType = $_FILES["file"]["type"];
$filesize = $_FILES["file"]["size"];
$fileErrorMsg = $_FILES["file"]["error"];

if (!$fileTmpLoc) {
    echo "Error: Please browse for a file before clicking the Upload Button.";
    exit();
}

if (move_uploaded_file($fileTmpLoc, "$filename"))
    echo "$filename upload is complete.";
else
    echo "move_uploaded_file function failed";