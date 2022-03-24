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
  selectedSubdivision: number = 0;
  selectedSex: Sex = 0;
  subdivisions: Subdivision[] = [];
  isError: boolean = false;
  sexTypes = Object.values(Sex).filter(value => typeof value != 'number');

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private subdivisionService: SubdivisionService
  ) { }

  ngOnInit() {
    this.getSubdivisions();
  }

  getSubdivisions(): void {
    this.subdivisionService.getSubdivisions().subscribe(subdivisions => this.subdivisions = subdivisions);
  }

  createEmployee(employee: NgForm): void {
    let newEmployee = <Employee>{};
    newEmployee.employeeId = 0;
    newEmployee.name = employee.value.name;
    newEmployee.surname = employee.value.surname;    
    newEmployee.dateofBirth = employee.value.dateofBirth;
    newEmployee.sex = this.convertSex(employee.value.sex);    
    newEmployee.subdivisionId = this.selectedSubdivision;

    console.log(newEmployee);

    if (newEmployee.name !== "" && newEmployee.subdivisionId !== undefined) {
      this.employeeService.addEmployee(newEmployee).subscribe( () => this.router.navigate(['employes/'] ));
    } else { this.isError = true}
  }

  convertSex(sex: string): number {
    return sex == 'mail' ? 0 : 1;
  }
}
