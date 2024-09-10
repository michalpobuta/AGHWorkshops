using App.Core.Database;
using Microsoft.Extensions.DependencyInjection;

namespace App
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitializeDatabase(serviceProvider).Wait();
            MainPage = new AppShell();
        }

        private async Task InitializeDatabase(IServiceProvider serviceProvider)
        {
            using (IServiceScope scope = serviceProvider.CreateScope())
            {
                await using var appContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                await appContext.Database.EnsureCreatedAsync();
            }
        }
    }
}
