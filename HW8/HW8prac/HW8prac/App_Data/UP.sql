
CREATE TABLE dbo.Artists
(
		ArtistID INT Identity(1,1) NOT NULL,
		ArtistName NVARCHAR(50) NOT NULL,
		DOB Nvarchar(64) NOT NULL,
		BirthCity NVARCHAR(50) NOT NULL,
		Constraint [PK_dbo.Artists] Primary KEY clustered (ArtistID ASC)
		--PRIMARY KEY (ArtistName ASC)

);


CREATE TABLE dbo.ArtWorks
(
	ArtWorkID INT Identity (1,1) NOT NULL,
	Title NVarchar(50) NOT NULL,
	ArtistID INT NOT NULL,
	Constraint [PK_dbo.ArtWorks] Primary key clustered (ArtWorkID Asc),
	Constraint [FK_dbo.ArtWorks_Artists] Foreign Key (ArtistID) References dbo.Artists(ArtistID)
	--PRIMARY KEY (Title ASC),
	--FOREIGN KEY(ArtistName) REFERENCES Artist(ArtistName)
);


CREATE TABLE dbo.Genres
(
	GenreID INT Identity (1,1) NOT NULL,
	GenreName NVARCHAR(40) NOT NULL,
	CONSTRAINT [PK_dbo.Genres] PRIMARY KEY CLUSTERED (GenreID ASC)
);


CREATE TABLE dbo.Classifications
(
	ClassificationID int Identity(1,1) NOT NULL,
	ArtWorkID INT NOT NULL,
	GenreID INT NOT NULL,
	CONSTRAINT [PK_dbo.Classifications] PRIMARY KEY CLUSTERED (ClassificationID ASC),
	CONSTRAINT [FK_dbo.ArtWorks_Classifications] FOREIGN KEY (ArtWorkID) REFERENCES dbo.ArtWorks(ArtWorkID),
	CONSTRAINT [FK_dbo.Genre_Classifications] FOREIGN KEY (GenreID) REFERENCES dbo.Genres(GenreID)
);

INSERT INTO dbo.Artists
(
	ArtistName,
	DOB,
	BirthCity
)
VALUES
	('MC Escher','06/17/1898', 'Leeuwarden, Netherlands' ),
	('Leonardo Da Vinci', '05/021519', 'Vinci, Italy'),
	('Hatip Mehmed Efendi','11/18/1680','Unknown'),
	('Salvador Dali','05/11/1904','Figueres, Spain');

INSERT INTO dbo.Genres
(
    GenreName
)
VALUES
('Tesselation'),
('Surrealism'),
('Portrait'),
('Renaissance');

INSERT INTO dbo.ArtWorks
(
	Title,
	ArtistID
)
VALUES
	('Circle Limit III', '1'),
	('Twon Tree', '1'),
	('Mona Lisa', '2'),
	('The Vitruvian Man','2'),
	('Ebru','3'),
	('Honey Is Sweeter Than Blood','4');

INSERT INTO dbo.Classifications
(
    ArtWorkID,
    GenreID
)
VALUES
( '1', '1' ),
( '2', '1' ),
( '2', '2' ),
( '3', '3' ),
( '3', '4' ),
( '4', '4' ),
( '5', '4' ),
( '6', '2' );
GO