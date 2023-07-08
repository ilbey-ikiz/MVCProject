using AutoMapper;
using MVCProject.Entities.Concrete;
using MVCProject.Models;

namespace MVCProject.AutoMappers
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeLoginVM, Employee>();   
            CreateMap<EmployeeRegisterVM, Employee>();   
            CreateMap<CompanyRegisterVM, Company>();   

        }
    }
}
