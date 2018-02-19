ALTER ROLE [db_owner] ADD MEMBER [sqluser];


GO
ALTER ROLE [db_datareader] ADD MEMBER [sqluser];


GO
ALTER ROLE [db_datawriter] ADD MEMBER [sqluser];

