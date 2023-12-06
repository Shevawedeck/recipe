create or alter procedure dbo.CookbookUpdate(
    @CookbookId int output,
    @UsernameId int,
    @CookbookName varchar(70),
    @Price decimal(6,2),
    @IsActive bit
)
as
begin

    select @CookbookId = isnull(@CookbookId, 0)

    if @CookbookId = 0
    begin
        insert Cookbook(UsernameId, CookbookName, Price, IsActive)
        values(@UsernameId, @CookbookName, @Price, @IsActive)
    end
    else
    begin
        update Cookbook
        set
        UsernameId = @UsernameId,
        CookbookName = @CookbookName,
        Price = @Price,
        IsActive = @IsActive
        where CookbookId = @CookbookId
    end
end 
go
