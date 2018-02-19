CREATE TABLE [dbo].[ParkingLot] (
    [ParkingLotID] INT           IDENTITY (1, 1) NOT NULL,
    [LotName]      VARCHAR (100) NULL,
    CONSTRAINT [PK_ParkingLot] PRIMARY KEY CLUSTERED ([ParkingLotID] ASC)
);

