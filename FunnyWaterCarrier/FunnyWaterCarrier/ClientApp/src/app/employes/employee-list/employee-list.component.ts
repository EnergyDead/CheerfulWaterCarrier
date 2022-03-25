import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { Employee } from 'src/app/dto/Employee';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-employes',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})

/** employes component*/
export class EmployesComponent implements OnInit {
  error: string = "";
  employes: Employee[] = [];

  constructor(
    private router: Router,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {
    this.GetEmployes();
  }

  GetEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes, error => this.error = error.message);
  }

  goTo(id: number):void {
    this.router.navigate(['employee/' + id]);
  }
}
