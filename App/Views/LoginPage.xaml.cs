using App.Core.ViewModels;

namespace App.Views;

public partial class LoginPage : BasePage
{
	public LoginPage(LoginPageViewModel vm) : base(vm)
	{
		InitializeComponent();
	}
}