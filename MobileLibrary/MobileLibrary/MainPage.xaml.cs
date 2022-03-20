using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }
        protected override void OnAppearing()
        {
           
            base.OnAppearing();
        }


    }
}
