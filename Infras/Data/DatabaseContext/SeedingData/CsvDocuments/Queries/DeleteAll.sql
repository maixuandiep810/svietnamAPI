USE svietnam_1_1;
--
--
--
--
-- CORE
--
--
--
--
DELETE FROM svietnam_1_1.dbo.EntityTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.DataTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.EntityStatuses WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.DocumentTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Documents WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Communes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Districts WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Provinces WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Addresses WHERE 1=1;
--
--
--
--
-- Eav
--
--
--
--
DELETE FROM svietnam_1_1.dbo.EavAttributeGroups WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.EavAttributes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.EavAttributeSets WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.EavAttributeEavAttributeSetMappings WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.EavAttributeValues WHERE 1=1;
--
--
--
--
-- Catalog
--
--
--
--

DELETE FROM svietnam_1_1.dbo.Categories WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Manufacturers WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Suppliers WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Products WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.ProductItems WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.ProductItemDetail WHERE 1=1;

