using Microsoft.Extensions.Logging;
using CommunityToolkit;
using CommunityToolkit.Maui;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using App.Core.Database;
using App.Core.Database.Model;
using App.Core.Database.Repositories;
using App.Database;
using App.Core.Common;
using App.Core.Services;
using App.Core.Services.Abstraction;
using App.Views;
using App.Core.ViewModels;

namespace App
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCommunityToolkit()
                .UseMauiCompatibility()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif      

            builder.Services.AddSingleton<IHashService, HashService>();
            builder.Services.AddSingleton<UserSession>();
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<INavigationService, NavigationService>();

            builder.Services.AddDbContext<AppDbContext>();
            builder.Services.AddSingleton<IBaseRepository<User>, UserRepository>();
            builder.Services.AddSingleton<IPath, DbPath>();

            builder.Services.AddSingleton<LoginPage>();
            builder.Services.AddSingleton<RegisterPage>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<UserProfilePage>();

            builder.Services.AddSingleton<LoginPageViewModel>();
            builder.Services.AddSingleton<RegisterPageViewModel>();
            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<UserProfilePageViewModel>();

            return builder.Build();
        }
    }
}
