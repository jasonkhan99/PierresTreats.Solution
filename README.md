# _Pierre's Sweet and Savory Treats_

#### _C# Database many to many relationship using authentication code review for Epicodus, 08/14/2020_

#### By _**Jason Khan**_

## Description

Pierre is back! He wants you to create a new application to market his sweet and savory treats. This time, he would like you to build an application with user authentication and a many-to-many relationship. Here are the features he wants in the application:

  1. The application should have user authentication. A user should be able to log in and log out. Only logged      in users should have create, update and delete functionality. All users should be able to have read functionality.
  2. There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.
  3. A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.

## Setup/Installation Requirements

  1. Click on this [link to the project repository](https://github.com/jasonkhan99/PierresTreats.Solution.git) on GitHub.  
  2. Click on the "Clone or download" button to copy the project.     
  3. If you know how to use the command line and Github, clone the project with `git clone`. Use "**Download ZIP**" if not.
  4. Extract the Zip to a folder of your choice and open with a code editor (i.e. vscode)
  5. Use a SQL Manager Database such as mySQL Workbench.
  6. Change the appsettings.json file to use your own first and last name and password 
  6. Navigate to the Treats directory by entering `cd` **Your Filepath/**`Treats`. Then enter `dotnet restore`, `dotnet build`, `dotnet dotnet ef migrations add _Your_Name_`, `dotnet ef database update` then `dotnet run` into the terminal.

## Known Bugs

_No known bugs_

## Support and contact details

_https://github.com/jasonkhan99_

## Technologies Used

* C#
* .NET-Core 2.2
* ASP.NET Core MVC
* Entity Framework Core
* MySql
* Visual Studio Code
* GitHub

### License

*This site is licensed under the MIT license.*

Copyright (c) 2020 **_{Jason Khan}_**