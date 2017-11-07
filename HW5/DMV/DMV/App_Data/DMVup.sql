CREATE TABLE dbo.People
(
	ID	INT IDENTITY(1,1) NOT NULL,
	DOB DateTime NOT NULL,
	FullName NVARCHAR(64) NOT NULL,
	rAddress NVARCHAR(100) NOT NULL,
	CSZ NVARCHAR(50) NOT NULL,
	County NVARCHAR(50) NOT NULL,
	nAddress NVARCHAR(100)  NULL,
	nCSZ NVARCHAR(50)  NULL,
	nCounty NVARCHAR(50)  NULL,
	sDate DateTime NOT NULL,

	CONSTRAINT [PK_dbo.People] PRIMARY KEY CLUSTERED (ID ASC)
);
GO

INSERT INTO dbo.People (DOB, FullName, rAddress, CSZ, County, nAddress, nCSZ, nCounty, sDate) VALUES
('04/12/1995', 'Slade, Rahevin', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland',GETDATE()),
('04/12/1995', 'Slade II, Rahevin', '42 Privet', 'Made up city, Fantasy, 42', 'Wonderland', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland',GETDATE()),
('04/12/1995', 'Slade, Sahegin', '43 Springfield', 'Made up city, Fantasy, 42', 'Imaginationland', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland',GETDATE()),
('04/12/1995', 'Slade, Darth', 'Death Star', 'Space', 'SpAce?', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland',GETDATE()),
('04/12/1995', 'Slade, Dane', '64+1 more', 'Math Ville', 'Imaginationland', '41 Privet Dr.', 'Made up city, Fantasy, 42', 'Imaginationland',GETDATE());
GO

