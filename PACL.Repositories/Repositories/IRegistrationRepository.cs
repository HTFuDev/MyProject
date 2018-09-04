using System.Collections.Generic;
using PACL.DomainModels.Models;

namespace PACL.Repositories.Repositories
{
    public interface IRegistrationRepository
    {
        void InsertRegistration(registration registration);
        void UpdatePassword(registration registration);
        void DeleteRegistration(int id);
        List<registration> GetRegistrationsByUserId(string userid);

    }
}
