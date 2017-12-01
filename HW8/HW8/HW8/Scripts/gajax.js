function Ajax(id) {
    var source = "/Home/Genre/" + id;
    console.log(source);
    $.ajax({
        type: "GET",
        dataType: "json",
        data: { id: id },
        url: source,
        success: displayResults,
        error: errorOnAjax
    });
}

function displayResults(data) {
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