<?php
if ($_POST){
    $input = $_POST['input'];
    $sum = 0;
    $temp = $input;

    while ($temp != 0){
        $rem = $temp % 10;
        $sum += $rem * $rem * $rem;     // is the same as $sum = $sum + $rem * $rem * $rem
        $temp /= 10;    // is the same as $temp = $temp / 10
    }
}

if ($input == $sum)
echo "<br/>Yes, $input is an Armstrong Number";
else
echo "<br/>No, $input is Not an Armstrong Number";
?>