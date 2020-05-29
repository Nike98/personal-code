function addWord() {
    var word = document.getElementById("new_word").value;
    var description = document.getElementById("desc").value;
    document.getElementById("res_desc").innerHTML = "";
    word = word + ":" + description;
    var http = new XMLHttpRequest();
    http.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200){
            if (this.responseText == "1"){
                document.getElementById("res_desc").style.color = "green";
                document.getElementById("res_desc").innerHTML = "Added the new word to the Dictionary";
            }
            else {
                document.getElementById("res_desc").style.color = "red";
                document.getElementById("res_desc").innerHTML = "Error adding new word to the Dictionary";
            }
        }
    };
    http.open("GET", "fileWriter.php?word="+word+"&type=write", true);
    http.send();
}

function searchWord(){
    var word = document.getElementById("new_word").value;
    document.getElementById("res_desc").innerHTML = "";
    var http = new XMLHttpRequest();
    http.onreadystatechange = function () {
        if (this.readyState == 4 && this.status == 200){
            if (this.responseText == "ERROR"){
                document.getElementById("res_desc").style.color = "red";
                document.getElementById("res_desc").innerHTML = "Word not found in the Dictionary";
            }
            else {
                document.getElementById("res_desc").style.color = "black";
                document.getElementById("res_desc").innerHTML = this.responseText;
            }
        }
    };
    http.open("GET", "fileWriter.php?word="+word+"&type=read", true);
    http.send();
}