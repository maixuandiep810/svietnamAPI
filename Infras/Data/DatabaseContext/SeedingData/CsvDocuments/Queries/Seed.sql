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
BULK INSERT Core_EntityTypeConsts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/EntityTypeConsts.csv'
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
BULK INSERT Core_DataTypeConsts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/DataTypeConsts.csv'
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
BULK INSERT Core_EntityStatusConsts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/EntityStatusConsts.csv'
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
BULK INSERT Core_DocumentTypeConsts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/DocumentTypeConsts.csv'
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
BULK INSERT Core_Documents
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
BULK INSERT Core_Provinces
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
BULK INSERT Core_Districts
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
BULK INSERT Core_Communes
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
BULK INSERT Core_Addresses
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
BULK INSERT Eav_EavAttributeGroupConsts
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Eav/EavAttributeGroupConsts.csv'
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
BULK INSERT Eav_EavAttributes
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
BULK INSERT Eav_EavAttributeSets
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
BULK INSERT Eav_EavAttributeEavAttributeSetMappings
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
BULK INSERT Eav_EavAttributeValues
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
BULK INSERT Catalog_Categories
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
BULK INSERT Catalog_Manufacturers
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
BULK INSERT Catalog_Suppliers
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
BULK INSERT Catalog_Products
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
BULK INSERT Catalog_ProductItems
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
BULK INSERT Catalog_ProductItemDetails
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


