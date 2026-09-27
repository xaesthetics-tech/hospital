/* =========================================
   AURELIACARE PREMIUM WEBSITE
========================================= */


/* ==============================
   MOBILE MENU
============================== */

const mobileMenu = document.querySelector(".mobile-menu");
const navLinks = document.querySelector(".nav-links");

if (mobileMenu) {

    mobileMenu.addEventListener("click", () => {

        navLinks.classList.toggle("open");

        if (navLinks.classList.contains("open")) {
            mobileMenu.innerHTML = "✕";
        } else {
            mobileMenu.innerHTML = "☰";
        }

    });

}


/* ==============================
   ACTIVE NAVIGATION
============================== */

const currentPage =
    window.location.pathname
        .split("/")
        .pop() || "index.html";

document.querySelectorAll(".nav-links a").forEach(link => {

    const href = link.getAttribute("href");

    if (href === currentPage) {
        link.classList.add("active");
    }

});


/* ==============================
   SCROLL REVEAL
============================== */

const revealObserver = new IntersectionObserver(
    entries => {

        entries.forEach(entry => {

            if (entry.isIntersecting) {

                entry.target.classList.add("show");

                revealObserver.unobserve(entry.target);

            }

        });

    },
    {
        threshold: 0.12
    }
);


document.querySelectorAll(".reveal")
    .forEach(element => {
        revealObserver.observe(element);
    });


/* ==============================
   CURSOR GLOW
============================== */

const cursorGlow =
    document.querySelector(".cursor-glow");

if (
    cursorGlow &&
    window.matchMedia("(pointer:fine)").matches
) {

    document.addEventListener("mousemove", event => {

        cursorGlow.style.left =
            event.clientX + "px";

        cursorGlow.style.top =
            event.clientY + "px";

    });

}


/* ==============================
   CLOSE MOBILE MENU
============================== */

document.querySelectorAll(".nav-links a")
    .forEach(link => {

        link.addEventListener("click", () => {

            navLinks?.classList.remove("open");

            if (mobileMenu) {
                mobileMenu.innerHTML = "☰";
            }

        });

    });


/* ==============================
   IMAGE PARALLAX
============================== */

const heroImage =
    document.querySelector(".hero-image");

if (
    heroImage &&
    window.matchMedia("(pointer:fine)").matches
) {

    document.addEventListener("mousemove", event => {

        const x =
            (event.clientX / window.innerWidth - .5);

        const y =
            (event.clientY / window.innerHeight - .5);

        heroImage.style.transform =
            `translate(${x * 8}px, ${y * 8}px)`;

    });

}


/* ==============================
   SMOOTH BUTTON FEEDBACK
============================== */

document.querySelectorAll(".button").forEach(button => {

    button.addEventListener("mouseenter", () => {

        button.style.transition =
            "transform .3s ease, box-shadow .3s ease";

    });

});


/* ==============================
   FORM HANDLING
============================== */

document.querySelectorAll("form")
    .forEach(form => {

        form.addEventListener("submit", event => {

            event.preventDefault();

            const button =
                form.querySelector("button");

            if (!button) return;

            const originalText =
                button.innerHTML;

            button.innerHTML =
                "Enquiry Sent ✓";

            button.style.background =
                "linear-gradient(135deg,#0a9f68,#16c784)";

            setTimeout(() => {

                button.innerHTML =
                    originalText;

                button.style.background = "";

                form.reset();

            }, 3000);

        });

    });


/* ==============================
   NUMBER COUNTER
================================ */

function animateCounter(element, target) {

    let current = 0;

    const duration = 1500;

    const startTime = performance.now();

    function update(time) {

        const progress =
            Math.min(
                (time - startTime) / duration,
                1
            );

        const ease =
            1 - Math.pow(1 - progress, 3);

        current =
            Math.floor(target * ease);

        element.textContent = current;

        if (progress < 1) {
            requestAnimationFrame(update);
        }

    }

    requestAnimationFrame(update);

}


/* ==============================
   BUTTON RIPPLE
============================== */

document.querySelectorAll(".button")
    .forEach(button => {

        button.addEventListener("click", function(event) {

            const ripple =
                document.createElement("span");

            ripple.style.position = "absolute";

            ripple.style.width = "20px";
            ripple.style.height = "20px";

            ripple.style.borderRadius = "50%";

            ripple.style.background =
                "rgba(255,255,255,.35)";

            ripple.style.pointerEvents = "none";

            ripple.style.left =
                event.offsetX + "px";

            ripple.style.top =
                event.offsetY + "px";

            ripple.style.transform =
                "translate(-50%,-50%) scale(0)";

            ripple.style.transition =
                "transform .6s ease, opacity .6s ease";

            this.style.position = "relative";

            this.style.overflow = "hidden";

            this.appendChild(ripple);

            requestAnimationFrame(() => {

                ripple.style.transform =
                    "translate(-50%,-50%) scale(15)";

                ripple.style.opacity = "0";

            });

            setTimeout(() => {
                ripple.remove();
            }, 700);

        });

    });


/* ==============================
   PAGE LOADED
============================== */

window.addEventListener("load", () => {

    document.body.classList.add("loaded");

});
