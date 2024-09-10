using App.Core.ViewModels;

namespace App.Views;

public partial class MainPage : BasePage
{
	public MainPage(MainPageViewModel vm) : base(vm)
	{
		InitializeComponent();
	}
}