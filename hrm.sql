CREATE DATABASE UserManagementDb;
GO

USE UserManagementDb;
GO

CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    EmployeeId INT NOT NULL,
    EmployeeName NVARCHAR(150) NOT NULL,
    IsActive BIT NOT NULL -- 1 = Active, 0 = Inactive
);
