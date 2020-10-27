using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    public class SaveModel
    {
        public int Id { get; set; } // Primary key for the Saved Events Table

        public string EvTitle { get; set; }
        public string EvDescription { get; set; }
        public string EvDate { get; set; }
        public string EvTime { get; set; }
        public string EvBuilding { get; set; }
        public int EvRoom { get; set; }
        public string EvCampus { get; set; }

        //public virtual ICollection<EventSave> EventToSave { get; set; }

    }

   /* public class EventSave
    {
        [Key]
        public int Id { get; set; }
        

        //foreign key property
        public int EventId { get; set; }

        [ForeignKey("EventId")]
        public virtual SaveModel Save { get; set; }
    } */
}
