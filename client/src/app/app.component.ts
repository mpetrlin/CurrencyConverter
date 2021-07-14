import { Component, Input, OnInit } from '@angular/core';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { UpdateDbModalComponent } from './modals/update-db-modal/update-db-modal.component';
import { DataService } from './_services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Currency converter by Matej';
  rates : any;
  bsModalRef: BsModalRef;
    
  constructor(private dataService: DataService, private modalService: BsModalService) {}

  @Input() inputAmount: number;
  amount: number;
  fromCurrency: string;
  toCurrency: string;
  calculatedAmount: number;
  roundedAmount: number;
  timestamp: number;
  nowTimestamp: number;
  daysOld: number;
  

  ngOnInit(): void {
    this.getLocalExchRates();
  }

  openUpdateModal() {
    this.bsModalRef = this.modalService.show(UpdateDbModalComponent, {class: 'modal-lg'});
    this.bsModalRef.content.timestamp = this.timestamp ;
    this.nowTimestamp=(Math.floor((new Date()).getTime() / 1000));
    this.daysOld=Math.floor((this.nowTimestamp-this.timestamp)/(24*60*60));
    this.bsModalRef.content.daysOld=this.daysOld;
  }

  calculate(): void {
    this.amount = this.inputAmount;
    this.calculatedAmount = this.amount*this.rates[this.toCurrency]/this.rates[this.fromCurrency];
    this.roundedAmount = Math.round((this.calculatedAmount + Number.EPSILON) * 100) / 100;
  }

  getLocalExchRates() {
    this.dataService.getLocalExchRates().subscribe(response => {
    delete response["id"];
    this.timestamp = response["timestamp"];
    delete response["timestamp"];
    this.rates = response;
    }, error => {
      console.log(error);
    })
  }

  

}
