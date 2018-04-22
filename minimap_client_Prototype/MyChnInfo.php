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
  <script src="js/myMarkerList.js"></script>
  <script src="js/popper.min.js"></script>
  <script src="bootstrap/js/bootstrap.min.js"></script>

  

    <!-- Google Map API -->
   <script async defer
    src="https://maps.googleapis.com/maps/api/js?key=AIzaSyBJ5LJqiXXZuEz8mpU9tK4tGThAu72Gen8&callback=initMap">
    </script>
</head>



<body>
  <!-- Navigation Bar -->
  <div id="topNav">
    <div class="container-fluid">
      <div class="navbar row">

        <div class="col-md-2 ">
          <a href="HomePage.php">
          <center>
            <font size="5" color="white">
              <i class="fas fa-map-marker-alt"></i> MiniMap</font>
          </center>
          </a>
        </div>

        <div class="col-md-6 ">
          <div class="input-group">
            <input type="text" class="form-control form-control-lg" placeholder="Search . . . ">
            <div class="input-group-append">
              <button class="btn btn-default" type="Submit">
                <i class="fas fa-search"></i>
              </button>
            </div>
          </div>
        </div>


        <div class="col-md-3 col-6 ">
          <button type="button" class="btn btn-sm float-right" id="red">
            Notifications <span class="badge badge-light">4</span>
          </button>
          
        </div>
        <div class="col-md-1 col-6">
          <a href="Profile.php">
            <font color="white" size="5"><i class="fas fa-user-circle"></i></font>
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
                <font size="3"><i class="far fa-map"></i> &emsp;Map</font>
              </button>
              </a>

          <!-- Marker -->
            <div class="dropdown dropright">
              
                <button class="btn ddm dropdown-toggle" type="button" data-toggle="dropdown">
                  <font size="3"><i class="fas fa-thumbtack"></i> &emsp;Marker</font>
                </button>
                
                <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
                    <a href="AddMarker.php"><li class="dropdown-item">Add Marker<i class="fas fa-plus-circle"></i></li></a>
                    <a href="MyMarkerList.php"><li class="dropdown-item">My Markers<i class="fas fa-plus-circle"></i></li></a>
                  </ul>
          </div>

          <!-- Channel -->
          <div class="dropdown dropright">
                <button class="btn ddm dropdown-toggle" type="button" data-toggle="dropdown">
                  <font size="3"><i class="fas fa-compass"></i>&emsp; Channel</font>
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
                  <font size="3"><i class="fas fa-cogs"></i>&emsp; Settings</font>
                </button>
                <ul class="dropdown-menu multi-level" role="menu" aria-labelledby="dropdownMenu">
                    <li class="dropdown-item"><a href="Profile.php">My Account<i class="fas fa-user-circle"></i></a></li>
                    <li class="dropdown-item"><a href="#">Help<i class="fas fa-question-circle"></i></a></li>
                    <li class="dropdown-item"><a href="#">Contact<i class="fas fa-envelope"></i></a></li>
                    <li class="dropdown-item"><a href="#">About<i class="fas fa-info-circle"></i></a></li>
                 </ul>
          </div>

          <a href="login.php">
              <button class="btn ddm" type="button">
                <font size="3"><i class="fas fa-sign-out-alt"></i></font>
              </button>
              </a>
              </center>
      </div>




      <!-- Map -->
      <div class="col-md-7 col-12">
        <div id="map"></div>
      </div>




      <!-- Right bar -->
      <div class="col-md-3 ">
        <center>
          <h2 style="padding: 15px;color :red">AIUB Mini Map</h2>
        </center>
        <div >
          <p>Total Markers : <b>450</b></p>
          <p>Total Views : <b>450</b></p>
          <p>Total Subscribed : <b>450</b></p>
          <p>Ratings : 
            <b><i class="fas fa-star"></i></b>
            <b><i class="fas fa-star"></i></b>
            <b><i class="fas fa-star"></i></b>
            <b><i class="far fa-star"></i></b>
            <b><i class="far fa-star"></i></b>
          </p>
        </div>

        
        <div class="cusDiv ">
            <b><p>About</p></b>
            <div class="textLeft">
              <p id="lineHeight">List of Markers which is very helpful for new students to explore the Campus.</p>
            </div>
        </div>
        
        <br>

        <a href="MarkerDetails.php">
          <div class="cusDiv">
            <p>My Place 0</p>
            <div class="textRight" style="display: none">
              <a href="#">
                <b id="Rm">Remove</b>
              </a>
            </div>
          </div>
        </a>

        <a href="MarkerDetails.php">
          <div class="cusDiv">
            <p>My Place 1</p>
            <div class="textRight" style="display: none">
              <a href="#">
                <b id="Rm">Remove</b>
              </a>
            </div>
          </div>
        </a>

        <a href="MarkerDetails.php">
          <div class="cusDiv">
            <p>My Place 2</p>
            <div class="textRight" style="display: none">
              <a href="#">
                <b id="Rm">Remove</b>
              </a>
            </div>
          </div>
        </a>

        <a href="MarkerDetails.php">
          <div class="cusDiv">
            <p>My Place 3</p>
            <div class="textRight" style="display: none">
              <a href="#">
                <b id="Rm">Remove</b>
              </a>
            </div>
          </div>
        </a>

        <a href="MarkerDetails.php">
          <div class="cusDiv">
            <p>My Place 4</p>
            <div class="textRight" style="display: none">
              <a href="#">
                <b id="Rm">Remove</b>
              </a>
            </div>
          </div>
        </a>






        

        <div>
          <center>
          <a href="#" id="manageBtn">
            <button class="btn RedButton bClass" type="button" >
                    <font size="2"><i class="fas fa-pencil-alt"></i> Manage</font>
                  </button>
          </a>

          <a href="MyChnInfo.php" class="hideIt" id="saveBtn">
            <button class="btn RedButton bClass" type="button" >
                    <font size="2"><i class="fas fa-pencil-alt"></i> Save</font>
                  </button>
          </a>
          <a href="MyChnInfo.php" class="hideIt"  id="cancelBtn">
            <button class="btn RedButton bClass" type="button">
                    <font size="2"><i class="fas fa-pencil-alt"></i> Cancel</font>
                  </button>
          </a>
          </center>
        </div>
      </div>

    </div>
  </div>

</body>

</html>
