import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { SubdivisionService } from 'src/app/subdivisions/shared/subdivision.service';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-edit-employee',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})

/** employee edit component*/
export class EditEmployeeComponent implements OnInit {
  subdivisions: Subdivision[] = [];
  employee: Employee = {} as Employee;
  isError: boolean = false;

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private subdivisionService: SubdivisionService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getEmployee();
    this.getSubdivisions();
  }

  getEmployee(): void {
    const employeeId = +this.route.snapshot.paramMap.get('employeeId')!;
    this.employeeService.getEmployee(employeeId).subscribe(employee => this.employee = employee, error => console.log(error));
  }

  getSubdivisions(): void {
    this.subdivisionService.getSubdivisions().subscribe(subdivisions => this.subdivisions = subdivisions, error => console.log(error));
  }

  saveEmployee(employee: NgForm): void {

    this.employee.name = employee.value.name == "" ? this.employee.name : employee.value.name;
    this.employee.surname = employee.value.surname == "" ? this.employee.surname : employee.value.surname;
    this.employee.patronymic = employee.value.patronymic == "" ? this.employee.patronymic : employee.value.patronymic;

    if (this.employee.name == "") {
      this.isError = true;
      return;
    }

    this.employeeService.editEmployee(this.employee).subscribe( () => this.router.navigate(['employes/'] ), error => console.log(error));
  }
}
