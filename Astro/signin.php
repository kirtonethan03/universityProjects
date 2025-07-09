<?php include "config.php";

      
// Check if the form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Retrieve user input
    $username = $_POST['username'];
    $password = $_POST['password'];

    

    // Use prepared statements to prevent SQL injection
    $stmt = $conn->prepare("SELECT username, password FROM users WHERE username = ?");
    $stmt->bind_param("s", $username);
    $stmt->execute();
    $stmt->store_result();

    // Check if a user with the provided username exists
    if ($stmt->num_rows > 0) {
        $stmt->bind_result($dbUsername, $dbPassword); 

        // Fetch the results
        $stmt->fetch();

       // Verify the password
        if (password_verify($password, $dbPassword)) {
            // Authentication successful, store user info in session     
            session_start();
            $_SESSION["username"] = $username;
            $_SESSION['signin_status'] = 'success';
            header('Location: index.php'); // Redirect to home page upon successful sign-in
            die();
        } else {
            $_SESSION['signin_status'] = 'failed';
            echo "<script>alert('Incorrect password. Please try again. ');</script>";
            sleep(1);
            header('Location: index.php'); 
        }
    } else {
        $_SESSION['signin_status'] = 'failed';
        echo '<script>alert("Username not found. Please check your credentials.");</script>';
        header('Location: index.php'); 
    } 

    // Close the prepared statement and database connection
    $stmt->close();
    $conn->close();
}
?>
