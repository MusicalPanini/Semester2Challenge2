/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

IF '$(LoadTestData)' = 'true'

BEGIN

DELETE Account
DELETE Team

INSERT INTO Team(TeamCode, TeamName) VALUES
(1234, 'Kabage'),
(5678, 'Halloumi')

INSERT INTO Account(StudentNo, [Name], TeamCode) VALUES
(101671643, 'Aidan Thorne', 1234),
(123456789, 'Brandon Taylor', NULL)

END
