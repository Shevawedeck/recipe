create or alter procedure dbo.RecipeIngredientGet(
    @RecipeIngredientId int = 0, 
    @IngredientId int = 0, 
    @RecipeId int = 0, @All bit = 0, 
    @IngredientName varchar(15) = '')
as
begin
    select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, i.IngredientName, ri.MeasurementTypeId, ri.SequenceNum, ri.Amount
    from Ingredient i
    join RecipeIngredient ri 
    on i.IngredientId = ri.IngredientId
    join MeasurementType m 
    on m.MeasurementTypeId = ri.MeasurementTypeId
    where i.IngredientId = @IngredientId
    or @All = 1
    or (@IngredientName <> '' and i.IngredientName like '%' + @IngredientName + '%')
    or ri.RecipeId = @RecipeId 
    or ri.RecipeIngredientId = @RecipeIngredientId
end
go

--exec IngredientGet @All = 1