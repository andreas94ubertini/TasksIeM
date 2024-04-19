//console.log("Ciao De cola");
class Automobile{
    
    constructor(marca, modello){
        this.marca = marca,
        this.modello = modello
    }

    stampaDettaglio(){
        console.log(`Automobile ${this.marca} ${this.modello}`)
    }
}

let autoUno = new Automobile("BMW", "420i");
autoUno.stampaDettaglio();