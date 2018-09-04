using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACL.DomainModels.Models;
using PACL.Repositories.Repositories;
using PACL.Repositories.DAL;
using PACL.ViewModels.ViewModels;
using PACL.ServiceLayer.Services;
using AutoMapper;
using AutoMapper.Configuration;
using PACL.ServiceLayer.MapperExtension;

namespace PACL.ServiceLayer.ServiceModels
{
    public class RegistrationService : IRegistrationService
    {
        IRegistrationRepository registrationRepository;

        public RegistrationService()
        {
            registrationRepository = new RegistrationRepository();
        }

        public void NewRegistration(RegistrationViewModel registrationViewModel)
        {
            var config = new MapperConfiguration(cfg => { cfg.CreateMap<RegistrationViewModel, registration>(); cfg.IgnoreUnmapped(); });
            IMapper mapper = config.CreateMapper();
            registration registration = mapper.Map<RegistrationViewModel, registration>(registrationViewModel);
            registrationRepository.InsertRegistration(registration);
            
        }
    }
}
