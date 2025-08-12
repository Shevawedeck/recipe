create or alter procedure dbo.UserGet(
    @userid int = 0,
    @sessionkey varchar(225) = '',
    @message varchar(500) = '' output
)
as 
begin
    declare @return int = 0, @maxseconds int = 30 --1200

    if isnull(@sessionkey, '') != ''
    begin 
        select @userId = userid from users u where u.sessionkey = @sessionkey

        if isnull(@userId,0) = 0
        begin
            goto exit_proc
        end

        if(select top 1 datediff(second, u.SessionKeyDate, getdate()) from users u where u.UserId = @userid) > @maxseconds
        begin 
            update u set u.SessionKey = '', u.SessionKeyDate = null from users u where u.UserId = @userid
        end

        else
        begin 
            update u set u.SessionKeyDate = getdate() from users u where u.UserId = @userid
        end

    end 

    exit_proc:

        select u.userid, u.roleid, u.sessionkey, r.rolename, r.rolerank
        from users u
        join roles r
        on r.roleid = u.roleid
        where u.userid = @userid
        or (u.SessionKey = @sessionkey and @sessionkey != '')
    return @return 
end 
go 
grant execute on UserGet to approle

--exec userget @sessionkey = 'E3C1ED58-711A-409C-931C-32E4805DB296'