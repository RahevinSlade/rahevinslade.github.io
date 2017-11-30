
CREATE TABLE dbo.Artist
(
		ArtistName NVARCHAR(50) NOT NULL,
		DOB DATE NOT NULL,
		BirthCity NVARCHAR(50) NOT NULL,
		Constraint [PK_dbo.ArtistName] Primary KEY clustered (ArtistName ASC)
		--PRIMARY KEY (ArtistName ASC)

);


CREATE TABLE dbo.ArtWork
(
	Title NVarchar(50) NOT NULL,
	ArtistName NVarchar(50) NOT NULL,
	Constraint [PK_dbo.Title] Primary key clustered (Title Asc),
	Constraint [FK_dbo.ArtistName] Foreign Key (ArtistName) References dbo.Artist(ArtistName)
	--PRIMARY KEY (Title ASC),
	--FOREIGN KEY(ArtistName) REFERENCES Artist(ArtistName)
);


CREATE TABLE dbo.Genre
(
	GenreName NVARCHAR(40) NOT NULL,
	CONSTRAINT [PK_dbo.Genre] PRIMARY KEY CLUSTERED (GenreName ASC)
);


CREATE TABLE dbo.Classification
(
	Title NVarchar(50) NOT NULL,
	Genre NVARCHAR(40) NOT NULL,
	CONSTRAINT [PK_dbo.Artwork_Genre] PRIMARY KEY CLUSTERED (Title, Genre ASC),
	CONSTRAINT [FK_dbo.ArtWork] FOREIGN KEY (Title) REFERENCES dbo.ArtWork(Title),
	CONSTRAINT [FK_dbo.Genre] FOREIGN KEY (Genre) REFERENCES dbo.Genre(GenreName)
);

INSERT INTO dbo.Artist
(
	ArtistName,
	DOB,
	BirthCity
)
VALUES
	('MC Escher','06/17/1898', 'Leeuwarden, Netherlands' ),
	('Leonardo Da Vinci', '05/02/1519', 'Vinci, Italy'),
	('Hatip Mehmed Efendi','11/18/1680','Unknown'),
	('Salvador Dali','05/11/1904','Figueres, Spain');

INSERT INTO dbo.Genre
(
    GenreName
)
VALUES
('Tesselation'),
('Surrealism'),
('Portrait'),
('Renaissance');

INSERT INTO dbo.ArtWork
(
	Title,
	ArtistName
)
VALUES
	('Circle Limit III', 'MC Escher'),
	('Twon Tree', 'MC Escher'),
	('Mona Lisa', 'Leonardo Da Vinci'),
	('The Vitruvian Man','Leonardo Da Vinci'),
	('Ebru','Hatip Mehmed Efendi'),
	('Honey Is Sweeter Than Blood','Salvador Dali');

INSERT INTO dbo.Classification
(
    Title,
    Genre
)
VALUES
( 'Circle Limit III', 'Tesselation' ),
( 'Twon Tree', 'Tesselation' ),
( 'Twon Tree', 'Surrealism' ),
( 'Mona Lisa', 'Portrait' ),
( 'Mona Lisa', 'Renaissance' ),
( 'The Vitruvian Man', 'Renaissance' ),
( 'Ebru', 'Tesselation' ),
( 'Honey Is Sweeter Than Blood', 'Surrealism' );
GO