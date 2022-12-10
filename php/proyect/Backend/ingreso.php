<?php
session_start();
include('conexion.php');
$usuario=$_POST["usuario"];
$contra =$_POST["contra"];

if ($conn->connect_error) 
    die("Connection failed: " . $conn->connect_error);
else {
$sql="select * from usuarios where usuario='".$usuario."'";
$result = $conn->query($sql);
$row = $result->fetch_assoc();
$_SESSION['usuario'] = $row["nombre"];
$contrasena = $row["contra"];
$_SESSION['ID_Sesion'] = generarID();
$_SESSION['IP_Cliente'] = $_SERVER['REMOTE_ADDR']; 

if (password_verify($contra, $contrasena)){
    echo "Login Exitoso";
     echo'<meta http-equiv="refresh" content="3;URL=../Frontend/sistema.php">';
      
       }
 
    else{ 
        echo "Usuario o password son incorrectos";
        echo'<meta http-equiv="refresh" content="3;URL=../Frontend/login.php">';	
     }
 $conn->close();
 }

 function generarID()
 {
    return rand(1,65000);
 }
 
?>