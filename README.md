# CheerfulWaterCarrier
Приложения для работы с заказами
## Web приложение для просмотра, ввода и редактирования следующих сущностей:

Сотрудники:
* Фамилия : string
* Имя : string
*  Отчество : string
*  Дата рождения : datetime
*  Пол : enum
*  Подразделение :  Ссылка на подразделение

Подразделения:
* Название : string
* Руководитель : Ссылка на сотрудника

Заказы:
* Номер : int
* Название товара : string
* Сотрудник : Ссылка на сотрудника
	
*Для одного заказа возможно указать несколько тегов, также один тег может быть указан у множества заказов.

# Инструкция
1) Должно быть установленно:
	Node js
	VisualStudio 2022
	SQLEXPRESS
2) Запустить приложение в Visual Studio 2022
3)Собрать проект
4) Открыть Package Manager Console
	Выполнить ```Add-Migration InitialCreate```
	Выполнить ```Update-Database```
5) Запустить проект
