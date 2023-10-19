--create store procedure for parcel entry
CREATE PROCEDURE spInsertParcel
    @ParcelID INT,
	@CustomerID INT,
    @ParcelName NVARCHAR(100),
    @ParcelDescription NVARCHAR(255),
    @Price DECIMAL,
    @Address NVARCHAR(100),
    @Weight DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Parcels (ParcelID, CustomerID, ParcelName, ParcelDescription, Price, Address, Weight)
    VALUES (@ParcelID, @CustomerID, @ParcelName, @ParcelDescription, @Price, @Address, @Weight);
END
