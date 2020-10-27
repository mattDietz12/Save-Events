using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using Microsoft.EntityFrameworkCore;

namespace FlashFlyers.Models
{
    public class ReminderModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [ForeignKey ("Accounts")]
        public int Account_Id { get; set; }

        [ForeignKey("Events")]
        public int Event_Id { get; set; }
        public string Event_Title { get; set; }
        
    }
}
