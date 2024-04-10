import { Oggetto } from "./oggetto";

export class Proposta {
    codice?: string|undefined;
    oggettoRif?: Oggetto;
    oggettoProp?: Oggetto;
    isAccepted?: boolean;
    constructor(codice?:string,oggettoRif?:Oggetto,oggettoProp?:Oggetto, isAccepted:boolean=false){
        this.codice = codice,
        this.oggettoRif = oggettoRif,
        this.oggettoProp = oggettoProp,
        this.isAccepted= isAccepted
    }
}
