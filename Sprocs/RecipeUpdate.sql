create or alter procedure dbo.RecipeUpdate(
    @RecipeId int output,
    @UsernameId int,
    @CuisineId int,
    @RecipeName varchar(70),
    @Calories int
)
as
begin

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin
        insert Recipe(UsernameId, CuisineId, RecipeName, Calories)
        values(@UsernameId, @CuisineId, @RecipeName, @Calories)
    end
    else
    begin
        update Recipe
        set
        UsernameId = @UsernameId,
        CuisineId = @CuisineId,
        RecipeName = @RecipeName,
        Calories = @Calories
        where RecipeId = @RecipeId
    end
end 
go
