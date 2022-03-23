import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { SubdivisionService } from '../shared/subdivision.service';


@Component({
  selector: 'app-subdivision',
  templateUrl: './subdivision.component.html',
  styleUrls: ['./subdivision.component.css']
})

/* subdivision component */
export class SubdivisionComponent implements OnInit {
  subdivision: Subdivision = {} as Subdivision;
  executor: Employee = {} as Employee;

  constructor(
    private router: Router,
    private subdivisionService: SubdivisionService,
    private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getOrder();
  }

  getOrder(): void {
    const subdivisionId = +this.route.snapshot.paramMap.get('subdivisionId')!;
    this.subdivisionService.getSubdivision(subdivisionId).subscribe(subdivision => {
      this.subdivision = subdivision;
      this.getExecutor(subdivision.supervisorId);
    });
  }

  getExecutor(id: number): void {
    this.employeeService.getEmployee(id).subscribe(employee => this.executor = employee );
  }
  
  goToExecutor(id: number):void {
    this.router.navigate(['employee/' + id]);
  }

  goToEdit(id: number):void {
    this.router.navigate([`subdivision/${id}/edit`]);
  }

  delete(): void {
    this.subdivisionService.deleteSubdivision(this.subdivision.subdivisionId).subscribe(_ => this.router.navigate([`subdivisions`]));
  }
}
