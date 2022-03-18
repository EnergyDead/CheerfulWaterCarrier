import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-create-order',
  templateUrl: './order-create.component.html',
  styleUrls: ['./order-create.component.css']
})

/** order create component*/
export class CreateOrderComponent implements OnInit {

  constructor(
    private router: Router,
    private ordersService: OrderService
  ) { }

  ngOnInit() {

  }
}
