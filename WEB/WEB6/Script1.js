function Tik() {
    var sayial = Number(document.getElementById("text_sayi").value);
    var sayilar="";
    for (var i = 0; i <= sayial; i++) {
        if (i % 3 == 0) {
            sayilar = sayilar + i+ " ";
        }
    }
    document.getElementById("pid").innerHTML = sayilar;
}

function Tikrenk() {
    var renkle = document.getElementById("renk").value;
    document.getElementById("sectionid").style.backgroundColor = renkle;
}