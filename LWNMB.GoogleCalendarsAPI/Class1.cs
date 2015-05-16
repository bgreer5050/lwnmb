using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Calendar.v3;


using Google.Apis.Calendar.v3.Data;


using Google.Apis.Services;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Util.Store;

namespace LWNMB.GoogleCalendarsAPI
{
    public class CalEvent
    {
        IList<string> scopes;
        Google.Apis.Calendar.v3.CalendarService serv;

        public CalEvent()
        {
            scopes = new List<string>();

            //Add the calendar specific scope to the scopes list.
            scopes.Add(CalendarService.Scope.Calendar);

            //Create a user credential
            ClientSecrets clientSecrets = new ClientSecrets();
            clientSecrets.ClientId = "327357483453-cset7hpghjvj6dl2pocbmoddb9gf7t54.apps.googleusercontent.com";


            clientSecrets.ClientSecret = "gNEByJItuQXsqb0YUtcHhmWO";
            UserCredential credential = GoogleWebAuthorizationBroker.AuthorizeAsync(clientSecrets,scopes,"bgreer5050@gmail.com",System.Threading.CancellationToken.None,new FileDataStore("Calendar.VB.Sample")).Result;


            BaseClientService.Initializer initializer = new BaseClientService.Initializer();
            initializer.HttpClientInitializer = credential;
        initializer.ApplicationName = "VB.NET Calendar Sample";
        serv = new CalendarService(initializer);

        List<CalendarListEntry> list = serv.CalendarList.List().Execute().Items.ToList();

        DisplayList(list);

        //DisplayEvents(list);

        }

        private void DisplayEvents(List<CalendarListEntry> list)
        {

            throw new NotImplementedException();
        
        }

        private void DisplayList(List<CalendarListEntry> list)
        {


            foreach(CalendarListEntry item in list)
            {
                
                if (item.Id == "bgreer5050@gmail.com")
                {


                    Events request = null;
                    Google.Apis.Calendar.v3.EventsResource.ListRequest lr = serv.Events.List(("bgreer5050@gmail.com"));

                    lr.TimeMin = DateTime.Now.AddDays(-5); //five days in the past
                    lr.TimeMax = DateTime.Now.AddDays(5); //five days in the future

                    request = lr.Execute();
                    http://codekicker.de/news/Retrieving-calendar-events-using-Google-Calendar-API

                    Console.ReadLine();

                    //Console.WriteLine(item.Id.ToString());
                    //Console.WriteLine(item.Summary + ". Location: " + item.Location + ", TimeZone: " + item.TimeZone);
                    //Google.Apis.Calendar.v3.EventsResource.ListRequest request = serv.Events.List(item.Id);
                    //request.MaxResults = 500;
                    //// request.TimeMin = new DateTime(2013, 10, 1, 20, 0, 0);
                    //request.TimeMin = DateTime.Now.AddDays(-5); //five days in the past
                    //request.TimeMax = DateTime.Now.AddDays(5); //five days in the future
                    
                    //foreach (Google.Apis.Calendar.v3.Data.Event calendarEvent in request.Execute().Items.ToList())
                    //{
                    //    if (calendarEvent.Start != null && calendarEvent.Start.Date != null)
                    //    {
                    //        Console.WriteLine(calendarEvent.Summary + " , Starts: " + calendarEvent.Start.Date.ToString());
                    //        Console.ReadLine();
                    //    }
                    //}
                }
                
            }
        }

            

    }
}
