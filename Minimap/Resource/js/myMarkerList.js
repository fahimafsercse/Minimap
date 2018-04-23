function initMap() {


        // var uluru = {lat: 23.8103, lng: 90.4125};
        
        //Configuring Map

        var markers = [
        {
            coor : {lat: 23.871166, lng: 90.382826},//sector -12
            contentString : '<button>Add Marker</button>'
        },
        {
            coor : {lat: 23.874266, lng: 90.387729},
            contentString : '<button>Hello Marker</button>'
        },
        {
            coor : {lat: 23.871617, lng: 90.387923},
            contentString : '<button>asdsad Marker</button>'
        },
        {
            coor : {lat: 23.867026, lng: 90.386549},
            contentString : '<button>asdsad Marker</button>'
        }
      ];


        
        // alert(markers[0].coor.lat);
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 15,
          center: {lat: 23.871166, lng: 90.382826}
        });

        for (var i = 0; i < markers.length; i++) 
        {
          addMarker(markers[i]);
        }

        
        function addMarker(marks)
        {
          var marker = new google.maps.Marker({
            position: marks.coor,
            map: map,
          });
       }
        

/////////////////////////////////////////////////////////////////////////////////////////
      }
$(document).ready(function(){



  //adding markers to the list
	$(document).on('click','.RedButton', function(e){

        //above message
        $(".textRight").show();

        $("a").click(function(){
            $(this).parent().parent().hide();
            // alert("alereada");
        });
    });

    $("#manageBtn").click(function(){
        $(this).hide();
        $("#saveBtn").show();
        $("#cancelBtn").show();
    });

 
});
    
