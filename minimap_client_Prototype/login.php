<!DOCTYPE html>
<html>
<head>
	<title></title>
	
	<!-- Linking CSS -->
	<head>
	<title></title>
	<!-- Linking Custom CSS -->
	<link rel="stylesheet" type="text/css" href="css/main.css">
	
	<!-- Linking Bootstrap  -->
	<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
	<link href="FontAwesome\web-fonts-with-css/css/fontawesome-all.css" rel="stylesheet">

</head>
<body>
	<div id="topNav">
		<div class="container">
			<div class="navbar row">
				<div class="col-md-3">
					<center>
						<font size="5" color="white"><i class="fas fa-map-marker-alt"></i> MiniMap</font></center>
				</div>
				
				<div class="col-md-1 col-6 ">
						<button class="btn btn-light" type="button">
							<a href="Register.php">
								<font color="red">Sign Up</font>
							</a>
						</button>
				</div>
				

			</div>
		</div>
	</div>

	<div class="container" style="padding-top: 70px;">
		<div class="row">
			<div class="col-md-7 " style="padding: 100px;">
				<img src="image/login.png" width="400px" class="img-fluid"/>
			</div>
			<div class="col-md-5 ">
				<div class="customDiv" style="padding: 40px;box-shadow: 10px 10px 50px #FF9595">
					<center>
						<font face="Roboto" size="5">Welcome to MiniMap</font>
					</center>

					<br>

					<b>
					<div class="form-group">
					  <label for="pwd">Username / Mobile No :</label>
					  <input type="text" class="form-control" id="pwd">
					</div>

					<div class="form-group">
					  <label for="pwd">Password</label>
					  <input type="password" class="form-control" id="pwd">
					</div>


					<div class="form-check" style="text-align: right;">
					  <label class="form-check-label">
					    <input type="checkbox" class="form-check-input" value="">Remember Me
					  </label>
					</div>
					</b>

					<a href="#">Forgot Password ?</a>

					
					<br><br>
					
					<a href="HomePage.php">
					<button class="btn btn-block bClass"  type="button" style="background: red;">
        				
          				<font size="3" color="white">
          						<i class="fas fa-image"></i> Login
          				</font>
          				
			        </button>
			    	</a>
				</div>
			</div>
		</div>
	</div>
</body>
</html>