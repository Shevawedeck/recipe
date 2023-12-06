create or alter procedure dbo.RecipeSearch(
    @RecipeName varchar(100) = '',
    @Message varchar(1000) = '' output
)
as
begin
    declare @return int = 0, @count int = 0
    declare @t table(recipeid int)

     select @RecipeName = isnull(@RecipeName, '')

    insert @t(recipeid)
    select r.RecipeId
    from Recipe r
	where (r.RecipeName like '%' + @RecipeName + '%' or @RecipeName = '')

	select r.RecipeId, r.UsernameId, r.CuisineId, r.RecipeName, r.Calories, r.DateDrafted, r.DatePublished, r.DateArchived
    from @t t
    join Recipe r
    on t.Recipeid = r.RecipeId
	order by r.RecipeName

    finished:
    return @return
end
go