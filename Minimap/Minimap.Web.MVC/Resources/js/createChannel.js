var markerTmp;
var infowindowTmp;
var mapTmp;
var markers = [];
function initMap() {

      
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 7,
          center: {lat: 22.8456, lng: 89.5403}
        });

        mapTmp = map;
        

        google.maps.event.addListener(map, 'click', function(event) {
           placeMarker(event.latLng);
           var cuslatLng = event.latLng;
        });



        function placeMarker(location) {
                var marker = new google.maps.Marker({
                position: location, 
                map: map
            });


                //close infowindow
                markerTmp = marker;

                //delete all markers
                markers.push(marker);
          
                var infowindow = new google.maps.InfoWindow({
                content: '<div id=iWindow><b><p>Name : My Place</b></p>'
                +'<b>Latitude : </b><p id=mapLat>'+location.lat().toFixed(5)+'</p>'
                +'<b>Longitude : </b><p id=mapLng>'+location.lng().toFixed(5)+'</p>'
                +'<br><button id=mapBtn>Add to List</button></div>'

                });
              
                infowindowTmp = infowindow;

                infowindow.open(map, marker);
                

                //Info Window Add listener
                marker.addListener('click', function() {
                  infowindow.open(map, marker);
                  
                });
        }
}



function DeleteMarkers() 
{
    //Loop through all the markers and remove
    for (var i = 0; i < markers.length; i++) {
        markers[i].setMap(null);
    }
    markers = [];
};

function closeWindow()
{
    infowindowTmp.close(mapTmp, markerTmp);
}
// function DeleteMarkers()
// {
//     marker.setMap(null);
// }
////////////////////////////////////////////////////////////////////// 
$(document).ready(function(){
    var i = 0
  //adding markers to the list
	$(document).on('click','#mapBtn', function(e){

    $("#clickMsg").hide();

    //below button
    $("#manageBtn").show();
    $(".list").append("<div class=cusDiv>Place Name : <input type=text class=textbox name=name[" + i + "] id=name[" + i + "] value=MyPlace />Latitude   :<input type=text name=lat[" + i + "] id=lat[" + i + "] value=" + $("#mapLat").text() + " readonly><br>Longitude  :<input type=text name=lng[" + i + "] id=lng[" + i + "] value=" + $("#mapLng").text() + " readonly><div class=textRight><a href=#> Remove </a></div></div>");
    //$(".list").append("<div class=cusDiv><p>Place Name : <input type=text class=textbox value=MyPlace></p><p>Location : "+$("#mapLat").text()+" , "+$("#mapLng").text()+"</p><div class=textRight><a href=#> Remove </a></div></div>");
    i++;
    $(this).hide();
    closeWindow();
    

    $("a").click(function(){
         $(this).parent("div").parent("div").hide();
    });
    
  });

  $("#clearList").click(function(){
    //markers div
    $(".list").empty();
    $("#clickMsg").show();
    DeleteMarkers();
   
    //manage button
    $("#manageBtn").hide();
  });


  $("#rqBtn").click(function(){
    alert("Request has been to sent to Admin for verification.");
  });


  //clearing all the markers from map
  $(document).on('click',"#clearMarkers",function(e){
    DeleteMarkers();
    $(".list").empty();
  });


});
    
