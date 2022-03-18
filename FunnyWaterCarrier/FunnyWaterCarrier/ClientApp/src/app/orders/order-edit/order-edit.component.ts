import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-edit-order',
  templateUrl: './order-edit.component.html',
  styleUrls: ['./order-edit.component.css']
})

/** order edit component*/
export class EditOrderComponent implements OnInit {

  constructor(
    private router: Router,
    private ordersService: OrderService
  ) { }

  ngOnInit() {

  }
}
