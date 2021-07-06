import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomersComponent } from './customers/customers.component';
import { HomeComponent } from './home/home.component';
import { ItemComponent } from './item/item.component';
import { OrdersComponent } from './orders/orders.component';
import { StoreComponent } from './store/store.component';

const routes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'store/:id',component: StoreComponent},
  {path: 'item/:storeid/:itemid',component: ItemComponent},
  {path: 'orders',component:OrdersComponent},
  {path: 'customers',component:CustomersComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
