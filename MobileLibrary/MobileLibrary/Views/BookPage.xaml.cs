using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileLibrary.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BookPage : ContentPage
    {
        string QrId;
        MainPageViewModel viewModel;
        public BookPage(string _qrid)
        {
            QrId = _qrid;
            InitializeComponent();
            viewModel = new MainPageViewModel() { Navigation = this.Navigation };
            BindingContext = viewModel;

        }

        protected override async void OnAppearing()
        {
            await viewModel.GetBooks(QrId);
            base.OnAppearing();
        }
    }
}