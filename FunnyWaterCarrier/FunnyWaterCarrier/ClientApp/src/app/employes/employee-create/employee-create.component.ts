import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-create-employee',
  templateUrl: './employee-create.component.html',
  styleUrls: ['./employee-create.component.css']
})

/** order create component*/
export class CreateEmployeeComponent implements OnInit {

  constructor(
    private router: Router,
    private employeeService: EmployeeService
  ) { }

  ngOnInit() {

  }
}
