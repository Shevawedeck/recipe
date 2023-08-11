create or alter procedure dbo.UsernameGet(@UsernameId int = 0, @All bit = 0, @UsernameName varchar(20) = '')
as
begin
    select @UsernameName = nullif(@UsernameName, '')
    select u.UsernameId, u.UsernameName, u.LastName, u.FirstName
    from Username u
    where u.UsernameId = @UsernameId
    or @All = 1
    or u.UsernameName like '%' + @UsernameName + '%'
    order by u.UsernameName
end
go

--exec UsernameGet
--exec UsernameGet @All = 1

--declare @id int
--select top 1 @id = u.UsernameId
--from Username u
--exec UsernameGet @UsernameId = @id
--exec UsernameGet @UsernameName = 'maga'
