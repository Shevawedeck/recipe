create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '')
as
begin
    select r.RecipeId, r.UsernameId, r.CuisineId, r.RecipeName,  r.RecipeStatus, u.UsernameName, r.Calories, NumIngredients = count(ri.IngredientId), r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeImage
    from Recipe r
    join Username u
    on u.UsernameId = r.UsernameId
    left join RecipeIngredient ri
    on r.RecipeId = ri.RecipeId
    where r.RecipeId = @RecipeId
    or @All = 1
    or r.RecipeName = '%' + @RecipeName + '%'
    group by r.RecipeId, r.RecipeName, r.RecipeStatus, u.UsernameName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeImage, r.UsernameId, r.CuisineId
    order by r.RecipeStatus desc
end
go

--exec RecipeGet

--exec RecipeGet @All = 1

--exec RecipeGet @RecipeName = 'ch'

--declare @id int
--select top 1 @id = r.RecipeId
--from Recipe r
--exec RecipeGet @RecipeId = 144