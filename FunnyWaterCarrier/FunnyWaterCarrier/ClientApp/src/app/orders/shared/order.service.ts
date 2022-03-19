import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Action } from 'rxjs/internal/scheduler/Action';
import { Order } from 'src/app/dto/Order';

@Injectable({ providedIn: 'root' })
export class OrderService {    
    private baseUrl: string;

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl; 
    }

    public GetOrders(): Observable<Order[]> {
        return this.http.get<Order[]>(this.baseUrl + 'api/orders');
    }
 }