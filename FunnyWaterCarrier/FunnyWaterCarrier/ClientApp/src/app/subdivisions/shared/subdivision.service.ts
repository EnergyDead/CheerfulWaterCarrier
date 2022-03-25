import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

import { Subdivision } from 'src/app/dto/Subdivision';

@Injectable({ providedIn: 'root' })
export class SubdivisionService {    
    private baseUrl: string;

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl; 
    }

    public getSubdivisions(): Observable<Subdivision[]> {
        const url = `${this.baseUrl}api/subdivisions`;
        return this.http.get<Subdivision[]>(url);
    }

    public getSubdivision(id: number): Observable<Subdivision> {
        const url = `${this.baseUrl}api/subdivision/${id}`;
        return this.http.get<Subdivision>(url);
    }

    public addSubdivision(subdivision: Subdivision): Observable<Subdivision> {
        const url = `${this.baseUrl}api/subdivision/add`;
        return this.http.post<Subdivision>(url, subdivision, this.httpOptions);
    }

    public editSubdivision(subdivision: Subdivision): Observable<Subdivision> {
        const url = `${this.baseUrl}api/subdivision/${subdivision.subdivisionId}/edit`;
        return this.http.post<Subdivision>(url, subdivision, this.httpOptions);
    }

    public deleteSubdivision(id: number): Observable<boolean> {
        const url = `${this.baseUrl}api/subdivision/${id}/delete`;
        return this.http.post<boolean>(url, null, this.httpOptions);
    }
 }