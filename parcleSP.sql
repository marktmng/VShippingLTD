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

-- -- Create stored procedure for updating a parcel
CREATE PROCEDURE spUpdateParcel
    @ParcelID INT,
    @CustomerID INT,
    @ParcelName NVARCHAR(100),
    @ParcelDescription NVARCHAR(255),
    @Price DECIMAL,
    @Address NVARCHAR(100),
    @Weight DECIMAL(10, 2)
AS
BEGIN
    UPDATE Parcels
    SET
        CustomerID = @CustomerID,
        ParcelName = @ParcelName,
        ParcelDescription = @ParcelDescription,
        Price = @Price,
        Address = @Address,
        Weight = @Weight
    WHERE
        ParcelID = @ParcelID;
END


-- Create stored procedure for deleting a parcel by ParcelID
CREATE PROCEDURE spDeleteParcel
    @ParcelID INT
AS
BEGIN
    DELETE FROM Parcels
    WHERE ParcelID = @ParcelID;
END
