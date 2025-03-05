create or alter proc dbo.DashboardGet(
    @All bit = 0,
    @Message varchar(500) = '' output,
    @IncludeBlank bit = 0
)
as
begin
    declare @return int = 0

    select DashboardType = 'recipe', DashBoardText = concat('Click here to search from among ', count(*), ' recipes.') from Recipe r 
    union select DashboardType = 'meal', DashBoardText = concat('Click here to search from among ', count(*), ' meals.') from Meal m
    union select DashboardType = 'cookbook', DashBoardText = concat('Click here to search from among ', count(*), ' cookbooks.') from Cookbook c

    where @All = 1    
    union select '', ''
    where @IncludeBlank = 1  
    return @return 
end
go  