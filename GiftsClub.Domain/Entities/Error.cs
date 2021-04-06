using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftsClub.Domain.Entities
{
    public class Error : EntityBase
    {
        public Error()
        {
            
        }

        public Error(Exception ex)
        {
            Message = ex.Message;
            Source = ex.Source;
            Event = ex.TargetSite.Name;
        }

        public string Url { get; set; }
        public string Message { get; set; }
        public string Source { get; set; }
        public string Line { get; set; }
        public string Col { get; set; }
        public string error { get; set; }
        public string UserAgent { get; set; }
        public string Event { get; set; }
        public string EventHandler { get; set; }

        public string GetEmail()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
