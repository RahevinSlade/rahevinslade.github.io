//window.setInterval(ajax_call, 5000);
function ajax_call(id) {
    $.ajax({
        type: 'GET',
        dataType: 'json',
        url: '/Items/Bidders/' + id,
        data: { id: id },
        success: displayResults,
        error: errorOnAjax
    });
}

function displayResults(data) {
    $('#results').empty();

    var item = document.getElementById("#results");
    data.arr.forEach(function (item) {
        $('#results').append(item);
    })
    console.log(data);
}

function errorOnAjax() {
    console.log("An error occurred.");
}

window.setInterval(ajax_call(id), 5000);