use acc_Task_Cinema;
SELECT * FROM Movie;

INSERT INTO Ticket (TicketID, ShowtimeID, SeatNumber, PurchasedDateTime, CustomerID)
VALUES
    (4, 1, 'A1', '2023-01-01 17:30:00', 1);

INSERT INTO Review (ReviewID, MovieID, CustomerID, ReviewText, Rating, ReviewDate)
VALUES
    (1, 1, 1, 'Great movie!', 5, '2023-01-02 10:00:00'),
    (2, 2, 2, 'Enjoyed it!', 4, '2023-02-10 10:30:00'),
    (3, 3, 1, 'Not my favorite.', 2, '2023-03-12 09:15:00');


CREATE VIEW FilmsInProgrammation AS
SELECT Title, DurationMinutes,ReleaseDate FROM Movie
JOIN Showtime ON Movie.MovieID = Showtime.MovieID

CREATE VIEW AvailableSeatsForShow AS
SELECT Theater.Capacity as totali, (Theater.Capacity - COUNT(Ticket.TicketID)) as postiDIS FROM Theater
JOIN Showtime ON Theater.TheaterID = Showtime.TheaterID
JOIN Movie ON Showtime.MovieID = Movie.MovieID
JOIN Ticket ON Showtime.ShowtimeID = Ticket.ShowtimeID
GROUP BY Theater.TheaterID, Theater.Capacity;


CREATE VIEW TotalEarningsPerMovie AS
SELECT Title AS Titolo, SUM(Price) AS 'Totale Generato' FROM Movie
JOIN Showtime ON Movie.MovieID = Showtime.MovieID
JOIN Ticket ON Showtime.ShowtimeID = Ticket.ShowtimeID
GROUP BY Title

CREATE VIEW RecentReviews AS
SELECT Title, Review.Rating, ReviewText,ReviewDate FROM Review
JOIN Movie ON Review.MovieID = Movie.MovieID



--Creare una stored procedure PurchaseTicket che permetta di acquistare un biglietto per uno
--spettacolo, specificando l'ID dello spettacolo, il numero del posto e l'ID del cliente. La procedura
--dovrebbe verificare la disponibilità del posto e registrare l'acquisto.

CREATE PROCEDURE PurchaseTicket 
@idSpett INT,
@numPost VARCHAR(10),
@idCli INT
AS
BEGIN
DECLARE @dispo INT;

SELECT @dispo= (Theater.Capacity - COUNT(Ticket.TicketID)) FROM Theater
JOIN Showtime ON Theater.TheaterID = Showtime.TheaterID
JOIN Movie ON Showtime.MovieID = Movie.MovieID
JOIN Ticket ON Showtime.ShowtimeID = Ticket.ShowtimeID
WHERE Showtime.ShowtimeID = 1
GROUP BY Theater.TheaterID, Theater.Capacity;
BEGIN TRY
		BEGIN TRANSACTION
		IF @dispo > 0
			INSERT INTO Ticket (TicketID, ShowtimeID, SeatNumber, PurchasedDateTime, CustomerID)
			VALUES
			(@@Identity+1, @idSpett, @numPost, CURRENT_TIMESTAMP, @idCli);
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT 'Errore riscontrato' + ERROR_MESSAGE();
	END CATCH


END;

--Implementare una stored procedure UpdateMovieSchedule che permetta di aggiornare gli orari
--degli spettacoli per un determinato film. Questo include la possibilità di aggiungere o rimuovere
--spettacoli dall'agenda.

CREATE PROCEDURE UpdateMovieSchedule
@newDate DATETIME,
@filmID INT
AS
BEGIN




BEGIN TRY
		BEGIN TRANSACTION

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
		ROLLBACK TRANSACTION
		PRINT 'Errore riscontrato' + ERROR_MESSAGE();
	END CATCH


END;


