# Machine_Problem_Solution

Set Up the ASP.NET Application
Create a New Project: Open Visual Studio, create a new project, and select "ASP.NET Core Web App (Model-View-Controller)".
Name Your Project: Name the project appropriately, such as SystemMonitoringApp.
2. Collect System Information
Create a Controller: Add a new controller named MonitoringController.
Get CPU Usage: Use the PerformanceCounter class from the System.Diagnostics namespace to monitor CPU utilization.
Get IP Details: Use the NetworkInterface class from the System.Net.NetworkInformation namespace to retrieve IP details of the network interfaces.
3. Store Data in SQL Server
Create Database and Table: Use SQL scripts to create a database (SystemMonitoringDB) and a table (MonitoringData) to store monitoring data.
Install Entity Framework Core: Add the necessary Entity Framework Core packages to your project using the Package Manager Console.
Create DataContext and Entity: Create a MonitoringContext class for database context and a MonitoringData class for the data entity.
Configure Entity Framework: In Startup.cs, configure the services to use SQL Server and set up the database context.
Set Up Connection String: Add the connection string for your SQL Server database in the appsettings.json file.
4. Create a Frontend to Display Data
Create a View: Add a new view named Index.cshtml in the Views/Monitoring folder to display the collected CPU usage and IP details on the web page.
5. Run Migrations and Update Database
Run Migrations: Use the Package Manager Console to create an initial migration and update the database schema based on your data context and entity classes.
Create a migration.
Update the database to apply the migration.
6. Run the Application
Build and Run: Build the solution and run the application in Visual Studio. Access the MonitoringController to trigger data collection, storage, and display.
