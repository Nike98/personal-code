<?php
    // Basic Bubble Sort Algorithm
    $array = array(9,2,8,6,1,7,4,5,0,3,10);

    echo "<h3>Unsorted Array:</h3>";
    foreach ($array as $item) {
        echo $item." ";
    }

    for ($i = 0; $i < count($array); $i++){
        for ($j = 0; $j < count($array) - $i - 1; $j++){
            if ($array[$j] > $array[$j + 1]) {
                $temp = $array[$j];
                $array[$j] = $array[$j + 1];
                $array[$j + 1] = $temp;
            }
        }
    }

    echo "<br /><br />";
    echo "<h3>Sorted Array</h3>";
    foreach ($array as $item) {
        echo $item." ";
    }
?>