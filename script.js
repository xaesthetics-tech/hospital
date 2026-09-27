/* =========================================================
   VITANOVA HOSPITAL
   INTERACTIONS & ANIMATIONS
========================================================= */


/* =========================================================
   HEADER SCROLL EFFECT
========================================================= */

const header = document.querySelector(".header");

window.addEventListener("scroll", () => {

    if (window.scrollY > 30) {

        header?.classList.add("scrolled");

    } else {

        header?.classList.remove("scrolled");

    }

});


/* =========================================================
   MOBILE MENU
========================================================= */

const menuToggle = document.getElementById("menuToggle");
const nav = document.getElementById("nav");

if (menuToggle && nav) {

    menuToggle.addEventListener("click", () => {

        nav.classList.toggle("open");

        document.body.classList.toggle("menu-open");

        const icon = menuToggle.querySelector("i");

        if (nav.classList.contains("open")) {

            icon.classList.remove("fa-bars");
            icon.classList.add("fa-xmark");

        } else {

            icon.classList.remove("fa-xmark");
            icon.classList.add("fa-bars");

        }

    });


    nav.querySelectorAll("a").forEach(link => {

        link.addEventListener("click", () => {

            nav.classList.remove("open");

            document.body.classList.remove("menu-open");

            const icon = menuToggle.querySelector("i");

            icon.classList.remove("fa-xmark");
            icon.classList.add("fa-bars");

        });

    });

}


/* =========================================================
   SCROLL REVEAL
========================================================= */

const revealElements =
    document.querySelectorAll(".reveal");


const revealObserver =
    new IntersectionObserver(

        entries => {

            entries.forEach(entry => {

                if (entry.isIntersecting) {

                    entry.target.classList.add("visible");

                    revealObserver.unobserve(entry.target);

                }

            });

        },

        {
            threshold: .12
        }

    );


revealElements.forEach(element => {

    revealObserver.observe(element);

});


/* =========================================================
   COUNTER ANIMATION
========================================================= */

const counters =
    document.querySelectorAll(".counter");


const counterObserver =
    new IntersectionObserver(

        entries => {

            entries.forEach(entry => {

                if (!entry.isIntersecting) return;

                const counter = entry.target;

                const target =
                    parseInt(counter.dataset.target);

                let current = 0;

                const duration = 1800;

                const increment =
                    target / (duration / 16);


                const updateCounter = () => {

                    current += increment;

                    if (current < target) {

                        counter.textContent =
                            Math.floor(current);

                        requestAnimationFrame(updateCounter);

                    } else {

                        counter.textContent = target;

                    }

                };


                updateCounter();

                counterObserver.unobserve(counter);

            });

        },

        {
            threshold: .7
        }

    );


counters.forEach(counter => {

    counterObserver.observe(counter);

});


/* =========================================================
   GALLERY FILTER
========================================================= */

const filterButtons =
    document.querySelectorAll(".filter-btn");

const galleryItems =
    document.querySelectorAll(".gallery-item");


filterButtons.forEach(button => {

    button.addEventListener("click", () => {

        const filter =
            button.dataset.filter;


        filterButtons.forEach(btn => {

            btn.classList.remove("active");

        });


        button.classList.add("active");


        galleryItems.forEach(item => {

            const category =
                item.dataset.category;


            if (
                filter === "all" ||
                category === filter
            ) {

                item.style.display = "";

                requestAnimationFrame(() => {

                    item.style.opacity = "1";
                    item.style.transform = "scale(1)";

                });

            } else {

                item.style.opacity = "0";
                item.style.transform = "scale(.92)";

                setTimeout(() => {

                    item.style.display = "none";

                }, 250);

            }

        });

    });

});


/* =========================================================
   GALLERY LIGHTBOX
========================================================= */

const galleryImages =
    document.querySelectorAll(".gallery-item img");

const lightbox =
    document.getElementById("lightbox");

const lightboxImage =
    document.getElementById("lightboxImage");

const lightboxClose =
    document.getElementById("lightboxClose");


galleryImages.forEach(image => {

    image.addEventListener("click", () => {

        if (!lightbox) return;

        lightboxImage.src = image.src;

        lightbox.classList.add("active");

        document.body.style.overflow = "hidden";

    });

});


function closeLightbox() {

    if (!lightbox) return;

    lightbox.classList.remove("active");

    document.body.style.overflow = "";

}


lightboxClose?.addEventListener(
    "click",
    closeLightbox
);


lightbox?.addEventListener("click", event => {

    if (event.target === lightbox) {

        closeLightbox();

    }

});


document.addEventListener("keydown", event => {

    if (event.key === "Escape") {

        closeLightbox();

    }

});


/* =========================================================
   FORM SUBMISSIONS
========================================================= */

const enquiryForm =
    document.getElementById("enquiryForm");


enquiryForm?.addEventListener("submit", event => {

    event.preventDefault();

    const button =
        enquiryForm.querySelector("button");

    const originalText =
        button.innerHTML;


    button.innerHTML =
        `<i class="fa-solid fa-check"></i>
         Request Submitted`;

    button.style.background =
        "#16a36a";


    enquiryForm.reset();


    setTimeout(() => {

        button.innerHTML =
            originalText;

        button.style.background = "";

    }, 4000);

});


const contactForm =
    document.getElementById("contactForm");


contactForm?.addEventListener("submit", event => {

    event.preventDefault();

    const button =
        contactForm.querySelector("button");

    const originalText =
        button.innerHTML;


    button.innerHTML =
        `<i class="fa-solid fa-check"></i>
         Message Sent`;

    button.style.background =
        "#16a36a";


    contactForm.reset();


    setTimeout(() => {

        button.innerHTML =
            originalText;

        button.style.background = "";

    }, 4000);

});


/* =========================================================
   SMOOTH MAGNETIC BUTTON EFFECT
========================================================= */

const magneticButtons =
    document.querySelectorAll(
        ".btn-primary, .btn-white, .nav-button"
    );


magneticButtons.forEach(button => {

    button.addEventListener("mousemove", event => {

        if (window.innerWidth < 850) return;


        const rect =
            button.getBoundingClientRect();


        const x =
            event.clientX -
            rect.left -
            rect.width / 2;


        const y =
            event.clientY -
            rect.top -
            rect.height / 2;


        button.style.transform =
            `translate(${x * .08}px, ${y * .08}px)`;

    });


    button.addEventListener("mouseleave", () => {

        button.style.transform = "";

    });

});


/* =========================================================
   PARALLAX HERO IMAGE
========================================================= */

const heroVisual =
    document.querySelector(".hero-visual");


window.addEventListener("mousemove", event => {

    if (!heroVisual) return;

    if (window.innerWidth < 900) return;


    const x =
        (window.innerWidth / 2 - event.clientX) / 70;

    const y =
        (window.innerHeight / 2 - event.clientY) / 70;


    heroVisual.style.transform =
        `translate(${x}px, ${y}px)`;

});


/* =========================================================
   CURRENT YEAR
========================================================= */

document.querySelectorAll(".footer-bottom")
    .forEach(footer => {

        footer.innerHTML =
            footer.innerHTML.replace(
                "2025",
                new Date().getFullYear()
            );

    });


/* =========================================================
   IMAGE LOAD EFFECT
========================================================= */

document.querySelectorAll("img").forEach(image => {

    image.addEventListener("load", () => {

        image.style.opacity = "1";

    });

});


/* =========================================================
   ACTIVE NAV BASED ON CURRENT PAGE
========================================================= */

const currentPage =
    window.location.pathname.split("/").pop()
    || "index.html";


document.querySelectorAll(".nav a").forEach(link => {

    const href =
        link.getAttribute("href");


    if (
        href === currentPage &&
        !link.classList.contains("nav-button")
    ) {

        link.classList.add("active");

    }

});
