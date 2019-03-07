function sayiMesaj() {
    alert(8 + 9);
}

function IDkullan() {
    let merhabaText = document.getElementById("kelime").innerHTML;
    alert(merhabaText);
}

function kenarlik() {
    var kutular = document.getElementsByClassName("kutu");
    var i;
    for (i = 0; i < kutular.length; i++) {
        kutular[i].style.border="3px solid";
    }
}

function RenkDegistir() {
    var kutu11 = document.getElementById("kutu1").classList[0];
    if (kutu11 == 'acik') {
        document.getElementById("kutu1").classList.remove('acik');
        document.getElementById("kutu1").classList.add('koyu');
    }

    if (kutu11 == 'koyu') {
        document.getElementById("kutu1").classList.replace('koyu', 'acik');
    }
}