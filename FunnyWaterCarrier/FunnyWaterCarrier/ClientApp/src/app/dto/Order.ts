import { Tag } from "./Tag";

export interface Order {
    id: number,
    name: string,
    employeeId: number,
    tags: Tag[]
}