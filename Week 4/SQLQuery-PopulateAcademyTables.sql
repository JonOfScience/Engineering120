
/*
CREATE TABLE Spartans (
	Id INT PRIMARY KEY IDENTITY,
	Title VARCHAR(4) NOT NULL,
	FirstName VARCHAR(20) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	Course VARCHAR(20) DEFAULT NULL,
	GradeAchieved VARCHAR(20) DEFAULT NULL,
	CityOfResidence VARCHAR(20) NOT NULL,
	DateJoined DATE NOT NULL,
	Stream INT NOT NULL,
	HasGraduated BIT DEFAULT 0,
	IsOnSite BIT DEFAULT 0,
	OnSiteAt INT DEFAULT NULL
);
*/

-- INSERT INTO Stream ( Name ) VALUES ( 'C# SDET' );
-- INSERT INTO Stream ( Name ) VALUES ( 'C# DEV' );

/*
INSERT INTO Spartans 
(
	Title, FirstName, LastName, CityOfResidence, DateJoined, Stream
) VALUES 
( 
	-- 'Dr', 'Jonathan', 'Crofts', 'London', '2022-06-27', 1
	-- 'Mr', 'Kai', 'Chan', 'London', '2022-06-27', 1
)
*/


/*
INSERT INTO Trainer
(
	Title, FirstName, LastName
) VALUES 
	('Ms', 'Cathy', 'French'),
	('Mr', 'Nishant', 'Mandal'),
	('Mr', 'Peter', 'Bellaby');
*/

/*
INSERT INTO SpartanTrainers
( 
	SpartanId, TrainerId
) VALUES
(1, 2),
(2, 2);
*/

-- Non-graduated Spartans
/*
SELECT
	Title + ' ' + FirstName + ' ' + LastName AS 'Full Name',
	st.Name
FROM Spartans spa
JOIN Stream st
ON spa.Stream = st.Id
WHERE HasGraduated = 0;
*/

-- Non-graduated Spartans by stream (TAQ: What capacity does Sparta have in train for each stream?)
/*
SELECT
	st.Name AS 'Stream Name',
	COUNT(spa.Id) AS 'Current Trainees'
FROM Spartans spa
JOIN Stream st
ON spa.Stream = st.Id
WHERE HasGraduated = 0
GROUP BY st.Name;
*/

-- Report for telling what to recruit

SELECT
	st.Name as 'Stream Name',
	COUNT(spa.Id) AS 'Current Trainees',
	CASE
		WHEN COUNT(spa.Id) < 1 THEN 'Get ' + st.Name + 's!'
		WHEN COUNT(spa.ID) < 10 THEN 'Advertise for ' + st.Name + 's.'
		ELSE 'No need to recruit ' + st.Name + 's.'
	END AS 'Recruitment Action'
FROM Stream st
LEFT JOIN Spartans spa
ON st.Id = spa.Stream
GROUP BY st.Name

/*
SELECT
	st.Name AS 'Stream Name',
	COUNT(spa.Id) AS 'Current Trainees',
	CASE
		WHEN COUNT(spa.Id) < 1 THEN 'Get ' + st.Name + 's!'
		WHEN COUNT(spa.ID) < 10 THEN 'Advertise for ' + st.Name + 's.'
		ELSE 'No need to recruit ' + st.Name + 's.'
	END AS 'Recruitment Action'
FROM Spartans spa
JOIN Stream st
ON spa.Stream = st.Id
WHERE HasGraduated = 0
GROUP BY st.Name;
*/

-- (Non-graduated) Spartans by Trainer (TAQ: Who has a heavy workload? OR Who has extra capacity?)
/*
SELECT tra.Title + ' ' + tra.FirstName + ' ' + tra.LastName AS "Trainer Name", COUNT(spa.Id) AS "Trainees"
FROM Spartans spa
JOIN SpartanTrainers spat
ON spa.Id = spat.SpartanId
JOIN Trainer tra
ON tra.Id = spat.TrainerId
WHERE spa.HasGraduated = 0
GROUP BY tra.Title + ' ' + tra.FirstName + ' ' + tra.LastName;
*/
