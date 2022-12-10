<?php
require_once("conexion.php");
// Campos
$nombre=$_POST['nombre'];
$usuario=$_POST['usuario'];
$contra=$_POST['contra'];
$correo=$_POST['correo'];
$cipher_passw = password_hash($contra,PASSWORD_DEFAULT) ;

if($conn -> connect_error)
   die("Connecion fallo: " . $cxn->connect_error);

   else {
    $sql_query="INSERT INTO usuarios (nombre,usuario,contra,correo) 
                 VALUES('$nombre','$usuario','$cipher_passw','$correo')";
    //echo $sql_query;             
   if($conn->query($sql_query) === TRUE) 
   {
      echo"Usuario Registrado exitosamente";
      //header("Location: forma1.html");
      echo"<meta http-equiv='refresh' content='3;url=../Frontend/login.php'>";
    }
   else
     echo"Error al intentar Registrar el usuario"; 

}
?>