-- Create the database
CREATE DATABASE PointOfSale;
GO

-- Switch to the database
USE PointOfSale;
GO

-- Create Admin table
CREATE TABLE Admin (
    AdminID INT NOT NULL IDENTITY(1,1),
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL,
    PRIMARY KEY (AdminID)
);
GO

-- Create Employee table
CREATE TABLE Employee (
    EmployeeID VARCHAR(20) NOT NULL,
    Username VARCHAR(20) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL, 
	Name VARCHAR(100) NOT NULL,
    AdminID INT NOT NULL DEFAULT -1,
    PRIMARY KEY (EmployeeID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Create Store table
CREATE TABLE Store(
		StoreID VARCHAR(20) NOT NULL,
		StoreName VARCHAR(100) NOT NULL UNIQUE,
		Address VARCHAR(255) NOT NULL,
		ContactNumber VARCHAR(20) NOT NULL,
		AdminID INT NOT NULL DEFAULT -1,
		PRIMARY KEY (StoreID),
		FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Create Item table
CREATE TABLE Item (
    ItemID VARCHAR(20) NOT NULL,
	ItemName VARCHAR(50) NOT NULL UNIQUE,
	Barcode INT NOT NULL, 
	Quantity INT NOT NULL DEFAULT 0, 
	Unit INT NOT NULL DEFAULT 0,
    UnitPrice DECIMAL(18, 2) NOT NULL, -- Use DECIMAL for prices
	Stock INT NOT NULL DEFAULT 0,
	Description VARCHAR(255),
	Supplier VARCHAR(255) NOT NULL,
    AdminID INT NOT NULL DEFAULT -1,
    PRIMARY KEY (ItemID),
    FOREIGN KEY (AdminID) REFERENCES Admin(AdminID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
);
GO



-- Create Customer table
CREATE TABLE LoyaltyCustomer (
    CustomerID VARCHAR(20) NOT NULL,
    Name VARCHAR(50) NULL, -- Removed DEFAULT 0, as NULL is allowed
	CustomerCardNumber VARCHAR(20) NOT NULL UNIQUE,
    Points INT DEFAULT 0,
    EmployeeID VARCHAR(20) NOT NULL,
    PRIMARY KEY (CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee (EmployeeID)
        ON DELETE NO ACTION
        ON UPDATE CASCADE
);
GO

-- Create Bill table
CREATE TABLE Bill (
    BillID INT IDENTITY(1,1) NOT NULL,
    Total DECIMAL(18, 2) NOT NULL DEFAULT 0, 
	CustomerPoints DECIMAL(10, 2) DEFAULT 0, 
	ToatalDiscount DECIMAL(10, 2) DEFAULT 0, 
    Date DATE NOT NULL, -- Use DATE for date values
    Time TIME NOT NULL, -- Use TIME for time values
    EmployeeID VARCHAR(20) NOT NULL,
	CustomerCardNumber VARCHAR(20),
	StoreID VARCHAR(20) NOT NULL,
    PRIMARY KEY (BillID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION,
	FOREIGN KEY (CustomerCardNumber) REFERENCES LoyaltyCustomer(CustomerCardNumber)
        ON DELETE NO ACTION
        ON UPDATE CASCADE,
	FOREIGN KEY (StoreID) REFERENCES Store(StoreID)
        ON DELETE NO ACTION
        ON UPDATE NO ACTION
);
GO


-- Optional parts begin

-- Insert Part 
INSERT INTO Admin (Username, Password)
VALUES 
    ('admin1', 'Admin123') ; 

INSERT INTO Employee (EmployeeID, Username, Password,Name, AdminID)
VALUES 
    ('E00', 'employeeAdmin', 'Employee000','Kevin', 1);

	
INSERT INTO Store (StoreID, StoreName, Address, ContactNumber, AdminID)
VALUES ('S01','Store','123/ Store road,abc','1234567890',1);





Drop database PointOfSale
