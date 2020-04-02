function formValidation(){
    var uid = document.registration.userid;
    var email = document.registration.email;
    var zip = document.registration.zip;


    userid_validation(uid, 6, 16);
    sex_validation();
    email_validation(email);
    zip_validation(zip);
}

// Function for validating the User ID text box to be empty or within the allowed range
function userid_validation(uid, min, max){
    var uid_length = uid.value.length;

    if (uid_length == 0 || uid_length > max || uid_length < min) {
        document.getElementById("err_uid").innerHTML = "* User ID should not be empty / Length should be between " + min + " and " + max;

    }else{
        document.getElementById("err_uid").innerHTML = "";
    }
}

// Function for validating the Gender input
function sex_validation(){
    if (document.getElementById("sex").checked)
        document.getElementById("err_gender").innerHTML = "";
    else
        document.getElementById("err_gender").innerHTML = "* Select either Male or Female";
}

//Function for Email format validation
function email_validation(email){
    var mail_format = /^\w+(\.-]?\w+)*@\w+(\.-]?\w+)*(\.\w{2,3})+$/;

    if (email.value.match(mail_format))
        document.getElementById("err_email").innerHTML = "";
    else
        document.getElementById("err_email").innerHTML = "* You have entered an invalid Email address.";

    if (email.value.length == 0)
        document.getElementById("err_email").innerHTML = "* Please fill the Email ID field.";

}

// Function to validate the Zip Code
function zip_validation(zip){
    var numbers = /^[0-9]+$/;
    var zip_length = zip.value.length;

    if (zip.value.match(numbers))
        document.getElementById("err_zip").innerHTML = "";
    else
        document.getElementById("err_zip").innerHTML = "* The Zip Code must contain numeric characters only.";

    if (zip_length > 6)
        document.getElementById("err_zip").innerHTML = "* The Zip Code value exceeds the defined format length.";

    if (zip_length == 0)
        document.getElementById("err_zip").innerHTML = "* Please fill the Email ID field.";
}