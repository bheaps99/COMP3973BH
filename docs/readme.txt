"NW": "Data Source=max.bcit.ca;Database=Northwind;Persist Security Info=True;User ID=nw;Password=N0rthP@55;"

services.AddDbContext<NorthwindContext>(options => options.UseSqlServer(Configuration.GetConnectionString("NW")));

dotnet-ef dbcontext scaffold "Data Source=max.bcit.ca;Database=Northwind;Persist Security Info=True;User ID=nw;Password=N0rthP@55;" Microsoft.EntityFrameworkCore.SqlServer -c NorthwindContext -o Models/NW