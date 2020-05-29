var q = 0;
var value = 0;

function action() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200){
            document.getElementById("question").innerHTML = this.responseText;
            document.getElementById("progress_msg").innerHTML = value + "% Completed";
            document.getElementById("prog").value = value;
        }
    };
    xhttp.open("GET", "question.php?q="+q, true);
    q++;
    xhttp.send();
}

function next_question() {
    if (value == 75){
        document.getElementById("mainForm").style.visibility = "hidden";
        document.getElementById("msg").style.visibility = "visible";
    }
    else {
        document.getElementById("ans").value = "";
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function () {
            if (this.readyState == 4 && this.status == 200){
                document.getElementById("question").innerHTML = this.responseText;
                value  = value + 25;
                document.getElementById("progress_msg").innerHTML = value + "% Completed";
                document.getElementById("prog").value = value;
            }
        };
        xhttp.open("GET", "question.php?q="+q, true);
        q++;
        xhttp.send();
    }
}