import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Employee } from 'src/app/dto/Employee';

@Injectable({ providedIn: 'root' })
export class EmployeeService {    
    private baseUrl: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl; 
    }

    public GetEmployes(): Observable<Employee[]> {
        const url = `${this.baseUrl}api/employes`;
        return this.http.get<Employee[]>(url);
    }

    public GetEmployee(id: number): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/${id}`;
        return this.http.get<Employee>(url);
    }

    public AddEmployee(employee: Employee): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/add`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Employee>(url, employee);
    }

    public EditEmployee(employee: Employee): Observable<Employee> {
        const url = `${this.baseUrl}api/employee/${employee.id}/edit`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Employee>(url, employee);
    }
 }