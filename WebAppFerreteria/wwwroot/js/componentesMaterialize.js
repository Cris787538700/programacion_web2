$(document).ready(function () {
    // Inicializaciones previas de Materialize
    $('.datepicker').datepicker();
    $('select').formSelect();
    $('.modal').modal();

    // Inicializo el carrusel-slider
    var $carousel = $('.carousel.carousel-slider');
    $carousel.carousel({
        fullWidth: true,
        indicators: true,
        duration: 200
    });

    // Auto?rotar cada 4 segundos
    setInterval(function () {
        $carousel.carousel('next');
    }, 4000);
});
