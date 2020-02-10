using System;
using System.Collections.Generic;

namespace App.Models
{
    public class AltUserRepository : Interfaces.IUserRepository
    {
        public List<User> GetAll()
        {
            return new List<User>
            {
                new User()
                {
                    FirstName    = "Lucas",
                    LastName     = "Lopez",
                    DateOfBirth  = new DateTime(1985, 12, 9),
                    Username     = "LukLop",
                    Document     = "31991840",
                    DocumentType = DocumentType.DU
                }            
            };            
        }
    }
}