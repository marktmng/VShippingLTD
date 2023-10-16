use VShippingdb;
GO

CREATE TABLE Admins (
Username NVARCHAR(50),
Password NVARCHAR(50)
);

-- Insert some sample admin data
INSERT INTO Admins (Username, Password)
VALUES ('admin', 'admin');