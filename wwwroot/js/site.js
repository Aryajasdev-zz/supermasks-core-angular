function showcart() {
    $('#shoping-cart').modal('show');
}

function showsignup() {
    try {
        $('#loginbox').hide();
        $('#forgetbox').hide();
        $('#signupbox').show();
    } catch (err) {
        txt += "Error description: " + err.message + "\n\n";
        //alert(txt);
    }
}

function showsignin() {
    try {
        $('#signupbox').hide();
        $('#forgetbox').hide();
        $('#loginbox').show();
    } catch (err) {
        txt += "Error description: " + err.message + "\n\n";
        //alert(txt);
    }
}

function showforget() {
    try {
        $('#signupbox').hide();
        $('#loginbox').hide();
        $('#forgetbox').show();
    } catch (err) {
        txt += "Error description: " + err.message + "\n\n";
        //alert(txt);
    }
}

function paynow() {
    $.getJSON("/api/GetRealRequest", function (json) {
        RealexHpp.init("payButtonId", "/api/GetRealResponse", json);
    });
}    