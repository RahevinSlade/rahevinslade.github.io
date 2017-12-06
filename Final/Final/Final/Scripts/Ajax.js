var ajax_call = function (id) {
    //your jQuery ajax code
    var source = "/Bids/Item" + id;
    $.ajax({
        type: "GET",
        dataType: "json",
        data: { id: id },
        url: source,
        success: displayResults,
        error: errorOnAjax
    });
};

var interval = 1000 * 5; // where X is your timer interval in X seconds

function displayResults(data) {//this display well the results from our search through artist with certain genre
    console.log("AJAX Success!");
    console.log(data);
    $('#results').empty();

    var item = document.getElementById("results");

    data.arr.forEach(function (item) {
        $('#results').append(item);
    });

}

function errorOnAjax() {
    console.log("Error");
}

window.setInterval(ajax_call, interval);