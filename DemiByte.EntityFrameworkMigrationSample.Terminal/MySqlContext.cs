using System;
using System.Data.Entity;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
	public partial class MySqlContext : DbContext
	{
		public MySqlContext () : base (nameOrConnectionString: "MySql")
		{
		}

		public DbSet<Customer> Customers { get; set; }
	}
}