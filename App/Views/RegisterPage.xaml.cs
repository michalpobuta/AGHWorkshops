using App.Core.ViewModels;

namespace App.Views;

public partial class RegisterPage : BasePage
{
	public RegisterPage(RegisterPageViewModel vm) : base(vm)
	{
		InitializeComponent();
	}
}