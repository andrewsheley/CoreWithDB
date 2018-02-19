CREATE TABLE [dbo].[Employee] (
    [EmployeeID]     INT           IDENTITY (1, 1) NOT NULL,
    [LastName]       VARCHAR (50)  NULL,
    [FirstName]      VARCHAR (50)  NULL,
    [MiddleName]     VARCHAR (50)  NULL,
    [StreetAddress1] VARCHAR (100) NULL,
    [StreetAddress2] VARCHAR (100) NULL,
    [City]           VARCHAR (50)  NULL,
    [State]          VARCHAR (2)   NULL,
    [ZipCode]        VARCHAR (9)   NULL,
    [PhoneNumber]    VARCHAR (10)  NULL,
    [ParkingLotID]   INT           NOT NULL,
    CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED ([EmployeeID] ASC),
    CONSTRAINT [FK_Employee_ParkingLot] FOREIGN KEY ([ParkingLotID]) REFERENCES [dbo].[ParkingLot] ([ParkingLotID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Employee]
    ON [dbo].[Employee]([EmployeeID] ASC);

