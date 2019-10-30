<?php
    echo "<h1>Array Merge</h1><br /><br />";

    $array = array(array(77, 87), array(23, 45));

    $result = array_reduce($array, "array_merge", array());

    foreach ($result as $item) {
        echo $item."<br />";
    }
?>