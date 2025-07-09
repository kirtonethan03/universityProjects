<?php

include 'config.php';

$checkUsernameQuery = "SELECT * FROM users WHERE username='".$_GET["username"] . "';";
$checkResult = $conn->query($checkUsernameQuery);

if ($checkResult->num_rows > 0) {
    echo "true";
} else {
    echo "false";
}