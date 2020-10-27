using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;

namespace FlashFlyers.Models
{
    public class CreateModel
    {
        public int Id { get; set; } //Event ID number
        public string Title { get; set; } //Event Title
        public string Description { get; set; } //Event Description
        public string FileName { get; set; } //Cover Image file
        public string Date { get; set;} //Date of the event
        public int Time { get; set; } //Time of the event
        public string Building { get; set; } //Building where event is held
        public int Room { get; set; } //Room number of event if applicable
        public string Campus { get; set; } //Campus where event is held
    }
}
