DECLARE @table NVARCHAR(250) = 'Course';

-- Header of the class
DECLARE @classHeader NVARCHAR(MAX) = 'public class ' + @table + '
{
';

-- Footer of the class
DECLARE @classFooter NVARCHAR(MAX) = '
}';

-- Query to generate the properties
DECLARE @properties NVARCHAR(MAX) = (
SELECT STRING_AGG(CONCAT(
' public ',
IIF(DATA_TYPE = 'nvarchar', 'string' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'uniqueidentifier', 'string' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'ntext', 'string' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'nchar', 'string' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'int', 'int' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'smallint', 'short' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'tinyint', 'byte' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'money', 'decimal' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'float', 'float' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'decimal', 'decimal' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'bit', 'bool' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'datetime', 'DateTime' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'date', 'DateTime' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'datetime2', 'DateTime' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
IIF(DATA_TYPE = 'image', 'byte[]' + IIF(IS_NULLABLE = 'YES', '?', ''), ''),
' ',
COLUMN_NAME,
' { get; set; }',
IIF((DATA_TYPE = 'nvarchar' OR DATA_TYPE = 'nchar') AND IS_NULLABLE = 'NO', ' = null!;', ''),
CHAR(13), CHAR(10)
), '') AS properties
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = @table
AND TABLE_SCHEMA = 'dbo'
);

-- Combine header, properties, and footer to form the complete class definition
DECLARE @classDefinition NVARCHAR(MAX) = @classHeader + @properties + @classFooter;

-- Return the complete class definition
SELECT @classDefinition;