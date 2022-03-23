
export interface Employee {
    employeeId: number,
    name: string,
    surname: string,
    bydthDay: Date,
    patronymic: string,
    subdivisionId: number,
    sex: Sex
}

export enum Sex {
    mail,
    femail
}