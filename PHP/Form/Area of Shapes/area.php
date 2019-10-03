<?php
if (isset($_POST['submit'])){
    $rect_len = $_POST['rect_len'];
    $rect_breadth = $_POST['rect_breadth'];
    $tri_height = $_POST['tri_height'];
    $tri_base = $_POST['tri_base'];
    $cir_rad = $_POST['cir_radius'];
    $sph_rad = $_POST['sph_radius'];
    $area_rect = 0.0;
    $area_tri = 0.0;
    $area_circle = 0.0;
    $area_sphere = 0.0;
    $pi = 3.142857;

    $area_rect = $rect_len * $rect_breadth;
    $area_tri = $tri_height * $tri_base * 0.5;
    $area_circle = $pi * pow($cir_rad, 2);
    $area_sphere = 4 * $pi * pow($sph_rad, 2);
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Area of Shapes</title>
</head>
<body>
<!-- Area of Rectangle, Triangle, Circle, Sphere -->

<form action="" method="post">
    <table cellpadding="10" cellspacing="10">
        <tr style="font-size: larger;">
            <td><b>Shape</b></td>
            <td><b>Type of Data</b></td>
            <td><b>Data Input</b></td>
        </tr>
        <tr></tr>
        <tr>
            <td rowspan="2"><b>Rectangle</b></td>
            <td><b>Length:</b></td>
            <td><input type="text" name="rect_len" value="<?php echo $rect_len ?>" /></td>
        </tr>
        <tr>
            <td><b>Breadth:</b></td>
            <td><input type="text" name="rect_breadth" value="<?php echo $rect_breadth ?>" /></td>
        </tr>
        <tr></tr>
        <tr>
            <td rowspan="2"><b>Triangle</b></td>
            <td><b>Height:</b></td>
            <td><input type="text" name="tri_height" value="<?php echo $tri_height ?>" /></td>
        </tr>
        <tr>
            <td><b>Base:</b></td>
            <td><input type="text" name="tri_base" value="<?php echo $tri_base ?>" /></td>
        </tr>
        <tr></tr>
        <tr>
            <td><b>Circle</b></td>
            <td><b>Radius:</b></td>
            <td><input type="text" name="cir_radius" value="<?php echo $cir_rad ?>" /></td>
        </tr>
        <tr></tr>
        <tr>
            <td><b>Sphere</b></td>
            <td><b>Radius:</b></td>
            <td><input type="text" name="sph_radius" value="<?php echo $sph_rad ?>" /></td>
        </tr>
        <tr><td></td></tr>
        <tr><td></td></tr>
        <tr>
            <td><b>Area of Rectangle</b></td>
            <td><input value="<?php echo $area_rect; ?>"></td>
        </tr>
        <tr>
            <td><b>Area of Triangle</b></td>
            <td><input value="<?php echo $area_tri; ?>"></td>
        </tr>
        <tr>
            <td><b>Area of Circle</b></td>
            <td><input value="<?php echo $area_circle; ?>"></td>
        </tr>
        <tr>
            <td><b>Area of Sphere</b></td>
            <td><input value="<?php echo $area_sphere; ?>"></td>
        </tr>
        <tr></tr>
        <tr></tr>
        <tr>
            <td></td>
            <td><input type="submit" name="submit" value="Submit"></td>
        </tr>
    </table>
</form>
</body>
</html>
