create or alter procedure dbo.RecipeIngredientGet(@IngredientId int = 0, @RecipeId int = 0, @All bit = 0, @IngredientName varchar(15) = '')
as
begin
    select ri.RecipeId, i.IngredientId, i.IngredientName
    from Ingredient i
    join RecipeIngredient ri 
    on i.IngredientId = ri.IngredientId
    where i.IngredientId = @IngredientId
    or @All = 1
    or (@IngredientName <> '' and i.IngredientName like '%' + @IngredientName + '%')
    or ri.RecipeId = @RecipeId 
end
go

--exec IngredientGet @All = 1