namespace Librarymmh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id,Name) Values(1,'Comedy')");
            Sql("INSERT INTO Genres(Id,Name) Values(2,'Action')");
            Sql("INSERT INTO Genres(Id,Name) Values(3,'Family')");
            Sql("INSERT INTO Genres(Id,Name) Values(4,'Romance')");
            Sql("INSERT INTO Genres(Id,Name) Values(5,'Comedy')");
            Sql("INSERT INTO Genres(Id,Name) Values(6,'Drama')");
            Sql("INSERT INTO Genres(Id,Name) Values(7,'Horror')");

            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(8,'IT')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(9,'History')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(10,'Math')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(11,'Science')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(12,'Series')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(13,'Traval')");
            //Sql("SET IDENTITY_INSERT Genres ON  INSERT INTO Genres(Id,Name) Values(14,'Prayers books')");
        }
        
        public override void Down()
        {
        }
    }
}
