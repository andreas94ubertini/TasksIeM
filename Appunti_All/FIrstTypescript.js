var Auto = /** @class */ (function () {
    function Auto(marca, modello) {
        this.marca = marca;
        this.modello = modello;
    }
    Auto.prototype.stampaDettaglio = function () {
        console.log("Auto ".concat(this.marca, " ").concat(this.modello));
    };
    return Auto;
}());
var autoM = new Auto("Mercedes", "A200");
autoM.stampaDettaglio();
