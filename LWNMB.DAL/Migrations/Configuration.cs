namespace LWNMB.DAL.Migrations
{
    using LWNMB.Domain;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LWNMB.DAL;

    internal sealed class Configuration : DbMigrationsConfiguration<LWNMBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

        }

        protected override void Seed(LWNMBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
       
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            context.ChairPersons.AddOrUpdate(
              p => p.FirstName,
              new ChairPerson { FirstName = "Test", LastName = "Test" }
            );

            context.BoardMembers.AddOrUpdate(
                p=>p.EmailAddress,
                new BoardMembers { FirstName="Cyndi", LastName="Pijarowski", EmailAddress="pijarowski3@icloud.com", PhoneNumber="555-1212"},
                new BoardMembers { FirstName = "Beth", LastName = "Steck", EmailAddress = "bethsteck@ameritech.net", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Tom", LastName = "Delegatto", EmailAddress = "tdelegatto@msn.com", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Patty", LastName = "Villasenor", EmailAddress = "Patty.Villasenor@guggenheimpartners.com", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Beth", LastName = "McGillivray", EmailAddress = "rbmcgillivray@gmail.com", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Mary Beth", LastName = "Perros", EmailAddress = "mbperros@comcast.net", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Trudy", LastName = "Sturino", EmailAddress = "tsturino@comcast.net", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "MaryLou ", LastName = "Weaver", EmailAddress = "mldavis1479@sbcglobal.net", PhoneNumber = "555-1212" },
                new BoardMembers { FirstName = "Steve", LastName = "Hastings", EmailAddress = "stevejh5@comcast.net", PhoneNumber = "555-1212" }

                );

            //LWNMB.Domain.BoardMembers bm = new LWNMB.Domain.BoardMembers();
            //try
            //{
            //    bm.EmailAddress = "test@test.com";
            //    bm.FirstName = "John";
            //    bm.LastName = "Doe";
            //    bm.PhoneNumber = "555-555-1212";

            //    LWNMB.DAL.LWNMBContext context = new LWNMB.DAL.LWNMBContext();
            //    context.BoardMembers.Add(bm);
            //    context.SaveChanges();
            //}
            //catch (Exception ex)
            //{
            //    ViewBag.message = ex.Message;
            //}

            //
        }
    }
}
