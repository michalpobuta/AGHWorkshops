using App.Core.ViewModels;

namespace App.Views;

public partial class UserProfilePage : BasePage
{
	public UserProfilePage(UserProfilePageViewModel vm) : base(vm)
	{
		InitializeComponent();
	}
}