using System;

namespace App.Models
{
    public class User 
    {
        public string Document { get; set; }
        public DocumentType DocumentType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }        
        public DateTime DateOfBirth { get; set; }
        public string Username { get; set; }
    }
}
