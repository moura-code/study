<?php 
  session_start();
  $_SESSION['usuario'] = NULL;
  unset($_SESSION['usuario']);
	echo "<meta http-equiv=Refresh content=\"1 ; url=../frontend/login.php\">";

?>