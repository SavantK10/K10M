for a Restaurant database, create tables for the below


1. 
Menulist - this will contain items served by restaurant, it will have below 
columns

itemId will be a number and it will be an identity key and would be primary key
itemName - dish name 
itemCategory 
itemPrice
insert minimum 10 items in the table

2. CustomerDetails

customerId
customerName
customerType (can only be 'Regular' or  'Visitor')
customerContactNo
customerEmail
customerWalletBalance (cannot be negative)
insert minimum 8 regular customer and 5 visitors

3. 
Orders
BillNo - would be a number and identity - also a primary key
orderNumber 
itemId/plateId - can have values only from MenuList
customerId - can have values only from customerDetails
orderQty - must be equal to or greater than 1 and cannot be null
insert 20 orders in the table

-------------------------------------------------------------------------------------------------

		Write Queries for the below

1. Display OrderNumber, CustomerName,CustomerType, ItemName, OrderQty
2. Total Orders based on ItemCategory
3. Display all the orders in descending order based on OrderQty
