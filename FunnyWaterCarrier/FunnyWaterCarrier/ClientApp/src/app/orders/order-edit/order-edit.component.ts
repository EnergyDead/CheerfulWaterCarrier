import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Order } from 'src/app/dto/Order';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { OrderService } from '../shared/order.service';


@Component({
  selector: 'app-edit-order',
  templateUrl: './order-edit.component.html',
  styleUrls: ['./order-edit.component.css']
})

/** order edit component*/
export class EditOrderComponent implements OnInit {
  employes: Employee[] = [];
  selectedEmployee: number = 0;
  isError: boolean = false;
  order: Order = {} as Order;

  constructor(
    private router: Router,
    private orderService: OrderService,
    private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getOrder();
    this.getEmployes();
  }


  getOrder(): void {
    const orderId = +this.route.snapshot.paramMap.get('orderId')!;
    this.orderService.getOrder(orderId).subscribe(order => this.order = order);
  }
  
  saveOrder(newOrder: NgForm): void {
    if (newOrder.value.name != "") {
      this.order.name = newOrder.value.name;
    }
    this.orderService.editOrder(this.order).subscribe( () => this.router.navigate(['orders/'] ));
  }

  getEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes );
  }
}
