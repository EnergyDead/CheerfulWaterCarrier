import { Tag } from "./Tag";

export interface Order {
    id: number,
    name: string,
    suname: string,
    employeeId: number,
    tags: Tag[]
}