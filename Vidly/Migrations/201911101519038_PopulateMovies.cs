namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies(Id,Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) VALUES (1,'Hangover',2000/01/01,2019/11/10,4,1)");
            Sql("INSERT INTO Movies(Id,Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) VALUES (2,'Die Hard',2001/02/02,2019/11/10,5,2)");
            Sql("INSERT INTO Movies(Id,Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) VALUES (3,'Terminator',2002/03/03,2019/11/10,6,2)");
            Sql("INSERT INTO Movies(Id,Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) VALUES (4,'Toy Story',2003/04/04,2019/11/10,7,3)");
            Sql("INSERT INTO Movies(Id,Name,ReleaseDate,DateAdded,NumberInStock,Genre_Id) VALUES (5,'Titanic',2004/05/05,2019/11/10,1,4)");
            
        }
        
        public override void Down()
        {
        }
    }
}
