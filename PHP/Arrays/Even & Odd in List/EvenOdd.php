<?php
    $num_arr = array(1,2,3,4,5,6,7,8,9,0);
    $even = array();
    $odd = array();

    foreach ($num_arr as $item) {
        if ($item % 2 == 0)
            array_push($even, $item);
        else
            array_push($odd, $item);
    }

    echo '<b>Even Numbers : </b>&emsp;';
    foreach ($even as $item) {
        echo $item.', ';
    }

    echo '<br /><br /><b>Odd Numbers : </b>&emsp;';
    foreach ($odd as $item) {
        echo $item.', ';
    }
?>