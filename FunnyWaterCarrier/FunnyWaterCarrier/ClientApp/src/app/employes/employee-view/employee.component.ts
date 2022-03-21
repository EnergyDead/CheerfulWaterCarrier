import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})

/** orders component*/
export class EmployeeComponent implements OnInit {

  constructor(
    private router: Router,
    private EmployeeService: EmployeeService
  ) { }

  ngOnInit() {
  }
}
