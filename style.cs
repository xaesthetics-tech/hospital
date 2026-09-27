:root {

    --blue: #0757d9;
    --dark-blue: #04327c;
    --cyan: #19bfff;

    --black: #08111f;
    --gray: #64748b;
    --light: #f5f9ff;
    --white: #ffffff;

    --border: rgba(8,17,31,.09);

    --radius: 28px;

    --font-main: "DM Sans", sans-serif;
    --font-heading: "Manrope", sans-serif;
}


* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}


html {
    scroll-behavior: smooth;
}


body {
    font-family: var(--font-main);
    color: var(--black);
    background: var(--white);
    overflow-x: hidden;
}


a {
    text-decoration: none;
    color: inherit;
}


button {
    font-family: inherit;
}


/* =========================
NAVBAR
========================= */

.navbar {

    position: fixed;

    top: 20px;
    left: 50%;

    transform: translateX(-50%);

    width: min(1200px, calc(100% - 40px));

    height: 76px;

    padding: 0 24px;

    display: flex;

    align-items: center;

    justify-content: space-between;

    background: rgba(255,255,255,.78);

    backdrop-filter: blur(25px);

    -webkit-backdrop-filter: blur(25px);

    border: 1px solid rgba(255,255,255,.8);

    border-radius: 100px;

    box-shadow:
        0 20px 60px rgba(7,87,217,.08);

    z-index: 1000;
}


.logo {

    display: flex;

    align-items: center;

    gap: 10px;

    font-family: var(--font-heading);

    font-size: 18px;

    font-weight: 800;

    letter-spacing: -.5px;
}


.logo-mark {

    width: 36px;
    height: 36px;

    display: grid;
    place-items: center;

    border-radius: 12px;

    color: white;

    font-size: 22px;

    background:
        linear-gradient(
            135deg,
            var(--blue),
            var(--cyan)
        );

    box-shadow:
        0 8px 20px rgba(7,87,217,.3);
}


.navbar nav {

    display: flex;

    gap: 34px;
}


.navbar nav a {

    position: relative;

    color: #526075;

    font-size: 14px;

    font-weight: 600;

    transition: .3s;
}


.navbar nav a:hover,
.navbar nav a.active {

    color: var(--blue);
}


.nav-button {

    padding: 14px 20px;

    border-radius: 100px;

    color: white;

    background: var(--black);

    font-size: 13px;

    font-weight: 700;

    transition: .3s;
}


.nav-button:hover {

    transform: translateY(-2px);

    background: var(--blue);

    box-shadow:
        0 10px 30px rgba(7,87,217,.25);
}


.nav-button span {
    margin-left: 8px;
}


.menu-toggle {
    display: none;

    border: 0;

    background: none;

    font-size: 24px;
}


/* =========================
HERO
========================= */

.hero {

    min-height: 920px;

    position: relative;

    display: flex;

    align-items: center;

    overflow: hidden;

    padding:
        150px
        max(7vw, 40px)
        100px;
}


.hero-background {

    position: absolute;

    inset: 0;

    z-index: -2;

    background:

        radial-gradient(
            circle at 75% 25%,
            rgba(25,191,255,.23),
            transparent 25%
        ),

        radial-gradient(
            circle at 90% 70%,
            rgba(7,87,217,.18),
            transparent 30%
        ),

        linear-gradient(
            110deg,
            #ffffff 30%,
            #edf6ff
        );
}


.hero-background::after {

    content: "";

    position: absolute;

    width: 700px;
    height: 700px;

    right: -250px;
    top: 120px;

    border-radius: 50%;

    border: 1px solid rgba(7,87,217,.12);

    box-shadow:
        0 0 0 100px rgba(7,87,217,.02),
        0 0 0 200px rgba(7,87,217,.015);
}


.hero-content {

    width: min(760px, 100%);

    position: relative;

    z-index: 3;
}


.eyebrow {

    display: flex;

    align-items: center;

    gap: 10px;

    margin-bottom: 30px;

    color: var(--blue);

    font-size: 12px;

    letter-spacing: 2px;

    font-weight: 800;
}


.eyebrow span {

    width: 28px;
    height: 2px;

    background: var(--blue);
}


.hero h1 {

    font-family: var(--font-heading);

    font-size: clamp(65px, 8vw, 115px);

    line-height: .94;

    letter-spacing: -7px;

    max-width: 900px;

    margin-bottom: 35px;
}


.hero h1 em {

    display: block;

    font-style: normal;

    color: transparent;

    -webkit-text-stroke: 2px var(--blue);
}


.hero-content > p {

    max-width: 560px;

    color: var(--gray);

    font-size: 18px;

    line-height: 1.8;

    margin-bottom: 40px;
}


.hero-buttons {

    display: flex;

    gap: 15px;

    flex-wrap: wrap;
}


.primary-button,
.secondary-button,
.white-button {

    padding: 18px 26px;

    border-radius: 100px;

    font-size: 14px;

    font-weight: 700;

    transition: .3s;
}


.primary-button {

    color: white;

    background: var(--blue);

    box-shadow:
        0 15px 35px rgba(7,87,217,.25);
}


.primary-button:hover {

    transform: translateY(-4px);

    box-shadow:
        0 20px 45px rgba(7,87,217,.35);
}


.primary-button span {

    margin-left: 20px;
}


.secondary-button {

    background: white;

    border: 1px solid var(--border);
}


.secondary-button:hover {

    border-color: var(--blue);

    color: var(--blue);
}


.hero-stats {

    display: flex;

    gap: 55px;

    margin-top: 80px;
}


.hero-stats div {

    display: flex;

    flex-direction: column;

    gap: 5px;
}


.hero-stats strong {

    font-family: var(--font-heading);

    font-size: 27px;
}


.hero-stats span {

    color: var(--gray);

    font-size: 12px;
}


.hero-card {

    position: absolute;

    right: 8%;

    bottom: 17%;

    width: 300px;

    padding: 20px;

    display: flex;

    align-items: center;

    gap: 14px;

    border-radius: 20px;

    background: rgba(255,255,255,.82);

    backdrop-filter: blur(20px);

    box-shadow:
        0 25px 80px rgba(7,87,217,.16);

    z-index: 5;
}


.pulse-icon {

    width: 48px;
    height: 48px;

    display: grid;
    place-items: center;

    color: white;

    background: var(--blue);

    border-radius: 15px;

    animation: heartbeat 1.8s infinite;
}


.hero-card div:nth-child(2) {

    display: flex;

    flex-direction: column;

    gap: 5px;
}


.hero-card strong {
    font-size: 13px;
}


.hero-card span {
    font-size: 10px;
    color: var(--gray);
}


.hero-card .arrow {

    margin-left: auto;

    color: var(--blue);

    font-size: 20px;
}


@keyframes heartbeat {

    0%,100% {
        transform: scale(1);
    }

    50% {
        transform: scale(1.08);
    }
}


.floating {

    animation:
        float 5s ease-in-out infinite;
}


@keyframes float {

    0%,100% {
        transform: translateY(0);
    }

    50% {
        transform: translateY(-18px);
    }
}


/* =========================
TRUST
========================= */

.trust-section {

    padding: 35px 7vw;

    border-top: 1px solid var(--border);

    border-bottom: 1px solid var(--border);

    text-align: center;
}


.trust-section p {

    font-size: 10px;

    color: #94a0b2;

    letter-spacing: 2px;

    font-weight: 700;

    margin-bottom: 25px;
}


.trust-row {

    display: flex;

    justify-content: center;

    gap: 80px;

    color: #9aa5b5;

    font-family: var(--font-heading);

    font-weight: 800;

    font-size: 19px;
}


/* =========================
GLOBAL
========================= */

.section {

    padding:
        140px
        max(7vw, 30px);
}


.section-label {

    display: flex;

    gap: 15px;

    align-items: center;

    color: var(--blue);

    font-size: 11px;

    letter-spacing: 2px;

    font-weight: 800;
}


.section-label span {

    padding: 7px 10px;

    border-radius: 50px;

    background: #eaf4ff;
}


.intro-grid {

    margin-top: 65px;

    display: grid;

    grid-template-columns: 1fr 1fr;

    gap: 100px;
}


.intro h2,
.section-heading h2 {

    font-family: var(--font-heading);

    font-size: clamp(45px, 5vw, 75px);

    line-height: 1;

    letter-spacing: -4px;
}


.intro h2 span,
.section-heading h2 span {

    color: var(--blue);
}


.large-text {

    font-family: var(--font-heading);

    font-size: 25px;

    line-height: 1.5;

    margin-bottom: 20px;
}


.intro-grid p:not(.large-text) {

    color: var(--gray);

    line-height: 1.8;
}


.text-link {

    display: inline-block;

    margin-top: 30px;

    color: var(--blue);

    font-weight: 700;

    font-size: 14px;
}


/* =========================
SERVICES
========================= */

.services-preview {

    background: var(--light);
}


.section-heading {

    display: flex;

    justify-content: space-between;

    align-items: end;

    margin-bottom: 70px;
}


.section-heading h2 {

    max-width: 600px;

    text-align: right;
}


.service-grid {

    display: grid;

    grid-template-columns:
        repeat(4,1fr);

    gap: 15px;
}


.service-card {

    min-height: 390px;

    padding: 30px;

    position: relative;

    display: flex;

    flex-direction: column;

    border-radius: var(--radius);

    background: white;

    border: 1px solid var(--border);

    overflow: hidden;

    transition: .5s;
}


.service-card:hover {

    transform: translateY(-10px);

    box-shadow:
        0 25px 70px rgba(7,87,217,.13);
}


.service-card.featured {

    color: white;

    background:
        linear-gradient(
            145deg,
            #0757d9,
            #063a91
        );
}


.service-number {

    font-size: 11px;

    color: #a1adbd;

    margin-bottom: auto;
}


.featured .service-number {

    color: rgba(255,255,255,.6);
}


.service-icon {

    width: 52px;
    height: 52px;

    display: grid;
    place-items: center;

    border-radius: 16px;

    color: var(--blue);

    background: #edf6ff;

    font-size: 24px;

    margin-bottom: 35px;
}


.featured .service-icon {

    color: white;

    background: rgba(255,255,255,.15);
}


.service-card h3 {

    font-family: var(--font-heading);

    font-size: 24px;

    margin-bottom: 15px;
}


.service-card p {

    color: var(--gray);

    font-size: 14px;

    line-height: 1.7;

    margin-bottom: 30px;
}


.featured p {

    color: rgba(255,255,255,.7);
}


.service-card a {

    color: var(--blue);

    font-size: 13px;

    font-weight: 800;
}


.featured a {

    color: white;
}


/* =========================
CTA
========================= */

.premium-cta {

    min-height: 550px;

    position: relative;

    overflow: hidden;

    display: grid;

    place-items: center;

    text-align: center;

    color: white;

    background:
        linear-gradient(
            120deg,
            #032d70,
            #0757d9
        );
}


.cta-orb {

    position: absolute;

    width: 700px;
    height: 700px;

    border-radius: 50%;

    border: 1px solid rgba(255,255,255,.15);

    box-shadow:
        0 0 0 80px rgba(255,255,255,.02),
        0 0 0 160px rgba(255,255,255,.015);
}


.cta-content {

    position: relative;

    z-index: 2;
}


.cta-content > span {

    font-size: 11px;

    letter-spacing: 3px;

    opacity: .65;
}


.cta-content h2 {

    margin: 25px 0;

    font-family: var(--font-heading);

    font-size: clamp(50px, 7vw, 90px);

    line-height: .95;

    letter-spacing: -5px;
}


.cta-content h2 em {

    display: block;

    color: transparent;

    -webkit-text-stroke: 1px white;

    font-style: normal;
}


.cta-content p {

    opacity: .7;

    margin-bottom: 35px;
}


.white-button {

    display: inline-block;

    color: var(--blue);

    background: white;
}


.white-button:hover {

    transform: translateY(-4px);

    box-shadow:
        0 15px 40px rgba(0,0,0,.2);
}


/* =========================
FOOTER
========================= */

footer {

    padding: 80px max(7vw,30px) 25px;

    background: #06101f;

    color: white;
}


.footer-main {

    display: grid;

    grid-template-columns: 2fr 1fr 1fr;

    gap: 80px;

    padding-bottom: 70px;
}


.footer-logo {

    color: white;

    margin-bottom: 20px;
}


.footer-main p {

    max-width: 250px;

    color: #718097;

    line-height: 1.7;
}


.footer-main h4 {

    font-size: 12px;

    letter-spacing: 1px;

    margin-bottom: 20px;

    color: #70809a;
}


.footer-main > div:not(:first-child) {

    display: flex;

    flex-direction: column;

    gap: 13px;
}


.footer-main a,
.footer-main span {

    font-size: 13px;

    color: #c1c9d5;

    transition: .2s;
}


.footer-main a:hover {

    color: white;
}


.footer-bottom {

    padding-top: 25px;

    border-top: 1px solid rgba(255,255,255,.08);

    display: flex;

    justify-content: space-between;

    color: #65758c;

    font-size: 11px;
}


/* =========================
REVEAL ANIMATION
========================= */

.reveal {

    opacity: 0;

    transform: translateY(30px);

    animation:
        reveal .9s ease forwards;
}


@keyframes reveal {

    to {

        opacity: 1;

        transform: translateY(0);

    }

}


/* =========================
RESPONSIVE
========================= */

@media(max-width:1000px) {

    .navbar nav,
    .nav-button {
        display: none;
    }

    .menu-toggle {
        display: block;
    }

    .hero {
        min-height: 850px;
    }

    .hero-card {
        right: 5%;
        bottom: 10%;
    }

    .service-grid {
        grid-template-columns: repeat(2,1fr);
    }

}


@media(max-width:700px) {

    .navbar {
        top: 10px;

        width:
            calc(100% - 20px);
    }


    .hero {

        min-height: 850px;

        padding:
            160px 25px
            80px;
    }


    .hero h1 {

        font-size: 60px;

        letter-spacing: -4px;
    }


    .hero-card {

        right: 20px;

        bottom: 30px;

        width:
            calc(100% - 40px);
    }


    .hero-stats {

        gap: 25px;

        margin-top: 50px;
    }


    .hero-stats strong {

        font-size: 21px;
    }


    .hero-stats span {

        font-size: 9px;
    }


    .trust-row {

        gap: 25px;

        flex-wrap: wrap;

        font-size: 15px;
    }


    .section {

        padding:
            90px 25px;
    }


    .intro-grid {

        grid-template-columns: 1fr;

        gap: 40px;
    }


    .section-heading {

        display: block;
    }


    .section-heading h2 {

        margin-top: 30px;

        text-align: left;
    }


    .service-grid {

        grid-template-columns: 1fr;
    }


    .service-card {

        min-height: 350px;
    }


    .footer-main {

        grid-template-columns: 1fr;

        gap: 40px;
    }


    .footer-bottom {

        flex-direction: column;

        gap: 10px;
    }

}
/* =========================
INNER PAGES
========================= */

.inner-page {
    padding-top: 100px;
}


.page-hero {

    min-height: 650px;

    padding:
        170px 7vw
        100px;

    background:

        radial-gradient(
            circle at 80% 30%,
            rgba(25,191,255,.18),
            transparent 25%
        ),

        #f5f9ff;
}


.page-hero h1 {

    max-width: 1000px;

    margin-top: 40px;

    font-family: var(--font-heading);

    font-size: clamp(55px, 8vw, 110px);

    line-height: .95;

    letter-spacing: -6px;
}


.page-hero h1 em {

    display: block;

    font-style: normal;

    color: var(--blue);
}


.page-hero p {

    max-width: 550px;

    margin-top: 35px;

    color: var(--gray);

    font-size: 18px;

    line-height: 1.8;
}


.service-list {

    background: white;
}


.big-service {

    padding:
        70px 0;

    display: grid;

    grid-template-columns: 100px 1fr;

    border-bottom:
        1px solid var(--border);

    transition: .4s;
}


.big-service:hover {

    padding-left: 25px;

}


.big-service > span {

    color: var(--blue);

    font-weight: 800;
}


.big-service h2 {

    font-family: var(--font-heading);

    font-size: clamp(35px,5vw,65px);

    letter-spacing: -3px;

    margin-bottom: 20px;
}


.big-service p {

    max-width: 650px;

    color: var(--gray);

    line-height: 1.8;

    margin-bottom: 25px;
}


.big-service a {

    color: var(--blue);

    font-size: 13px;

    font-weight: 800;
}


@media(max-width:700px) {

    .big-service {

        grid-template-columns: 50px 1fr;

    }

}
.gallery-grid {

    padding: 100px 7vw;

    display: grid;

    grid-template-columns:
        repeat(2,1fr);

    gap: 20px;
}


.gallery-item {

    position: relative;

    height: 450px;

    overflow: hidden;

    border-radius: 28px;

    background: #ddd;
}


.gallery-item.large {

    height: 650px;

    grid-row: span 2;
}


.gallery-item.wide {

    grid-column: span 2;

}


.gallery-item img {

    width: 100%;
    height: 100%;

    object-fit: cover;

    transition: 1s;
}


.gallery-item:hover img {

    transform: scale(1.08);
}


.gallery-caption {

    position: absolute;

    left: 20px;
    right: 20px;
    bottom: 20px;

    padding: 17px 20px;

    color: white;

    background:
        rgba(5,20,45,.65);

    backdrop-filter: blur(15px);

    border-radius: 15px;

    font-weight: 700;
}


.gallery-caption span {

    margin-right: 15px;

    color: #71cfff;
}


@media(max-width:700px) {

    .gallery-grid {

        grid-template-columns: 1fr;

        padding:
            60px 25px;
    }

    .gallery-item,
    .gallery-item.large,
    .gallery-item.wide {

        grid-column: auto;

        grid-row: auto;

        height: 400px;
    }

}
.enquiry {

    min-height: 900px;

    padding:
        180px 7vw
        120px;

    display: grid;

    grid-template-columns:
        .8fr 1.2fr;

    gap: 100px;

    background: #f5f9ff;
}


.enquiry-info h1 {

    margin-top: 40px;

    font-family: var(--font-heading);

    font-size: clamp(55px,6vw,90px);

    line-height: .95;

    letter-spacing: -5px;
}


.enquiry-info h1 em {

    display: block;

    color: var(--blue);

    font-style: normal;
}


.enquiry-info > p {

    max-width: 450px;

    color: var(--gray);

    line-height: 1.8;

    margin-top: 30px;
}


.contact-mini {

    display: flex;

    flex-direction: column;

    gap: 5px;

    margin-top: 70px;

    padding-left: 20px;

    border-left: 3px solid var(--blue);
}


.contact-mini span {

    color: var(--gray);
}


.premium-form {

    padding: 45px;

    background: white;

    border-radius: 30px;

    box-shadow:
        0 30px 100px rgba(7,87,217,.1);
}


.form-row {

    display: grid;

    grid-template-columns:
        1fr 1fr;

    gap: 20px;
}


.premium-form label {

    display: block;

    margin-bottom: 25px;

    color: #65748a;

    font-size: 12px;

    font-weight: 700;
}


.premium-form input,
.premium-form select,
.premium-form textarea {

    width: 100%;

    margin-top: 10px;

    padding: 18px;

    border: 1px solid #e2e8f0;

    border-radius: 14px;

    outline: none;

    font-family: inherit;

    background: #fafcff;

    transition: .3s;
}


.premium-form input:focus,
.premium-form select:focus,
.premium-form textarea:focus {

    border-color: var(--blue);

    box-shadow:
        0 0 0 4px rgba(7,87,217,.08);
}


@media(max-width:800px) {

    .enquiry {

        grid-template-columns: 1fr;

        padding:
            140px 25px
            80px;

    }

    .form-row {

        grid-template-columns: 1fr;

    }

    .premium-form {

        padding: 25px;

    }

}
.contact-page {

    padding:
        180px 7vw
        120px;

    background:
        radial-gradient(
            circle at 80% 20%,
            rgba(25,191,255,.15),
            transparent 25%
        ),
        #f5f9ff;
}


.contact-page h1 {

    margin-top: 40px;

    font-family: var(--font-heading);

    font-size: clamp(60px,8vw,110px);

    letter-spacing: -6px;

    line-height: .9;
}


.contact-page h1 em {

    color: var(--blue);

    font-style: normal;
}


.contact-grid {

    margin-top: 100px;

    display: grid;

    grid-template-columns:
        repeat(2,1fr);

    gap: 20px;
}


.contact-box {

    min-height: 260px;

    padding: 35px;

    border-radius: 28px;

    background: white;

    border: 1px solid var(--border);

    transition: .4s;
}


.contact-box:hover {

    transform: translateY(-7px);

    box-shadow:
        0 25px 70px rgba(7,87,217,.1);
}


.contact-box span {

    color: var(--blue);

    font-size: 10px;

    font-weight: 800;

    letter-spacing: 2px;
}


.contact-box h3 {

    margin-top: 60px;

    font-family: var(--font-heading);

    font-size: 25px;
}


.contact-box p {

    margin-top: 10px;

    color: var(--gray);

    line-height: 1.6;
}


.contact-map {

    min-height: 400px;

    grid-column: span 2;

    border-radius: 30px;

    display: flex;

    flex-direction: column;

    align-items: center;

    justify-content: center;

    gap: 20px;

    color: white;

    background:

        radial-gradient(
            circle,
            rgba(25,191,255,.4),
            transparent 25%
        ),

        linear-gradient(
            135deg,
            #062e70,
            #0757d9
        );
}


.map-pin {

    width: 70px;
    height: 70px;

    display: grid;
    place-items: center;

    border-radius: 50%;

    background: white;

    color: var(--blue);

    font-size: 30px;

    box-shadow:
        0 20px 50px rgba(0,0,0,.2);
}


@media(max-width:700px) {

    .contact-page {

        padding:
            140px 25px 80px;

    }

    .contact-grid {

        grid-template-columns: 1fr;

    }

    .contact-map {

        grid-column: auto;

    }

}
