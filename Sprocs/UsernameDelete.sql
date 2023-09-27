create or alter procedure dbo.UsernameDelete(
	@UsernameId int = 0,
	@Message varchar(500) = ''  output
)
as
begin
	declare @return int = 0

    if exists(select * from Recipe r join Meal m on m.UsernameId = r.UsernameId where r.UsernameId = @UsernameId or m.UsernameId = @UsernameId)
    begin
        select @return = 1, @Message = 'Are you sure you want to delete this user and all related recipes, meals and cookbooks?'
        goto finished
    end

	select @UsernameId = isnull(@UsernameId,0)

    delete Recipe where UsernameId = @UsernameId
    delete Meal where UsernameId = @UsernameId 
	delete Username where UsernameId = @UsernameId

    finished:
	return @return
end
go
