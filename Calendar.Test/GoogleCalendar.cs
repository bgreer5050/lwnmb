using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Test
{
    public static class LWGoogleCalendar
    {
        public string CalendarId { get; set; }
        
        

        public string Name { get; set; }
        public string Description { get; set; }
        public GoogleOauthInfo OAuthInfo { get; set; }
        
        

    }


    public static class GoogleOauthInfo
    {
        public string ClientID { get; set; }
        public string EmailAddress { get; set; }
        public string ClientSecret { get; set; }
        public List<string> RedirectURIs { get; set; }
        public List<string> JavascriptOrigins { get; set; }
    }


    

}
