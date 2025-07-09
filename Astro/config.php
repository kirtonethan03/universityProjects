<?php 
$servername = "127.0.0.1";
$servUsername = "root";
$servPassword = "";
$dbname = "astrogames";

// Create connection
$conn = new mysqli($servername, $servUsername, $servPassword, $dbname);

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
?>