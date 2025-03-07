use HeartyHearthDB
go 

--select concat('grant execute on ', r.ROUTINE_NAME, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on UsernameUpdate to approle
grant execute on UsernameGet to approle
grant execute on CuisineGet to approle
grant execute on RecipeGet to approle
grant execute on RecipeUpdate to approle
grant execute on IngredientGet to approle
grant execute on MeasurementGet to approle
grant execute on CourseGet to approle
grant execute on CuisineDelete to approle
grant execute on CourseUpdate to approle
grant execute on UsernameDelete to approle
grant execute on DirectionGet to approle
grant execute on DirectionUpdate to approle
grant execute on DirectionDelete to approle
grant execute on RecipeDelete to approle
grant execute on RecipeDateUpdate to approle
grant execute on RecipeMealCookbookAmountGet to approle
grant execute on IngredientUpdate to approle
grant execute on RecipeIngredientGet to approle
grant execute on IngredientDelete to approle
grant execute on RecipeClone to approle
grant execute on CuisineUpdate to approle
grant execute on CookbookCreate to approle
grant execute on CookbookDelete to approle
grant execute on CookbookUpdate to approle
grant execute on CookbookRecipeGet to approle
grant execute on CookbookGet to approle
grant execute on RecipeListGet to approle
grant execute on CookbookGet to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on CourseDelete to approle
grant execute on MeasurementDelete to approle
grant execute on RecipeSearch to approle
grant execute on MealGet to approle
grant execute on CaloriesPerMeal to approle
grant execute on CookbookRecipeDelete to approle
grant execute on CookbookRecipeUpdate to approle
grant execute on RecipeIngredientDelete to approle
grant execute on RecipeIngredientUpdate to approle
grant execute on RecipeDraft to approle
grant execute on CookbookRecipeSearch to approle
grant execute on MeasurementUpdate to approle
grant execute on CuisineRecipeSearch to approle