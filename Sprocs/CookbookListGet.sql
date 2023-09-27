create or alter procedure dbo.CookbookListGet(@All bit = 0)
as 
begin
    select c.CookbookName, Author = concat(u.FirstName, ' ', u.LastName) , NumRecipes = count(cr.RecipeId), c.Price
    from Cookbook c
    join CookbookRecipe cr 
    on cr.CookbookId = c.CookbookId
    join Username u
    on c.UsernameId = u.UsernameId
    where @All = 1
    group by c.CookbookName, c.Price, u.FirstName, u.LastName
end
go

exec CookbookListGet @All = 1
