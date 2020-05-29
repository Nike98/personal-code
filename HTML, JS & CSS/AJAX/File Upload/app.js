function _(element) { return document.getElementById(element); }

function fileUpload() {
    var file = _("file").files[0];
    var formData = new FormData();
    formData.append("file", file);

    var http = new XMLHttpRequest();
    http.upload.addEventListener("progress", progressHandler, false);
    http.addEventListener("load", completionHandler, false);
    http.addEventListener("error", errorHandler, false);
    http.addEventListener("abort", abortHandler, false);
    http.open("POST", "FileUpload.php");
    http.send(formData);
}

function progressHandler(event) {
    _("status").innerHTML = "Uploaded " + event.loaded + "bytes of " + event.total;
    var percent = (event.loaded / event.total) * 100;
    _("progressBar").value = Math.round(percent);
    _("status").innerHTML = Math.round(percent) + "% uploaded. Please wait...";
}

function completionHandler(event) {
    _("status").innerHTML = event.target.responseText;
    _("progressBar").value = 0;
}

function errorHandler(event) {
    _("status").innerHTML = "Upload Failed";
}

function abortHandler(event) {
    _("status").innerHTML = "Upload Aborted";
}