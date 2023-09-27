create or alter procedure dbo.MealListGet(@All bit = 0)
as 
begin
    ;
    with x as(
        select m.MealName, NumCalories = sum(r.Calories)
        from Meal m 
        join MealCourse mc 
        on mc.MealId = m.MealId
        join MealCourseRecipe mcr 
        on mcr.MealCourseId = mc.MealCourseId
        join Recipe r 
        on r.RecipeId = mcr.RecipeId
        group by m.MealName
    ), 
    y as(
        select m.MealName, NumRecipes = count(*)
        from Meal m 
        join MealCourse mc 
        on mc.MealId = m.MealId
        join MealCourseRecipe mcr 
        on mcr.MealCourseId = mc.MealCourseId
        group by m.MealName
    ), 
    z as(
        select m.MealName, NumCourses = count(mc.CourseId)
        from Meal m 
        join MealCourse mc 
        on m.MealId = mc.MealId
        group by m.MealName
    )
    select m.MealName, [User] = concat(u.FirstName, ' ', u.LastName), x.NumCalories, z.NumCourses, y.NumRecipes
    from Meal m 
    join x 
    on x.MealName = m.MealName
    join y 
    on y.MealName = x.MealName
    join z 
    on z.MealName = m.MealName
    join Username u 
    on u.UsernameId = m.UsernameId
    where @All =1
    order by m.MealName
end 
go 

exec MealListGet @All = 1