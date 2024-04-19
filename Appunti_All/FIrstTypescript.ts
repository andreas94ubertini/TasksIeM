class Auto{
    marca: string;
    modello: string;
    
    constructor(marca:string, modello:string){
        this.marca = marca;
        this.modello = modello;
    }

    stampaDettaglio() : void{
        console.log(`Auto ${this.marca} ${this.modello}`);
    }
}

let autoM = new Auto("Mercedes", "A200");
autoM.stampaDettaglio();