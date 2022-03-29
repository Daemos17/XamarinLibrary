using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileLibrary.Views;
using Xamarin.Forms;
using MobileLibrary.ViewModels;
using Xamarin.Forms.Xaml;

namespace MobileLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        MainPageViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();

    
        }

        public async void button_Clicked(object sender,EventArgs e)
        {
            bool allowed = false;
            allowed = await GoogleVisionBarCodeScanner.Methods.AskForRequiredPermission();
            if (allowed)
               await Navigation.PushModalAsync(new NavigationPage(new ScanQrCodePage()));
            else await DisplayAlert("Alert", "You have to provide Camera permission", "Ok");
        }
        protected override void OnAppearing()
        {
           
            base.OnAppearing();
        }


    }
}
