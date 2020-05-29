function display()
{
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        document.getElementById("time").innerHTML = "<b>" + xhttp.responseText + "</b>";
    };
    xhttp.open("GET", "getTime.php", true);
    xhttp.send();
}