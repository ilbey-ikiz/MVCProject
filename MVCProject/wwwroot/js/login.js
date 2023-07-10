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