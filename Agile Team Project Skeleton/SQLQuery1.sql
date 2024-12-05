USE [p2724513]
GO

DECLARE	@return_value Int

EXEC	@return_value = [dbo].[sproc_tblCustomer_FilterByCustomerID]
		@CustomerID = NULl

SELECT	@return_value as 'Return Value'

GO
