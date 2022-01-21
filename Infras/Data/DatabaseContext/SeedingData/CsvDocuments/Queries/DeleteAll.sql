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
DELETE FROM svietnam_1_1.dbo.Core_EntityTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_DataTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_EntityStatuses WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_DocumentTypes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_Documents WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_Communes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_Districts WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_Provinces WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Core_Addresses WHERE 1=1;
--
--
--
--
-- Eav
--
--
--
--
DELETE FROM svietnam_1_1.dbo.Eav_EavAttributeGroups WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Eav_EavAttributes WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Eav_EavAttributeSets WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Eav_EavAttributeEavAttributeSetMappings WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Eav_EavAttributeValues WHERE 1=1;
--
--
--
--
-- Catalog
--
--
--
--

DELETE FROM svietnam_1_1.dbo.Catalog_Categories WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Catalog_Manufacturers WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Catalog_Suppliers WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Catalog_Products WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Catalog_ProductItems WHERE 1=1;
DELETE FROM svietnam_1_1.dbo.Catalog_ProductItemDetail WHERE 1=1;

