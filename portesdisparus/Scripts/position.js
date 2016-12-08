var map;

var jsondata;
function initMap() {
    // Create a map object and specify the DOM element for display.

    $.getJSON(url)
        .done(function (jsondata) {
            //map = new google.maps.Map(document.getElementById('map'), {
            //    scrollwheel: true,
            //    center: { lat: 5.865427, lng: -4.196123 },
            //    zoom: 8,
            //    mapTypeId:'hybrid'
            //});
            //for (var i = 0; i < jsondata.length; i++) {
            //    var lat = jsondata[i].Latitude;
            //    var lng = jsondata[i].Longitude;

            //        var latLng = new google.maps.LatLng(lat,lng);
            //        var marker = new google.maps.Marker({
            //            position: latLng,
            //            map: map
            //        });
            //    }
            ////map.data.loadGeoJson(json);

            })
        .fail(function (jqXHR, textStatus, err) {

        });
}
 
    // Where all the fun happens 
    //function initMap() { 
 
    //    // Google has tweaked their interface somewhat - this tells the api to use that new UI 
    //    google.maps.visualRefresh = true; 
    //    var Abidjan = new google.maps.LatLng( 5.865427,-4.196123 ); 
 
    //    // These are options that set initial zoom level, where the map is centered globally to start, and the type of map to show 
    //    var mapOptions = { 
    //        zoom: 8, 
    //        center: Abidjan, 
    //        mapTypeId: google.maps.MapTypeId.G_NORMAL_MAP 
    //    }; 
 
    //    // This makes the div with id "map_canvas" a google map 
    //    var map = new google.maps.Map(document.getElementById("map"), mapOptions); 
 
    //    // a sample list of JSON encoded data of places to visit in Tunisia 
    //    // you can either make up a JSON list server side, or call it from a controller using JSONResult 

    //    $.ajax({
    //        type:'GET',
    //        url: '@Url.Action("GetPersonPoint","Alert")',
    //        dataType: 'json',
    //        data:{PersonId:@ViewBag.PersonId},
    //        success: function(data){
    //            // Using the JQuery "each" selector to iterate through the JSON list and drop marker pins 
                
                
    //            $.each(data, function (i, item) { 
    //                var marker = new google.maps.Marker({ 
    //                    'position': new google.maps.LatLng(item.Longitude, item.Latitude), 
    //                    'map': map, 
    //                    'title': item.CurrentAddress
    //                }); 
    //                //alert(item.Latitude);
    //                // Make the marker-pin blue! 
    //                //marker.setIcon('http://maps.google.com/mapfiles/ms/icons/blue-dot.png') 
 
    //                //// put in some information about each json object - in this case, the opening hours. 
    //                var infowindow = new google.maps.InfoWindow({ 
    //                    content: "<div class='infoDiv'><h2>" + item.CurrentAddress + "</div></div>" 
    //                }); 
 
    //                // finally hook up an "OnClick" listener to the map so it pops up out info-window when the marker-pin is clicked! 
    //                google.maps.event.addListener(marker, 'click', function () { 
    //                    infowindow.open(map, marker); 
    //                }); 
 
    //            })
    //        },
    //        error: function(ex){
    //            var r = jQuery.parseJSON(response.responseText);
    //            alert("Message: " + r.Message);
    //            alert("StackTrace: " + r.StackTrace);
    //            alert("ExceptionType: " + r.ExceptionType);
    //        }

    //    });
    //} 
