create or alter procedure dbo.RecipeUpdate(
    @RecipeId int output,
    @UsernameId int,
    @CuisineId int,
    @RecipeName varchar(70),
    @Calories int,
    @DateDrafted date,
    @DatePublished date,
    @DateArchived date,
    @RecipeStatus varchar(10),
    @RecipeImage varchar(150)
)
as
begin
    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin
        insert Recipe(UsernameId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived, RecipeStatus, RecipeImage)
        values(@UsernameId, @CuisineId, @RecipeName, @Calories, @DateDrafted, @DatePublished, @DateArchived, @RecipeStatus, @RecipeImage)
    end
    else
    begin
        update Recipe
        set
        UsernameId = @UsernameId,
        CuisineId = @CuisineId,
        RecipeName = @RecipeName,
        Calories = @Calories,
        DateDrafted = @DateDrafted,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived,
        RecipeStatus = @RecipeStatus,
        RecipeImage = @RecipeImage
        where RecipeId = @RecipeId
    end
end 
go
