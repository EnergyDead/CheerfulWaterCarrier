import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Order } from 'src/app/dto/Order';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})

/** orders component*/
export class OrderComponent implements OnInit {
  order: Order = {} as Order;
  constructor(
    private router: Router,
    private ordersService: OrderService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getOrder();
  }

  getOrder(): void {
    const orderId = +this.route.snapshot.paramMap.get('orderId')!;
    this.ordersService.getOrder(orderId).subscribe(order => this.order = order);
  }
}
