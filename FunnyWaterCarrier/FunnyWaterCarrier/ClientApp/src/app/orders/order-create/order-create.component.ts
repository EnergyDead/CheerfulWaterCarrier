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
  employes: Employee[] = [];
  selectedEmployee: number = 0;
  isError: boolean = false;
  order: Order = {} as Order;

  constructor(
    private router: Router,
    private orderService: OrderService,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {
    this.getEmployes();
  }

  addOrder(newOrder: Order, create: NgForm) {
    newOrder = <Order>{};
    newOrder.id = 0;
    newOrder.name = create.value.name;
    newOrder.employeeId = this.selectedEmployee;
    if (newOrder.name !== "" && newOrder.employeeId !== undefined) {
      this.orderService.addOrder(newOrder).subscribe( () => this.router.navigate(['orders/'] ));
    } else { this.isError = true}
  }

  getEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes );
  }
}
