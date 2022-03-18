import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})

/** orders component*/
export class OrderComponent implements OnInit {

  constructor(
    private router: Router,
    private ordersService: OrderService
  ) { }

  ngOnInit() {
  }
}
