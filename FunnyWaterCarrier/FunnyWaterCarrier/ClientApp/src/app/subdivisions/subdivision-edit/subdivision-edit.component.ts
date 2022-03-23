import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Employee } from 'src/app/dto/Employee';
import { Subdivision } from 'src/app/dto/Subdivision';
import { EmployeeService } from 'src/app/employes/shared/employee.service';
import { SubdivisionService } from '../shared/subdivision.service';


@Component({
  selector: 'app-edit-subdivision',
  templateUrl: './subdivision-edit.component.html',
  styleUrls: ['./subdivision-edit.component.css']
})

/** order edit component*/
export class EditSubdivisionComponent implements OnInit {
  employes: Employee[] = [];
  selectedEmployee: number = 0;
  isError: boolean = false;
  subdivision: Subdivision = {} as Subdivision;

  constructor(
    private router: Router,
    private subdivisionService: SubdivisionService,
    private employeeService: EmployeeService,
    private route: ActivatedRoute
  ) { }

  ngOnInit() {
    this.getSubdivision();
    this.getEmployes();
  }


  getSubdivision(): void {
    const subdivisionId = +this.route.snapshot.paramMap.get('subdivisionId')!;
    this.subdivisionService.getSubdivision(subdivisionId).subscribe(subdivision => this.subdivision = subdivision);
  }
  
  saveSubdivision(newOrder: NgForm): void {
    if (newOrder.value.name != "") {
      this.subdivision.name = newOrder.value.name;
    }
    this.subdivisionService.editSubdivision(this.subdivision).subscribe( _ => this.router.navigate(['subdivisions/'] ));
  }

  getEmployes(): void {
    this.employeeService.getEmployes().subscribe(employes => this.employes = employes );
  }
}
