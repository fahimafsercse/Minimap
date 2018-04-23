// var markerTmp;
// var infowindowTmp;
// var mapTmp;
// var markers = [];
function initMap() {


       
        var uluru = {lat: 23.874758, lng:90.382677};
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 17,
          center: uluru
        });
        var marker = new google.maps.Marker({
          position: uluru,
          map: map
        });
        
        var infoWindow = new google.maps.InfoWindow({
                content: '<h1>Jasim Uddin Road</h1><p>Latitude : <b><big>23.874758</big></b>&emsp;Longitude : <b><big>90.382677</big></b>'
        });


        marker.addListener('click', function() {
            infoWindow.open(map, marker);
        });
}


