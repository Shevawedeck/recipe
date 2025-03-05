create or alter procedure dbo.UserLogout(
    @username varchar(20),
    @message varchar(500) = '' output
)
as
begin 
    declare @return int = 0
    select @message = ''

    update users set SessionKey = '', SessionKeyDate = null where username = @username
    return @return
end
go 

grant execute on UserLogout to approle
