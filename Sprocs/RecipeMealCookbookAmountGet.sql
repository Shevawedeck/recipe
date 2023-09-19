create or alter procedure dbo.RecipeMealCookbookAmountGet(@All bit = 0)
as
begin
    select Type = 'Recipes', Number = count(r.RecipeName) 
    from Recipe r
    union select 'Meals', count(m.MealName)
    from Meal m
    union select 'Cookbook', count(c.CookbookName)
    from Cookbook c
    order by [Type] desc
    
end
go

exec RecipeMealCookbookAmountGet