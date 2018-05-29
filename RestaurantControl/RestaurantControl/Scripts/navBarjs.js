$(window).scroll(function () {
    if ($("#menu").offset().top > 56) {
        $("#menu").addClass("colorCambio");
    } else {
        $("#menu").removeClass("colorCambio")
    }
});