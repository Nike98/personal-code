<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Product Repository</title>
</head>
<body>
    <h1>Product Search</h1>
    <br /><br />
    <form action="" method="post">
        <span style="margin-left: 50px;"><b>Enter product ID:</b></span>
        <input type="number" name="prod_id" style="margin-left: 100px;">
        <input type="submit" name="search" value="Search" style="margin-left: 100px;">
    </form>
    <br /><br />
    <?php
    $products = array(
            1 => array("Product Name" => "One Plus 7t Pro", "Manufacturer" => "One Plus", "Quantity" => "10", "Price" => "Rs.53,999"),
            2 => array("Product Name" => "IPhone XS Max", "Manufacturer" => "Apple", "Quantity" => "10", "Price" => "Rs.1,00,000"),
            3 => array("Product Name" => "Google Pixel 3XL", "Manufacturer" => "Google", "Quantity" => "10", "Price" => "Rs.83,000"),
    );

    if (isset($_POST['search'])){
        $prod_id = $_POST['prod_id'];
        if (array_key_exists($prod_id, $products)){
            foreach ($products[$prod_id] as $product => $desc) {
                echo $product." = ".$desc."<br />";
            }
        }
        else
            echo "Product Not Found";
    }
    ?>
</body>
</html>