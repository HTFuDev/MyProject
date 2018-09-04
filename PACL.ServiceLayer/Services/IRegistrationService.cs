using System.Collections.Generic;
using PACL.ViewModels.ViewModels;


namespace PACL.ServiceLayer.Services
{
    public interface IRegistrationService
    {
        void NewRegistration(RegistrationViewModel registrationViewModel);
    }
}
