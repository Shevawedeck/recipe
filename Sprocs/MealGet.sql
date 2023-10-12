create or alter procedure dbo.MealGet(@MealId int = 0, @All bit = 0, @MealName varchar(50) = '')
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
    select m.MealId, m.UsernameId, m.MealName, [User] = concat(u.FirstName, ' ', u.LastName), x.NumCalories, z.NumCourses, y.NumRecipes, m.DateCreated, m.IsActive, m.MealImage
    from Meal m 
    join x 
    on x.MealName = m.MealName
    join y 
    on y.MealName = x.MealName
    join z 
    on z.MealName = m.MealName
    join Username u 
    on u.UsernameId = m.UsernameId
    where @All = 1
    or m.MealName = @MealName
    or m.MealId = @MealId
    order by m.MealName
end 
go 

--exec MealGet @All = 1