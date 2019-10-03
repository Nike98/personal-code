<?php
function demo(){
    static $no_of_calls;
    $no_of_calls++;
    return $no_of_calls;
}

demo();
demo();
demo();
demo();
demo();
$final = demo();

echo '<h3><b>The Function "demo()" has been called - '.$final.' times.</b></h3>'
?>