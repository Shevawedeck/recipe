create or alter function dbo.CaloriesPerMeal(@MealId int)
returns int
as 
begin 
    declare @value int = 0
    
    select @Value = sum(Calories)
    from MealCourseRecipe mcr
    join Recipe r 
    on r.RecipeId = mcr.RecipeId
    join MealCourse mc
    on mc.MealCourseId = mcr.MealCourseId
    where mc.MealId = @MealId

    return @Value
end 
go

select CaloriesPerMeal = dbo.CaloriesPerMeal(m.MealId), m.*
from Meal m