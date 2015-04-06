using System;
using System.Data.Entity.Migrations.Design;
using System.IO;
using System.Resources;
using System.Configuration;
using System.Data.Entity.Migrations;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
	public class MigrationManager
	{
		private string _migrationFolder;
		private MySqlMigrationsConfiguration _config;

		public MigrationManager (string migrationFolder)
		{
			_migrationFolder = migrationFolder;
			_config = new MySqlMigrationsConfiguration ();
		}

		public void To (string migration)
		{
			var migrator = new DbMigrator (_config);
			migrator.Update (migration);
		}

		public void Up ()
		{
			var migrator = new DbMigrator (_config);

			migrator.Update ();
		}

		public void Add (string title)
		{
			
			var scaffolder = new MigrationScaffolder (_config);

			var migration = scaffolder.Scaffold (title);

			//Because monodevelop/xamarin doesn't support resxfilecodegenerator, we can't user resx files properly
			//Another issue is lack of power shell support which force us to generate all cs/resx files manually and add them to 
			//projet, what is why we are going to put all migration data to one file using ugly hacks
			//Code might stop working on future versions of Entity framework.

			//Add Migration Namespace
			migration.UserCode = "using System.Data.Entity.Migrations.Infrastructure;\n\n" + migration.UserCode;

			//Add IMigrationMetadata interface
			migration.UserCode = migration.UserCode.Replace ("DbMigration", "DbMigration, IMigrationMetadata");

			//Insert IMigrationMetadate implementation
			migration.UserCode = migration.UserCode.Replace ("public override void Up()",
				string.Format ("\tstring IMigrationMetadata.Id {{\n\t\t\t" +
				"get {{ return \"{0}\"; }}\n\t\t" +
				"}}\n\n\t\t" +
				"string IMigrationMetadata.Source {{\n\t\t\t" +
				"get {{ return null; }}\n\t\t" +
				"}}\n\n\n\t\t" +
				"string IMigrationMetadata.Target {{\n\t\t\t" +
				"get {{ return \"{1}\"; }}\n\t\t}}" +
				"\n\n\tpublic override void Up()", migration.MigrationId, migration.Resources ["Target"]));

			File.WriteAllText (Path.Combine (_migrationFolder, migration.MigrationId + ".cs"), migration.UserCode);
		}
	}
}