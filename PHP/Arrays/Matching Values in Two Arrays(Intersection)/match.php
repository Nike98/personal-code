<?php
    $array1 = array(1,2,3,4,5,6,7,8,9);
    $array2 = array(4,9,22,10,2,70,1,89,62);

    $result = array_intersect($array1, $array2);

    echo '<b>Matches : </b>&emsp;';
    foreach ($result as $item) {
        echo $item.' ';
    }
?>