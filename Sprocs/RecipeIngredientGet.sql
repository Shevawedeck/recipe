create or alter procedure dbo.RecipeIngredientGet(
    @RecipeIngredientId int = 0, 
    @IngredientId int = 0, 
    @RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = ''  output
)
as
begin
    declare @return int = 0

	select @All = isnull(@All,0), @RecipeIngredientId = isnull(@RecipeIngredientId,0), @RecipeId = isnull(@RecipeId, 0)

    select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, i.IngredientName--,ri.MeasurementTypeId, ri.SequenceNum, ri.Amount
    from Ingredient i
    left join RecipeIngredient ri 
    on i.IngredientId = ri.IngredientId
    left join MeasurementType m 
    on m.MeasurementTypeId = ri.MeasurementTypeId
    where ri.RecipeIngredientId = @RecipeIngredientId
    or @All = 1
    or ri.RecipeId = @RecipeId
    --or (@IngredientName <> '' and i.IngredientName like '%' + @IngredientName + '%')
    --or ri.RecipeId = @RecipeId 
    --or ri.RecipeIngredientId = @RecipeIngredientId
    union select 0,0,0, ''
    where @IncludeBlank = 1
    return @return
end
go

--exec RecipeIngredientGet @RecipeId = 2
--select * from Recipe