var mapa;
var geocoder;

<<<<<<< HEAD
function atualizarFocosMapa(link, descricao)
{
    $.getJSON(link, function (data) {
        $(data).each(function (index, item) {
            mapa.setZoom(7);

=======
function atualizarFocosMapa(link)
{
    $.getJSON(link, function (data) {
        $(data).each(function (index, item) {
            mapa.setZoom(5);
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
            var ponto = item.results[index].geometry.location;
            var latLng = new google.maps.LatLng(ponto.lat, ponto.lng);

            var marker = new google.maps.Marker({
                map: mapa,
                position: latLng
            });
<<<<<<< HEAD

            marker.setIcon('img/aedes.png');

            var infoDescricao = new google.maps.InfoWindow({
                content: $.trim(descricao) ? descricao : ''
            });

            marker.addListener('click', function () {
                infoDescricao.open(mapa, marker);
            });
=======
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
        });
    });
}

function carregaEndereco(event) {
    event.preventDefault();

    var endereco = $('#txtEndereco').val();
    var pais = $('#txtPais').val();
    var estado = $('#txtEstado').val();
    var cidade = $('#txtCidade').val();
    var bairro = $('#txtBairro').val();
    var descricao = $('#txtDescricao').val();

    var pesquisar = validarCamposObrigatorios();

    if (pesquisar) {
        $('#btnSalvar').attr('disabled', false);

        geocoder.geocode({ 'address': pais + ', ' + estado + ', ' + cidade + ', ' + bairro + ', ' + endereco }, function geocodeResult(results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                mapa.setCenter(results[0].geometry.location);
                mapa.setZoom(15);

                var marker = new google.maps.Marker({
                    map: mapa,
                    position: results[0].geometry.location
                });

<<<<<<< HEAD
                marker.setIcon('img/aedes.png');

                var infoDescricao = new google.maps.InfoWindow({
                    content: $.trim(descricao) ? descricao : ''
=======
                var infoDescricao = new google.maps.InfoWindow({
                    content: 'Descrição 1'
>>>>>>> 21a1d9d7b788db1148b25f473e48d703ed21163e
                });

                marker.addListener('click', function () {
                    infoDescricao.open(mapa, marker);
                });
            }
            else {
                alert('Ocorreu um erro ao tentar localizar o Geocode: ' + status);
            }
        });
    }
    else
        $('#btnSalvar').attr('disabled', true);
}

function initialize() {
    //Exibe o mapa
    var posicaoAtual = new google.maps.LatLng(-18.8800397, -47.05878999999999);
    var opcoesMapa = {
        zoom: 5,
        center: posicaoAtual,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };

    geocoder = new google.maps.Geocoder();

    //Exibir o mapa na div #mapa
    mapa = new google.maps.Map(document.getElementById('mapa'), opcoesMapa);

    //marcador = new google.maps.Marker({
    //    map: mapa,
    //    draggable: true
    //});

    //marcador.setPosition(posicaoAtual);
}

function validarCamposObrigatorios() {
    var pais = $('#txtPais');
    var estado = $('#txtEstado');
    var cidade = $('#txtCidade');
    var rua = $('#txtEndereco');
    var situacaoFoco = $('#ddlStatus');
    var bloquear = false;

    if (!$.trim(pais.val())) {
        colorirCampoObrigatorio(pais, true);
        bloquear = true;
    }
    else
        colorirCampoObrigatorio(pais, false);

    if (!$.trim(estado.val())) {
        colorirCampoObrigatorio(estado, true);
        bloquear = true;
    }
    else
        colorirCampoObrigatorio(estado, false);

    if (!$.trim(cidade.val())) {
        colorirCampoObrigatorio(cidade, true);
        bloquear = true;
    }
    else
        colorirCampoObrigatorio(cidade, false);

    if (!$.trim(rua.val())) {
        colorirCampoObrigatorio(rua, true);
        bloquear = true;
    }
    else
        colorirCampoObrigatorio(rua, false);

    if (!$.trim(situacaoFoco.val())) {
        colorirCampoObrigatorio(situacaoFoco, true);
        bloquear = true;
    }
    else
        colorirCampoObrigatorio(situacaoFoco, false);

    bloquearPesquisaMapa(bloquear);

    return !bloquear;
}

function bloquearPesquisaMapa(bloquear)
{   
    if (bloquear)
        $('#lblErro').text('Preencha os campos obrigatórios.');
    else
        $('#lblErro').text('');
}

function colorirCampoObrigatorio(campo, colorir){
    if(colorir){
        campo.css('border-style', 'solid');
        campo.css('border-color', 'red');
        campo.css('border-width', '2px');
    }
    else{
        campo.css('border-style', 'solid');
        campo.css('border-color', 'lightgrey');
        campo.css('border-width', '1px');
    }
}

$(document).ready(function () {
    initialize();
});