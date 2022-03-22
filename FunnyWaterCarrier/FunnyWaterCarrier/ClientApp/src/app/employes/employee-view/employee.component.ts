import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})

/** orders component*/
export class EmployeeComponent implements OnInit {
  employee: Employee = {} as Employee;

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getEmployee();
  }


  getEmployee(): void {
    const orderId = +this.route.snapshot.paramMap.get('employeeId')!;
    this.employeeService.getEmployee(orderId).subscribe(employee => this.employee = employee);
  }

  goToEdit(id: number):void {
    this.router.navigate([`employee/${id}/edit`]);
  }

  delete(): void {
    this.employeeService.deleteEmployee(this.employee.id).subscribe( _ => this.router.navigate([`employes`]) );
  }

  goToSubdivision(id: number): void {
    this.router.navigate([`subdivision/${id}`]);
  }
}
