﻿// Write your Javascript code.

function poll() {
    setTimeout(function() {
        $.ajax({
            url: "/Bank/Status",
            type: "GET",
            success: function(data) {
                console.log("polling");
                console.log(data);
                if(data === true)
                {
                    window.location.href = "/Bank/Secure";
                }
            },
            error: function(data){
                console.log("polling failed");
                // window.location.href = "/Authenticator/error"
            },
            dataType: "json",
            complete: poll,
            timeout: 2000
        })
    }, 5000);
};