// Write your Javascript code.

(function poll() {
    setTimeout(function() {
        $.ajax({
            url: "/Bank/Status",
            type: "GET",
            success: function(data) {
                console.log("polling");
            },
            dataType: "json",
            complete: poll,
            timeout: 2000
        })
    }, 5000);
})();
