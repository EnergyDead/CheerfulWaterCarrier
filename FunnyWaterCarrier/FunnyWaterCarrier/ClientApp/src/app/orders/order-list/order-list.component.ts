import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-orders',
  templateUrl: './order-list.component.html',
  styleUrls: ['./order-list.component.css']
})

/** orders component*/
export class OrdersComponent implements OnInit {

  constructor(
    private router: Router,
    private ordersService: OrderService
  ) { }

  ngOnInit() {

  }
}
