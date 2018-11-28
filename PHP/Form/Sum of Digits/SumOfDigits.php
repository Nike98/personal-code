<?php
if ($_POST){
    $input = $_POST['input'];
    $sum = 0; $rem = 0;

    for ($i = 0 ; $i <= strlen($input) ; $i++){
        $rem = $input % 10;
        $sum += $rem;   // is the same as $sum = $sum + $rem
        $input /= 10;   // is the same as $input = $input / 10
    }
}

echo "<br/> The Sum of the Digits = $sum";
?>