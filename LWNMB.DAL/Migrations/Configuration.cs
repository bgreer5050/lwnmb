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

            context.Events.AddOrUpdate(
                p =>p.Name,
                new Event {  Description="Summer Car Wash"},
                new Event {  Description="Fish Fry"},
                new Event {  Description="Holiday Pie Sale"},
                new Event {  Description="Spiritwear"},
                new Event {  Description="Scrip Card Program"},
                new Event {  Description="Cheesecake Sale"},
                new Event {  Description="Evergreen Sale"},
                new Event {  Description="Fall Mum Sale"},
                new Event {  Description="Spring Flower Sale"},
                new Event {  Description="Princess Party"}

                );

            context.BoardPositions.AddOrUpdate(
                p => p.Title,
                new BoardPosition {  Title="President", Description="President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015")},
                new BoardPosition { Title = "President - Elect", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Secretary", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Treasurer", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Treasurer - Elect", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Communications", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Ways-Means", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition { Title = "Ways-Means - Elect", Description = "President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015") },
                new BoardPosition {  Title="Webmaster", Description="President of Lincoln-Way North Music Boosters", StartDate = DateTime.Parse("1/1/2014"), EndDate = DateTime.Parse("12/31/2015")}

                );


            context.FundRaisers.AddOrUpdate(
                p => p.Name,
                new FundRaiser { Name="Summer Car Wash", Description="" },
                new FundRaiser { Name="Fish Fry", Description="" },
                new FundRaiser { Name="Holiday Pie Sale", Description="" },
                new FundRaiser { Name="Spiritwear", Description="" },
                new FundRaiser { Name="Scrip Card Program", Description="" },
                new FundRaiser { Name="Cheesecake Sale", Description="" },
                new FundRaiser { Name="Evergreen Sale", Description="" },
                new FundRaiser { Name="Fall Mum Sale", Description="" },
                new FundRaiser { Name="Spring Flower Sale", Description="" },
                new FundRaiser { Name="Princess Party", Description="" }

                );


            context.SaveChanges();
            
            context.ChairPersons.AddOrUpdate(
              p => p.FirstName,
              new ChairPerson { FirstName = "Test", LastName = "Test" }
            );


            context.SaveChanges();


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


            foreach(BoardPosition bp in context.BoardPositions.ToList())
            {
                switch(bp.Title)
                {
                    case "President":
                        bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "pijarowski3@icloud.com").FirstOrDefault();
                        break;

                    case "President - Elect":
                        bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "tdelegatto@msn.com").FirstOrDefault();
                            break;


                    case "Secretary":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "Patty.Villasenor@guggenheimpartners.com").FirstOrDefault();
                            break;


                    case "Treasurer":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "bethsteck@ameritech.net").FirstOrDefault();
                            break;


                    case "Treasurer - Elect":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "rbmcgillivray@gmail.com").FirstOrDefault();
                            break;


                    case "Communications":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "mbperros@comcast.net").FirstOrDefault();
                            break;

                    case "Ways-Means":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "tsturino@comcast.net").FirstOrDefault();
                            break;


                    case "Ways-Means - Elect":
                          bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "mldavis1479@sbcglobal.net").FirstOrDefault();
                            break;

                    case "Webmaster":
                            bp.BoardMember = context.BoardMembers.Where(c => c.EmailAddress == "stevejh5@comcast.net").FirstOrDefault();
                            break;
                      
                    default:
                            break;
                }
            }
            context.SaveChanges();
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
