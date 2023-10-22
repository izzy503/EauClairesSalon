# Eau Claire's Salon

Eau Claire's Salon is a web application built with ASP.NET Core MVC that allows salon owners to manage their stylists and clients efficiently. It provides a user-friendly interface for adding, editing, and viewing stylists and their associated clients.

## Description

Eau Claire's Salon is designed to simplify the management of salon stylists and their clients. The application provides an intuitive interface for salon owners to add, edit, and view stylist and client information.

## Technologies Used

- ASP.NET Core MVC
- Entity Framework Core
- SQLite Database
- HTML, CSS, JavaScript
- .NET SDK 6.0
- Visual Studio (optional but recommended)

## Setup/Installation Requirements

To run Eau Claire's Salon on your local machine, you'll need the following prerequisites:

- [.NET SDK 6.0 or higher](https://dotnet.microsoft.com/download)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/) (optional but recommended)

Follow these installation steps:

1. Clone the repository:

  
   git clone https://github.com/izzy503/EauClaireSalon.git

2. Navigate to the project directory:

   cd EauClaireSalon

3. Restore dependencies:

dotnet restore

4. Run the application:

dotnet run

The application should now be running locally at http://localhost:5000 (or https://localhost:5001 with HTTPS).

To Setup and create your own appsettings.json and .sql file do the following if you have not done this yet 

1. Clone the Repository:

git clone https://github.com/your-username/your-repo.git
cd your-repo

2. Recreate appsettings.json:
You will need to create or modify the appsettings.json file with your application's configuration settings. You can typically copy the appsettings.example.json provided and update it with the necessary values, such as the database connection string.

3.Recreate the Database:
In this example, we'll assume you're using MySQL as your database system.

a. Using MySQL Workbench (GUI):
* Open MySQL Workbench and connect to your MySQL server.
* Open a SQL script file or a query tab.
* Load the provided .sql file using the File > Run SQL Script... option.
* Select the .sql file and execute it.

b. Using the Terminal (Command Line):
* Navigate to the directory where your .sql file is located.
* Log in to MySQL using the command:

mysql -u your-username -p

* You'll be prompted to enter your MySQL password.
* After logging in, select the database where you want to import data:

USE your-database;

* import the .sql file by running:

source your-file.sql

* Replace your-database with your database name and your-file.sql with the path to your .sql file.

4. Install Dependencies and Run the Application:
Build and run your application using dotnet run:

dotnet run

By following these installation steps, you'll set up the project with the required configuration settings and a database created from the provided .sql file. Make sure to customize the instructions according to your specific project and environment.

## Usage

Open your web browser and go to http://localhost:5000 (or https://localhost:5001).
You'll land on the stylists list page, where you can view existing stylists and their details.
To add a new stylist, click the "Create Stylist" button.
To add a client to a stylist, click the "Details" link next to a stylist's name, then click the "Create Client" button on the stylist details page.
You can also edit and delete stylists and clients as needed.

## Known Bugs

There are no known bugs in this version of Eau Claire's Salon. If you encounter any issues, please report them to the project repository.

## License

This project is licensed under the MIT License - see the LICENSE file for details.

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Make your changes and commit them with clear, descriptive commit messages.
4. Push your changes to your fork.
5.Create a pull request to the main repository's main branch.
6. Customize this README file according to your project's specifics, including any additional features or instructions you'd like to provide. Ensure that you update placeholders like yourusername with actual values.



