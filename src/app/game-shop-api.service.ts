import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class GameShopAPIService {

  baseConnection:string ="https://localhost:44335/";
  constructor(private http:HttpClient) { }
}
