  
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { AppComponent } from './app.component';

@Injectable({
  providedIn: 'root'
})
export class GameshopapiService {

  baseURL:string ="https://localhost:44335/";
  
  constructor(private http:HttpClient) { }

  getStores(){
    return this.http.get(this.baseURL+"Store");
  }

  getCustomers(){
    return this.http.get(this.baseURL+"Customer");
  }
}
