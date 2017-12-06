
Create Table dbo.Buyers
(
	BuyerID INT Identity (1,1) Not Null,
	Buyername Nvarchar(64) Not Null,
	Constraint [PK_dbo.Buyers] Primary Key clustered (BuyerID Asc)
);

Create Table dbo.Sellers
(
	SellerID INT Identity (1,1) Not Null,
	Sellername Nvarchar(64) Not Null,
	Constraint [PK_dbo.Sellers] Primary Key clustered (SellerID Asc)
);

Create Table dbo.Items
(
	ItemID Int Identity (1001,1) Not null,
	ItemName Nvarchar(64) Not null,
	ItemDescription nvarchar(200) not null,
	SellerID int Not null,
	Constraint [PK_dbo.Items] Primary Key clustered (ItemID Asc),
	Constraint [FK_dbo.Items_Sellers] Foreign Key (SellerID) References dbo.Sellers(SellerID)
);

Create Table dbo.Bids
(
	BidID int identity(1,1) not null,
	ItemID Int Not null,
	BuyerID Int Not null,
	Price Int not null,
	Stamp DateTime not null,
	Constraint [PK_dbo.Bids] primary key clustered (Price Desc),
	constraint [FK_dbo.Items_Bids] Foreign key (ItemID) References dbo.Items(ItemID),
	Constraint [FK_dbo.Buyers_Bids] Foreign key (BuyerID) References dbo.Buyers(BuyerID)
);

Insert into dbo.Buyers
(
	Buyername
) 
Values 
('Jane Stone'),
('Tom McMasters'),
('Otto Vanderwall');

Insert into dbo.Sellers
(
Sellername) 
Values 
('Gayle Hardy'),
('Lyle Banks'),
('Pearl Greene');

Insert into dbo.Items
(
	ItemName,
	ItemDescription,
	SellerID
 ) 
 Values 
('Abraham Lincoln Hammer'    ,'A bench mallet fashioned from a broken rail-splitting maul in 1829 and owned by Abraham Lincoln','3'),
('Albert Einsteins Telescope','A brass telescope owned by Albert Einstein in Germany, circa 1927','1'),
('Bob Dylan Love Poems'      ,'Five versions of an original unpublished, handwritten, love poem by Bob Dylan','2');

Insert Into dbo.Bids
(
	ItemID,
	BuyerID,
	Price,
	Stamp
 ) 
 Values 
 ('1001','3','250000','12/04/2017 09:04:22'),
 ('1003','1','95000','12/04/2017 08:44:03');
GO