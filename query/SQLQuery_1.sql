select * from recipe
exec RecipeGet @All =1

exec DirectionGet @RecipeId = 25
exec RecipeSearch 

exec RecipeUpdate @RecipeId = 0, @RecipeName = 'hi', @CuisineId = 1, @UsernameId = 2, @Calories = 100

exec CookbookUpdate @CookbookId = 0, @UsernameId = 4, @CookbookName = 'Meaningful Tastes', @Price = 20, @DateCreated = '5/12/23'

exec CookbookGet @All = 1

--union select (select u.UsernameId from Username u where u.UsernameName = 'ssuss'), 'Meaningful Tastes', 20, 1, '5/12/23'
select * from RecipeIngredient ri
join recipe r 
on r.RecipeId = ri.RecipeIngredientId

exec RecipeIngredientGet @All = 1

select *,  datediff(second, u.SessionKeyDate, getdate())
from users u 
join roles r 
on r.RoleId = u.RoleId

--exec RecipeUpdate @recipeid = 9, @usernameid = 1, @cuisineid = 1, @recipename= 'cheesecake', @calories = 23, @datedrafted = '09/09/13'
--select * from recipe


exec CuisineUpdate @cuisineid = 0, @cuisinetype = 'italia'
select * from cuisine

exec CuisineDelete @cuisineid = 6