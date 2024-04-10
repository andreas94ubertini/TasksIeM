import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonaListComponent } from './components/persona-list/persona-list.component';
import { PersonaCreateComponent } from './components/persona-create/persona-create.component';

const routes: Routes = [
  {path: "", redirectTo:"persone/lista", pathMatch :"full"},
  {path: "persona/lista", component: PersonaListComponent},
  {path: "persona/inserisci", component: PersonaCreateComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
