/*console.log('Hello World!')

// variaveis 
let nome = "Usuario teste"
let endereco = "Rua Tal tal tal"
let data = "28/10/2021"
let descricao = ""
let foto_do_local
let coordenada_x
let coordenada_y
let coordenadas
let protocolo



function Formulario() {

    
    console.log(nome)

}


    
function ExibeFormulario() {

}*/


//Formulario()
//ExibeFormulario()



function verificar() {

  const form = document.getElementById('form')
  form.addEventListener("submit", function (event) {
    event.preventDefault();
    const input = document.getElementById("address").value + ", Brazil"
    geocodingParams = { searchText: input };
    geocoder.geocode(geocodingParams, onResult);
  })

  var first_name = document.getElementById("first_name").value;
  var last_name = document.getElementById("last_name").value;
  var email = document.getElementById("email").value;
  var address = document.getElementById("address").value;
  var bairro = document.getElementById("bairro").value;
  var city = document.getElementById("city").value;
  var estado = document.getElementById("estado").value;
  var date = document.getElementById("date").value;
  var options = document.getElementById("options").value;

  var resultado_name = document.querySelector("div#resultado-name");
  var resultado_email = document.querySelector("div#resultado-email");
  var resultado_endereco = document.querySelector("div#resultado-endereco");
  var resultado_cidade = document.querySelector("div#resultado-cidade");
  var resultado_data = document.querySelector("div#resultado-data");
  var resultado_tipo = document.querySelector("div#resultado-tipo");

  if (first_name == '') {
    alert('Error! Você não preencheu todos os dados.')
  } else {
    resultado_name.innerHTML = `Seu nome é: ${first_name} ${last_name}`;
    resultado_email.innerHTML = `Seu e-mail é: ${email}`;
    resultado_endereco.innerHTML = `Seu endereço é: ${address} ${bairro}`
    resultado_cidade.innerHTML = `Sua cidade e estado é: ${city} ${estado}`
    resultado_data.innerHTML = `A data e hora que realizou a sua ocorrência foi: ${date}`
    resultado_tipo.innerHTML = `O tipo de ocorrência que você selecionou foi: ${options}`

    // MAPA DE GEOLOCALIZAÇÃO
    var platform = new H.service.Platform({
      'apikey': 'j6pG018A3FfLcLt0NwVys7BbGZMMAnvoBJU51e7fl0M'
    });

    // Obtain the default map types from the platform object:
    var defaultLayers = platform.createDefaultLayers();

    // Instantiate (and display) a map object:
    var map = new H.Map(
      document.getElementById('mapContainer'),
      defaultLayers.vector.normal.map, {
      zoom: 14,
      center: { lat: 52.5, lng: 13.4 }
    });

    // Get the default map types from the platform object:
    var defaultLayers = platform.createDefaultLayers();

    var geocodingParams;

    // Define a callback function to process the geocoding response:
    var onResult = function (result) {
      var locations = result.Response.View[0].Result,
        position,
        marker;
      // Add a marker for each location found
      for (i = 0; i < locations.length; i++) {
        position = {
          lat: locations[i].Location.DisplayPosition.Latitude,
          lng: locations[i].Location.DisplayPosition.Longitude
        };
        map.setCenter(position)
        map.setZoom(14)
        marker = new H.map.Marker(position);
        map.addObject(marker);
      }
    };

    // Get an instance of the geocoding service:
    var geocoder = platform.getGeocodingService();
  }

}










