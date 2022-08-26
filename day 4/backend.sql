create database shoppingAPPDB

use shoppingAPPDB

create table ProductsList
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)
insert into ProductsList values(101,'Pepsi','Cold-Drink',50,1)
insert into ProductsList values(102,'Coke','Cold-Drink',50,1)
insert into ProductsList values(103,'IPhone','Electronic',1500000,0)
insert into ProductsList values(104,'Dell','Electronic',85000,1)
insert into ProductsList values(105,'OGeneral','Electronic',46000,0)

select * from ProductsList

create table Customers
(
	customerId int primary key identity,
	customerName varchar(20),
	customerType varchar(20),
	customerWalletBalance int,
	customerEmail varchar(40),

	constraint chk_customerType check (customerType in ('Regular','New','Rare Visits'))
)
insert into Customers values('Nikhil','Regular',500,'nikhil@gmail.com')
insert into Customers values('Karan','New',500,'karan@gmail.com')
insert into Customers values('Rahul','Regular',500,'rahul@gmail.com')
insert into Customers values('Sumit','Rare Visits',500,'nikhil@gmail.com')


select * from Customers




