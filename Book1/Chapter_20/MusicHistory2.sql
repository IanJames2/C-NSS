--------------------------------------------------------------------------------------------------NOTES-----------------------------------------------------------------------------------------------------------------------

--SELECT * FROM Genre

--SELECT * FROM Artist a ORDER BY a.ArtistName

--SELECT * FROM Song INNER JOIN Artist
--	ON Song.ArtistId = Song.Id;

--SELECT * FROM Song WHERE ArtistID > 0

--INSERT INTO Genre (Name) VALUES ('Soul');
--INSERT INTO Artist (ArtistName, YearEstablished) VALUES ('Judas Priest', 1969);
--INSERT INTO Album (Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId) VALUES ('The Black Album', '11/14/2003', 2268, 'Def Jam', 27, 13);
--INSERT INTO Song (Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId) VALUES ('Revenge', 61, '12/03/1982', 9, 8, 22);

--SELECT * FROM Song INCLUDE ...

--SELECT Title from Song WHERE Id= 1;
--UPDATE Song SET Title = "Walmart" WHERE Id = 1;
--SELECT Title FROM Song WHERE Id = 1;

--SELECT g.Name
--FROM Genre g
--JOIN Album a on a.GenreId = g.id 
--WHERE g.Name = Soul;

--SELECT Title, ReleaseDate, Label 
--FROM Album
--WHERE AlbumLength < 2000
--ORDER BY Title DESC

--INSERT INTO Album
--(Title, ReleaseDate, Label, AlbumLength, ArtistId, GenreId)
--VALUES
--('War', '10/22/1983', 'Island Records', 354546, 18, 2);

--UPDATE Album 
--SET ReleaseDate = '10/10/1983'
--WHERE Id = 23;

--DELETE FROM Album
--WHERE Title = 'War';


--SELECT ArtistName
--FROM Artist
--WHERE Id = 18

--SELECT Title, ReleaseDate, ArtistName
--FROM Album
--INNER JOIN Artist
--ON Album.ArtistId = Artist.Id
--WHERE Title = 'War'

--SELECT Title, ReleaseDate, ArtisitName, Name
--FROM Album
--INNER JOIN Artist
--ON Album.ArtistId = Artist.Id
--INNER JOIN Genre
--ON Album.GenreId = Genre.Id;

--------------------------------------------------------------------------------------------------INTRO-----------------------------------------------------------------------------------------------------------------------

--1
--SELECT * FROM Genre


--2
--SELECT * FROM Artist a ORDER BY a.ArtistName


--3
--Select * FROM Song JOIN Artist ON (Song.Id = Song.ArtistId)

--4 Write a SELECT query that lists all the Artists that have a Soul Album
--Select * FROM Artist INNER JOIN Album
--	ON Artist.Id = Album.ArtistId
--	WHERE GenreId = 1;

--5 Write a SELECT query that lists all the Artists that have a Jazz or Rock Album
--Select * FROM Artist INNER JOIN Album
--	ON Artist.Id = Album.ArtistId
--	WHERE GenreId = 2;

--Select * FROM Artist INNER JOIN Album
--	ON Artist.Id = Album.ArtistId
--	WHERE GenreId = 4;

--6 Write a SELECT statement that lists the Albums with no songs
--SELECT AlbumId FROM Song WHERE SongLength = 0;

--7 Using the INSERT statement, add one of your favorite artists to the Artist table.
--INSERT INTO Artist (ArtistName, YearEstablished) VALUES ('GHerbo', 1995);

--8 Using the INSERT statement, add one, or more, albums by your artist to the Album table.
--INSERT INTO Album (Title, ReleaseDate, AlbumLength, Label, ArtistId, GenreId) VALUES ('25', '08/01/2021', 3000, 'Def Jam', 28, 13);

--9 Using the INSERT statement, add some songs that are on that album to the Song table.
--INSERT INTO Song (Title, SongLength, ReleaseDate, GenreId, ArtistId, AlbumId) VALUES ('Drill', 245, '08/01/2021', 13, 28, 22);

--10 Write a SELECT query that provides the song titles, album title, and artist name for all of the data you just entered in. Use the LEFT JOIN keyword sequence to connect the tables, and the WHERE keyword to filter the results to the album and artist you added.
--SELECT Song.Title, Album.Title, Artist.ArtistName FROM Song 
--	INNER JOIN Album
--	ON Song.AlbumId = Album.Id
--	INNER JOIN Artist 
--	ON Song.ArtistId = Artist.Id

--NOTE: Direction of join matters. Try the following statements and see the difference in results.

--SELECT a.Title, s.Title FROM Album a LEFT JOIN Song s ON s.AlbumId = a.Id;
--SELECT a.Title, s.Title FROM Song s LEFT JOIN Album a ON s.AlbumId = a.Id;


--11 Write a SELECT statement to display how many songs exist for each album. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
--SELECT Count(id) FROM Song
--	GROUP BY AlbumId

--12 Write a SELECT statement to display how many songs exist for each artist. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
--SELECT Count(Song.Id) FROM Song GROUP BY ArtistId;

--13 Write a SELECT statement to display how many songs exist for each genre. You'll need to use the COUNT() function and the GROUP BY keyword sequence.
--SELECT Count(Song.Id) FROM Song GROUP BY GenreId

--14 Write a SELECT query that lists the Artists that have put out records on more than one record label. Hint: When using GROUP BY instead of using a WHERE clause, use the HAVING keyword
--🚫
--SELECT Artist.Name FROM Album INNER JOIN Artist
--	ON Album.ArtistId = Artist.Id
--	GROUP BY Album.Label

--15 Using MAX() function, write a select statement to find the album with the longest duration. The result should display the album title and the duration.
	--SELECT MAX(Album.AlbumLength) FROM Album 
	--SELECT Album.Title, Album.AlbumLength FROM Album 


--16 Using MAX() function, write a select statement to find the song with the longest duration. The result should display the song title and the duration.
	--SELECT MAX(Song.SongLength) FROM Song 
	--SELECT Song.Title, Song.SongLength FROM Song 

--17 Modify the previous query to also display the title of the album.
	--🚫
	--SELECT MAX(Song.SongLength), Album.Title FROM Album INNER JOIN Song
	--	ON Song.AlbumId = Album.Id
