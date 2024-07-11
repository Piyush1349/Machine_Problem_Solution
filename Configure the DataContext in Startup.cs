public void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();

    services.AddDbContext<MonitoringContext>(options =>
        options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
}

{
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server_name;Database=SystemMonitoringDB;User Id=your_user_id;Password=your_password;"
    },
    ...
}
