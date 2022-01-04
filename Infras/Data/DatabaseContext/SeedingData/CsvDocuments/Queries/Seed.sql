USE svietnam_1_1;
BULK INSERT DocumentTypes
FROM '/home/p/Desktop/svietnam/svietnamAPI/Infras/Data/DatabaseContext/SeedingData/CsvDocuments/Core/DocumentTypes.csv'
WITH
(
	CODEPAGE='RAW',
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


