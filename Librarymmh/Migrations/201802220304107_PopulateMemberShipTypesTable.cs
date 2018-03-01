namespace Librarymmh.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMemberShipTypesTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MemberShipTypes(Id,Name,DurationInMonths) Values(1,'A',3)");
            Sql("INSERT INTO MemberShipTypes(Id,Name,DurationInMonths) Values(2,'B',6)");
            Sql("INSERT INTO MemberShipTypes(Id,Name,DurationInMonths) Values(3,'C',9)");
            Sql("INSERT INTO MemberShipTypes(Id,Name,DurationInMonths) Values(4,'D',12)");
           
         
        }
        
        public override void Down()
        {
        }
    }
}
