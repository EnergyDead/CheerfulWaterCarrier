import { Tag } from "./Tag";

export interface Order {
    id: number,
    name: string,
    executorId: number,
    tags: Tag[]
}