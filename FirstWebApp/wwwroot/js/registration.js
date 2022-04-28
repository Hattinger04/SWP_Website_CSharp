$(document).ready(() => {
    $("#Email").blur(() => {
        $.ajax({
            url: "/user/checkEmail",
            method: "GET",
            data: { email: $("#Email").val() }
        })
            .done((dataFromServer) => {
                if (dataFromServer) {
                    $("#eMailMessage").css("visibility", "visible");
                    $("#Email").addClass("redBorder");
                }
                else {
                    $("#eMailMessage").css("visibility", "hidden");
                    $("#Email").removeClass("redBorder");
                }
            })
            .fail(() => {
                alert("Server URL nicht erreichbar");
            });
    });
    $("#btnToggle").click(() => {
        $("#formReg").toggle();
    });
});
