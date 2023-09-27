create or alter procedure dbo.IngredientGet(@IngredientId int = 0, @All bit = 0, @IngredientName varchar(15) = '')
as
begin
    select i.IngredientId, i.IngredientName
    from Ingredient i
    where i.IngredientId = @IngredientId
    or @All = 1
    or (@IngredientName <> '' and i.IngredientName like '%' + @IngredientName + '%')
end
go

--exec IngredientGet @All = 1