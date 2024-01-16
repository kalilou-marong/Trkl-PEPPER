// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


// Modal contact de contact relié au css

document.addEventListener("DOMContentLoaded", function () {
  const openBtn = document.getElementById("open-btn");
  const modal = document.getElementById("contactez-nous");
  const closeBtn = document.getElementById("close-btn");

  // Ouvrir la modal quand le bouton est cliqué
  openBtn.addEventListener("click", function () {
    modal.style.display = "flex"; // Afficher la modal
  });

  // Fermer la modal quand on clique sur le bouton de fermeture
  closeBtn.addEventListener("click", function () {
    modal.style.display = "none"; // Cacher la modal
  });

  // Fermer la modal si on clique en dehors de celle-ci
  window.addEventListener("click", function (event) {
    if (event.target === modal) {
      modal.style.display = "none"; // Cacher la modal
    }
  });

  // Modal formulaire de contact relié au css
  const openBtnReservation = document.getElementById("btn_reservation");
  const openBtnReservation2 = document.getElementById("btn_reservation2");
  const openBtnReservation3 = document.getElementById("btn_reservation3");
  const modalReservation = document.getElementById("reservez");
  const closeBtnReservation = document.getElementById("prendre-reservation-close-btn");

  function openModal() {
    modalReservation.style.display = "flex"; // Afficher la modal
  }

  openBtnReservation.addEventListener("click", openModal);
  openBtnReservation2.addEventListener("click", openModal);
  openBtnReservation3.addEventListener("click", openModal);

  // Fermer la modal quand on clique sur le bouton de fermeture
  closeBtnReservation.addEventListener("click", function () {
    modalReservation.style.display = "none"; // Cacher la modal
  });

  // Fermer la modal si on clique en dehors de celle-ci
  window.addEventListener("click", function (event) {
    if (event.target === modalReservation) {
      modalReservation.style.display = "none"; // Cacher la modal
    }
  });

  // Carousel functions
  let items = document.querySelectorAll(".carousel .carousel-item");

  items.forEach((el) => {
    const minPerSlide = 3;
    let next = el.nextElementSibling;

    for (let i = 1; i < minPerSlide; i++) {
      if (!next) {
        next = items[0];
      }

      let cloneChild = next.cloneNode(true);
      el.appendChild(cloneChild.children[0]);
      next = next.nextElementSibling;
    }
  });

  let multipleCardCarousel = document.querySelector("#carouselExampleControls");

  if (window.matchMedia("(min-width: 768px)").matches) {
    let carousel = new bootstrap.Carousel(multipleCardCarousel, {
      interval: false, // Disable automatic sliding
      wrap: false, // Prevent wrapping at the end
    });

      // Afficher les infos détaillées du menu découverte
      var clickableItems = document.querySelectorAll('.menuDecouverteLeft li.clickable');

      clickableItems.forEach(function (item) {
          item.addEventListener('click', function () {
              // Gestion du clic ici
              var itemName = item.textContent.trim();
              var itemDescription = item.nextElementSibling.textContent.trim().substring(1);

              // Obtenir le chemin de l'image spécifique à l'élément cliqué
              var discoverImage = item.querySelector('img');
              var imagePath = discoverImage ? discoverImage.src : '';

              // Mettre à jour le contenu de la carte menuDecouverteRight
              var menuRightTitle = document.querySelector('.menuDecouverteRight h2');
              var menuRightImage = document.querySelector('.menuDecouverteRight img');
              var menuRightTitleCard = document.querySelector('.menuDecouverteRight .card-title');
              var menuRightText = document.querySelector('.menuDecouverteRight .card-text');

              menuRightTitle.textContent = itemName;
              menuRightImage.src = imagePath;
              menuRightTitleCard.textContent = itemName;
              menuRightText.textContent = itemDescription;
          });
      });



    let carouselInner = document.querySelector("#carouselExampleControls .carousel-inner");
    let cardWidth = document.querySelector("#carouselExampleControls .carousel-item").offsetWidth;
    let scrollPosition = 0;

    document.querySelector("#carouselExampleControls .carousel-control-next").addEventListener("click", function () {
      if (scrollPosition < carouselInner.scrollWidth - cardWidth * 4) {
        scrollPosition += cardWidth;
        carouselInner.scroll({ left: scrollPosition, behavior: "smooth" });
      }
    });

    document.querySelector("#carouselExampleControls .carousel-control-prev").addEventListener("click", function () {
      if (scrollPosition > 0) {
        scrollPosition -= cardWidth;
        carouselInner.scroll({ left: scrollPosition, behavior: "smooth" });
      }
    });
  } else {
    multipleCardCarousel.classList.add("slide");
  }
});

