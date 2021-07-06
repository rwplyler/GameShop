import { Component, OnInit } from '@angular/core';
import { GameshopapiService } from '../gameshopapi.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  stores:any;
  constructor(private api:GameshopapiService ) { }

  ngOnInit (): void {
    this.api.getStores().subscribe(data => {
      console.log(data);
      this.stores = data;
      console.log("in get");
    });
    console.log("In ngOnInit");
  }

}
