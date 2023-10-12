create or alter procedure dbo.RecipeDateUpdate(
    @RecipeId int output,
    @DateDrafted date = null output,
    @DatePublished date = null output,
    @DateArchived date = null output
)
as
begin
    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin
        insert Recipe(DateDrafted, DateArchived, DatePublished)
        values(@DateDrafted, @DateArchived, @DatePublished)
    end
    else
    begin
        update Recipe
        set
        DateDrafted = @DateDrafted,
        DatePublished = @DatePublished,
        DateArchived = @DateArchived
        where RecipeId = @RecipeId
    end
end 
go