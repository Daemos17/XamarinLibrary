using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using MobileLibrary.ViewModels;

namespace MobileLibrary
{
    public partial class MainPage : ContentPage
    {

        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel() { Navigation = this.Navigation};
            BindingContext = viewModel;

        }


        protected override async void OnAppearing()
        {
            await viewModel.GetBooks();
            base.OnAppearing();
        }
    }
}
