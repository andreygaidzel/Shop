import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app.component';
import { NotFoundComponent } from './components/content/not-found/not-found.component';
import { MenuComponent } from './components/menu/menu.component';
import { HomeComponent } from './components/content/home/home.component';
import {HeaderComponent} from './components/header/header.component';


const appRoutes: Routes = [
  {
    path: '',
    component: HomeComponent
  },
  // {
  //   path: 'phone',
  //   component: PhoneComponent
  // },
  {
    path: '**',
    component: NotFoundComponent
  }
];


@NgModule({
  declarations: [
    AppComponent,
    NotFoundComponent,
    MenuComponent,
    HomeComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
