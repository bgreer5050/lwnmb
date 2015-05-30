using LWNMB.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LWNMB.DAL
{
   public  class LWNMBContext : DbContext
    {

       public LWNMBContext()
           : base("LWNMBContext2")
       {
           Database.SetInitializer<LWNMBContext>(new DropCreateDatabaseIfModelChanges<LWNMBContext>());
       }

        public DbSet<Event> Events  { get; set; }
        public DbSet<EventDate> EventDates  { get; set; }
       

        public DbSet<WebsitePost> WebsitePosts  { get; set; }
        public DbSet<Section> Sections  { get; set; }
        public DbSet<Volunteer> Volunteers  { get; set; }
        public DbSet<VolunteerOppurtunity> VolunteerOppurtunities  { get; set; }
        public DbSet<ChairPerson> ChairPersons { get; set; }
        public DbSet<BoardMembers> BoardMembers { get; set; }
        public DbSet<BoardPosition> BoardPositions { get; set; }
        public DbSet<FundRaiser> FundRaisers { get; set; }

    }

 
}
