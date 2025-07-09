<?php
include 'config.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $username = $_POST["username"];
    $password = password_hash($_POST["password"], PASSWORD_BCRYPT);
    $email = $_POST["email"];
    $dateOfBirth = $_POST["date_of_birth"];

    $checkUsernameQuery = "SELECT * FROM users WHERE username = '$username'";
    $checkResult = $conn->query($checkUsernameQuery);

    if ($checkResult->num_rows > 0) {
        echo '<script>';
        echo 'alert("Username already exists. Please choose a different username.");';
        echo 'window.location.href = "index.php";';
        echo '</script>';
        echo '<button onclick="window.location.href=\'index.php\'">Go back to Home</button>';
        exit();
    }

    $stmt = $conn->prepare("INSERT INTO users (username, password, email, date_of_birth) VALUES (?, ?, ?, ?)");
    $stmt->bind_param("ssss", $username, $password, $email, $dateOfBirth);

    if ($stmt->execute()) {
        echo '<script>';
        echo 'alert("Registration successful! Please log in.");';
        echo 'window.location.href = "index.php";';
        echo '</script>';
        echo '<button onclick="window.location.href=\'index.php\'">Go back to Home</button>';
        exit();
    } else {
        echo "Error: " . $stmt->error;
    }

    $stmt->close();
}

$conn->close();
?>
