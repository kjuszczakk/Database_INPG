USE [INPG]
GO
/****** Object:  StoredProcedure [dbo].[People_Insert]    Script Date: 23.05.2018 20:51:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[People_Insert] 
	@NazwaMleka nvarchar(50),
	@IloscKartonow nvarchar(50),
	@CenaZaKartonBrutto nvarchar(100),
	@WspolrzedneMagazynu varchar(20)
AS
BEGIN
	SET NOCOUNT ON;

    insert into dbo.People(NazwaMleka, IloscKartonow, CenaZaKartonBrutto, WspolrzedneMagazynu)
	values (@NazwaMleka, @IloscKartonow, @CenaZaKartonBrutto, @WspolrzedneMagazynu);

END
