import { Component, OnInit } from '@angular/core';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { DataService } from 'src/app/_services/data.service';

@Component({
  selector: 'app-update-db-modal',
  templateUrl: './update-db-modal.component.html',
  styleUrls: ['./update-db-modal.component.css']
})
export class UpdateDbModalComponent implements OnInit {
  timestamp: number;
  daysOld: number;
  updateRes: any;

  constructor(public bsModalRef: BsModalRef, private dataService: DataService) { }

  ngOnInit(): void {
  }

  updateThanDelete(){
    this.dataService.updateDatabase().subscribe(response => {
      this.updateRes = response;
    }, error => {
      console.log(error);
      return;
    })

    this.dataService.deleteOld().subscribe(response => {
      this.updateRes = response;
    }, error => {
      console.log(error);
    })

    this.bsModalRef.hide();
  }

}
