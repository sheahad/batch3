CREATE DATABASE StudentDB

USE StudentDB
--DROP DATABASE StudentDB

CREATE TABLE Students(
ID int IDENTITY (1,1),
Name VARCHAR(100),
Age int
)
--DROP TABLE Students

INSERT INTO Students (ID, Name, Age) VALUES (1, 'Ali', 21)
INSERT INTO Students (ID, Name, Age) VALUES (2, 'Asad', 22)

INSERT INTO Students (Age, Name, ID) VALUES (30, 'Asad', 3)
INSERT INTO Students VALUES (30, 'Asad', 3)


--
INSERT INTO Students ( Name, Age) VALUES ( 'Ali', 21)
INSERT INTO Students ( Name, Age) VALUES ('Asad', 22)

INSERT INTO Students (Age, Name) VALUES (30, 'Asad')
INSERT INTO Students VALUES ('Arif', 31)




SELECT * FROM Students

UPDATE Students 
SET ID = 2
WHERE Name = 'Asad' 

DELETE Students
WHERE ID = 30 