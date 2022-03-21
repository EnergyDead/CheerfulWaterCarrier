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
    this.GetOrders();
  }

  GetOrders(): void {
    this.ordersService.GetOrders().subscribe(orders => {
      this.orders = orders;
      console.log(orders);
    });
  }

  goTo(id: number):void {
    this.router.navigate(['order/' + id]);
  }
}
