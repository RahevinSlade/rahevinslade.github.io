function Ajax(id) {//How'dy this is the ajax, bit confusing but this essentially allows us to only display artist by genre'
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