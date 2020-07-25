--Create DataBase ManageCafe
go
use ManageCafe
go

-- Food
-- TableFood
-- FoodCategory
-- Account
-- Bill
-- BillInfo
Create Table Account
(
	UserName nvarchar(100) Primary Key,
	DisplayName nvarchar(100) not null Default 'User',
	Password nvarchar(1000) not null Default 0,
	Type int not null default 0--1:admin && 0:staff
)
go
Create Table TableFood
(
	Id int Identity Primary Key,
	Name nvarchar(50) not null default 'Noname',
	Status int not null default 0 -- 0:Unoccupied && 1:Occupied
)
go
Create Table FoodCategory
(
	Id int Identity Primary Key,
	Name nvarchar(50) not null default 'NoName',
)
go
Create Table Food
(
	Id int Identity Primary Key,
	Id_Category int not null,
	Name nvarchar(50) not null default 'Noname',
	Price Float not null default 0,
	Foreign Key(Id_Category) references dbo.FoodCategory(Id)
)
go
Create Table Bill
(
	Id int Identity Primary Key,
	Id_TableFood int not null,
	DateCheckIn Date not null,
	DateCheckOut Date,
	Status int default 0 not null -- 1: paid && 0: unpaid
	Foreign Key(Id_TableFood) references dbo.TableFood(Id)
)
go
Create Table BillInfo
(
	Id int Identity Primary Key,
	Id_Bill int not null,
	Id_Food int,
	Count int default 0 not null
	Foreign Key(Id_Bill) references dbo.Bill(Id),
	Foreign Key(Id_Food) references dbo.Food(Id)
)
go