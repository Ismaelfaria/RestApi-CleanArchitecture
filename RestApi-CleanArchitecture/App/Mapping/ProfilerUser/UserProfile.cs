using AutoMapper;
using RestApi_CleanArchitecture.App.Mapping.Model;
using RestApi_CleanArchitecture.Domain;

namespace RestApi_CleanArchitecture.App.Mapping.ProfilerUser
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<InputModelUser, User>();
            CreateMap<User, InputModelUser>();
            CreateMap<User, ViewModelUser>();
            CreateMap<ViewModelUser, User>();

        }
    }
}
