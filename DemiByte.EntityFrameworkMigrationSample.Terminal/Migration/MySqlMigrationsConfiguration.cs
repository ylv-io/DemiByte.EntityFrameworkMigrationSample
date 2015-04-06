using System;
using System.Data.Entity.Migrations;
using MySql.Data.Entity;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
	public class MySqlMigrationsConfiguration : DbMigrationsConfiguration<MySqlContext>
	{
		public MySqlMigrationsConfiguration ()
		{
			SetSqlGenerator ("MySql.Data.MySqlClient", new MySqlMigrationSqlGenerator ());
		}
	}
}