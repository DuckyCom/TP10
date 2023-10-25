// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function MostrarTemporadas(IdS, nombre) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetallesTemporadas',
        data: { IdSerie: IdS },
        success: function (response) {
            let temporadas="";
            $("#NombreS").html("Cantidad de Temporadas de " + nombre + ": " + response.length);
            for (const temporada of response) {
                temporadas = temporadas + temporada.tituloTemporada + "<br>"
            }
            $("#Body").html(temporadas)
        }
    });
}

function MostrarActores(IdS,nombre){
    $.ajax({
            type: 'GET',
            datatype: 'JSON',
            url: '/Home/VerDetallesActores',
            data: {IdSerie: IdS},
            success:
                function(response){
                    console.log(response)
                    let actores="";
                    $("#NombreS").html("Cantidad de Actores "+ nombre + ": " + response.length);
                    for(const actor of response){
                        actores = actores + actor.nombre + "<br>"
                    }
                    $("#Body").html(actores);
                }
        });
}

function MostrarSerie(IdS, nombre) {
    $.ajax({
        type: 'POST',
        dataType: 'JSON',
        url: '/Home/VerDetallesSerie',
        data: { IdSerie: IdS },
        success: function (response) {
            $("#NombreS").html("Más info de la serie " + response.nombre);  
            $("#Body").html("Nombre de la serie: " + nombre + "<br>" + "Año de Inicio: " + response.añoInicio + "<br>" + "Sinopsis: " + response.sinopsis + "<br>")
            $("#AñoInicio").html(response.añoInicio);
            $("#Sinopsis").html(response.sinopsis);
            $("#ImagenSerie").attr("src", "/"+response.imagenSerie);
        }
    });
}