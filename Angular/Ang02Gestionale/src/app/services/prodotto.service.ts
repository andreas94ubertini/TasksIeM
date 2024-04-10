import { Injectable } from '@angular/core';
import { Prodotto } from '../models/prodotto';

@Injectable({
  providedIn: 'root'
})
export class ProdottoService {
  private elenco: Prodotto[] = new Array();

  constructor() {
    this.elenco.push(new Prodotto("VT112", "Vite", "Dura", 0.12));
    this.elenco.push(new Prodotto("GV998", "CacciaVite", "Estraente", 0.19));
    this.elenco.push(new Prodotto("WD111", "WD40", "Sblocca tutto", 5.25));
   }

   recuperaProdotti() : Prodotto[]{
      return this.elenco
   }
   insertProdotto(p : Prodotto): boolean{
    if(p){
      this.elenco.push(p);
      return true;
    }
    
    return false;
   }

}
