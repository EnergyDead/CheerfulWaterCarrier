import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Action } from 'rxjs/internal/scheduler/Action';
import { Order } from 'src/app/dto/Order';

@Injectable({ providedIn: 'root' })
export class OrderService {    
    private baseUrl: string;

    httpOptions = {
        headers: new HttpHeaders({ 'Content-Type': 'application/json' })
    };

    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.baseUrl = baseUrl; 
    }

    public getOrders(): Observable<Order[]> {
        const url = `${this.baseUrl}api/orders`;
        return this.http.get<Order[]>(url);
    }

    public getOrder(id: number): Observable<Order> {
        const url = `${this.baseUrl}api/order/${id}`;
        console.log(url);
        return this.http.get<Order>(url);
    }

    public addOrder(order: Order): Observable<Order> {
        const url = `${this.baseUrl}api/order/add`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Order>(url, order, this.httpOptions);
    }

    public editOrder(order: Order): Observable<Order> {
        const url = `${this.baseUrl}api/order/${order.id}/edit`;
        // todo: проверить, может что-то ещё нужно
        return this.http.post<Order>(url, order);
    }
 }