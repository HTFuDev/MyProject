using System;
using System.Collections.Generic;
using System.Linq;
using PACL.DomainModels.Models;
using PACL.DomainModels.DBContext;
using PACL.Repositories.Repositories;

namespace PACL.Repositories.DAL
{
    public class RegistrationRepository : IRegistrationRepository
    {
        PACLDatabaseDbContext _db;

        public RegistrationRepository()
        {
            _db = new PACLDatabaseDbContext();
        }

        public void DeleteRegistration(int id)
        {
            registration registration = _db.Registrations.Where(temp => temp.RegId == id).FirstOrDefault();
            if (registration != null) {
                _db.Registrations.Remove(registration);
                _db.SaveChanges();

            }
        }

        public List<registration> GetRegistrationsByUserId(string userid)
        {
            var registrationIndb = _db.Registrations.Where(temp => temp.UserId == userid).ToList();
            return registrationIndb;
        }

        public void InsertRegistration(registration registration)
        {
            _db.Registrations.Add(registration);
            _db.SaveChanges();
        }

        public void UpdatePassword(registration registration)
        {
            registration registrationIndb = _db.Registrations.Where(temp => temp.RegId == registration.RegId).FirstOrDefault();
            if (registrationIndb != null) {
                registrationIndb.Password = registration.Password;
                _db.SaveChanges();
            }
        }
    }
}
