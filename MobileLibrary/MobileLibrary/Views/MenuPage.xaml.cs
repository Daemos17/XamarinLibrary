using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GoogleVisionBarCodeScanner;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileLibrary.ViewModels;

namespace MobileLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPageViewModel viewModel;
        public MenuPage()
        {
            InitializeComponent();
            viewModel = new MainPageViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;
        }
        protected override async void OnAppearing()
        {
            await viewModel.GetBooks();
            base.OnAppearing();
        }
        private async void MainPageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }

        private async void QrCodeButton_Clicked(object sender, EventArgs e)
        {
            bool allowed = false;
            allowed = await GoogleVisionBarCodeScanner.Methods.AskForRequiredPermission();
            if (allowed)
                await Navigation.PushModalAsync(new NavigationPage(new ScanQrCodePage()));
            else await DisplayAlert("Alert", "You have to provide Camera permission", "Ok");
        }
    }
}