//$(document).ready(function () {
//    GetList();
//});

function GetList() {
    $.ajax({
        url: "/Storages/List",
        type: "get",
        success: function (response) {
            $("#list").html(response);
            $("#createStorage").html("");
            $("#message").html("<h3>Liste geldi</h3>");
        }
    });
}
function CreateStoragePage() {
    
    $.ajax({
        url: "/Storages/CreateStorage",
        type: "get",
        success: function (response) {
            $("#createStorage").html(response);
        }
    });
}

function CreateStorage() {
    var columnNameList = [];

    $("input[name^='columnNameList']").each(function () {
        columnNameList.push($(this).val());
    });

    var storageName = $("#StorageName").val();

    $.ajax({
        url: "/Storages/CreateStorage",
        type: "post",
        data: {
            cVM: {
                columnNameList: columnNameList,
                storageName: storageName
            }
        },
        success: function (response) {
            if (response == "ok") {
                $("#createStorage").html("");
                GetList();
            }
            else {
                GetList();
            }

        }
    });
}
