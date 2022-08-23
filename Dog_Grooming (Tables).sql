DROP TABLE Payment, Booking, Options, Staff, Dog_Vaccination, Vaccination, Dog, Client

CREATE TABLE Client (
	ClientID VARCHAR(4) NOT NULL,
	Forename VARCHAR(30) NOT NULL,
	Surname VARCHAR(30) NOT NULL,
	Sex VARCHAR(6) NOT NULL,
	DateOfBirth DATE NOT NULL,
	HomeAddress VARCHAR(50) NOT NULL,
	City VARCHAR(50) NOT NULL,
	Postcode VARCHAR(8) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	PhoneNo VARCHAR(15) NOT NULL,
	DateJoined DATE NOT NULL

	CONSTRAINT [PK_ClientID] PRIMARY KEY ([ClientID])
)

INSERT INTO Client VALUES('0001', 'Peter', 'Smith', 'Male', '03-JUN-1986', '45 Trout Lane', 'Derry/Londonderry', 'BT45 6HB', 'petersmith45@gmail.com', '07865489352', '14-FEB-2012')
INSERT INTO Client VALUES('0002', 'Steven', 'Wilson', 'Male', '19-JAN-1979', '189 Waterside Heights', 'Newtown', 'SW21 7JI', 'swilson789@gmail.com', '07589493677', '25-MAR-2011')
INSERT INTO Client VALUES('0003', 'Terry', 'Armstrong', 'Male', '31-AUG-1998', '231 Penny Lane', 'Cookstown', 'SJ67 7WN', 'TerryA31@gmail.com', '075682708998', '01-DEC-2014')
INSERT INTO Client VALUES('0004', 'Angela', 'Wong', 'Female', '01-APR-1999', '21 Brayton Crescent', 'Newport', 'BT32 7HF', 'angelawong@gmail.com', '077785421645', '15-JAN-2018')

CREATE TABLE Dog (
	DogID VARCHAR(4) NOT NULL,
	ClientID VARCHAR(4) NOT NULL,
	DogName VARCHAR(30) NOT NULL,
	Breed VARCHAR(30) NOT NULL,
	Sex VARCHAR(6) NOT NULL,
	DateOfBirth DATE NOT NULL,
	MedicalNotes VARCHAR(100) NOT NULL

	CONSTRAINT [PK_DogID] PRIMARY KEY ([DogID]),
	CONSTRAINT [FK_ClientID] FOREIGN KEY (ClientID) REFERENCES [Client]([ClientID])
)

INSERT INTO Dog VALUES('0001', '0001', 'Rupert', 'Husky', 'Male', '05-APR-2015', 'Cannot eat beef')
INSERT INTO Dog VALUES('0002', '0002', 'Oscar', 'Border Collie', 'Male', '29-MAY-2013', 'None')
INSERT INTO Dog VALUES('0003', '0003', 'Maya', 'Border Terrier', 'Female', '12-JAN-2015', 'Lactose Intolerant')
INSERT INTO Dog VALUES('0004', '0003', 'Layla', 'Springer Spaniel', 'Female', '13-MAY-2018', 'Allergic to eggs')
INSERT INTO Dog VALUES('0005', '0004', 'Blossom', 'Pomeranian', 'Female', '30-AUG-2016', 'None')
INSERT INTO Dog VALUES('0006', '0004', 'Skippy', 'Golden Retriever', 'Male', '13-MAR-2017', 'Allergic to eggs')
INSERT INTO Dog VALUES('0007', '0004', 'Muncher', 'Pug', 'Male', '29-JUL-2019', 'Has one eye')

CREATE TABLE Vaccination (
	VaccinationNo VARCHAR(4) NOT NULL,
	VaccinationName VARCHAR(30) NOT NULL

	CONSTRAINT [PK_VaccinationNo] PRIMARY KEY ([VaccinationNo])
)

INSERT INTO Vaccination VALUES('0001', 'Infectious Canine Hepatitis')
INSERT INTO Vaccination VALUES('0002', 'Leptospirosis')
INSERT INTO Vaccination VALUES('0003', 'Distemper')
INSERT INTO Vaccination VALUES('0004', 'Canine Parvovirus')
INSERT INTO Vaccination VALUES('0005', 'Rabies')

CREATE TABLE Dog_Vaccination (
	DogID VARCHAR(4) NOT NULL,
	VaccinationNo VARCHAR(4) NOT NULL,
	VaccinationDate DATE

	CONSTRAINT [PK_DogID-VaccinationNo] PRIMARY KEY (DogID, VaccinationNo),
	CONSTRAINT [FK_DogID] FOREIGN KEY (DogID) REFERENCES [Dog]([DogID]),
	CONSTRAINT [FK_VaccinationNo] FOREIGN KEY (VaccinationNo) REFERENCES [Vaccination]([VaccinationNo])
)

INSERT INTO Dog_Vaccination VALUES('0001', '0001', '06-APR-2015')
INSERT INTO Dog_Vaccination VALUES('0001', '0002', '05-APR-2015')
INSERT INTO Dog_Vaccination VALUES('0001', '0003', '05-APR-2015')
INSERT INTO Dog_Vaccination VALUES('0001', '0004', '06-APR-2015')
INSERT INTO Dog_Vaccination VALUES('0001', '0005', '06-APR-2015')
INSERT INTO Dog_Vaccination VALUES('0002', '0001', '29-MAY-2013')
INSERT INTO Dog_Vaccination VALUES('0002', '0002', '29-MAY-2013')
INSERT INTO Dog_Vaccination VALUES('0002', '0003', NULL)
INSERT INTO Dog_Vaccination VALUES('0002', '0004', '29-MAY-2013')
INSERT INTO Dog_Vaccination VALUES('0002', '0005', NULL)
INSERT INTO Dog_Vaccination VALUES('0003', '0001', NULL)
INSERT INTO Dog_Vaccination VALUES('0003', '0002', '12-JAN-2015')
INSERT INTO Dog_Vaccination VALUES('0003', '0003', '13-JAN-2015')
INSERT INTO Dog_Vaccination VALUES('0003', '0004', '13-JAN-2015')
INSERT INTO Dog_Vaccination VALUES('0003', '0005', '14-JAN-2015')
INSERT INTO Dog_Vaccination VALUES('0004', '0001', NULL)
INSERT INTO Dog_Vaccination VALUES('0004', '0002', NULL)
INSERT INTO Dog_Vaccination VALUES('0004', '0003', NULL)
INSERT INTO Dog_Vaccination VALUES('0004', '0004', '15-MAY-2018')
INSERT INTO Dog_Vaccination VALUES('0004', '0005', '15-MAY-2018')
INSERT INTO Dog_Vaccination VALUES('0005', '0001', '30-AUG-2016')
INSERT INTO Dog_Vaccination VALUES('0005', '0002', '30-AUG-2016')
INSERT INTO Dog_Vaccination VALUES('0005', '0003', '30-AUG-2016')
INSERT INTO Dog_Vaccination VALUES('0005', '0004', '30-AUG-2016')
INSERT INTO Dog_Vaccination VALUES('0005', '0005', '30-AUG-2016')
INSERT INTO Dog_Vaccination VALUES('0006', '0001', '15-MAR-2017')
INSERT INTO Dog_Vaccination VALUES('0006', '0002', NULL)
INSERT INTO Dog_Vaccination VALUES('0006', '0003', '15-MAR-2017')
INSERT INTO Dog_Vaccination VALUES('0006', '0004', '15-MAR-2017')
INSERT INTO Dog_Vaccination VALUES('0006', '0005', NULL)
INSERT INTO Dog_Vaccination VALUES('0007', '0001', '29-JUL-2019')
INSERT INTO Dog_Vaccination VALUES('0007', '0002', '29-JUL-2019')
INSERT INTO Dog_Vaccination VALUES('0007', '0003', '30-JUL-2019')
INSERT INTO Dog_Vaccination VALUES('0007', '0004', '30-JUL-2019')
INSERT INTO Dog_Vaccination VALUES('0007', '0005', NULL)

CREATE TABLE Staff (
	StaffID VARCHAR(4) NOT NULL,
	Forename VARCHAR(30) NOT NULL,
	Surname VARCHAR(30) NOT NULL,
	Sex VARCHAR(6) NOT NULL,
	DateOfBirth DATE NOT NULL,
	HomeAddress VARCHAR(50) NOT NULL,
	City VARCHAR(50) NOT NULL,
	Postcode VARCHAR(8) NOT NULL,
	Email VARCHAR(50) NOT NULL,
	PhoneNo VARCHAR(15) NOT NULL,
	JobContract VARCHAR(15) NOT NULL,
	JobPosition VARCHAR(30) NOT NULL,
	Salary NUMERIC(10, 2) NOT NULL,
	DateJoined DATE NOT NULL

	CONSTRAINT [PK_StaffID] PRIMARY KEY ([StaffID])
)

INSERT INTO Staff VALUES('0001', 'John', 'Shepherd', 'Male', '30-SEP-1985', '170 Salmon Street', 'Newtown', 'BT48 3JH', 'johnshepherd97@gmail.com', '07886549322', 'Full-Time', 'Management', 30000,'10-APR-2012')
INSERT INTO Staff VALUES('0002', 'Diane', 'Shepherd', 'Female', '30-SEP-1987', '170 Salmon Street', 'Newtown', 'BT48 3JH', 'dianeshepherd11@gmail.com', '07659982312', 'Full-Time', 'Administration', 30000,'10-APR-2012')
INSERT INTO Staff VALUES('0003', 'Elaine', 'West', 'Female', '30-SEP-1986', '14 Fulford Road', 'Letterkenny', 'CH86 4BP', 'ewest721@gmail.com', '07721637644', 'Full-Time', 'Grooming', 24000,'23-JAN-2013')
INSERT INTO Staff VALUES('0004', 'Richard', 'Harrison', 'Male', '30-SEP-1982', '73 Crown Street', 'Newtown', 'SW18 6SD', 'richardh45@gmail.com', '07761098905', 'Full-Time', 'Grooming', 24000,'03-JUN-2013')
INSERT INTO Staff VALUES('0005', 'Jane', 'O''Gallagher', 'Female', '30-SEP-1996', '69 Jesmond Road', 'Belfast', 'KW90 4RW', 'janeogallagher897@gmail.com', '07840045271', 'Part-Time', 'Grooming', 10000,'30-MAY-2015')

CREATE TABLE Options (
	ServiceOptionNo VARCHAR(15) NOT NULL,
	ServiceOptionDescription VARCHAR(100) NOT NULL,
	Duration TIME(1) NOT NULL,
	Price NUMERIC(5, 2) NOT NULL

	CONSTRAINT [PK_ServiceOption] PRIMARY KEY ([ServiceOptionNo])
)

INSERT INTO Options VALUES('Option 1', 'Wash, shampoo and brush', '00:30', 19.99)
INSERT INTO Options VALUES('Option 2', 'Wash, shampoo, brush and trim', '01:00', 29.99)
INSERT INTO Options VALUES('Option 3', 'Wash, shampoo, brush and full cut', '01:30', 39.99)

CREATE TABLE Booking (
	BookingNo VARCHAR(4) NOT NULL,
	DogID VARCHAR(4) NOT NULL,
	AppointmentDate DATE NOT NULL,
	StartTime TIME(1) NOT NULL,
	ServiceOptionNo VARCHAR(15) NOT NULL,
	ExtraOption BIT NOT NULL,
	StaffID VARCHAR(4) NOT NULL,
	DateCreated DATE NOT NULL

	CONSTRAINT [PK_BookingNo] PRIMARY KEY ([BookingNo]),
	CONSTRAINT [FK_DogID-2] FOREIGN KEY (DogID) REFERENCES [Dog]([DogID]),
	CONSTRAINT [FK_ServiceOption] FOREIGN KEY (ServiceOptionNo) REFERENCES [Options]([ServiceOptionNo]),
	CONSTRAINT [FK_StaffID] FOREIGN KEY (StaffID) REFERENCES [Staff]([StaffID])
)

INSERT INTO Booking VALUES('0001', '0001', '31-JAN-2020', '13:30', 'Option 1', 0, '0004', '01-JAN-2020')
INSERT INTO Booking VALUES('0002', '0003', '14-FEB-2020', '10:00', 'Option 2', 0, '0005', '25-JAN-2020')
INSERT INTO Booking VALUES('0003', '0004', '27-FEB-2020', '12:00', 'Option 2', 1, '0005', '30-DEC-2019')
INSERT INTO Booking VALUES('0004', '0005', '17-MAR-2020', '12:15', 'Option 3', 1, '0003', '10-MAR-2020')
INSERT INTO Booking VALUES('0005', '0005', '24-MAR-2020', '14:45', 'Option 3', 1, '0003', '10-MAR-2020')
INSERT INTO Booking VALUES('0006', '0006', '20-MAR-2020', '15:30', 'Option 3', 1, '0003', '10-MAR-2020')
INSERT INTO Booking VALUES('0007', '0004', '03-APR-2020', '09:45', 'Option 1', 0, '0004', '13-MAR-2020')

CREATE TABLE Payment (
	PaymentNo VARCHAR(4) NOT NULL,
	BookingNo VARCHAR(4) NOT NULL,
	PaymentDate DATE,
	AmountDue NUMERIC(5, 2),
	PaymentMethod VARCHAR(20),
	CardNumber VARCHAR(16),
	SecurityCode VARCHAR(3),
	Paid BIT NOT NULL

	CONSTRAINT [PK_PaymentNo] PRIMARY KEY ([PaymentNo]),
	CONSTRAINT [FK_BookingNo] FOREIGN KEY (BookingNo) REFERENCES [Booking]([BookingNo])
)

INSERT INTO Payment VALUES('0001', '0001', '01-JAN-2020', 19.99, 'Cash', NULL, NULL, 1)
INSERT INTO Payment VALUES('0002', '0002', '13-FEB-2020', 29.99, 'Credit Card', '5784265411579987', '256', 1)
INSERT INTO Payment VALUES('0003', '0003', NULL, 39.99, NULL, NULL, NULL, 0)
INSERT INTO Payment VALUES('0004', '0004', '10-MAR-2020', 49.99, 'Debit Card', '2254875966584441', '447', 1)
INSERT INTO Payment VALUES('0005', '0005', '10-MAR-2020', 49.99, 'Debit Card', '2254875966584441', '447', 1)
INSERT INTO Payment VALUES('0006', '0006', '10-MAR-2020', 49.99, 'Debit Card', '2254875966584441', '447', 1)
INSERT INTO Payment VALUES('0007', '0007', NULL, 19.99, NULL, NULL, NULL, 0)
