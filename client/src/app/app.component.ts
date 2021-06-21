import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Currency converter';
  rates: any;

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.getExchRates();
  }

  getExchRates() {
    this.http.get("https://localhost:5001/rates").subscribe(response => {
      this.rates = response;
    }, error => {
      console.log(error);
    })
  }

}
