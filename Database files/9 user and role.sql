drop table if exists users
drop table if exists roles
go
create table dbo.Roles(
    RoleId int not null identity primary key,
    RoleName varchar(12) not null constraint u_Role_RoleName unique, --constraint min char
    RoleRank int not null constraint u_Role_RoleRank unique --constraint > -1
)
go 
create table dbo.Users(
    UserId int not null identity primary key,
    RoleId int not null constraint f_Roles_Users foreign key references roles(roleid),
    UserName varchar(20) not null constraint u_Users_Username unique, --constraint min amnt charcters
    Password varchar(20) not null, --constraint min amnt chars
    SessionKey varchar(255) not null default '', -- constraint u_Users_SessionKey unique,
    SessionKeyDate datetime null
)