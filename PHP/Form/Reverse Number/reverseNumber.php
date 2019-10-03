<?php
if (isset($_POST['submit'])){
    $num = $_POST['num'];
    $rev = 0;

    while($num > 0){
        $rev = $rev * 10 + $num % 10;
        $num = (int) ($num / 10);
    }

    echo '
    <br /><br />
    The Reverse Number is : '.$rev.'
    ';
}
?>