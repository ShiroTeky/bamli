var map;
var url = 'http://localhost:54978/api/map';
var jsondata;
function initMap() {
    // Create a map object and specify the DOM element for display.

    $.getJSON(url)
        .done(function (jsondata) {
            map = new google.maps.Map(document.getElementById('map'), {
                scrollwheel: true,
                center: { lat: 5.865427, lng: -4.196123 },
                zoom: 8,
                mapTypeId:'hybrid'
            });
            for (var i = 0; i < jsondata.length; i++) {
                var lat = jsondata[i].Latitude;
                var lng = jsondata[i].Longitude;

                    var latLng = new google.maps.LatLng(lat,lng);
                    var marker = new google.maps.Marker({
                        position: latLng,
                        map: map
                    });
                }
                //map.data.loadGeoJson(json);

            })
        .fail(function (jqXHR, textStatus, err) {

        });
}