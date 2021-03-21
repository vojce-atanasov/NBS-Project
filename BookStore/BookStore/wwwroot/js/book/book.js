$(document).ready(function () {
    console.log("Document Redy From included JS Script!!!")
});


$("#AuthorID").change(function () {
    var optionSelected = $("option:selected", this);
    console.log(optionSelected);
    // nacin 1 za vadenje na imeto
    var optionName = optionSelected[0].innerHTML;
    /*console.log("OptionName 1: " + optionName);*/
    // nacin 2 za vadenje na imeto
    var optionName2 = optionSelected.text();
    /*console.log("OptionName 2: " + optionName2);*/

    $("#AuthorName").val(optionName2);
    /*console.log("AuthorName func check:" + $("#AuthorName").val());*/

});

$("#PublisherID").change(function () {
    var optionSelected = $("option:selected", this);
    var optionName = optionSelected.text();     
    $("#PublisherName").val(optionName);    
});

$("#CategoryID").change(function () {
    var optionSelected = $("option:selected", this);    
    var optionName = optionSelected.text();      
    $("#CategoryName").val(optionName);    
});

//$(document).ready(function () {
//      // Add the page method call as an onclisck handler for the div.
//    $("#Result").click(function () {
//        $.ajax({
//            type: "POST",
//            url: "",
//            data: { someParameter: "some value" },
//            contentType: "application/json; charset=utf-8",
//            dataType: "json",
//            success: function (msg) {
//                // Replace the div's content with the page method's return.
//                $("#Result").text(msg.d);
//            }
//        });
//    });
//});

$("#addNewAuthor").click(function () {
    console.log("model button author add new author");
    var data = {
        name: "VOjche"
    };
    $.ajax({
            type: "POST",
        url: "/Author/CreateAuthorAJAX",
            data: data,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                // Replace the div's content with the page method's return.
                $("#Result").text(msg.d);
            }
    });
});
$("#addNewPublisher").click(function () {
    console.log("model button publisher add new publisher");
    $.ajax({
        type: "POST",
        url: "",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            // Replace the div's content with the page method's return.
            $("#Result").text(msg.d);
        }
    });
});
$("#addNewCategory").click(function () {
    console.log("model button category add new category");
    $.ajax({
        type: "POST",
        url: "",
        data: data,
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (msg) {
            // Replace the div's content with the page method's return.
            $("#Result").text(msg.d);
        }
    });
});