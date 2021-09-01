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

