using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    public class UserSavedEvents
    {
        public int User_ID { get; set; } // The Id of the Current User

        public ICollection<EventList> SavedEvents { get; set; } // a List of the this Users Saved Events


    }
}
