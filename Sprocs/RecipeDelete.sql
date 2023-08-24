create or alter procedure dbo.RecipeDelete(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    if exists(select * from Direction d where d.RecipeId = @RecipeId)
    begin
        select @return = 1, @Message = 'Cannot eretur recipe that has related directions.'
        