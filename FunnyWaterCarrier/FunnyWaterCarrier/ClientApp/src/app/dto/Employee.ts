
export interface Employee {
    id: number,
    name: string,
    surname: string,
    bydthDay: Date,
    patronymic: string,
    subdivisionId: number,
    sex: Sex
}

enum Sex {
    mail,
    femail
}