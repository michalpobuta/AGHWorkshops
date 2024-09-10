using App.Views;

namespace App
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            RegisterRoutes();
            InitializeComponent();
        }

        private void RegisterRoutes() 
        {
            Routing.RegisterRoute("Register",typeof(RegisterPage));
            Routing.RegisterRoute("MainPage", typeof(MainPage));
            Routing.RegisterRoute("Profile", typeof(UserProfilePage));
        }

    }
}
