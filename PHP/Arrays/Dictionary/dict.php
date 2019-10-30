<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Dictionary</title>
</head>
<body>
    <form action="" method="post">
        <h1>Dictionary</h1>
        <input type="text" name="word" placeholder="Word" style="margin-left: 50px;">
        <input type="submit" name="search" value="Search" style="margin-left: 50px;">
    </form>
    <br /><br />
    <?php
    $dictionary = array("Hello" => "Used as a greeting or to begin a Telephone conversation",
                        "Word" => "A single distinct meaningful element of speech or writing used with others (or sometimes)
                                    to form a sentence and typically shown with a space on either side when written or printed.
                                    I don't like the word Unofficial.",
                        "Abstract" => "To take Away.",
                        "Above" => "Overhead",
                        "Responsive" => "Reacting quickly and Positively."
                        );

    if (isset($_POST['search'])){
        $word = $_POST['word'];
        echo $dictionary[$word];
    }
    ?>
</body>
</html>