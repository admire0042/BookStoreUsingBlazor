function saveMessage(firstname, lastname) {
   /* alert(firstname + " " + lastname + " has been saved successfully");*/
    document.getElementById("divServerValidations").innerText = firstname + " " + lastname + " has been saved successfully"

}

function savePubMessage(firstname) {
    /* alert(firstname + " " + lastname + " has been saved successfully");*/
    document.getElementById("divServerValidationss").innerText = firstname  + " has been saved successfully"

}


function setFocusOnElement(element) {
    element.focus();
}

//Assuming this is a javascript function that pulls all the biggest cities in America and return them i.e
function getCities() {
    var cities = ["New York", "Los Angeles", "Chicago", "Houston", "Phoenix", "Philadelphia"]
    return cities;
}