import { Component, OnInit } from '@angular/core';
import { DataService } from '../_services/data.service';

@Component({
  selector: 'app-available-currencies',
  templateUrl: './available-currencies.component.html',
  styleUrls: ['./available-currencies.component.css']
})
export class AvailableCurrenciesComponent implements OnInit {
  availCurr: any;

  constructor(private dataService: DataService) { }

  ngOnInit(): void {
    this.getAvailCurr();
  }

  getAvailCurr() {
    this.dataService.getAvailCurr().subscribe(response => {
      this.availCurr = response;
    }, error => {
      console.log(error);
    })
  }
}
