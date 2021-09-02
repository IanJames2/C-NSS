-------------------------------------------------------------------Investigating the Data-------------------------------------------------------------------
--Query the PoKi database using SQL SELECT statements to answer the following questions.

--What grades are stored in the database?
--SELECT * FROM Grade

--What emotions may be associated with a poem?
--SELECT * FROM Emotion

--How many poems are in the database?
--SELECT Count(Poem.Id) FROM Poem

--Sort authors alphabetically by name. What are the names of the top 76 authors?
--SELECT * FROM Author ORDER BY Author.Name

--Starting with the above query, add the grade of each of the authors.
--SELECT Author.Name, Grade.Name FROM Author INNER JOIN Grade ON Author.GradeId = Grade.Id ORDER BY Author.Name

--Starting with the above query, add the recorded gender of each of the authors.
--SELECT Author.Name, Grade.Name, Gender.Name FROM Author 
--INNER JOIN Grade ON Author.GradeId = Grade.Id
--INNER JOIN Gender ON Author.GenderId = Gender.Id 



--What is the total number of words in all poems in the database?
--SELECT SUM(WordCount) FROM Poem 

--Which poem has the fewest characters?
--SELECT Poem.Title, Poem.CharCount FROM Poem ORDER BY CharCount ASC

--How many authors are in the third grade?
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 3;

--How many total authors are in the first through third grades?
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 1;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 2;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 3;


--What is the total number of poems written by fourth graders?
--SELECT Count(Poem.Id) FROM Poem INNER JOIN Author ON Poem.AuthorId = Author.Id WHERE GradeId = 4;

--How many poems are there per grade?
--SELECT * FROM Grade
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 1;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 2;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 3;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 4;
--SELECT SUM(Author.GradeId) FROM Author WHERE GradeId = 5;

--How many authors are in each grade? (Order your results by grade starting with 1st Grade)
--🚫
--SELECT * FROM Author ORDER BY Author.GradeId ASC

--What is the title of the poem that has the most words?
--SELECT Poem.Title, Poem.WordCount FROM Poem ORDER BY Poem.WordCount DESC

--Which author(s) have the most poems? (Remember authors can have the same name.)
--🚫
--SELECT Author.Name, Poem.Title, Sum(Poem.Id) FROM Poem INNER JOIN Author ON Author.Id = Poem.AuthorId

--How many poems have an emotion of sadness?
--SELECT * FROM PoemEmotion
--SELECT Emotion.Name FROM Emotion
--SELECT Sum(PoemEmotion.Id) FROM PoemEmotion WHERE EmotionId = 3

--How many poems are not associated with any emotion?
--Which emotion is associated with the least number of poems?
--Which grade has the largest number of poems with an emotion of joy?
--Which gender has the least number of poems with an emotion of fear?