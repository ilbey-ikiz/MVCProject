﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {

    var current_fs, next_fs, previous_fs; //fieldsets
    var opacity;


    $(".next").click(function () {

        current_fs = $(this).parent();
        next_fs = $(this).parent().next();

        //Add Class Active
        $("#progressbar li").eq($("fieldset").index(next_fs)).addClass("active");

        //show the next fieldset
        next_fs.show();
        //hide the current fieldset with style
        current_fs.animate({ opacity: 0 }, {
            step: function (now) {
                // for making fielset appear animation
                opacity = 1 - now;

                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });
                next_fs.css({ 'opacity': opacity });
            },
            duration: 600
        });
    });

    $(".previous").click(function () {

        current_fs = $(this).parent();
        previous_fs = $(this).parent().prev();

        //Remove class active
        $("#progressbar li").eq($("fieldset").index(current_fs)).removeClass("active");

        //show the previous fieldset
        previous_fs.show();

        //hide the current fieldset with style
        current_fs.animate({ opacity: 0 }, {
            step: function (now) {
                // for making fielset appear animation
                opacity = 1 - now;

                current_fs.css({
                    'display': 'none',
                    'position': 'relative'
                });
                previous_fs.css({ 'opacity': opacity });
            },
            duration: 600
        });
    });

    $('.radio-group .radio').click(function () {
        $(this).parent().find('.radio').removeClass('selected');
        $(this).addClass('selected');
    });

    $(".submit").click(function () {
        return false;
    });


});

function GetSuccess() {
    $.ajax({
        url: "/Register/Success",
        type: "get",
        success: function (response) {
            $("#successFeield").html(response)
        }
    });
}


function Login() {
    let person = {
        mail: $("#form3Example3").val(),
        password: $("#form3Example4").val(),
    }
    $.ajax({
        url: "/Login/IsPeronExistControl",
        type: "get",
        data: person,
        success: function (response) {
            if (response != "fail") {
                window.location.href = "/UserHome/Index/" + response;
            }
            else {
                $("#error").html("<h4>No Person</h4>")
            }
        }
    });
}

function CheckValidCompany() {
    var companyInputList = $('.companyData');
    let button = $("#companyNextButton")
    let j = 0;
    for (var i = 0; i < companyInputList.length; i++) {

        if ($(companyInputList[i]).is('.valid')) {
            j++;
        }
    }
    if (j == companyInputList.length) {
        button.prop('disabled', false ); 
    } else {
        button.prop('disabled', true); 
    }
}

function CheckValidEmployee() {
    var employeeInputList = $('.employeeData');
    let button1 = $("#employeeNextButton")
    let k = 0;
    for (var i = 0; i < employeeInputList.length; i++) {

        if ($(employeeInputList[i]).is('.valid')) {
            k++;
        }
    }
    if (k == employeeInputList.length) {
        button1.prop('disabled', false);
    } else {
        button1.prop('disabled', true);
    }

}