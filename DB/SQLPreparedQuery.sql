use Student;


create table Student
(	
	StudentID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50),
	Age int,
);

create table Teacher
(
	TeacherID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	TeacherName varchar(50),
);

create table Faculty
(
	FacultyID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	FacultyName varchar(50),
);

create table Subjekt
(	
	SubjectID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	SubjektName varchar(50),
	TeacherID INT,
	FacultyID INT,	
	FOREIGN KEY (TeacherID) REFERENCES Teacher(TeacherID),
	FOREIGN KEY (FacultyID) REFERENCES Faculty(FacultyID)
);

create table StudentConnSubject
(	
	StudentConnSubjectID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	StudentID INT,
	SubjectID INT,
	FOREIGN KEY (StudentID) REFERENCES Student(StudentID),
	FOREIGN KEY (SubjectID) REFERENCES Subjekt(SubjectID)
);

INSERT INTO Student (FirstName, LastName, Age) 
VALUES 
 ('Pascal', 'Dziersk', 18),
 ('Toni', 'Einecker', 19),
 ('Tim', 'Farahani', 20),
 ('Toni', 'Einecker', 21),	
 ('Jannis', 'Fix', 12),
 ('Michaela', 'Fleig', 23),
 ('Leon', 'Gieringer', 24),
 ('Elia Michael', 'Herzog', 17),
 ('Konstantin', 'Huwa', 18),
 ('Anna', 'Janzen', 19),
 ('Manuela Rebekka', 'Kalmbach', 20),
 ('Tim', 'Koch', 21),
 ('Simon', 'K�nig', 22),
 ('Pascal', 'Kunkel', 23),
 ('Jan Simon', 'Lafferton', 24),		
 ('Dominik', 'Lange', 17),
 ('Maximilian', 'Maier',18),
 ('Robin', 'Meckler', 19),
 ('Mohammad', 'Mehjazi', 20),
 ('David', 'Perk', 21),
 ('Manuel Celestine', 'Piroch', 22),	
 ('Nico', 'Rahm', 23),
 ('Niklas', 'Rajsp', 18),
 ('Franz-Vinzenz', 'Reitzler', 19),
 ('Samuel', 'Schlingheider', 20),
 ('Adrian', 'Schmidt', 21),
 ('Leo', 'Schneider', 22),
 ('Vincent Julian', 'Schreck', 23),
 ('Marcel Manuel', 'Sommer', 24),
 ('Lukas', 'von Ehr', 18),
 ('Daniel', 'Wulfert', 19),
 ('Johannes', 'Zipfel', 20),
 ('Tobias','B�hler', 21);
	
INSERT INTO Teacher (TeacherName) 
VALUES 
	('Vollmer'),
	('Br�uner'),
	('Lehmann'),
	('R�thig'),
	('Nagato-Plum'),
	('Brune'),
	('Berkling');

INSERT INTO Faculty (FacultyName) 
VALUES 
	('Informatik'),
	('Wirtschaft'),
	('Elektrotechnik'),
	('Mathematik'),
	('Phsik');

INSERT INTO Subjekt (SubjektName, TeacherID, FacultyID) 
VALUES 
	('�bersetzterbau', 1,1),
	('Java', 4,1),
	('Rechnerarchitekturen', 3,3),
	('Netztechnik 1', 2,3),
	('Angewandte Mathematik (Numerik)', 5,4),
	('SW-Eningeering',7,1),
	('Web-Engineering',4,1);


INSERT INTO StudentConnSubject (StudentID, SubjectID) 
VALUES 
	(1,1),(2,2),(3,3),(4,4),(5,5),(6,6),(7,7),
	(8,1),(9,2),(10,3),(11,4),(12,5),(13,6),(14,7),
	(15,1),(16,2),(17,3),(18,4),(19,5),(20,6),(21,7),
	(22,1),(23,2),(24,3),(25,4),(26,5),(27,6),(28,7),
	(29,1),(30,2),(31,3),(32,4),(33,5);

	
SELECT *
From Student;

SELECT *
From Teacher;

SELECT *
From Faculty;

SELECT *
From Subjekt;

SELECT *
From StudentConnSubject;