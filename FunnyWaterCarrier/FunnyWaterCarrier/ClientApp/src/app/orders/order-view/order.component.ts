import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

import { Employee } from 'src/app/dto/Employee';
import { Order } from 'src/app/dto/Order';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-order',
  templateUrl: './order.component.html',
  styleUrls: ['./order.component.css']
})

/** orders component*/
export class OrderComponent implements OnInit {
  order: Order = {} as Order;
  executor: Employee = {} as Employee;

  constructor(
    private router: Router,
    private ordersService: OrderService,
    private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getOrder();
  }

  getOrder(): void {
    const orderId = +this.route.snapshot.paramMap.get('orderId')!;
    this.ordersService.getOrder(orderId).subscribe(order => {
      this.order = order;
      this.getExecutor(order.employeeId);
    });
  }

  getExecutor(id: number): void {
    this.employeeService.getEmployee(id).subscribe(employee => this.executor = employee, error => console.log(error));
  }
  
  goToExecutor(id: number):void {
    this.router.navigate(['employee/' + id]);
  }

  goToEdit(id: number):void {
    this.router.navigate([`order/${id}/edit`]);
  }

  delete(): void {
    this.ordersService.deleteOrder(this.order.orderId).subscribe(_ => this.router.navigate([`orders`]), error => console.log(error));
  }
}
