<?php
    $res_encrypt = $res_decrypt = "";

    if (isset($_POST['encrypt'])){
        $string = $_POST['str1'];
        $res_encrypt = Encipher($string, 3);
    }

    if (isset($_POST['decrypt'])){
        $string2 = $_POST['str2'];
        $res_decrypt = Decipher($string2, 3);
    }

    function Cipher($char, $key){
        if (!ctype_alpha($char))
            return $char;

        $offset = ord(ctype_upper($char) ? 'A' : 'a');

        return chr(fmod(((ord($char) + $key) - $offset), 26) + $offset);
    }

    function Encipher($input, $key){
        $output = "";
        $input_arr = str_split($input);
        foreach ($input_arr as $item) {
            $output .= Cipher($item, $key);
        }
        return $output;
    }

    function Decipher($input, $key){
        return Encipher($input, 26 - $key);
    }
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Caesar's Cipher</title>
</head>
<body>
    <h1>Cryptography</h1>
    <br />
    <h2>Caesar's Cipher</h2>
    <form method="post">
        <h3>Encryption</h3>
        <p>
            <span style="margin-left: 50px;"><b>String: </b></span>
            <span style="margin-left: 50px;"><input type="text" name="str1"></span>
            <span style="margin-left: 50px;"><input type="submit" name="encrypt" value="Encrypt"></span>
        </p>
        <p>
            <span style="margin-left: 50px;"><b>Encrypted String : </b></span>
            <span style="margin-left: 50px;"><input type="text" value="<?php echo $res_encrypt; ?>"></span>
        </p>
        <br />
        <h3>Decryption</h3>
        <p>
            <span style="margin-left: 50px;"><b>Enter String to Decrypt : </b></span>
            <span style="margin-left: 50px;"><input type="text" name="str2" ></span>
            <span style="margin-left: 50px;"><input type="submit" name="decrypt" value="Decrypt"></span>
        </p>
        <p>
            <span style="margin-left: 50px;"><b>Decrypted String : </b></span>
            <span style="margin-left: 50px;"><input type="text" value="<?php echo $res_decrypt; ?>"></span>
        </p>
    </form>
</body>
</html>
