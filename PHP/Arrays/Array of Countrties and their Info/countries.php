<?php
    session_start();
    $countries = array("India" => array("Maharashtra" => "Maharashtra is a state in the Western region of India and is India's 
                                                            second-most populous state and the third-largest state by area.",
                                        "Goa" => "Goa is a state in India within the coastal region known as Konkan, in Western India.",
                                        "MP" => "Madhya Pradesh is a state in Central India.",
                                        "Gujarat" => "Gujarat is state situated in the Western and North-Western region of India."),
                        "US" => array("Alabama" => "Alabama is a state in the South-Eastern region of the United States.",
                                        "Alaska" => "Alaska is a U.S. State in the North-West extremity of North America.",
                                        "Arizona" => "Arizona is a U.S. state in the South-Western region of the United States.",
                                        "Arkansas" => "Arkansas is a state in the Southern region of the United States, home to over 3 Million people as of 2017.",
                                        "California" => "California is a U.S. state in the Pacific region of the United States."),
                        "Australia" => array("Queensland" => "Queensland is the Second-Largest and third-most populous state in the Commonwealth of Australia.",
                            "Victoria" => "Victoria (abbreviated as Vic) is a state in South-Eastern Australia.",
                            "Christmas Island" => "The Territory of Christmas Island is an external territory comprising the island of the same name.")
    );
?>

<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Drop Down List - Countries</title>
</head>
<body>
    <h2>Drop Down List of Countries</h2>
    <form action="" method="post">
        <select name="country">
            <option selected="selected">Choose One</option>
            <?php
            foreach ($countries as $country => $desc) {
            ?>
            <option value="<?php echo $country; ?>"> <?php echo $country; ?></option>
            <?php
            }
            ?>
        </select>
        <br /><br />
        <input type="submit" name="submit" value="Submit" style="margin-left: 100px;">
        <br /><br />
        <select name="state">
            <?php
            if (isset($_POST['country']) && isset($_POST['submit'])){
                $select1 = $_POST['country'];
                $_SESSION['country'] = $select1;

                foreach ($countries[$select1] as $country => $item) {
                ?>

            <option value="<?php echo $country; ?>"><?php echo $country; ?></option>
            <?php
                }
            }
            ?>
        </select>
        <br /><br />
        <input type="submit" name="submit2" value="Get Info" style="margin-left: 100px;">
        <br /><br />
        <?php
        if (isset($_POST['submit2']) && isset($_POST['state'])){
            $select2 = $_POST['state'];
            $select1 = $_SESSION['country'];
            echo $countries[$select1][$select2];
        }
        ?>
    </form>
</body>
</html>
