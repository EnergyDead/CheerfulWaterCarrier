import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Order } from 'src/app/dto/Order';
import { Subdivision } from 'src/app/dto/Subdivision';
import { SubdivisionService } from '../shared/subdivision.service';


@Component({
  selector: 'app-subdivisions',
  templateUrl: './subdivision-list.component.html',
  styleUrls: ['./subdivision-list.component.css']
})

/** orders component*/
export class SubdivisionsComponent implements OnInit {
  subdivisions: Subdivision[] = [];

  constructor(
    private router: Router,
    private subdivisionService: SubdivisionService
  ) { }

  ngOnInit() {
    this.getSbdivision();
  }

  getSbdivision(): void {
    this.subdivisionService.getSubdivisions().subscribe(subdivisions => this.subdivisions = subdivisions, error => console.log(error));
  }

  goTo(id: number):void {
    this.router.navigate(['subdivision/' + id]);
  }
}
