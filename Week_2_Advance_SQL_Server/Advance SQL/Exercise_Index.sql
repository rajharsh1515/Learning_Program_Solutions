-- Exercise 1: Creating a Non-Clustered Index 

 

SET STATISTICS IO ON; 

SET STATISTICS TIME ON; 

SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME IN ('Products', 'Orders');-- Enable performance statistics
SET STATISTICS IO ON;
SET STATISTICS TIME ON;

-- DROP tables if they already exist
IF OBJECT_ID('Products', 'U') IS NOT NULL DROP TABLE Products;
IF OBJECT_ID('Orders', 'U') IS NOT NULL DROP TABLE Orders;

-- Create Products table
CREATE TABLE Products (
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(100)
);

-- Insert data into Products
INSERT INTO Products (ProductID, ProductName) VALUES
(1, 'Laptop'),
(2, 'Keyboard'),
(3, 'Mouse'),
(4, 'Monitor');

-- Create Orders table
CREATE TABLE Orders (
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    OrderDate DATE
);

-- Insert data into Orders
INSERT INTO Orders (OrderID, CustomerID, OrderDate) VALUES
(101, 1, '2023-01-15'),
(102, 2, '2023-02-01'),
(103, 1, '2023-01-15'),
(104, 3, '2023-03-05');

-- Query before index
SELECT * FROM Products WHERE ProductName = 'Laptop';

-- Create non-clustered index
CREATE NONCLUSTERED INDEX IX_Products_ProductName
ON Products (ProductName);

-- Query after index
SELECT * FROM Products WHERE ProductName = 'Laptop';

-- Drop index
DROP INDEX IX_Products_ProductName ON Products
-- Query before index
SELECT * FROM Orders WHERE OrderDate = '2023-01-15';

-- Create non-clustered index (simulation for practice)
CREATE NONCLUSTERED INDEX IX_Orders_OrderDate
ON Orders (OrderDate);

-- Query after index
SELECT * FROM Orders WHERE OrderDate = '2023-01-15';

-- Drop index
DROP INDEX IX_Orders_OrderDate ON Orders;

-- Query before composite index
SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';

-- Create composite non-clustered index
CREATE NONCLUSTERED INDEX IX_Orders_CustomerID_OrderDate
ON Orders (CustomerID, OrderDate);

-- Query after index
SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15';

SELECT  
    i.name AS IndexName,
    i.type_desc AS IndexType,
    OBJECT_NAME(i.object_id) AS TableName,
    COL_NAME(ic.object_id, ic.column_id) AS ColumnName,
    ic.key_ordinal AS KeyOrder
FROM sys.indexes i
INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
WHERE OBJECT_NAME(i.object_id) IN ('Products', 'Orders')
ORDER BY TableName, IndexName, KeyOrder;



CREATE NONCLUSTERED INDEX IX_Products_ProductName  

ON Products (ProductName); 

SELECT * FROM Products WHERE ProductName = 'Laptop'; 

DROP INDEX IX_Products_ProductName ON Products; 

 

-- Exercise 2: Creating a Clustered Index 

 

SELECT * FROM Orders WHERE OrderDate = '2023-01-15'; 

CREATE NONCLUSTERED INDEX IX_Orders_OrderDate  

ON Orders (OrderDate); 

SELECT * FROM Orders WHERE OrderDate = '2023-01-15'; 

 

-- Exercise 3: Creating a Composite Index 

 

SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15'; 

CREATE NONCLUSTERED INDEX IX_Orders_CustomerID_OrderDate  

ON Orders (CustomerID, OrderDate); 

SELECT * FROM Orders WHERE CustomerID = 1 AND OrderDate = '2023-01-15'; 

SELECT  

    i.name AS IndexName, 

    i.type_desc AS IndexType, 

    OBJECT_NAME(i.object_id) AS TableName, 

    COL_NAME(ic.object_id, ic.column_id) AS ColumnName, 

    ic.key_ordinal AS KeyOrder 

FROM sys.indexes i 

INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id 

WHERE OBJECT_NAME(i.object_id) IN ('Products', 'Orders') 

ORDER BY TableName, IndexName, KeyOrder; 