using System.Collections.Generic;

namespace App.Interfaces
{
    public interface IUserRepository
    {
        List<Models.User> GetAll();
    }
}