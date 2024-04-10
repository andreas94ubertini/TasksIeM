import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';

@Component({
  selector: 'app-prodotto-create',
  templateUrl: './prodotto-create.component.html',
  styleUrl: './prodotto-create.component.css'
})
export class ProdottoCreateComponent {
  codice : string|undefined;
  nome : string|undefined;
  descrizione : string|undefined;
  prezzo : number|undefined;
  constructor(private ProdottoSvc : ProdottoService){

  }
  salvaProdotto(){
    console.log(this.codice);
    let p = new Prodotto(this.codice,this.nome,this.descrizione,this.prezzo);
    this.ProdottoSvc.insertProdotto(p);
  }
}
