create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int
as 
begin 
    declare @value int = 0
    
    select @Value = sum(r.Calories), mcr.MealCourseRecipeId
    from MealCourseRecipe mcr
    join Recipe r 
    on r.RecipeId = mcr.RecipeId
    where mcr.MealCourseRecipeId = @MealCourseRecipeId
    group by mcr.MealCourseRecipeId, r.Calories

    return @Value
end 
go
select CaloriesPerMeal = dbo.CaloriesPerMeal(mcr.MealCourseRecipeId), r.*
from MealCourseRecipe mcr
join Recipe r 
on r.RecipeId = mcr.RecipeId