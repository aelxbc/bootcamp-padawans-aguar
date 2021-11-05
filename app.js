function verificar() {

  var first_name = document.getElementById("first_name").value;
  var last_name = document.getElementById("last_name").value;
  var email = document.getElementById("email").value;
  var address = document.getElementById("address").value;
  var bairro = document.getElementById("bairro").value;
  var city = document.getElementById("city").value;
  var estado = document.getElementById("estado").value;
  var date = document.getElementById("date").value;
  var options = document.getElementById("options").value;
  var title = document.querySelector("h1.title").value;

  var resultado_name = document.querySelector("div#resultado-name");
  var resultado_email = document.querySelector("div#resultado-email");
  var resultado_endereco = document.querySelector("div#resultado-endereco");
  var resultado_cidade = document.querySelector("div#resultado-cidade");
  var resultado_data = document.querySelector("div#resultado-data");
  var resultado_tipo = document.querySelector("div#resultado-tipo");
  var title_ocorrencia = document.querySelector("h1.title")

  if (first_name == '') {
    alert('Error! Você não preencheu todos os dados.')
  } else {
    title_ocorrencia.innerHTML = `SUA OCORRÊNCIA FOI REGISTRADA`
    resultado_name.innerHTML = `Nome registrado: <p class="dados">  ${first_name} ${last_name} </p>`;
    resultado_email.innerHTML = `E-mail registrado: <p class="dados"> ${email} </p>`;
    resultado_endereco.innerHTML = `Endereço registrado: <p class="dados"> ${address} / Bairro: ${bairro} </p>`
    resultado_cidade.innerHTML = `Cidade/Estado registrado: <p class="dados"> ${city} / ${estado} </p>`
    resultado_data.innerHTML = `Data e Hora registrada: <p class="dados"> ${date}`
    resultado_tipo.innerHTML = `Tipo de ocorrência registrada: <p class="dados"> ${options} </p>`

    const form = document.getElementById('form')
    form.addEventListener("submit", function (event) {
      event.preventDefault();
      const input = document.getElementById("address").value + ", Brazil"
      geocodingParams = { searchText: input };
      geocoder.geocode(geocodingParams, onResult);
    })

    // MAPA DE GEOLOCALIZAÇÃO
    var platform = new H.service.Platform({
      'apikey': 'O4oWmp-htCMAOzx5kLBX_jnz0mcd12Vv39brKWaT8w0'
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















