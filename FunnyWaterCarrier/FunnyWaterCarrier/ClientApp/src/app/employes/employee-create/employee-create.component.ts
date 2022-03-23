import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-create-employee',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})

/** order create component*/
export class CreateEmployeeComponent implements OnInit {
  selectedSubdivision: number = 0;
  subdivisions: Subdivision[] = [];
  isError: boolean = false;

  constructor(
    private router: Router,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {

  }

  createEmployee(employee: NgForm): void {
    let newEmployee = <Employee>{};
    newEmployee.id = 0;
    newEmployee.name = employee.value.name;
    newEmployee.surname = employee.value.surname;    
    newEmployee.bydthDay = employee.value.bydthDay;

    newEmployee.subdivisionId = this.selectedSubdivision;
    if (newEmployee.name !== "" && newEmployee.subdivisionId !== undefined) {
      this.employeeService.addEmployee(newEmployee).subscribe( () => this.router.navigate(['employes/'] ));
    } else { this.isError = true}
  }
}
