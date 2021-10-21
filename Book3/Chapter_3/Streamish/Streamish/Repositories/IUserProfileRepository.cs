using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Streamish.Models;


namespace Streamish.Repositories
{
    public interface IUserProfileRepository
    {
        List<UserProfile> GetAll();
        UserProfile GetById(int id);
        void Add(UserProfile userprofile);
        void Update(UserProfile userprofile);
        void Delete(int id);

    }
}
