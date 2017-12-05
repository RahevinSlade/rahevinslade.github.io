$("#searchbutton").click(function () {

    var rating = $("#rating").val();

    var rstring = "&rating=" + rating;

    console.log(rstring);

    $.ajax(
        {
            type: "GET",
            dataType: "json",
            url: "/Search/Search?q=" + $("#searchbox").val() + rstring,
            success: function (data) { displayData(data); },
            error: function () { alert("Things broke!"); }
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
