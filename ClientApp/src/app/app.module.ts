import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';


import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { ConsultarApiComponent } from './consultar-api/consultar-api.component';
import { TareaComponent } from './tarea/tarea.component';
import { TareasComponent } from './tareas/tareas.component';
import { TareaEditarComponent } from './tarea-editar/tarea-editar.component';
import { TareaCrearComponent } from './tarea-crear/tarea-crear.component';
import { TareaUserComponent } from './tarea-user/tarea-user.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    ConsultarApiComponent,
    TareaComponent,
    TareasComponent,
    TareaEditarComponent,
    TareaCrearComponent,
    TareaUserComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
    { path: '', component: TareasComponent, pathMatch: 'full' },
    { path: 'counter', component: CounterComponent },
    { path: 'fetch-data', component: FetchDataComponent },
    { path: 'consultar-api', component: ConsultarApiComponent },
    { path: 'tareas', component: TareasComponent },
    { path: 'new-tarea', component: TareaCrearComponent },
    { path: 'tareas/:id', component: TareaEditarComponent },
    { path: 'user/:id', component: TareaUserComponent },
], { relativeLinkResolution: 'legacy' })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
