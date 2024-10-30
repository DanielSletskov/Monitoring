CREATE TABLE Employee(
                         EmployeeID INT PRIMARY KEY IDENTITY(1,1),
                         Fname NVARCHAR(50) NOT NULL,
                         Lname NVARCHAR(50) NOT NULL,
                         Position NVARCHAR(100),
                         HireDate DATE
);
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Bob','Jenses','TeamLeader','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Billie','Petersen','Developer','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Susanne','Ibsen','Developer','2022-08-02');
INSERT INTO Employee(Fname, Lname, Position, Hiredate)
VALUES('Olivia','Hansen','Developer','2022-08-02');