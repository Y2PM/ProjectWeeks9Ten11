DROP TABLE [ECommerceProjectSystem].[dbo].[items]

CREATE TABLE [ECommerceProjectSystem].[dbo].[items]
(
item_name varchar(255) NOT NULL PRIMARY KEY,
item_price decimal(10,2)
); 

INSERT INTO [ECommerceProjectSystem].[dbo].[items] (item_name, item_price) VALUES ('PocketWormHole', 50)
INSERT INTO [ECommerceProjectSystem].[dbo].[items] (item_name, item_price) VALUES ('NuclearWinterGenerator', 2000)
GO
