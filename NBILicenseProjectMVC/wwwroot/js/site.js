// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var setHeight = 3650;

document.getElementById("iddiv").style.height = setHeight + "px";



// CREATE SLIDER
$(document).ready(function () {
    $("#slider").on("input change", function () {
        $("#range-value").text($("#slider").val());
    });
});

$(document).ready(function () {
    $("#slider2").on("input change", function () {
        $("#range-value2").text($("#slider2").val());
    });
});

// EDIT SLIDER
$(document).ready(function () {
    $("#slider3").on("input change", function () {
        $("#range-value3").text($("#slider3").val());
    });
});

$(document).ready(function () {
    $("#slider4").on("input change", function () {
        $("#range-value4").text($("#slider4").val());
    });
});
