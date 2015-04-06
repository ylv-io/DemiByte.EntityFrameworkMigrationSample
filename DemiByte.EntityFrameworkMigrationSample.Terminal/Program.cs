using System;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine (string.Format (@"Type command for migration operation: {0}	Add; {0}	Up; {0}	To; ", Environment.NewLine));

			var mgrMan = new MigrationManager (@"../../Migration");

			var command = Console.ReadLine ();
			switch (command) {
			case "Add":
				{
					Console.WriteLine ("Specify Migration Title");
					var migrationName = Console.ReadLine ();
					mgrMan.Add (migrationName);
					Console.WriteLine ("Migration Added");
				}
				break;


			case "Up":
				{
					mgrMan.Up ();
					Console.WriteLine ("Database version is upped");

				}
				break;
			case "To":
				{
					Console.WriteLine ("Specify Migration");
					var migration = Console.ReadLine ();
					mgrMan.To (migration);
					Console.WriteLine ("Database migrated");
				}
				break;
			}

		}
	}
}
