create or alter function dbo.RecipeDesc(@RecipeId int)
returns varchar(150)
as
begin
    declare @Value varchar(150) = ''
    
    ;
    with x as(
        select NumOfSteps = count(d.DirectionDesc), r.RecipeName
        from Direction d
        join Recipe r 
        on r.RecipeId = d.RecipeId
        group by r.RecipeName
    ),
    y as(
        select NumOfIng = count(ri.RecipeIngredientId), r.RecipeName
        from RecipeIngredient ri
        join Recipe r 
        on r.RecipeId = ri.RecipeId
        group by r.RecipeName
    )
    select @Value = concat(r.RecipeName, ' (', c.CuisineType, ')', ' has ', y.NumOfIng, ' ingredients and ', x.NumOfSteps, ' steps.')
    from Recipe r
    join x
    on x.RecipeName = r.RecipeName
    join y 
    on y.RecipeName = r.RecipeName
    left join Cuisine c 
    on c.CuisineId = r.CuisineId
    where r.RecipeId = @RecipeId 
    
    return @Value
end
go

select RecipeDesc = dbo.RecipeDesc(r.RecipeId), r.*
from Recipe r