import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

//import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { LimanComponent } from './liman/liman.component';
import { PersonellerComponent } from './personeller/personeller.component';
import { PersonelbilgiComponent } from './personelbilgi/personelbilgi.component';

@NgModule({
  declarations: [
    //AppComponent,
    LimanComponent,
    PersonellerComponent,
    PersonelbilgiComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [LimanComponent]
})
export class AppModule { }
