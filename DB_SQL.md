
USE [master]
GO

// CREATE DATABASE WITH NAME [KTNDB]




/*
Navicat SQL Server Data Transfer

Source Server         : MSSQL_LOCAL
Source Server Version : 105000
Source Host           : localhost:1433
Source Database       : KTNDB
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 105000
File Encoding         : 65001

Date: 2016-04-22 11:46:34
*/


-- ----------------------------
-- Table structure for [dbo].[PERSONS]
-- ----------------------------
DROP TABLE [dbo].[PERSONS]
GO
CREATE TABLE [dbo].[PERSONS] (
[ID] int NOT NULL IDENTITY(1,1) ,
[FIRST_NAME] nvarchar(30) NOT NULL ,
[LAST_NAME] nvarchar(30) NOT NULL ,
[REGION_ID] int NOT NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[PERSONS]', RESEED, 100)
GO

-- ----------------------------
-- Records of PERSONS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[PERSONS] ON
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'1', N'Micah', N'Mcknight', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'2', N'Delilah', N'Barr', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'3', N'Malcolm', N'Finley', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'4', N'Elizabeth', N'Brock', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'5', N'Charlotte', N'Hickman', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'6', N'Adena', N'Carney', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'7', N'Alfonso', N'Gilbert', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'8', N'Brent', N'Michael', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'9', N'Alexandra', N'Eaton', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'10', N'Acton', N'Garcia', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'11', N'Cedric', N'Rivera', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'12', N'Giacomo', N'Chan', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'13', N'Joshua', N'Levine', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'14', N'Deirdre', N'Pollard', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'15', N'Halla', N'Petersen', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'16', N'Piper', N'Lawrence', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'17', N'Illiana', N'Weeks', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'18', N'Keane', N'Keller', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'19', N'Brennan', N'Owens', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'20', N'Wayne', N'Burton', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'21', N'Ahmed', N'Wynn', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'22', N'Stephen', N'Sanford', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'23', N'Hedwig', N'Harrell', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'24', N'Dora', N'Barry', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'25', N'Maggy', N'Parks', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'26', N'Clementine', N'Horton', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'27', N'Maryam', N'Marsh', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'28', N'Fatima', N'Shelton', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'29', N'Iona', N'Woodward', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'30', N'Tiger', N'Powers', N'76');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'31', N'Violet', N'Preston', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'32', N'Naida', N'Schneider', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'33', N'Jade', N'Hendrix', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'34', N'Lance', N'Butler', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'35', N'Ezra', N'Marks', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'36', N'Shelly', N'Collins', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'37', N'Nasim', N'Moon', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'38', N'Donna', N'Garner', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'39', N'Phoebe', N'Bradley', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'40', N'Kenneth', N'Saunders', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'41', N'Daryl', N'Nieves', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'42', N'Stephen', N'Dejesus', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'43', N'Hayden', N'West', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'44', N'Morgan', N'Gilbert', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'45', N'Yuri', N'Strong', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'46', N'Byron', N'Stokes', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'47', N'Tarik', N'Gutierrez', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'48', N'Jenette', N'Mccormick', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'49', N'Signe', N'Wade', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'50', N'Darryl', N'Martin', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'51', N'Tallulah', N'Anderson', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'52', N'Lisandra', N'Spears', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'53', N'Keegan', N'Mckenzie', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'54', N'Charles', N'Mendoza', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'55', N'Andrew', N'Day', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'56', N'Meghan', N'Gay', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'57', N'Francis', N'Hale', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'58', N'Kristen', N'Powers', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'59', N'Tara', N'Everett', N'77');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'60', N'Alec', N'Cummings', N'49');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'61', N'Eugenia', N'Nieves', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'62', N'Kiona', N'Hensley', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'63', N'Sasha', N'Hinton', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'64', N'Hamish', N'Atkins', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'65', N'Fulton', N'Mcintyre', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'66', N'Emily', N'Patrick', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'67', N'Aidan', N'Morin', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'68', N'Shelly', N'Steele', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'69', N'Graiden', N'Hendrix', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'70', N'Jessamine', N'Valenzuela', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'71', N'Dillon', N'Sims', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'72', N'Margaret', N'Henson', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'73', N'Jolie', N'Serrano', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'74', N'Dora', N'Weeks', N'81');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'75', N'Adria', N'Glenn', N'39');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'76', N'Micah', N'Stevens', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'77', N'MacKensie', N'Barton', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'78', N'Ulla', N'Banks', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'79', N'Simon', N'Chandler', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'80', N'Dai', N'Pacheco', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'81', N'Odysseus', N'Camacho', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'82', N'Barry', N'Fitzgerald', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'83', N'Ciaran', N'Kane', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'84', N'Benjamin', N'Knapp', N'95');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'85', N'Dominique', N'Acosta', N'38');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'86', N'Audrey', N'Shaffer', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'87', N'Sheila', N'Bond', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'88', N'Brynne', N'Crane', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'89', N'Otto', N'Banks', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'90', N'Laurel', N'Lynch', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'91', N'Maxwell', N'Ruiz', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'92', N'Anastasia', N'Mendoza', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'93', N'Hermione', N'Stephens', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'94', N'Illiana', N'Le', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'95', N'Melinda', N'Baxter', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'96', N'Georgia', N'Chapman', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'97', N'Rigel', N'Mason', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'98', N'Winter', N'Pierce', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'99', N'Nero', N'Benton', N'86');
GO
INSERT INTO [dbo].[PERSONS] ([ID], [FIRST_NAME], [LAST_NAME], [REGION_ID]) VALUES (N'100', N'Kylee', N'Winters', N'86');
GO
SET IDENTITY_INSERT [dbo].[PERSONS] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[REGIONS]
-- ----------------------------
DROP TABLE [dbo].[REGIONS]
GO
CREATE TABLE [dbo].[REGIONS] (
[ID] int NOT NULL IDENTITY(1,1) ,
[P_ID] int NULL ,
[REGION_NAME] nvarchar(60) NOT NULL ,
[LEVEL] tinyint NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[REGIONS]', RESEED, 100)
GO

-- ----------------------------
-- Records of REGIONS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[REGIONS] ON
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'1', null, N'Az?rbaycan', N'0');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'2', N'1', N'Bak?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'3', N'1', N'Ab?eron', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'4', N'1', N'A?c?b?di', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'5', N'1', N'A?dam', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'6', N'1', N'A?da?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'7', N'1', N'A?d?r?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'8', N'1', N'A?stafa', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'9', N'1', N'A?su', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'10', N'1', N'Astara', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'11', N'1', N'Balak?n', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'12', N'1', N'Beyl?qan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'13', N'1', N'B?rd?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'14', N'1', N'Bil?suvar', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'15', N'1', N'C?bray?l', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'16', N'1', N'C?lilabad', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'17', N'1', N'Da?k?s?n', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'18', N'1', N'?abran', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'19', N'1', N'?irvan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'20', N'1', N'F?zuli', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'21', N'1', N'G?d?b?y', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'22', N'1', N'G?nc?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'23', N'1', N'Goranboy', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'24', N'1', N'G?y?ay', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'25', N'1', N'Hac?qabul', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'26', N'1', N'Xa?maz', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'27', N'1', N'G?yg?l', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'28', N'1', N'X?z?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'29', N'1', N'Xocav?nd', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'30', N'1', N'?mi?li', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'31', N'1', N'?smay?ll?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'32', N'1', N'K?lb?c?r', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'33', N'1', N'K?rd?mir', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'34', N'1', N'Qax', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'35', N'1', N'Qazax', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'36', N'1', N'Q?b?l?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'37', N'1', N'Qobustan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'38', N'1', N'Quba', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'39', N'1', N'Qusar', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'40', N'1', N'La??n', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'41', N'1', N'Lerik', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'42', N'1', N'L?nk?ran', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'43', N'1', N'Masall?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'44', N'1', N'Ming??evir', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'45', N'1', N'Naftalan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'46', N'1', N'Nax??van', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'47', N'1', N'Neft?ala', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'48', N'1', N'O?uz', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'49', N'1', N'Saatl?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'50', N'1', N'Sabirabad', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'51', N'1', N'Salyan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'52', N'1', N'Samux', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'53', N'1', N'Siy?z?n', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'54', N'1', N'Sumqay?t', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'55', N'1', N'?amax?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'56', N'1', N'??ki', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'57', N'1', N'??mkir', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'58', N'1', N'T?r-t?r', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'59', N'1', N'Tovuz', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'60', N'1', N'Ucar', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'61', N'1', N'Yard?ml?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'62', N'1', N'Yevlax', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'63', N'1', N'Zaqatala', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'64', N'1', N'Z?ngilan', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'65', N'1', N'Z?rdab', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'66', N'1', N'?u?a', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'67', N'1', N'Qubadl?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'68', N'1', N'Xocal?', N'1');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'69', N'47', N'?ahbuz', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'70', N'47', N'??rur', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'71', N'47', N'K?ng?rli', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'72', N'47', N'Bab?k', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'73', null, N'T?rkiy?', N'0');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'74', null, N'Rusiya', N'0');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'75', null, N'G?rc?stan', N'0');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'76', N'3', N'Mehdiabad', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'77', N'3', N'Novxan?', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'78', N'3', N'Goradil', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'79', N'3', N'G?zd?k', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'80', N'14', N'Beydili', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'81', N'14', N'X?rmandal?', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'82', N'6', N'A?a?? Nem?tabad', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'83', N'6', N'A?a?? Q?sil', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'84', N'6', N'Bulaqota??', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'85', N'6', N'C?v?', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'86', N'6', N'Qara?an ??xlar', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'87', N'6', N'?mirarx', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'88', N'6', N'?ord?hn?', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'89', N'6', N'Xosrov', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'90', N'51', N'Abadk?nd', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'91', N'51', N'A?a?? K?rk?ndi', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'92', N'51', N'Boran?k?nd', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'93', N'51', N'Piratman', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'94', N'51', N'?ad?rl?', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'95', N'51', N'?orsulu', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'96', N'51', N'Qara?ala', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'97', N'14', N'Amank?nd', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'98', N'14', N'A?al?k?nd', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'99', N'14', N'Ba?banlar', N'2');
GO
INSERT INTO [dbo].[REGIONS] ([ID], [P_ID], [REGION_NAME], [LEVEL]) VALUES (N'100', N'14', N'N?simi', N'2');
GO
SET IDENTITY_INSERT [dbo].[REGIONS] OFF
GO

-- ----------------------------
-- Table structure for [dbo].[USERS]
-- ----------------------------
DROP TABLE [dbo].[USERS]
GO
CREATE TABLE [dbo].[USERS] (
[ID] int NOT NULL IDENTITY(1,1) ,
[FIRST_NAME] nvarchar(60) NOT NULL ,
[LAST_NAME] nvarchar(60) NOT NULL ,
[USERNAME] varchar(30) NOT NULL ,
[PASSWORD] varchar(30) NOT NULL 
)


GO

-- ----------------------------
-- Records of USERS
-- ----------------------------
SET IDENTITY_INSERT [dbo].[USERS] ON
GO
INSERT INTO [dbo].[USERS] ([ID], [FIRST_NAME], [LAST_NAME], [USERNAME], [PASSWORD]) VALUES (N'1', N'Emin', N'Cavadov', N'eminj', N'123456');
GO
SET IDENTITY_INSERT [dbo].[USERS] OFF
GO

-- ----------------------------
-- Indexes structure for table PERSONS
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[PERSONS]
-- ----------------------------
ALTER TABLE [dbo].[PERSONS] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table REGIONS
-- ----------------------------
CREATE INDEX [indx_par_id] ON [dbo].[REGIONS]
([P_ID] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table [dbo].[REGIONS]
-- ----------------------------
ALTER TABLE [dbo].[REGIONS] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Indexes structure for table USERS
-- ----------------------------
CREATE UNIQUE INDEX [inx_username] ON [dbo].[USERS]
([USERNAME] ASC) 
GO

-- ----------------------------
-- Primary Key structure for table [dbo].[USERS]
-- ----------------------------
ALTER TABLE [dbo].[USERS] ADD PRIMARY KEY ([ID])
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[PERSONS]
-- ----------------------------
ALTER TABLE [dbo].[PERSONS] ADD FOREIGN KEY ([REGION_ID]) REFERENCES [dbo].[REGIONS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

-- ----------------------------
-- Foreign Key structure for table [dbo].[REGIONS]
-- ----------------------------
ALTER TABLE [dbo].[REGIONS] ADD FOREIGN KEY ([ID]) REFERENCES [dbo].[REGIONS] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO


