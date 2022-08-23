CREATE VIEW ClientBookings
AS SELECT C.ClientID, C.Surname, C.Forename, B.DateCreated FROM Client C JOIN Dog D ON C.ClientID = D.ClientID JOIN Booking B ON D.DogID = B.DogID