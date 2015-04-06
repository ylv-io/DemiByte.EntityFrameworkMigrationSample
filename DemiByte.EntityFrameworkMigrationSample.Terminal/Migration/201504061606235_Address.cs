using System.Data.Entity.Migrations.Infrastructure;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Address : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201504061606235_Address"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "H4sIAAAAAAAAA8xX23LbNhB970z/gYNnh7CSOE09ZDKOZGc8jexMqOQdIlc0JriwAOiK39aHflJ/oUvxKtKSJTXT6Zu42D27e7AX6O8//wrer6XwHsFYrlVIJv458UDFOuEqDUnuVi/ekvfvfv4puE7k2vvW6L0q9dBS2ZA8OJddUmrjB5DM+pLHRlu9cn6sJWWJpi/Pz3+lkwkFhCCI5XnBl1w5LmHzgZ9TrWLIXM7EXCcgbC3Hk2iD6t0xCTZjMYRkBpJ/KBz41wjhihuDR39o833OU8McRhcxmQnwF2AkV0wQ70pwhnFGIFbEY0ppt9G7/GohckarNMpQwMSiyAD1VkxYqLO77NQPTfT8ZZko7QwbqDi3TssjASevaubo0Pwk/knLLHJbEVhmveE3JNONCzDEGzq7nApTKh5Pv9+AnnnHmp619YZl6V9c/PLafz25ePvmzJvmwuUGQgW5M6Xi53wpePwbFAv9HVSociH6qWKyeLYlQNFnozMwrvgCq5qA24R4dNuODg1bs55NRc3HnOPvO/TNlgLaQqJ7zRfcCWgQsByx74g3Z+tPoFL3EBL8SbwbvoakkdSwXxXHNkUjZ/JnvVwliQFrf7CfgHYlNC4sbGrHuAJTxzAvot9FKYS1e6LCsBvrIrO1r+2MKtAI3KBYMakuiqrL/a6Qnwq3DawbM7SaM808ojsGUjBnWYbM9QZULfGiajpNX0THN6asMGhsn+jPNtrWk9OGpTA4RdcY6Q031s2YY0tW3t00kSO1rWvYQXHjasj0sIM64huL8ndldfKgGHrpSEaMVIJyGwqgjbY3uEammxXCBDNPdO1Ui1yqXZ2/z7pu2j5ALToco23JPkorHOMEdMDC8DLo6DYGk2x4vftaY6jSem9bZNAKQV2Wzy/wUZ1WKsRDgh550taoX577VbkKjgl3GnOm+Aqsq6Y9ufDfDLb8/2fjUmsTceDa/c83VvqvN5bA51M10DuUExbSYTDH7ZvxPDxsoezdJ1WthiRZaoy9CrS3iU5cN+PeCWj/iRzMwPK0gygfzArisig70EbnVq10wzZm14+oURlcxhwcS5CkK+P4isUOj2O8nM0T4RsTOapcyyUkt+o+d1nurqwFuRRFP9+A7ve/2anbMQf3Wfllf0QKGCbHFOBefci5SNq4b8YVvQuirJePgPJqO+HD0kFatEh3Wh0IVNM3gwxUgnNrAbjoEMze4857hFNiw8fRJ0hZXDQTcDfI8xexTXsw4ww3srQ1Rmdf/u2j5f++d/8IMABTMd0LKQ4AAA=="; }
		}

	public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
