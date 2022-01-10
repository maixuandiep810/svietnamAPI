--
--
--
--
-- CORE
--
--
--
--
USE svietnam_1_1;
BULK INSERT EntityTypes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/EntityTypes.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT DataTypes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/DataTypes.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT EntityStatuses
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/EntityStatus.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT DocumentTypes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/DocumentTypes.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Documents
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/Documents.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Provinces
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/Provinces.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Districts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/Districts.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Communes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/Communes.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Addresses
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/Addresses.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
-- 
-- 
-- 
-- 
-- EAV
-- 
-- 
-- 
-- 
USE svietnam_1_1;
BULK INSERT EavAttributeGroups
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributeGroups.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT EavAttributes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributes.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT EavAttributeSets
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributeSets.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT EavAttributeEavAttributeSetMappings
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributeEavAttributeSetMappings.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT EavAttributeValues
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributeValues.csv'
WITH
(
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
-- 
-- 
-- 
-- 
-- CATALOG
-- 
-- 
-- 
-- 
USE svietnam_1_1;
BULK INSERT Categories
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/Categories.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Manufacturers
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/Manufacturers.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Suppliers
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/Suppliers.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT Products
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/Products.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT ProductItems
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/ProductItems.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);
USE svietnam_1_1;
BULK INSERT ProductItemDetails
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Catalog/ProductItemDetails.csv'
WITH
(
--	DATAFILETYPE = 'char',
--	CODEPAGE='RAW',
	KEEPIDENTITY,
    FIRSTROW = 2, -- as 1st one is header
    FIELDQUOTE = '"',
    FIELDTERMINATOR = ',',  --CSV field delimiter
    ROWTERMINATOR = '\n',   --Use to shift the control to next row
    TABLOCK
);


