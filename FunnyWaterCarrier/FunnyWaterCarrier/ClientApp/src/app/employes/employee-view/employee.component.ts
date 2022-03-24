import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { SubdivisionService } from 'src/app/subdivisions/shared/subdivision.service';
import { EmployeeService } from '../shared/employee.service';


@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})

/** orders component*/
export class EmployeeComponent implements OnInit {
  
  employee: Employee = {} as Employee;
  sex: string = "";
  subdivision: Subdivision = {} as Subdivision;

  constructor(
    private router: Router,
    private employeeService: EmployeeService,
    private subdivisionService: SubdivisionService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getEmployee();
  }


  getEmployee(): void {
    const orderId = +this.route.snapshot.paramMap.get('employeeId')!;
    this.employeeService.getEmployee(orderId).subscribe(employee => {
      this.employee = employee,
      console.log(employee);
      console.log(typeof employee.dateofBirth);
      this.sex = this.convertSex(employee.sex);
      this.getSubdivision(employee.subdivisionId);
    });
  }

  convertSex(sexType: number):string {
    return sexType == 0 ? "мужской" : "женский";
  }

  getSubdivision(id: number):void {
    this.subdivisionService.getSubdivision(id).subscribe(subdivision => this.subdivision = subdivision);
  }

  goToEdit(id: number):void {
    this.router.navigate([`employee/${id}/edit`]);
  }

  delete(): void {
    this.employeeService.deleteEmployee(this.employee.employeeId).subscribe( _ => this.router.navigate([`employes`]) );
  }

  goToSubdivision(id: number): void {
    this.router.navigate([`subdivision/${id}`]);
  }
}
