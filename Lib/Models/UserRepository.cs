using System;
using System.Collections.Generic;

namespace App.Models
{
    public class UserRepository : Interfaces.IUserRepository
    {
        public List<User> GetAll()
        {
            return new List<User>()
        {
            new User()
            {
                FirstName    = "Ash",
                LastName     = "Ketchum",
                DateOfBirth  = new DateTime(1997, 12, 30),
                Username     = "ichooseyou",
                Document     = "12345678",
                DocumentType = DocumentType.DU
            },
            new User()
            {
                FirstName    = "Brock",
                LastName     = "Harrison",
                DateOfBirth  = new DateTime(1992, 3,31),
                Username     = "rockrulez",
                Document     = "999",
                DocumentType = DocumentType.DU
            },
            new User()
            {
                FirstName    = "Misty",
                LastName     = "",
                DateOfBirth  = new DateTime(1999, 5,4),
                Username     = "ihearttogepi",
                Document     = "222333",
                DocumentType = DocumentType.DU
            }
        };            
        }
    }
}