# Crea_Demo
This Project was developed with .net6, entityframework and Sqlite techstack.
After cloned it locally, you should run "dotnet ef database update" command in order to create db on your local sql lite db. 
(You can watch db via Db Browser for SqlLite app)
When you run/debug the application, there will be swagger index page which automatically opened.
Firstly you should use auth services in order to register a user, then login via that user and get the token. 
There is a locking symbol in the right top corner of the swagger controller, you can enter the token via this button, with this token you 
will be able to create, get and other operation. (please enter token as bearer <token>)
 
NOTE:  Project aims to be more integrated with the below part, because of the lack of the time, this functionalities not implemented:
    - Person, community should be reached via User
    - Integration/Unit test
    - Some other minor improvement.
