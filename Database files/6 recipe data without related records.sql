insert Recipe(UsernameId, CuisineId, RecipeName, Calories, DateDrafted, DatePublished, DateArchived)
select (select u.UsernameId from Username u where u.UsernameName = 'ctepfer'), (select c.CuisineId from Cuisine c where c.CuisineType = 'English'),'Challah', 200, '7/5/2020', '9/5/2020', null
union select (select u.UsernameId from Username u where u.UsernameName = 'ssuss'),  (select c.CuisineId from Cuisine c where c.CuisineType = 'French'), 'Zuchinni Soup', 100, '7/4/2020', '9/4/2020', null
union select (select u.UsernameId from Username u where u.UsernameName = 'eliyair'),  (select c.CuisineId from Cuisine c where c.CuisineType = 'American'), 'Lemon Mousse', 400, '6/5/2010', '9/5/2015', null
union select (select u.UsernameId from Username u where u.UsernameName = 'eliyair'),  (select c.CuisineId from Cuisine c where c.CuisineType = 'American'), 'Pancakes', 400, '7/1/2006', '9/5/2008', '9/5/2021'
union select (select u.UsernameId from Username u where u.UsernameName = 'eliyair'),  (select c.CuisineId from Cuisine c where c.CuisineType = 'American'), 'Pear Salad', 100, '7/5/2013', '9/5/2014', null
