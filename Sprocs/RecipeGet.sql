create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '')
as
begin
    select r.RecipeId, r.UsernameId, r.RecipeId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.RecipeImage
    from Recipe r
    where r.RecipeId = @RecipeId
    or @All = 1
    or (@RecipeName <> '' and r.RecipeName like '%' + @RecipeName + '%')
end
go

--exec RecipeGet

--exec RecipeGet @All = 1

--exec RecipeGet @RecipeName = 'ch'

--declare @id int
--select top 1 @id = r.RecipeId
--from Recipe r
--exec RecipeGet @RecipeId = @id