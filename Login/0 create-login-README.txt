script to create login and user is excluded from this repo.
Create a file called create-login.sql (this file is ignored by git ignore in this repo)
add the following to that file

--use master 
create login [loginname] with password = '[password]'

--important switch to HeartyHearthDB
create user [username] from login [login name]