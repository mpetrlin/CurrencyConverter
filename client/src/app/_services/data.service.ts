import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class DataService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) { }

  getAvailCurr() {
    return this.http.get("https://openexchangerates.org/api/currencies.json");
  }

  getLocalExchRates() {
    return this.http.get(this.baseUrl + "getrates");
  }

  updateDatabase() {
    return this.http.get(this.baseUrl + "update");  
  }

  deleteOld() {
    return this.http.get(this.baseUrl + "deleteold");  
  }
}
