<?php
if ($_POST){
    $input = $_POST['input'];
    for ($i = 2 ; $i <= $input - 1 ; $i++){
        if ($input % $i == 0)
        $value = true;
    }
}

// If the Number is Not Prime
if (isset($value) && $value)
echo "<br/>The Number " . $input . " is Not Prime";
else
echo "<br/>The Number " . $input . " is Prime";
?>