
function doNota() {
    let doNota = document.getElementById('re');
    let button = document.getElementById('do-button');
    button.style.backgroundColor = "blue";
    button.style.color = "white";
    doNota.onpause;
    doNota.currentTime = 0;
    doNota.play();
}

function reNota() {
    let reNota = document.getElementById('re');
    let button = document.getElementById('re-button');
    button.style.backgroundColor = "green";
    button.style.color = "white";
    reNota.onpause;
    reNota.currentTime = 0;
    reNota.play();
}

function miNota() {
    let miNota = document.getElementById('mi');
    let button = document.getElementById('mi-button');
    button.style.backgroundColor = "orange";
    button.style.color = "white";
    miNota.onpause;
    miNota.currentTime = 0;
    miNota.play();
}
function faNota() {
    let faNota = document.getElementById('fa');
    let button = document.getElementById('fa-button');
    button.style.backgroundColor = "pink";
    button.style.color = "white";
    faNota.onpause;
    faNota.currentTime = 0;
    faNota.play();
}
function solNota() {
    let solNota = document.getElementById('sol');
    let button = document.getElementById('sol-button');
    button.style.backgroundColor = "green";
    button.style.color = "white";
    solNota.onpause;
    solNota.currentTime = 0;
    solNota.play();
}
function laNota() {
    let laNota = document.getElementById('la');
    let button = document.getElementById('la-button');
    
    button.style.backgroundColor = "purple";
    button.style.color = "white";
    laNota.onpause;
    laNota.currentTime = 0;
    laNota.play();
}
function siNota() {
    let siNota = document.getElementById('si');
    let button = document.getElementById('si-button');
    button.style.backgroundColor = "brown";
    button.style.color = "white";
    siNota.onpause;
    siNota.currentTime = 0;
    siNota.play();
}
function houseNota() {
    let siNota = document.getElementById('house');
    let button = document.getElementById('house-button');
    button.style.backgroundColor = "yellow";
    button.style.color = "white";
    siNota.onpause;
    siNotacurrentTime = 0;
    siNota.play();
}
function ohnoNota() {
    let ohnoNota = document.getElementById('ohno');
    let button = document.getElementById('ohno-button');
    button.style.backgroundColor = "violet";
    button.style.color = "white";
    ohnoNota.onpause;
    ohnoNota.currentTime = 0;
    ohnoNota.play();
}
function loveNota() {
    let loveNota = document.getElementById('love');
    let button = document.getElementById('love-button');
    button.style.backgroundColor = "red";
    button.style.color = "white";
    loveNota.onpause;
    loveNota.currentTime = 0;
    loveNota.play();
}

function allAboardNota() {
    let allaboard = document.getElementById('allaboard');
    let button = document.getElementById('allAboard-button');
    button.style.backgroundColor = "blue";
    button.style.color = "white";
    allaboard.onpause;
    allaboard.currentTime = 0;
    allaboard.play();
}

function fernandoNota() {
    let fernando = document.getElementById('fernando');
    let button = document.getElementById('fernando-button');
    button.style.backgroundColor = "grey";
    button.style.color = "white";
    fernando.onpause;
    fernando.currentTime = 0;
    fernando.play();
}

function MexeOMingau(event) {
    var key = event.keyCode;
    if (key == 76) //tecla L
        doNota();
    if (key == 83)//Tecla do S
        reNota();
    if (key == 68)//Tecla do D
        miNota();
    if (key == 70)//Tecla do F
        faNota();
    if (key == 71)//Tecla do G
        soNota();
    if (key == 72)//Tecla do H
        laNota();
    if (key == 74)//Tecla do J
        siNota();
}