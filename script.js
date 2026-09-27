/* ==========================
   MOBILE MENU
========================== */

const menuButton = document.querySelector(".menu-toggle");
const nav = document.querySelector(".navbar nav");

if (menuButton) {

    menuButton.addEventListener("click", () => {

        nav.classList.toggle("mobile-open");

    });

}


/* ==========================
   CURSOR PARALLAX
========================== */

const hero = document.querySelector(".hero");
const heroCard = document.querySelector(".hero-card");

if (hero && heroCard) {

    hero.addEventListener("mousemove", (e) => {

        const x =
            (window.innerWidth / 2 - e.clientX) / 40;

        const y =
            (window.innerHeight / 2 - e.clientY) / 40;

        heroCard.style.transform =
            `translate(${x}px, ${y}px)`;

    });


    hero.addEventListener("mouseleave", () => {

        heroCard.style.transform =
            "translate(0,0)";

    });

}


/* ==========================
   SCROLL REVEAL
========================== */

const revealElements =
    document.querySelectorAll(
        ".service-card, .intro-grid, .section-heading"
    );


const observer =
    new IntersectionObserver(
        entries => {

            entries.forEach(entry => {

                if (entry.isIntersecting) {

                    entry.target.classList.add("visible");

                }

            });

        },

        {
            threshold: .12
        }

    );


revealElements.forEach(el => {

    el.style.opacity = "0";

    el.style.transform =
        "translateY(35px)";

    el.style.transition =
        "opacity .8s ease, transform .8s ease";

    observer.observe(el);

});


/* ==========================
   ANIMATION CLASS
========================== */

const style = document.createElement("style");

style.innerHTML = `

    .service-card.visible,
    .intro-grid.visible,
    .section-heading.visible {

        opacity: 1 !important;

        transform: translateY(0) !important;

    }

`;

document.head.appendChild(style);


/* ==========================
   SMOOTH MAGNETIC BUTTON
========================== */

document
    .querySelectorAll(
        ".primary-button, .white-button, .nav-button"
    )
    .forEach(button => {

        button.addEventListener("mousemove", e => {

            const rect =
                button.getBoundingClientRect();

            const x =
                e.clientX -
                rect.left -
                rect.width / 2;

            const y =
                e.clientY -
                rect.top -
                rect.height / 2;

            button.style.transform =
                `translate(${x * .08}px, ${y * .08}px)`;

        });


        button.addEventListener("mouseleave", () => {

            button.style.transform =
                "translate(0,0)";

        });

    });


/* ==========================
   NUMBER COUNTER
========================== */

const counters =
    document.querySelectorAll(
        ".hero-stats strong"
    );


const counterObserver =
    new IntersectionObserver(
        entries => {

            entries.forEach(entry => {

                if (!entry.isIntersecting)
                    return;

                const element =
                    entry.target;

                const original =
                    element.innerText;

                const number =
                    parseInt(
                        original.replace(/\D/g, "")
                    );

                const suffix =
                    original.replace(/[0-9]/g, "");

                let current = 0;

                const increment =
                    Math.ceil(number / 60);

                const timer =
                    setInterval(() => {

                        current += increment;

                        if (current >= number) {

                            current = number;

                            clearInterval(timer);

                        }

                        element.innerText =
                            current + suffix;

                    }, 25);

                counterObserver.unobserve(element);

            });

        }
    );


counters.forEach(counter => {

    counterObserver.observe(counter);

});
