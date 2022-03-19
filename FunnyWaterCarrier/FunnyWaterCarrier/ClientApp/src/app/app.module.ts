import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './shared/nav-menu/nav-menu.component';
import { OrdersComponent } from './orders/order-list/order-list.component';
import { OrderComponent } from './orders/order-view/order.component';
import { CreateOrderComponent } from './orders/order-create/order-create.component';
import { EditOrderComponent } from './orders/order-edit/order-edit.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    OrderComponent,
    OrdersComponent,
    EditOrderComponent,
    CreateOrderComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', redirectTo: '/orders', pathMatch: 'full' },
      { path: 'order/create', component: CreateOrderComponent, pathMatch: 'full' },
      { path: 'order/:orderId', component: OrderComponent, pathMatch: 'full' },
      { path: 'order/:orderId/edit', component: EditOrderComponent },
      { path: 'orders', component: OrdersComponent },

    /* 
      { path: 'employee/create', component: RegistrationComponent, pathMatch: 'full' },
      { path: 'employee/:employeeId', component: RegistrationComponent, pathMatch: 'full' },
      { path: 'employee/:employeeId/edit', component: RegistrationComponent, pathMatch: 'full' },
      { path: 'employes', component: RegistrationComponent, pathMatch: 'full' },

      { path: 'subdivisione/create', component: ScriptUserComponent, pathMatch: 'full' },
      { path: 'subdivisione/:subdivisioneId', component: ScriptUserComponent, pathMatch: 'full' },
      { path: 'subdivisione/:subdivisioneId/edit', component: ScriptUserComponent, pathMatch: 'full' },
      { path: 'subdivisions', component: SubdivisionsComponent, pathMatch: 'full' } 
    */
    ])
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
