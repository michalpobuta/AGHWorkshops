using App.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Views
{
    public partial class BasePage : ContentPage
    {
        private readonly BaseViewModel _viewModel;
        public BasePage(BaseViewModel vm) 
        {
            _viewModel = vm;
            BindingContext = vm;
        }

        protected override void OnAppearing()
        {
            _viewModel.OnAppearing();
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            _viewModel.OnDisappearing();
            base.OnDisappearing();
        }


    }
}
