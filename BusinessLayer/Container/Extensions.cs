using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessLayer.Container;
    
public static class Extensions
{
    public static IServiceCollection ContainerDependencies(this IServiceCollection services)
    {
        services.AddScoped<IServiceService, ServiceManagaer>();
        services.AddScoped<IServiceDal, EfServiceDal>();
        services.AddScoped<ITeamService, TeamManager>();
        services.AddScoped<ITeamDal, EfTeamDal>();
        services.AddScoped<IAnnouncementService, AnnouncementManager>();
        services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
        services.AddScoped<IImageService, ImageManager>();
        services.AddScoped<IImageDal, EfImageDal>();
        services.AddScoped<IAddressService, AddressManager>();
        services.AddScoped<IAddressDal, EfAddressDal>();
        services.AddScoped<IContactService, ContactManager>();
        services.AddScoped<IContactDal, EfContactDal>();
        services.AddScoped<ISocialMediaService, SocialMediaManager>();
        services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
        services.AddScoped<IAboutService, AboutManager>();
        services.AddScoped<IAboutDal, EfAboutDal>();
        services.AddScoped<IAdminService, AdminManager>();
        services.AddScoped<IAdminDal, EfAdminDal>();
        return services;
    }
}