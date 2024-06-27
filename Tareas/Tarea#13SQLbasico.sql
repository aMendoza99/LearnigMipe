-- CREATE DATABASE
CREATE DATABASE ContactManagement;
GO

USE ContactManagement;
GO

-- Table ContactUpdateLog
CREATE TABLE ContactUpdateLog (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    ContactID INT,
    OldFirstName NVARCHAR(50),
    OldLastName NVARCHAR(50),
    OldEmail NVARCHAR(100),
    OldPhone NVARCHAR(15),
    NewFirstName NVARCHAR(50),
    NewLastName NVARCHAR(50),
    NewEmail NVARCHAR(100),
    NewPhone NVARCHAR(15),
    UpdateDate DATETIME DEFAULT GETDATE()
);
GO

-- Table/Contact
CREATE TABLE Contact (
    ContactID INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100),
    Phone NVARCHAR(15)
);
GO

-- Table/Appointment
CREATE TABLE Appointment (
    AppointmentID INT PRIMARY KEY IDENTITY(1,1),
    ContactID INT,
    AppointmentDate DATETIME NOT NULL,
    Location NVARCHAR(100),
    Description NVARCHAR(255),
    FOREIGN KEY (ContactID) REFERENCES Contact(ContactID)
);
GO

-- Trigger/UpdateContact
CREATE TRIGGER trg_AfterUpdateContact
ON Contact
AFTER UPDATE
AS
BEGIN
    INSERT INTO ContactUpdateLog (ContactID, OldFirstName, OldLastName, OldEmail, OldPhone, NewFirstName, NewLastName, NewEmail, NewPhone)
    SELECT
        d.ContactID,
        d.FirstName AS OldFirstName,
        d.LastName AS OldLastName,
        d.Email AS OldEmail,
        d.Phone AS OldPhone,
        i.FirstName AS NewFirstName,
        i.LastName AS NewLastName,
        i.Email AS NewEmail,
        i.Phone AS NewPhone
    FROM
        deleted d
    INNER JOIN
        inserted i ON d.ContactID = i.ContactID;
END;
GO

-- Stored Procedure/AddContact
CREATE PROCEDURE AddContact
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(15)
AS
BEGIN
    INSERT INTO Contact (FirstName, LastName, Email, Phone)
    VALUES (@FirstName, @LastName, @Email, @Phone);
END;
GO

-- Stored Procedure/UpdateContact
CREATE PROCEDURE UpdateContact
    @ContactID INT,
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Email NVARCHAR(100),
    @Phone NVARCHAR(15)
AS
BEGIN
    UPDATE Contact
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        Phone = @Phone
    WHERE ContactID = @ContactID;
END;
GO

-- Stored Procedure/DeleteContact
CREATE PROCEDURE DeleteContact
    @ContactID INT
AS
BEGIN
    DELETE FROM Contact
    WHERE ContactID = @ContactID;
END;
GO

-- Insert/TableContact
INSERT INTO Contact (FirstName, LastName, Email, Phone) VALUES
('Adrien', 'Mendoza', 'amendoza@intelution.net', '555-1234'),
('Julian', 'Fuentez', 'jfuentez@intelution.net', '555-5678'),
('Pedro', 'Rodriguez', 'prodriguez', '555-8765');
GO

-- Insert/TableAppointemnt
INSERT INTO Appointment (ContactID, AppointmentDate, Location, Description) VALUES
(1, '2024-07-01 10:00:00', 'Oficina A', 'Reunión con Reinaldo'),
(2, '2024-07-02 11:00:00', 'Oficina B', 'reunion con Stalin'),
(3, '2024-07-03 09:00:00', 'Oficina C', 'reunion con Darien');
GO
