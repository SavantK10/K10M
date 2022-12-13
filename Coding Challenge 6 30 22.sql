create database EasyPeeezyRestaurant 

create table MenuList
(
	dishId int primary key identity (100,1) not null,
	dishName varchar(30) not null,
	dishCategory varchar(20) not null,
	dishPrice float not null,

)

--insert 10 menu items
insert into MenuList (dishName, dishCategory, dishPrice) values ('sliece of pizza', 'hot food', 2.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('hot dogs', 'hot food', 0.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('pasta', 'hot food', 5.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('sushi', 'cold food', 10.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('seafood', 'hot food', 12.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('ice cream', 'desserts', 2.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('brownie', 'desserts', 2.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('Spite', 'drink', 1.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('water', 'drink', 1.99)
insert into MenuList (dishName, dishCategory, dishPrice) values ('Sweet Tea', 'drink', 1.99)

select * from MenuList

create table CustomerDetails
(
	custId int primary key IDENTITY (500,5) not null,
	custName varchar(40) not null,
	custType varchar(10) not null,
	custContactNo long (10) not null,
	custEmail varchar(50) not null,
	custWalletBalance float not null,

	constraint chk_custWalletBalance check (custWalletBalance > 0)
	CONSTRAINT chk_custWalletBalance check (custWalletBalance != NULL)

)

--make 13 customers
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (1,'Adam F.', 'Regular', 52357898,'adf@dbd.com',200.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (2,'David K.', 'Visitor', 52347898,'ddk@dbd.com',300.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (3,'Elodie K.', 'Regular', 52557888,'eek@dbd.com',100.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (4,'Mikaela R.', 'Regular', 52339888,'mar@dbd.com',50.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (5,'Feng M.', 'Visitor', 52787888,'fgm@dbd.com',900.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (6,'Felix R.', 'Regular', 52359888,'fxr@dbd.com',800.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (7,'Kate D.', 'Regular', 52357188,'ked@dbd.com',500.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (8,'Jake P.', 'Visitor', 52357588,'jep@dbd.com',100.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (9,'Dwight F.', 'Regular', 52379888,'dtf@dbd.com',400.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (10,'Jeff J.', 'Visitor', 52353888,'jfj@dbd.com',500.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (11,'Bill O.', 'Regular', 52356888,'blo@dbd.com',600.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (12,'Jonah V.', 'Visitor', 52399888,'jhv@dbd.com',300.00)
insert into CustomerDetails (custId, custName, custType, custContactNo, custEmail, custWalletBalance) values (13,'Haddie K.', 'Regular', 52319888,'hek@dbd.com',550.00)

select * from CustomerDetails

select CustomerDetails.custName, CustomerDetails.custWalletBalance from CustomerDetails where custWalletBalance =
(

)

create table Orders
(
	billNo int primary key identity (300,3) not null,
	orderNo int not null,
	plateId int not null,
	customerId int not null,
	orderQty int

	constraint fk_plateId foreign key (plateId) references MenuList(dishId)
	constraint fk_customerId foreign key (customerId) references CustomerDetails(custId)
	constraint chk_orderQty check (orderQty >= 1)
	constraint chk_orderQty check (OrderQty != null)
)

--insert 20 orders
insert into Orders (orderNo, plateId, customerId, orderQty) values (1,1,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (2,6,4,2)
insert into Orders (orderNo, plateId, customerId, orderQty) values (3,8,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (4,7,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (5,1,5,2)
insert into Orders (orderNo, plateId, customerId, orderQty) values (6,6,3,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (7,2,5,3)
insert into Orders (orderNo, plateId, customerId, orderQty) values (8,1,5,2)
insert into Orders (orderNo, plateId, customerId, orderQty) values (9,8,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (10,1,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (11,4,5,3)
insert into Orders (orderNo, plateId, customerId, orderQty) values (11,5,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (12,8,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (13,1,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (14,5,5,4)
insert into Orders (orderNo, plateId, customerId, orderQty) values (15,1,5,7)
insert into Orders (orderNo, plateId, customerId, orderQty) values (16,4,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (17,1,5,1)
insert into Orders (orderNo, plateId, customerId, orderQty) values (18,3,5,2)
insert into Orders (orderNo, plateId, customerId, orderQty) values (19,2,5,2)
insert into Orders (orderNo, plateId, customerId, orderQty) values (20,5,5,1)


select * from Orders

--1. Display OrderNumber, CustomerName,CustomerType, ItemName, OrderQty
select * from Orders where orderNo = 309


--2. Total Orders based on ItemCategory
select count(*) from Orders group by plateId


--3. Display all the orders in descending order based on OrderQty
select * from Orders order by orderQty desc



