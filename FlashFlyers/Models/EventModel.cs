using System;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class EventModel
    {
        /*
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        */
        public int Id { get; set; } //Event ID number
        public string Title { get; set; } //Event Title
        public string Description { get; set; } //Event Description
        public string FileName { get; set; } //Cover Image file
        public string Date { get; set; } //Date of the event
        public string Time { get; set; } //Time of the event
        public string Building { get; set; } //Building where event is held
        public int Room { get; set; } //Room number of event if applicable
        public string Campus { get; set; } //Campus where event is held

        public bool Saved { get; set; }
    }
}
