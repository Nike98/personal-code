<?php
    $string = "The other day I went for a bike ride";
    $spaceCount = substr_count($string, " ");
    $letterIndex = 0;

    // Count the Number of spaces
    for ($i = 0; $i <= $spaceCount; $i++){
        // get space positions
        $spaceIndex = strpos($string, " ", $letterIndex);

        // assign word by specifying start position and length
        if ($spaceIndex == 0)
            $word = substr($string, $letterIndex);
        else
            $word = substr($string, $letterIndex, $spaceIndex - $letterIndex);

        // push the word into the array
        $array[] = $word;

        // get the first letter after the space
        $letterIndex = $spaceIndex + 1;
    }

    // reverse the array
    $reverse = array_reverse($array);

    // print
    foreach ($reverse as $item) {
        echo $item." ";
    }
?>