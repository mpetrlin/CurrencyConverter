import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AvailableCurrenciesComponent } from './available-currencies/available-currencies.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { UpdateDbModalComponent } from './modals/update-db-modal/update-db-modal.component';

@NgModule({
  declarations: [
    AppComponent,
    AvailableCurrenciesComponent,
    UpdateDbModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ModalModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
