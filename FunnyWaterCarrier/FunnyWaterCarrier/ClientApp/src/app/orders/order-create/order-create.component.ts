import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { Employee } from 'src/app/dto/Employee';
import { Order } from 'src/app/dto/Order';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-create-order',
  templateUrl: './order-create.component.html',
  styleUrls: ['./order-create.component.css']
})

/** order create component*/
export class CreateOrderComponent implements OnInit {
  error: string = "";
  employes: Employee[] = [];
  selectedEmployee: number = 0;
  isError: boolean = false;

  constructor(
    private router: Router,
    private orderService: OrderService,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {
    this.getEmployes();
  }

  addOrder(orderName: NgForm) {
    const newOrder = <Order>{
      name: orderName.value.name,
      employeeId: this.selectedEmployee
    };
    if (newOrder.name =="" || newOrder.employeeId == undefined) {
      this.isError = true;
      return;
    }

    this.orderService.addOrder(newOrder).subscribe( () => this.router.navigate(['orders/']), error => this.error = error.message);
  }

  getEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes, error => this.error = error.message);
  }
}
