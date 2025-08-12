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

exec IngredientGet @All = 1

select *,  datediff(second, u.SessionKeyDate, getdate())
from users u 
join roles r 
on r.RoleId = u.RoleId

--exec RecipeUpdate @recipeid = 9, @usernameid = 1, @cuisineid = 1, @recipename= 'cheesecake', @calories = 23, @datedrafted = '09/09/13'
--
select * from recipe r
join recipeingredient ri on ri.RecipeId = r.RecipeId
where r.recipeid = 1044

exec CuisineUpdate @cuisineid = 0, @cuisinetype = 'italia'
select * from cuisine

exec CuisineDelete @cuisineid = 6

exec RecipeUpdate @recipeid = 0, @usernameid = 5, @cuisineid = 9, @recipename= 'testingD', @calories =22, @datedrafted = '7/20/25'

select * from MeasurementType 

exec RecipeIngredientUpdate @recipeIngredientId=0, @recipeid = 1044, @ingredientId = 33, @measurementTypeId = 8, @amount = 2, @sequencenum = 2

 exec RecipeIngredientGet @all = 1
exec RecipeIngredientGet @recipeid = 1044
 exec directionget @all = 1
