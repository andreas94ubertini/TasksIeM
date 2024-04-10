import { Injectable } from '@angular/core';
import { Oggetto } from '../models/oggetto';
import { Persona } from '../models/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonaService {
  personaList? : Persona[] = new Array();
  constructor() {
    if(!localStorage.getItem("personaLista"))
      localStorage.setItem("personaLista", JSON.stringify(this.personaList))
    
   }
  getAll(): Persona[]{
    
      return  JSON.parse(localStorage.getItem("personaLista")!);
  
  }
  insertPersona(p:Persona):boolean{
      let elenco = JSON.parse(localStorage.getItem("personaLista")!);
      elenco.push(p);
      localStorage.setItem("personaLista", JSON.stringify(elenco))
      return true;

  }
  getByCod(codice:string): void{
    let elenco : Persona[] = JSON.parse(localStorage.getItem("personaLista")!);
    let index : number = 0;
    let persona: Persona;

  }
}
