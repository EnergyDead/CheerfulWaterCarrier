import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
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
    private EmployeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getEmployee();
  }

  getEmployee(): void {
    const employeeId = +this.route.snapshot.paramMap.get('employeeId')!;
    this.EmployeeService.getEmployee(employeeId).subscribe(employee => this.employee = employee);
  }

  saveEmployee(employee: NgForm): void {
    if (employee.value.name != "") {
      this.employee.name = employee.value.name;
      this.employee.patronymic = "";
    }
    this.EmployeeService.editEmployee(this.employee).subscribe( () => this.router.navigate(['employes/'] ));
  }
}
