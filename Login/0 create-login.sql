use master

create login appadmin with password = 'CPU1234!'

if @@SERVERNAME like '%SQLExpress'
begin
    alter login appadmin with password = 'CPU4321!'
end

use HeartyHearthDB

create user appadmin_user from login appadmin
