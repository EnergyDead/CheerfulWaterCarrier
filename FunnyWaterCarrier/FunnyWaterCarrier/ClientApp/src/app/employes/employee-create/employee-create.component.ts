import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';

import { Employee, Sex } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { SubdivisionService } from 'src/app/subdivisions/shared/subdivision.service';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-create-employee',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})

/** order create component*/
export class CreateEmployeeComponent implements OnInit {
  error: string = "";
  selectedSubdivision: number = 1;
  selectedSex: Sex = 0;
  subdivisions: Subdivision[] = [];
  isError: boolean = false;
  sexTypes: (Sex | string)[] = Object.values(Sex).filter(value => typeof value != 'number');

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private subdivisionService: SubdivisionService
  ) { }

  ngOnInit() {
    this.getSubdivisions();
  }

  getSubdivisions(): void {
    this.subdivisionService.getSubdivisions().subscribe(subdivisions => this.subdivisions = subdivisions, error => this.error = error.message);
  }

  createEmployee(employee: NgForm): void {
    if (employee.value.name == "") {
      this.isError = true;
      return;
    }

    const newEmployee = <Employee> {
      name: employee.value.name,
      surname: employee.value.surname,
      dateofBirth: employee.value.dateofBirth,
      sex: this.convertSex(employee.value.sex),
      subdivisionId: employee.value.subdivision
    };

    this.employeeService.addEmployee(newEmployee).subscribe( () => this.router.navigate(['employes/'] ), error => this.error = error.message);
  }

  convertSex(sex: string): number {
    return sex == 'mail' ? 0 : 1;
  }
}
