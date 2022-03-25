import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Order } from 'src/app/dto/Order';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-orders',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})

/** orders component*/
export class OrdersComponent implements OnInit {
  orders: Order[] = [];

  constructor(
    private router: Router,
    private ordersService: OrderService
  ) { }

  ngOnInit() {
    this.getOrders();
  }

  getOrders(): void {
    this.ordersService.getOrders().subscribe(orders => this.orders = orders, error => console.log(error));
  }

  goTo(id: number):void {
    this.router.navigate(['order/' + id]);
  }
}
