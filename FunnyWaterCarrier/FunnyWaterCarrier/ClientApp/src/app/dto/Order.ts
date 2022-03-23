import { Tag } from "./Tag";

export interface Order {
    orderId: number,
    name: string,
    employeeId: number,
    tags: Tag[]
}