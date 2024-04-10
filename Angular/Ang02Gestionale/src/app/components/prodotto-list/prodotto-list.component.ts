import { Component } from '@angular/core';
import { Prodotto } from '../../models/prodotto';
import { ProdottoService } from '../../services/prodotto.service';

@Component({
  selector: 'app-prodotto-list',
  templateUrl: './prodotto-list.component.html',
  styleUrl: './prodotto-list.component.css'
})
export class ProdottoListComponent {
  listaProd : Prodotto[] = new Array();

  constructor(private ProdottoSvc: ProdottoService){

  }
  ngOnInit(): void {
    this.listaProd = this.ProdottoSvc.recuperaProdotti();
    
  }
}
