import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { Employee } from 'src/app/dto/Employee';

@Injectable({ providedIn: 'root' })
export class EmployeeService {    
    private baseUrl: string;

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl; 
    }

    public getEmployes(): Observable<Employee[]> {
        const url = `${this.baseUrl}api/employes`;
        return this.http.get<Employee[]>(url);
    }

    public getEmployee(id: number): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/${id}`;
        return this.http.get<Employee>(url);
    }

    public addEmployee(employee: Employee): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/add`;
        return this.http.post<Employee>(url, employee, this.httpOptions);
    }

    public editEmployee(employee: Employee): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/${employee.employeeId}/edit`;
        return this.http.post<Employee>(url, employee, this.httpOptions);
    }

    public deleteEmployee(id: number): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/${id}/delete`;
        return this.http.post<Employee>(url, null, this.httpOptions);
    }
 }