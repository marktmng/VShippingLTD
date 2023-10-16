USE VShippingdb;
GO

-- Create the Customers table
CREATE TABLE Customers (
    CustomerID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Email NVARCHAR(100),
    PhoneNumber NVARCHAR(20)
);

-- Create the Addresses table
CREATE TABLE Addresses (
    AddressID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    AddressLine1 NVARCHAR(100),
    AddressLine2 NVARCHAR(100),
    City NVARCHAR(50),
    PostalCode NVARCHAR(10),
    Country NVARCHAR(50)
);

-- Create the Employees table
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    JobTitle NVARCHAR(50)
);

-- Create the Parcels table
CREATE TABLE Parcels (
    ParcelID INT PRIMARY KEY IDENTITY(1,1),
    CustomerID INT,
    ParcelType NVARCHAR(50), -- Drum, Box, Pallet, Container, etc.
    ParcelSize NVARCHAR(50), -- Small, Medium, Large, etc.
    AdditionalCharges DECIMAL(10, 2),
    PickupDate DATETIME,
    DeliveryDate DATETIME
);

-- Create the Shipments table
CREATE TABLE Shipments (
    ShipmentID INT PRIMARY KEY IDENTITY(1,1),
    ParcelID INT,
    WarehouseID INT,
    ShipmentDate DATETIME
);

-- Create a table for the Warehouse if needed
CREATE TABLE Warehouse (
    WarehouseID INT PRIMARY KEY IDENTITY(1,1),
    WarehouseName NVARCHAR(50),
    Location NVARCHAR(100)
);
