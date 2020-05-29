<?php

$date = getdate();
$day = $date['mday'];
$month = $date['mon'];
$year = $date['year'];
$hour = $date['hours'];
$mins = $date['minutes'];
$secs = $date['seconds'];

echo "$day-$month-$year  $hour : $mins : $secs";

function checkTime($i)
{
    if ( $i < 10 )
    {
        $i = "0".$i;
    }
    return $i;
}
