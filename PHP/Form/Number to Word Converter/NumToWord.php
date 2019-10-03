

<?php
/*function readNumber($num, $depth=0)
{
    $num = (int)$num;
    $retval ="";
    if ($num < 0) // if it's any other negative, just flip it and call again
        return "negative " + readNumber(-$num, 0);
    if ($num > 99) // 100 and above
    {
        if ($num > 999) // 1000 and higher
            $retval .= readNumber($num/1000, $depth+3);

        $num %= 1000; // now we just need the last three digits
        if ($num > 99) // as long as the first digit is not zero
            $retval .= readNumber($num/100, 2)." hundred\n";
        $retval .=readNumber($num%100, 1); // our last two digits
    }
    else // from 0 to 99
    {
        $mod = floor($num / 10);
        if ($mod == 0) // ones place
        {
            if ($num == 1) $retval.="one";
            else if ($num == 2) $retval.="two";
            else if ($num == 3) $retval.="three";
            else if ($num == 4) $retval.="four";
            else if ($num == 5) $retval.="five";
            else if ($num == 6) $retval.="six";
            else if ($num == 7) $retval.="seven";
            else if ($num == 8) $retval.="eight";
            else if ($num == 9) $retval.="nine";
        }
        else if ($mod == 1) // if there's a one in the ten's place
        {
            if ($num == 10) $retval.="ten";
            else if ($num == 11) $retval.="eleven";
            else if ($num == 12) $retval.="twelve";
            else if ($num == 13) $retval.="thirteen";
            else if ($num == 14) $retval.="fourteen";
            else if ($num == 15) $retval.="fifteen";
            else if ($num == 16) $retval.="sixteen";
            else if ($num == 17) $retval.="seventeen";
            else if ($num == 18) $retval.="eighteen";
            else if ($num == 19) $retval.="nineteen";
        }
        else // if there's a different number in the ten's place
        {
            if ($mod == 2) $retval.="twenty ";
            else if ($mod == 3) $retval.="thirty ";
            else if ($mod == 4) $retval.="forty ";
            else if ($mod == 5) $retval.="fifty ";
            else if ($mod == 6) $retval.="sixty ";
            else if ($mod == 7) $retval.="seventy ";
            else if ($mod == 8) $retval.="eighty ";
            else if ($mod == 9) $retval.="ninety ";
            if (($num % 10) != 0)
            {
                $retval = rtrim($retval); //get rid of space at end
                $retval .= "-";
            }
            $retval.=readNumber($num % 10, 0);
        }
    }

    if ($num != 0)
    {
        if ($depth == 3)
            $retval.=" thousand\n";
        else if ($depth == 6)
            $retval.=" million\n";
        if ($depth == 9)
            $retval.=" billion\n";
    }
    return $retval;
}

$num = readNumber(123,4);

echo $num;*/

/*if (isset($_POST['submit'])){
    $num = (int)$_POST['num'];
    $retval = "";
    $mod = floor($num / 10);

    if ($mod == 0)  // One's place
    {
        if ($num == 1) $retval .= "ONE";
        else if ($num == 2) $retval .= "TWO";
        else if ($num == 3) $retval .= "THREE";
        else if ($num == 4) $retval .= "FOUR";
        else if ($num == 5) $retval .= "FIVE";
        else if ($num == 6) $retval .= "SIX";
        else if ($num == 7) $retval .= "SEVEN";
        else if ($num == 8) $retval .= "EIGHT";
        else if ($num == 9) $retval .= "NINE";
    }

    else if ($mod == 1)  // if there is a One at the Ten's place
    {
        if ($num == 10) $retval .= "TEN";
        else if ($num == 11) $retval .= "ELEVEN";
        else if ($num == 12) $retval .= "TWELVE";
        else if ($num == 13) $retval .= "THIRTEEN";
        else if ($num == 14) $retval .= "FOURTEEN";
        else if ($num == 15) $retval .= "FIFTEEN";
        else if ($num == 16) $retval .= "SIXTEEN";
        else if ($num == 17) $retval .= "SEVENTEEN";
        else if ($num == 18) $retval .= "EIGHTEEN";
        else if ($num == 19) $retval .= "NINETEEN";
    }

    else    // if there's a different number at the ten's place
    {
        if ($mod == 2) $retval .= "TWENTY";
        else if ($mod == 3) $retval .= "THIRTY";
        else if ($mod == 4) $retval .= "FORTY";
        else if ($mod == 5) $retval .= "FIFTY";
        else if ($mod == 6) $retval .= "SIXTY";
        else if ($mod == 7) $retval .= "SEVENTY";
        else if ($mod == 8) $retval .= "EIGHTY";
        else if ($mod == 9) $retval .= "NINETY";

        if (($num % 10) != 0){
            $retval = rtrim($retval);
            $retval .= "-";
        }
        $retval = $num % 10;
    }
}*/

if (isset($_POST['submit'])){
    $num = $_POST['num'];
    $temp = $num;
    $rev = 0;

    while ($temp > 1){
        $rem = $temp % 10;
        $rev = ($rev * 10) + $rem;
        $temp = (int)($temp / 10);
    }

    do {
        $remainder = $rev % 10;

        switch ($remainder){
            case 0:
                echo 'ZERO';
                break;
            case 1:
                echo 'ONE';
                break;
            case 2:
                echo 'TWO';
                break;
            case 3:
                echo 'THREE';
                break;
            case 4:
                echo 'FOUR';
                break;
            case 5:
                echo 'FIVE';
                break;
            case 6:
                echo 'SIX';
                break;
            case 7:
                echo 'SEVEN';
                break;
            case 8:
                echo 'EIGHT';
                break;
            case 9:
                echo 'NINE';
                break;
        }
        $rev = (int)($rev / 10);
        //if ($rev == 0) {echo 'ZERO';}
        echo '  ';
    } while ($rev > 0);
}

?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Numbers to Words</title>
</head>
<body>
<form action="" method="post">
    <table cellpadding="10" cellspacing="10">
        <tr>
            <td><b>Enter the Number:</b></td>
            <td><input type="text" name="num" value="<?php echo $num; ?>"></td>
        </tr>
        <tr>
            <td></td>
            <td><input type="submit" name="submit" value="Submit"></td>
        </tr>
    </table>
</form>
</body>
</html>
