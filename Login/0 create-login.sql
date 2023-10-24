use master

create login appadmin with password = 'CPU1234!'

use HeartyHearthDB

create user appadmin_user from login appadmin
