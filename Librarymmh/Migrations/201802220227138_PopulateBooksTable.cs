namespace Librarymmh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateBooksTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(1,'Get Start with C# and .Net Programming','~/Image/book5.jpg','2001/12/12','2001/12/12','The way to learn C# Programming fast and Easily','Jesse Liberty & Brian Mac Donald',50,25,7)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(2,'Benny Hill','~/Image/book1.jpg','2011/12/12','2011/12/12','Benny Hills saucy smirks and lascivious glances at underdressed women are relished across all continents by all creeds. Yet he cut an unlikely figure of global admiration: he was a deeply private individual, a loner, uninterested in money and the trappings of success. With the circus and sex in his background (his father sold condoms worldwide from a Southampton backstreet shop) Benny combined the two in a career that, after many struggles, took off in the earliest days of television. Acclaimed in the. ','Benny Hill',10,5,1)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(3,'Lisa Bernne','~/Image/book2.jpg','2016/07/01','2001/12/12','I write historical romance for Avon/HarperCollins. To learn more about me, my books, and my quirky interests (as revealed in my blog), you are cordially invited to visit my website, www.LisaBerne.com, and to sign up for my newsletter, too, so that you’ll never miss a new release!','Lisa Berne',50,25,4)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(4,'Iron King','~/Image/book3.jpg','2001/12/12','2010/12/12','Parents need to know that The Iron King, first book in the highly acclaimed New York Times bestselling Iron Fey series, has likable, heroic characters, and dastardly villains. Teen Meghan Chase goes in search of her younger brother, who s been spirited away to the fairytale world of A Midsummers Night Dream. The story includes hand-to-hand. ','Julie Agawa',500,25,2)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(5,'Modern Indian History','~/Image/book4.jpg','2001/12/12','2001/12/12','During the late 16th and the 17th Centuries, the European trading companies in India competed with each other ferociously. By the last quarter of the 18th Century the English had outdone all others and established themselves as the dominant power in India. The British administered India for a period of about two centuries and brought about revolutionary changes in the social, political and the economic life of the country.','VD Mahadja',50,25,7)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(6,'Car Book I','~/Image/Car1.jpg','2001/12/12','2001/12/12','Check your Car Book I','MMH',1000,25,3)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(7,'Car Book II','~/Image/car2.jpg','2001/12/12','2001/12/12','Check your Car Book II','MMH',50,25,3)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(8,'Car Book III','~/Image/car3.jpg','2001/12/12','2001/12/12','Check your Car Book III','MMH',50,25,3)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(9,'Car Book IV','~/Image/car4.jpg','2001/12/12','2001/12/12','Check your Car Book IV','MMH',50,25,3)");
            Sql("SET IDENTITY_INSERT Books ON  INSERT INTO Books(Id,Name,Image,PublishedDate,DateAdded,Description,AuthorName,NumberInStock,NumberAvailable,GenreId) Values(10,'Car Book V','~/Image/car5.jpg','2001/12/12','2001/12/12','Check your car Book V','Jesse Liberty & Brian Mac Donald',50,25,3)");
        }
        
        public override void Down()
        {
        }
    }
}
