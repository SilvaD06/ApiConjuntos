
CREATE PROCEDURE Insert_Person
   @IsResident bit
   ,@IdResidence int
   ,@IdDocumentType int
   ,@DocumentNumber varchar(32)
   ,@FirstName varchar(32)
   ,@LastName varchar(32)
   ,@Email nvarchar(32)
   ,@Telephone nvarchar(32)
AS
BEGIN

  Insert Into [dbo].[Person](
	   [IsResident]
      ,[IdResidence]
      ,[IdDocumentType]
      ,[DocumentNumber]
      ,[FirstName]
      ,[LastName]
      ,[Email]
      ,[Telephone])
  Values ( @IsResident
   ,@IdResidence
   ,@IdDocumentType
   ,@DocumentNumber
   ,@FirstName
   ,@LastName
   ,@Email
   ,@Telephone )
END
GO
