<?php
    $word = $_GET['word'];
    $type = $_GET['type'];

    if ($type == 'write'){
        $word = $word.PHP_EOL;
        $file = fopen("dictionary.txt", "a+");
        fwrite($file, $word);
        fclose($file);
        echo "1";
    }
    elseif ($type == 'read') {
        $file = fopen("dictionary.txt", "r");
        $desc = "ERROR";
        while (!feof($file)){
            $text = fgets($file);
            $split = explode(":", $text,  2);
            if ($split[0] == $word) {
                $desc = "<b>" .$word. " : </b>&emsp;" .$split[1];
                break 1;
            }
        }
        echo $desc;
        fclose($file);
    }
?>