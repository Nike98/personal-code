<?php
$a = 10;
$b = 20;

// Displaying the Values before Swapping
echo "<strong>The Value of a : </strong>$a<br/>";
echo "<strong>The Value of b : </strong>$b<br/>";

$temp = $a;
$a = $b;
$b = $temp;

// Displaying the Swapped Values
echo "<br/><br/><strong>The Value of a : </strong>$a<br/>";
echo "<strong>The Value of b : </strong>$b<br/>";
?>