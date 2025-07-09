<?php
session_start();

// Check if the user is logged in
if (isset($_SESSION['username'])) {
    // Clear all session variables
    $_SESSION = array();

    // Destroy the session
    session_destroy();

    // Ensure the session cookie is deleted
    setcookie(session_name(), '', time() - 3600, '/');

    // Redirect to index.php
    header('Location: index.php');
    exit();
} 
?>
