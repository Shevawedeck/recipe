delete users
delete roles

insert roles(RoleName, RoleRank)
select 'user', '1'
union select 'superuser', '2'
union select 'admin', '3'

insert users(roleid, Username, password)
select r.roleid, 'user', 'password' from roles r where r.rolerank = 1
union select r.roleid, 'sam', 'password' from roles r where r.rolerank = 2
union select r.roleid, 'admin', 'password' from roles r where r.rolerank = 3

select * from roles
select * from users