//$(document).ready(GetList());

function GetList() {
    $.ajax({
        url: "/Management/List",
        type: "get",
        success: function (response) {
            $("#list").html(response);
            $("#addEmployee").html("");
            $("#update").html("");
            $("#error").html("");
        }
    })
}

function GetCreatEmployee()
{
    $.ajax({
        url: "/Management/CreateEmployee",
        type: "get",
        success: function (response) {
            $("#list").html("");
            $("#addEmployee").html(response);
            $("#update").html("");
            $("#error").html("");
        }
    })
}

