import { Component, OnInit } from '@angular/core';
import { GameshopapiService } from '../gameshopapi.service';

@Component({
  selector: 'app-customers',
  templateUrl: './customers.component.html',
  styleUrls: ['./customers.component.css']
})
export class CustomersComponent implements OnInit {

  allcustomers: any;
  
  constructor(private api:GameshopapiService ) { }

  ngOnInit(): void {
    this.api.getCustomers().subscribe(data =>{
      this.allcustomers = data;
      console.log("in API call");
      console.log(this.allcustomers);
    });
  }

}
