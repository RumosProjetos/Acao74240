CREATE VIEW [dbo].[VW_DataHoraAtual]
AS 
	SELECT GETDATE() AS DataAtual
