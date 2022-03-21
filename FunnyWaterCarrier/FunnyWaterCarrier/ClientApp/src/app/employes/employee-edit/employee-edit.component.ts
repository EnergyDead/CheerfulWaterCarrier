import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-edit-employee',
  templateUrl: './employee-edit.component.html',
  styleUrls: ['./employee-edit.component.css']
})

/** employee edit component*/
export class EditEmployeeComponent implements OnInit {

  constructor(
    private router: Router,
    private EmployeeService: EmployeeService
  ) { }

  ngOnInit() {

  }
}
