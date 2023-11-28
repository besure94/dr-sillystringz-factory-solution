# Dr Sillystringz Factory

#### A web application that allows a user (Dr Sillystringz, factory owner) to manage engineers and the machines that they repair.

#### By Brian Scherner

## Technologies Used

* C#
* .NET
* ASP.NET MVC
* MySQL
* EF Core
* EF Migrations

## Description

This application presents a factory owner with a splash page for their factory. It lists all of the engineers that they employ, and the machines that they are licensed to repair. The owner can navigate to `Manage engineers` or `Manage machines` to begin adding engineers and machines to their respective lists.

To create an engineer, the owner can navigate to a form where they enter a name and description for that engineer. They can then view the engineer's details by selecting it. The engineer's details contain a list of all the machines they are licensed to repair. The owner can add machines to the engineer, and can also edit the engineer's information, or delete the engineer from the application entirely. The owner can also remove individual machines from the list. There needs to be at least one machine in the application in order for the owner to add a machine to an engineer.

To create a machine, the owner can navigate to a form where they enter a name and description for that machine. They can then view the machine's details by selecting it. The machine's details contain a list of all the engineers that are licensed to repair it. The owner can then add more engineers to the machine, and remove them individually if they wish. There must be at least one engineer in order for the owner to add an engineer to a machine.

## Setup Instructions

### Install Tools

Install the tools that are introduced in [this series of lessons on LearnHowToProgram.com](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-0-lessons-1-5-getting-started-with-c/3-0-0-01-welcome-to-c).

### Set Up and Run Project

1. Clone this repository to your desktop.
2. Open the terminal and navigate to this project's production directory called `Factory`.
3. Within the production directory `Factory`, create a new file called `appsettings.json`.
4. Within `appsettings.json`, put in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL. For the LearnHowToProgram.com lessons, always assume the `uid` is `root` and the `pwd` is `epicodus`. You can use the database name below, or name it whatever you like.

```json
{
    "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=dr_sillystringz_factory;uid=root;pwd=epicodus;"
    }
}
```

5. Open your terminal to the production directory called `Factory`, and run `dotnet ef database update`. This will create the database using the migrations located inside this project's `Migrations` folder. You should now see the database in your MySQL workbench.
    * If you need to create your own migration, run the command `dotnet ef migrations add MigrationName`. The migration name should be specific and in UpperCamelCaseFormat.
6. Within the production directory called `Factory`, run `dotnet watch run` in the command line to start the project in development mode with a watcher.
7. Open the browser to [https://localhost:5001](https://localhost:5001). If you cannot access localhost:5001 it is likely because you have not configured a .NET developer security certificate for HTTPS. To learn about this, review this LearnHowToProgram.com lesson: [Redirecting to HTTPS and Issuing a Security Certificate](https://old.learnhowtoprogram.com/fidgetech-3-c-and-net/3-2-basic-web-applications/3-2-0-17-redirecting-to-https-and-issuing-a-security-certificate).

## Known Bugs

Application is fully functional.

## License

MIT

Copyright(c) 2023 Brian Scherner