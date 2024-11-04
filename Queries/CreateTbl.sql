CREATE TABLE Employee(
                         EmployeeID INT PRIMARY KEY IDENTITY(1,1),
                         Fname NVARCHAR(50) NOT NULL,
                         Lname NVARCHAR(50) NOT NULL,
                         Position NVARCHAR(100),
                         HireDate DATE
);
CREATE TABLE WorkplanTasks(
                              WorkplanID INT PRIMARY KEY IDENTITY(1,1),
                              TaskDescription NVARCHAR(100),
                              Week int,
                              StartDate DATE,
                              EndDate DATE
);
CREATE TABLE Department((
                              DepartmentID INT PRIMARY KEY IDENTITY(1,1),
                              DepartmentName NVARCHAR(50)
);
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Bob','Jenses','TeamLeader','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Billie','Petersen','Developer','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Susanne','Ibsen','Developer','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Olivia','Hansen','Developer','2022-08-02');