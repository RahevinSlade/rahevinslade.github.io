$("#searchbutton").click(function () {
    $.ajax(
        {
            type: "GET",
            dataType: "json",
            url: "/Search/Search?q=" + $("#searchbox").val(),
            success: function (data) { displayData(data); },
            error: function () { alert("Things broke!");}
        }
    );
});

function displayData(data) {
    $("#output").empty();
    $.each(data, function (i, image) {
        $("#output").append(
            "<div class='giphy'><img class='img-responsive' src='"
            + image["image"]
            + "' />"
            + "</div>"
        );
    });
}