# JML
Simple project for reading information and pass tests using:
 - ASP.NET Core WebAPI 3.x
 - EntityFramework Core 3.x
 - Core DI
 - Angular 8.x
 - Bootstrap
 
## Build 
- Restore NuGet packages 
- Create database using EntityFramework migration:
  - Change connection string:
    - `JML.DataAccess.Context` > `AppDbFactory`
    - `JML.Presentation.WebClient` > `appsettings.json`
  - Set `JML.Presentation.WebClient` as default startup projcet
  - Open `Package Manager Console`
  - Set `JML.DataAccess.Context` as default project
  - run `Update-Database`
 
