<?php

session_start();
if (isset($_SESSION['username'])) {
    $profileLinkText = $_SESSION['username'];
    echo "Welcome back, $profileLinkText!";
    $logoutButton = '<a href="logout.php" onclick="logout()">Log Out</a>';
} else {
    $profileLinkText = 'Profile';
    $logoutButton = '';
}
//DB connection
include 'config.php';
// $productQuery = "SELECT GameID, Creator, Price, Title, Description, imageCode FROM games LIMIT 6";
// $result = $conn->query($productQuery);

// // Check if there are products in the database
// if ($result->num_rows > 0) {
//     $products = $result->fetch_all(MYSQLI_ASSOC);
// } else {
//     $products = array();
// }

$mmoData = file_get_contents("https://www.mmobomb.com/api1/giveaways");
$mmoData = json_decode($mmoData, true);

$labelsString = "";
$dataString = "";

foreach ($mmoData as $data) {
    $labelsString .= ("\"".$data["title"] . "\",");
    $dataString .= (explode("%", $data["keys_left"])[0] . ",");
}
?>

<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
    <title>Astro Games</title>
    <style>
        .page-content {
            display: none;
        }
    </style>

    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.11.3/font/bootstrap-icons.min.css">

    <script src="https://cdn.jsdelivr.net/npm/chart.js"></script>

    <script src="https://code.jquery.com/jquery-3.7.1.js"
        integrity="sha256-eKhayi8LEQwp4NKxN+CfCh+3qOVUtJn3QNZ0TciWLP4=" crossorigin="anonymous"></script>
    <script src="./script.js"></script>
</head>

<body>

    <header>
        <div id="logo"><a href="#" class="nav-link" data-page="index">Your Logo</a></div>
        <nav>
            <a href="#" class="nav-link" data-page="profile"><?php echo $profileLinkText; ?><a>
                    <a href="#" class="nav-link" data-page="cart">Cart</a>


        </nav>
    </header>
    <nav class="main-nav">
        <a href="#" class="nav-link" data-page="page1">New Releases</a>
        <a href="#" class="nav-link" data-page="page2">Free Games</a>
        <a href="#" class="nav-link" data-page="page3">Popular</a>
    </nav>

    <section class="page-content" id="index">
        <!-- Content for the Profile page -->
        <h2>home Page</h2>
        <!-- Content for webpage -->
    </section>

    <section class="page-content" id="profile">
        <!-- Content for the Profile page -->
        <h2>Profile Page</h2>
        <!-- Content for webpage -->
        <button href="#" id="registerBtn" data-page="registerBtn">Register</button>
        <button href="#" id="signIN" data-page="signIN">Sign In</button>
        <?php echo $logoutButton; ?>
    </section>

    <section class="page-content" id="cart">
        <!-- Content for the Cart page -->
        <h2>Cart Page</h2>
        <!-- Content for webpage -->
    </section>

    <section class="page-content" id="page1">
        <!-- Content for Page 1 -->
        <h2>New Releases</h2>
        <div class="container mt-4">
            <div class="row" id="games-container">
            </div>
        </div>

        <div>
            <canvas id="giveawayChart"></canvas>
        </div>
    </section>

    <section class="page-content" id="page2">
        <!-- Content for Page 2 -->
        <h2>Page 2 Content</h2>
        <!-- Content for webpage -->
    </section>

    <section class="page-content" id="page3">
        <!-- Content for Page 3 -->
        <h2>Page 3 Content</h2>
        <!-- Content for webpage -->
    </section>

    <section class="page-content" id="signin" style="display: none;">
        <!-- Content for Sign In -->
        <h2>Sign In</h2>
        <form id="signInForm" action="signin.php" method="post">
            <label for="username">Username:</label>
            <input type="text" id="username" name="username" required>

            <label for="password">Password:</label>
            <input type="password" id="password" name="password" required>

            <button type="submit">Sign In</button>
        </form>
    </section>

    <?php include 'register.php'; ?>
    <section class="page-content" id="registration" style="display: none;">
        <!-- Content for Register -->
        <h2>Register</h2>
        <form id="registrationForm" action="register.php" method="post">
            <p class="text-danger" id="invalid-username">Username already taken</p>
            <label for="username">Username:</label>
            <input type="text" id="username-register" name="username" required>

            <label for="password">Password:</label>
            <input type="password" id="password" name="password" required>

            <label for="email">Email:</label>
            <input type="email" id="email" name="email" required>

            <label for="date_of_birth">Date of Birth:</label>
            <input type="date" id="date_of_birth" name="date_of_birth" required>

            <button type="submit">Submit</button>
        </form>
    </section>

    <script>
        document.addEventListener('DOMContentLoaded', function () {
            // Display the index page by default
            document.getElementById('index').style.display = 'block';

            const navLinks = document.querySelectorAll('.nav-link');
            const pageContents = document.querySelectorAll('.page-content');

            navLinks.forEach(link => {
                link.addEventListener('click', function (e) {
                    e.preventDefault();

                    // Hide all page contents
                    pageContents.forEach(content => {
                        content.style.display = 'none';
                    });

                    // Show the selected page content
                    const targetPage = this.getAttribute('data-page');
                    const selectedPage = document.getElementById(targetPage);
                    selectedPage.style.display = 'block';
                });
            });

            // Add event listener for the Register button
            const registerBtn = document.getElementById('registerBtn');
            registerBtn.addEventListener('click', function (e) {
                // Hide all page contents
                pageContents.forEach(content => {
                    content.style.display = 'none';
                });

                // Show the registration form
                document.getElementById('registration').style.display = 'block';
            });
            <?php
            if (isset($_SESSION['registration_successful']) && $_SESSION['registration_successful']) {
                echo "alert('Registration successful!');";
                //unset($_SESSION['registration_successful']); // Clear the session variable
            }
            ?>
            // script event listener for the sign in button
            const signInBtn = document.getElementById('signIN');
            signInBtn.addEventListener('click', function (e) {
                // Hide all page contents
                pageContents.forEach(content => {
                    content.style.display = 'none';
                });

                // Show the sign-in form
                document.getElementById('signin').style.display = 'block';
            });
            const logoutBtn = document.getElementById('logoutBtn');

            if (logoutBtn) {
                logoutBtn.addEventListener('click', function () {
                    // Open logout.php when the button is clicked
                    window.location.href = 'logout.php';
                });
            }

            function logout() {
                // Redirect to logout.php 
                href = 'logout.php';

            }

            // ChartJS
            const ctx = document.getElementById('giveawayChart');

            new Chart(ctx, {
                type: 'bar',
                data: {
                    labels: [<?php echo $labelsString ?>],
                    datasets: [{
                        label: '% of keys left',
                        data: [<?php echo $dataString ?>],
                        borderWidth: 1
                    }]
                },
                options: {
                    scales: {
                        y: {
                            beginAtZero: true
                        }
                    }
                }
            });
        });
    </script>
</body>

</html>