  
CREATE DATABASE GameShop;
USE Gameshop;

CREATE TABLE ACustomer( 
ID int IDENTITY(1,1) Primary Key,
FName varChar(50),
LName varchar(50));

CREATE TABLE AStore( 
ID int IDENTITY(1,1) Primary Key,
StoreName varchar(50));

Create Table AnItem(
ID int IDENTITY(1,1) Primary Key,
ItemName varchar(50),
Price decimal(10,2));

Create Table InventoryDetail(
InventoryID int IDENTITY(1,1) Primary Key,
StoreID int,
ItemID int,
Amount int,
FOREIGN KEY (StoreID) References Astore(ID),
FOREIGN KEY (ItemID) References AnItem(ID)
);

Create Table AOrder(
OrderID int  IDENTITY(1,1) Primary Key,
CustomerID int,
StoreID int,
OrderTime DateTime,
Total Decimal(10,2),
FOREIGN KEY (CustomerID) References ACustomer(ID),
FOREIGN KEY (StoreID) References AStore(ID));

Create Table AOrderDetail(
ID int IDENTITY(1,1) Primary Key,
OrderID int,
ItemID int,
ItemAmount int,
Total Decimal(10,2),
FOREIGN KEY(OrderID) References AOrder(ORDERID),
FOREIGN KEY(ItemID) References AnItem(ID));