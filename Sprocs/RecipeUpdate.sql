create or alter procedure dbo.RecipeUpdate(
    @RecipeId int output
    @UsernameId int,
    @CuisineId int,
    @RecipeName varchar(),
    @Calories int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0 

    select @RecipeId = isnull(@RecipeId, 0)

    begin
        select 
    end
