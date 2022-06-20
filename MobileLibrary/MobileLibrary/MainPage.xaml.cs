using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileLibrary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
          
            InitializeComponent();
            
        }

        protected override bool OnBackButtonPressed()
        {

            base.OnBackButtonPressed();

            if (webView.CanGoBack)
            {
                webView.GoBack();
                return true;
            }
            else
            {
                base.OnBackButtonPressed();
                return true;
            }

        }


        protected override void OnAppearing()
        {
           
            base.OnAppearing();  
            RunTimePermission();
          
         
        }

        public async void RunTimePermission()
        {
            var status = PermissionStatus.Unknown;

            status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Camera);

            if (status != PermissionStatus.Granted)
            {

                status = await Utils.CheckPermissions(Permission.Camera);
            }

        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        { 
            webView.Reload();
            refView.IsRefreshing = false;
        }
    }
}