create or alter procedure dbo.CuisineDelete(
	@CuisineId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0


    /*if exists(select * from MealCourseRecipe m left join CookbookRecipe cr on cr.RecipeId = m.RecipeId where m.RecipeId = @RecipeId or cr.RecipeId = @RecipeId)
    begin
        select @return = 1, @Message = 'Cannot delete cuisine that is part of a meal or cookbook.'
        goto finished
    end */

	select @CuisineId = isnull(@CuisineId,0)

	
	delete cr from CookbookRecipe cr join Recipe r on r.RecipeId = cr.RecipeId where r.CuisineId = @CuisineId
	delete mcr from MealCourseRecipe mcr join Recipe r on r.RecipeId = mcr.RecipeId where r.CuisineId = @CuisineId
	delete ri from RecipeIngredient ri join Recipe r on r.RecipeId = ri.RecipeId where r.CuisineId = @CuisineId
	delete d from Direction d join Recipe r on r.RecipeId = d.RecipeId where r.CuisineId = @CuisineId
	delete Recipe where CuisineId = @CuisineId
	delete Cuisine where CuisineId = @CuisineId

	return @return
end
go
