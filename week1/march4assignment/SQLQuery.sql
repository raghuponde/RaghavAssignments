/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP (1000) [Id]
      ,[Name]
      ,[Price]
      ,[CategoryId]
  FROM [cgefdb1].[dbo].[Products]

  -- GetAllProducts
CREATE OR ALTER PROCEDURE GetAllProducts
AS
BEGIN
    SELECT Id, Name, Price, CategoryId FROM Products;
END

-- GetProductById
CREATE OR ALTER PROCEDURE GetProductById @Id int
AS
BEGIN
    SELECT Id, Name, Price, CategoryId FROM Products WHERE Id = @Id;
END

exec GetProductById 9
-- InsertProduct
CREATE OR ALTER PROCEDURE InsertProduct @Name nvarchar(100), @Price decimal(18,2),
@CategoryId int
AS
BEGIN
    INSERT INTO Products (Name, Price, CategoryId)
	OUTPUT INSERTED.Id, INSERTED.Name, INSERTED.Price, INSERTED.CategoryId
    VALUES (@Name, @Price, @CategoryId);
END

-- UpdateProduct
CREATE OR ALTER PROCEDURE UpdateProduct @Id int, @Name nvarchar(100), @Price decimal(18,2), @CategoryId int
AS
BEGIN
    UPDATE Products SET Name = @Name, Price = @Price, CategoryId = @CategoryId
    WHERE Id = @Id;
END

-- DeleteProduct
CREATE OR ALTER PROCEDURE DeleteProduct @Id int
AS
BEGIN
    DELETE FROM Products WHERE Id = @Id;
END

