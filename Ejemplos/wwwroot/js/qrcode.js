let qrcode = new QRCode(document.getElementById("qrcode"), {
    width: 100,
    height: 100
});

function makeCode() {
    let elText = document.getElementById("text");

    /*if (!elText.value) {
        alert("Input a text");
        elText.focus();
        return;
    }*/

    qrcode.makeCode(elText.value);
}

makeCode();

$("#text").
    on("blur", function () {
        makeCode();
    }).
    on("keydown", function (e) {
        if (e.keyCode == 13) {
            makeCode();
        }
    });