export interface Employee {
    employeeId: number,
    name: string,
    surname: string,
    dateofBirth: Date,
    patronymic: string,
    subdivisionId: number,
    sex: number
}

export enum Sex {
    mail,
    femail
}