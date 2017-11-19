# SimpleMVC
This is a simple asp .net mvc project before you clone and start extend it read the requierments.



## Requierments:
1.Visual Studio Community 2017.
2.MSSQL or MYSQL server 


###### First Step (Build)
Before you proceed with any operation build your project in order to restore NuGet package. In our case we have only one package the EntityFramework. This process will download and resolve the references for the EntityFramework.


###### Migration
Before you run the project (F5) from visual studio you must run the migration script in order to create the database.

###### How to run the Migration
From visual studio open the Package Manager Console and just write the command "Update-Database" and press enter. Be sure that the connection string in "MyDbContext" class is the correct for your local sql server.


