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

	<!-- Google Map API -->
	 <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyD5aWDUor0l1wYnXeYFv0_fuOVhVPyhobU&callback=initMap">
    </script>
	<!-- Add Google Map -->
	<script>
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
      }
    </script>
</head>



<body>
	<!-- Navigation Bar -->
	<div id="topNav">
		<div class="container-fluid">
			<div class="navbar row">
				<div class="col-md-3">
					<center>
						<font size="5"><i class="fas fa-map-marker-alt"></i> MiniMap</font></center>
				</div>
				<div class="col-md-7">
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