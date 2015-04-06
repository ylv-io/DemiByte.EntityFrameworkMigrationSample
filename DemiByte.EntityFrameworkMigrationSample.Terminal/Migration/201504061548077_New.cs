using System.Data.Entity.Migrations.Infrastructure;

namespace DemiByte.EntityFrameworkMigrationSample.Terminal
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class New : DbMigration, IMigrationMetadata
    {
        	string IMigrationMetadata.Id {
			get { return "201504061548077_New"; }
		}

		string IMigrationMetadata.Source {
			get { return null; }
		}


		string IMigrationMetadata.Target {
			get { return "H4sIAAAAAAAAA8xX227bRhB9L9B/IPbZ4Upx3DYGmcCR7MBoZAehkvcVOaIX2Qu7u3TEb+tDP6m/0OGdIi3Fdoqib+TuzJmZMzfy7z//Ct7upPDuwViuVUjm/ox4oGKdcJWGJHfbF7+Rt29+/im4TOTO+9LKnZZyqKlsSO6cy84ptfEdSGZ9yWOjrd46P9aSskTTl7PZazqfU0AIglieF3zKleMSqhd8XWgVQ+ZyJlY6AWGbc7yJKlTvhkmwGYshJEuQ/F3hwL9ECFdcGbz6ps3XFU8Nc+hdxGQmwF+DkVwxQbwLwRn6GYHYEo8ppV0ld/7ZQuSMVmmU4QET6yIDlNsyYaGJ7rwXf2ygs5dloLRXbKHi3Dotnwg4P22Yo2P1Z/FPOmaR25rAMuqK35AsKhNgiDc2dr4QphR8Ov1+C3riPVX1pKs3LEv/7OzXV/6r+ez09Ym3yIXLDYQKcmdKwY/5RvD4dyjW+iuoUOVCDEPFYPFu7wCPPhqdgXHFJ9g2BFwnxKP7enSs2KkNdGpq3uccn2/QNtsI6AqJHlVfcyegRcByxL4j3ortPoBK3V1I8JF4V3wHSXvSwH5WHNsUlZzJR1YC2qd2mnBsNse4AtN4sCqiP0R5CDv3QOaxS5rk28bWfjw1aARuVESWeL0Xdff5fYE95G7nWN/+tO7/dk7QA4MiWLEsQ+YGg6M58aJ6aixeRE9vGFlj0Ng+0Dedt50lpw1LYXSLptHTK26sWzLHNqzM3SKRE7G9NByguDU1Znpc2T3xrUb5XGs9u4HHVnqSESOVoFxFAXTeDgbKRLUa7Uww80A3LbTIpTrUkce0m2YaAjRHU4yAjrwfk0gnLI4mwzgtx0p6LNJZ70p7VMJBU07fX4iT+qpFiIfk3POkqy2/vPfrMhMcA+4lVkzxLVhXT09y5v8y2pr/nw1GrU3EI9fYf74B0h/eAAI/R+pB3KP86ICfDqDHTfCjA7wuspAkG42+144ORv8z5/u06AM6/FYMlmB52kOUX44K4rKaetBW5lptdcs1Rjf0qBUZpWIFjiVI0oVxfMtih9cxWFvt5C9M5ChyKTeQXKvb3GW5u7AW5EYUw3gDetx+tcT2fQ5us/LN/hshoJscQ4Bb9S7nIun8vpqW4iGIsl7eA57X6wC/sBykRYd0o9UjgRr6lpCBSnDgrAE3C4LZW1wy9/Ac3/Br5AOkLC7a0XUY5PuJ2Kc9WHKGK1DaBqPXL/9/aPkD9OYfAQYAqyTv3DINAAA="; }
		}

	public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Title = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
