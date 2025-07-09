/* <div class="col-md-4 mb-4">
<div class="card">
<img src="<?php echo $product['imageCode']; ?>" class="card-img-top" alt="Product Image">
<div class="card-body">
<h5 class="card-title"><?php echo $product['Title']; ?></h5>
<p class="card-text"><?php echo $product['Description']; ?></p>
<p class="card-text">Creator: <?php echo $product['Creator']; ?></p>
<p class="card-text">Price: $<?php echo $product['Price']; ?></p>
<button class="btn btn-primary" onclick="addToCart(<?php echo $product['GameID']; ?>)">Add to Cart</button>
</div>
</div>
</div> */

function likeButtonClicked(id) {
  // Get Element
  const likeButton = document.getElementById(`like-button-game${id}`);

  // If unliked then like
  if (likeButton.classList.contains("btn-outline-primary")) {
    likeButton.classList.remove("btn-outline-primary");
    likeButton.classList.add("btn-danger");
  }

  // If liked then unlike
  else if (likeButton.classList.contains("btn-danger")) {
    likeButton.classList.remove("btn-danger");
    likeButton.classList.add("btn-outline-primary");
  }
}

// Wait for DOM content to load
$(document).ready(function () {
  // AJAX Request to data.json
  $.get("./data.json", function (data) {
    const games = data.games;
    games.forEach((game) => {
      // Create game card
      const gameCard = $(`<div class="col-md-4 mb-4">
            <div class="card">
                <img src="./Photos/${game.ImageCode}" alt="${game.ImageAlt}" />
                <div>
                    <h5 class="card-title">${game.Title}</h5>
                    <p class="card-text">${game.Description}</p>
                    <p class="card-text">${game.Creator}</p>
                    <p class="card-text">${game.Price}</p>
                    <button class="btn btn-primary" onclick="addToCart(${game.GameID})">Add to Cart</button>
                    <button class="btn btn-outline-primary" onclick="likeButtonClicked(${game.GameID})" id="like-button-game${game.GameID}">
                        <i class="bi bi-balloon-heart-fill"></i>
                    </button>
                </div>
            </div>
        </div>`);

      // Show game card in DOM
      $("#games-container").prepend(gameCard);
    });
  });

  // AJAX Request for username validation
  $(`#username-register`).change(function (e) {
    $.get(`./validateUsername.php?username=${e.target.value}`, function (data) {
      if (data == "true") {
        // Username Exists - Valid
        $("#invalid-username").show();
      } else if (data == "false") {
        // Username Doesn't Exist - Invalid
        $("#invalid-username").hide();
      }
    });
  });
});
