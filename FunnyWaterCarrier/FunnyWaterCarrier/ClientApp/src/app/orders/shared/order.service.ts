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
        const url = `${this.baseUrl}api/orders`;
        return this.http.get<Order[]>(url);
    }

    public GetOrder(id: number): Observable<Order> {
        const url = `${this.baseUrl}api/order/${id}`;
        return this.http.get<Order>(url);
    }

    public AddOrder(order: Order): Observable<Order> {
        const url = `${this.baseUrl}api/add`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Order>(url, order);
    }

    public EditOrder(order: Order): Observable<Order> {
        const url = `${this.baseUrl}api/order/${order.id}/edit`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Order>(url, order);
    }
 }