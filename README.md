Simple CRUD web API created by using DotNet Core 7 to store contact details in MySQL Databse. Repository Design pattern is followed to create the API.

## Install tool globally
`dotnet tool install --global dotnet-ef` Install EF tool globally if you don't have.  

## Add First migration
`dotnet ef migrations add MyFirstMigration ` This will create a folder inside your project.

## Create table in the DB
`dotnet ef database update`. this command will create table in DB.

I have other two repo for same project

1. Contact API using MySQL database and Authorization with JSON Web Tokens (JWT) : https://github.com/dev-scripts/contact-api-mysql-auth-jwt
2. Contact API using InMemoery database, no Authorization : https://github.com/dev-scripts/contact-api
