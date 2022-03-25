import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Inject, Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';

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
        return this.http.post<Order>(url, order, this.httpOptions);
    }

    public editOrder(order: Order): Observable<Order> {
        const url = `${this.baseUrl}api/order/${order.orderId}/edit`;
        return this.http.post<Order>(url, order, this.httpOptions);
    }

    public deleteOrder(id: number): Observable<boolean> {
        const url = `${this.baseUrl}api/order/${id}/delete`;
        return this.http.post<boolean>(url, null, this.httpOptions);
    }
 }