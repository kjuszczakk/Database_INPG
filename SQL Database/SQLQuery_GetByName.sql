USE [INPG]
GO
/****** Object:  StoredProcedure [dbo].[People_GetByLastName]    Script Date: 23.05.2018 20:51:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[People_GetByLastName] 
	@NazwaMleka nvarchar(50)
AS
BEGIN
	SET NOCOUNT ON;
    select NazwaMleka, IloscKartonow,CenaZaKartonBrutto, WspolrzedneMagazynu
	from dbo.People
	where NazwaMleka = @NazwaMleka;
	
END
