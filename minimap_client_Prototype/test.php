<!DOCTYPE html>
<html>
<head>
	<title></title>
	<!-- Linking Custom CSS -->
	<link rel="stylesheet" type="text/css" href="css/main.css">
	
	<!-- Linking Bootstrap  -->
	<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
	<link href="FontAwesome\web-fonts-with-css/css/fontawesome-all.css" rel="stylesheet">
	
	<!-- Bootstrap for Javascript -->
	<script src="js/jquery.js"></script>
	<script src="js/popper.min.js"></script>
	<script src="bootstrap/js/bootstrap.min.js"></script>

	
	<!-- Add Google Map -->
	<script>
	
    function initMap() {


        // var uluru = {lat: 23.8103, lng: 90.4125};
        
        //Configuring Map
        


        var markers = [
        	{
	        	coor : {lat: 22.8456, lng: 89.5403},
	        	contentString : '<button>Add Marker</button>'
	    	},
	    	{
	        	coor : {lat: 23.8103, lng: 90.4125},
	        	contentString : '<button>Hello Marker</button>'
	    	},
	    	{
	        	coor : {lat: 22.3569, lng: 91.7832},
	        	contentString : '<button>asdsad Marker</button>'
	    	}
        ];

        // alert();
        var map = new google.maps.Map(document.getElementById('map'), {
          zoom: 7,
          center: markers[0].coor
        });

        for (var i = 0; i < markers.length; i++) 
        {
       		addMarker(markers[i]);
       	}
        //Content in Info Window
        // addMarker();

        // addMarker();

        // addMarker();

        
        function addMarker(marks)
        {
        	var marker = new google.maps.Marker({
		        position: marks.coor,
		        map: map,
	        });
	        
	        if(marks.contentString)
	        {
	        	var infowindow = new google.maps.InfoWindow({
          			content: marks.contentString
        		});

        // Info Window Add listener
		        marker.addListener('click', function() {
		          infowindow.open(map, marker);
		        });

	        }
        }
        
        // Add Marker
        

        // Making Info Window 
        // var infowindow = new google.maps.InfoWindow({
        //   content: contentString
        // });

        // // Info Window Add listener
        // marker.addListener('click', function() {
        //   infowindow.open(map, marker);
        // });
      }
    </script>

    <!-- Google Map API -->
	 <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBJ5LJqiXXZuEz8mpU9tK4tGThAu72Gen8&callback=initMap">
    </script>
</head>



<body>
	<!-- Navigation Bar -->
	<div id="topNav">
		<div class="container-fluid">
			<div class="row" id="">
				<div class="col-md-2 ">
					<center>
						<font size="5"><i class="fas fa-map-marker-alt"></i> MiniMap</font></center>
				</div>

				<div class="col-md-7 ">
					<div class="input-group">
					  <input type="text" class="form-control form-control-lg" placeholder="Search . . . ">
					  <div class="input-group-append">
					    <button class="btn btn-default" type="Submit">
					    	<i class="fas fa-search"></i>
					    </button>
					  </div>
					</div>
				</div>

				<div class="col-md-1 col-6">
					<font size="3" class="float-right" color="white" face="Roboto Condensed">Arefin Saad</font>
				</div>

				<div class="col-md-1 col-6">
					<a href="#">
						<img src="image/user.jpg" class=" img-thumbnail rounded-circle" 
						id="userImage">	
					</a>
				</div>
				

			</div>
		</div>
	</div>

	<div class="container-fluid" style="height: 535px;">
		<div class="row " style="">
			<!-- DropDown -->
			<div class="col-md-2">
  				
				<center>
				<a href="HomePage.php">
				<button class="btn ddm" type="button">
	              <font size="3">Map <i class="far fa-map"></i></font>
	            </button>
	            </a>

  				<!-- Marker -->
		        <div class="dropdown dropright">
		            <button class="btn ddm dropdown-toggle" type="button" data-toggle="dropdown">
		              <font size="3">Marker <i class="fas fa-thumbtack"></i></font>
		            </button>
		            <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
		                <li class="dropdown-item"><a href="#">Add Marker<i class="fas fa-plus-circle"></i></a></li>
		                <li class="dropdown-submenu">
		                  <a  class="dropdown-item"  href="#">My Markers<i class="fas fa-map-marker"></i></a>
		                  <ul class="dropdown-menu">
		                    <li class="dropdown-item"><a  href="HomePage.php">My Marker 1</a></li>
		                    <li class="dropdown-item"><a  href="HomePage.php">My Marker 2</a></li>
		                    <li class="dropdown-item"><a  href="HomePage.php">My Marker 3</a></li>
		                    <li class="dropdown-item"><a  href="HomePage.php">My Marker 4</a></li>
		                    <li class="dropdown-item"><a  href="HomePage.php">My Marker 5</a></li>
		                  </ul>
		                </li>
		              </ul>
    			</div>

    			<!-- Channel -->
    			<div class="dropdown dropright">
		            <button class="btn ddm dropdown-toggle" type="button" data-toggle="dropdown">
		              <font size="3">Channel <i class="fas fa-compass"></i></font>
		            </button>
		            <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
		                <li class="dropdown-item"><a href="CreateChannel.php">Create New Channel<i class="fas fa-search-plus"></i></a></li>
		            	<li class="dropdown-item"><a href="MyChannel.php">My Channels<i class="fas fa-search-plus"></i></a></li>
		                <li class="dropdown-item"><a href="ExploreChannel.php">Explore New Channel<i class="fas fa-search-plus"></i></a></li>
		                <li class="dropdown-item"><a href="MySubscribes.php">My Subscribes<i class="fas fa-search-plus"></i></a></li>
		                
		              </ul>
    			</div>

    			<!-- Settings -->
    			<div class="dropdown dropright">
		            <button class="btn ddm dropdown-toggle" type="button" id="dropdownMenu1" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
		              <font size="3">Settings <i class="fas fa-cogs"></i></font>
		            </button>
		            <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
		                <li class="dropdown-item"><a href="Profile.php">My Account<i class="fas fa-user-circle"></i></a></li>
		                <li class="dropdown-item"><a href="#">Help<i class="fas fa-question-circle"></i></a></li>
		                <li class="dropdown-item"><a href="#">Contact<i class="fas fa-envelope"></i></a></li>
		                <li class="dropdown-item"><a href="#">About<i class="fas fa-info-circle"></i></a></li>
		             </ul>
    			</div>
   			
	            <button class="btn ddm" type="button">
	              <a href="login.php"><font size="3"><i class="fas fa-sign-out-alt"></i></font></a>
	            </button>
	            </center>
			</div>
			<!-- Map -->
			<div class="col-md-7 col-12">
				<div id="map"></div>
			</div>

			<!-- Right bar -->
			<div class="col-md-3 ">
				<center>
					<h2 style="padding: 15px;">My Markers</h2>
				</center>

				<div class="Sort">
					<div class="dropdown">
					Sort By : 
					  <button class="btn dropdown-toggle" type="button" id="dropdownMenuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
					    <i class="fas fa-sort-amount-down"></i>
					  </button>
					  <div class="dropdown-menu" aria-labelledby="dropdownMenuButton">
					    <a class="dropdown-item" href="#">Name</a>
					    <a class="dropdown-item" href="#">Date</a>
					    <a class="dropdown-item" href="#">Month</a>
					  </div>
					</div>
				</div>

				<a href="#">
					<div class="cusDiv ">
						<b><p>My Place 1</p></b>
						<div class="textRight">
							Date : 27-08-2017
						</div>
					</div>
				</a>

				<a href="#">
					<div class="cusDiv ">
						<b><p>My Place 2</p></b>
						<div class="textRight">
							Date : 27-08-2017
						</div>
					</div>
				</a>

				<a href="#">
					<div class="cusDiv ">
						<b><p>My Place 3</p></b>
						<div class="textRight">
							Date : 27-08-2017
						</div>
					</div>
				</a>

				<a href="#">
					<div class="cusDiv ">
						<b><p>My Place 3</p></b>
						<div class="textRight">
							Date : 27-08-2017
						</div>
					</div>
				</a>

				<div>
					<center>
					<a href="#">
						<button class="btn RedButton bClass" type="button">
			            	<font size="2">Manage <i class="fas fa-edit"></i></font>
	            		</button>
	            	</a>
					</center>
				</div>
			</div>

		</div>
	</div>
	

</body>

</html>