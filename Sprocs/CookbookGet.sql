create or alter procedure dbo.CookbookGet(@All bit = 0)
as 
begin
    select c.UsernameId, c.CookbookName, Author = concat(u.FirstName, ' ', u.LastName) , NumRecipes = count(cr.RecipeId), c.Price, c.IsActive, c.DateCreated
    from Cookbook c
    join CookbookRecipe cr 
    on cr.CookbookId = c.CookbookId
    join Username u
    on c.UsernameId = u.UsernameId
    where @All = 1
    group by c.CookbookName, c.Price, u.FirstName, u.LastName, c.UsernameId, c.IsActive, c.DateCreated
end
go

exec CookbookGet @All = 1
select * from cookbook