-- SM Excellent! See comments, fix and resubmit.
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select Type = 'Recipes', Number = count(r.RecipeName) 
from Recipe r
union select 'Meals', count(m.MealName)
from Meal m
union select 'Cookbook', count(c.CookbookName)
from Cookbook c
order by [Type] desc

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. 
	Archived recipes should appear gray. Surround the archived recipe with <span style="color:gray">recipe name</span>
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
-- SM -50% You need to only include published and archived. And the archived ones should be in specific format. Format dates. Don't show null for dates show blank. Add some data for this.
select r.RecipeName, r.RecipeStatus, u.UsernameName, r.Calories, NumIngredients = count(ri.IngredientId)
from Recipe r
join Username u
on u.UsernameId = r.UsernameId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
group by r.RecipeName, r.RecipeStatus, u.UsernameName, r.Calories
order by r.RecipeStatus desc
/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a)
-- SM No need for CTE. You can count distinct.
;
with x as
(
    select r.RecipeName, NumIngredients = count(ri.RecipeIngredientId)
    from RecipeIngredient ri 
    join Recipe r 
    on r.RecipeId = ri.RecipeId
    where r.RecipeName = 'Apple Yogurt Smoothie'
    group by r.RecipeName
)
select r.RecipeName, r.Calories, x.NumIngredients, NumSteps = count(d.RecipeId), r.RecipeImage
from Recipe r 
join x 
on r.RecipeName = x.RecipeName
join Direction d 
on d.RecipeId = r.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
group by r.RecipeName, r.Calories, x.NumIngredients, r.RecipeImage
--b)
select ListIngredients = concat(ri.Amount,' ', m.MeasurementTypeName, ' ', i.IngredientName), r.RecipeImage
from RecipeIngredient ri 
join Ingredient i 
on i.IngredientId = ri.IngredientId
join MeasurementType m 
on m.MeasurementTypeId = ri.MeasurementTypeId
join Recipe r 
on r.RecipeId = ri.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by ri.SequenceNum
--c)
select d.DirectionDesc, r.RecipeImage
from Direction d
join Recipe r 
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Apple Yogurt Smoothie'
order by d.SequenceNum

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
-- SM Should only be for active meals. No need for CTE. You can count distinct.
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
order by m.MealName
/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is serverd as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a)
select m.MealName, u.UsernameName, m.DateCreated, m.MealImage
from Meal m
join Username u 
on u.UsernameId = m.UsernameId
where m.MealName = 'Summer Brunch'
--b)
select ListRecipes = concat(case 
             when c.CourseType = 'main course'
             then concat(c.CourseType,': ', case 
                                when mcr.IsMainDish = 0 
                                then 'Side Dish - '
                                else 'Main Dish - '
                                end)
             else concat(c.CourseType, ': ')
             end
             , r.RecipeName), m.MealImage
from Meal m
join MealCourse mc 
on mc.MealId = m.MealId 
join Course c
on c.CourseId = mc.CourseId
join MealCourseRecipe mcr 
on mcr.MealCourseId = mc.MealCourseId
join Recipe r 
on r.RecipeId = mcr.RecipeId
where m.MealName = 'Summer Brunch'
/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
-- SM Sorted by book name.
select c.CookbookName, Author = concat(u.FirstName, ' ', u.LastName), NumRecipes = count(cr.RecipeId), c.Price
from Cookbook c
join CookbookRecipe cr 
on cr.CookbookId = c.CookbookId
join Username u
on c.UsernameId = u.UsernameId
group by c.CookbookName, c.Price, u.FirstName, u.LastName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a
select c.CookbookName, u.UsernameName, c.DateCreated, c.Price, NumRecipes = count(cr.RecipeId), c.CookbookImage
from Cookbook c 
join Username u 
on u.UsernameId = c.UsernameId
join CookbookRecipe cr 
on cr.CookbookId = c.CookbookId
where c.CookbookName = 'Treats for Two'
group by c.CookbookName, u.UsernameName, c.DateCreated, c.Price, c.CookbookImage
--b
;
-- SM Should be sorted in correct order. And no need for CTE.
with x as
(
    select r.RecipeName, NumIngredients = count(ri.RecipeId)
    from Cookbook c
    join CookbookRecipe cr 
    on cr.CookbookId = c.CookbookId
    join Recipe r 
    on r.RecipeId = cr.RecipeId
    join RecipeIngredient ri 
    on ri.RecipeId = r.RecipeId
    where c.CookbookName = 'Treats for Two'
    group by r.RecipeName
)
select r.RecipeName, u.CuisineType, x.NumIngredients, NumSteps = count(d.RecipeId), c.CookbookImage
from Cookbook c 
join CookbookRecipe cr 
on cr.CookbookId = c.CookbookId
join Recipe r 
on r.RecipeId = cr.RecipeId
join Cuisine u 
on u.CuisineId = r.CuisineId
join Direction d 
on d.RecipeId = r.RecipeId
join x 
on x.RecipeName = r.RecipeName
where c.CookbookName = 'Treats for Two'
group by r.RecipeName, u.CuisineType, x.NumIngredients, c.CookbookImage
/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a
-- SM This is returning multiple times each recipe.
select JokeRecipes = concat(upper(substring(reverse(r.RecipeName),1,1)), lower(substring(reverse(r.RecipeName),2,100))), 
       Pictures = concat('Recipe_', replace(concat(upper(substring(reverse(r.RecipeName),1,1)), lower(substring(reverse(r.RecipeName),2,100))), ' ', '_'),'.jpg')
from Recipe r
join CookbookRecipe cr 
on cr.RecipeId = r.RecipeId
where r.RecipeId = cr.RecipeId
--b 
;
with x as
(
select d.RecipeId, SequenceNum = max(d.SequenceNum)
from Direction d 
group by d.RecipeId
)
select d.DirectionDesc
from Direction d 
join x 
on x.RecipeId = d.RecipeId
where d.SequenceNum = x.SequenceNum
/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a 
;
with x as(
    select r.UsernameId, NumPublishedRecipes = count(*)
    from Recipe r 
    where r.RecipeStatus = 'published'
    group by r.UsernameId
),
y as(
    select r.UsernameId, NumDraftedRecipes = count(*)
    from Recipe r 
    where r.RecipeStatus = 'drafted'
    group by r.UsernameId
),
z as(
    select r.UsernameId, NumArchivedRecipes = count(*)
    from Recipe r 
    where r.RecipeStatus = 'archived'
    group by r.UsernameId
)
select distinct u.UsernameName, NumPublishedRecipes = isnull(x.NumPublishedRecipes,0), NumDraftedRecipes = isnull(y.NumDraftedRecipes,0), NumArchivedRecipes = isnull(z.NumArchivedRecipes,0)
    from Recipe r 
    join Username u 
    on u.UsernameId = r.UsernameId
    left join x 
    on x.UsernameId = r.UsernameId
    left join y
    on y.UsernameId = r.UsernameId
    left join z
    on z.UsernameId = r.UsernameId
--b) 
;
with x as(
select u.UsernameName, NumRecipes = count(r.RecipeId) 
from Recipe r 
join Username u 
on u.UsernameId = r.UsernameId
group by u.UsernameName
)
select u.UsernameName, AvgDaysTilPublished = avg(datediff(day, r.DateDrafted, r.DatePublished)), x.NumRecipes
from Recipe r 
join Username u 
on u.UsernameId = r.UsernameId
join x 
on x.UsernameName = u.UsernameName
group by u.UsernameName, x.NumRecipes
--c)
-- SM Use sum() and set to 1 else 0. And you set the opposite.
select u.UsernameName, TotalMeals = count(m.MealId), ActiveMeals = count(case when m.IsActive = 0 then m.MealId end), InactiveMeals = count(case when m.IsActive = 1 then m.MealId end) 
from Meal m 
join Username u 
on u.UsernameId = m.UsernameId
group by u.UsernameName 
--d) 
-- SM Use sum() and set to 1 else 0. And you set the opposite.
select u.UsernameName, TotalCookbooks = count(c.CookbookId), ActiveCookbooks = count(case when c.IsActive = 0 then c.CookbookId end), InactiveCookbooks = count(case when c.IsActive = 1 then c.CookbookId end) 
from Cookbook c
join Username u 
on u.UsernameId = c.UsernameId
group by u.UsernameName 
--e)
-- SM Add data for this.
select r.RecipeName, DaysTilArchived = datediff(day, r.DateDrafted, r.DateArchived)
from Recipe r 
where r.RecipeStatus = 'archived'
and r.DatePublished = null
/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: For the number of recipes, use count of records that have a staffid or CTE.
*/
--a
-- SM Add column name.
select 'Recipes', count(r.RecipeName)
from Username u 
join Recipe r 
on r.UsernameId = u.UsernameId
where u.UsernameName = 'ssuss'
union select 'Meals', count(m.MealName)
from Username u 
join Meal m 
on m.UsernameId = u.UsernameId
where u.UsernameName = 'ssuss'
union select 'Cookbooks', count(c.CookbookName)
from Username u 
join Cookbook c 
on c.UsernameId = u.UsernameId
where u.UsernameName = 'ssuss'
--b
-- SM Published can never be before archived. Use isnull()
select r.RecipeName, r.RecipeStatus, NumOfHoursUntilCurrentStatus = datediff(hour, case when r.RecipeStatus = 'published' then r.DateDrafted 
                                                                                        when r.RecipeStatus = 'archived' and r.DatePublished < r.DateDrafted then r.DateDrafted  
                                                                                        else r.DatePublished end, 
                                                                                    case when r.RecipeStatus = 'archived' then r.DateArchived else r.DatePublished end)
from Username u 
join Recipe r 
on r.UsernameId = u.UsernameId
where u.UsernameName = 'ssuss'
and r.RecipeStatus <> 'drafted'