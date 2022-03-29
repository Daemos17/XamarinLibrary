using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Threading.Tasks;
using GoogleVisionBarCodeScanner;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Android.Hardware;

namespace MobileLibrary.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanQrCodePage : ContentPage, INotifyPropertyChanged
    {

        CameraView camera;
        public ScanQrCodePage()
        {
            InitializeComponent();
            GoogleVisionBarCodeScanner.Methods.SetSupportBarcodeFormat(BarcodeFormats.Code39 | BarcodeFormats.QRCode);
            camera = new CameraView();
        }

        private async void CancelButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void FlashlightButton_Clicked(object sender, EventArgs e)
        {
            Camera.TorchOn = !Camera.TorchOn;

        }

        private async void CameraView_OnDetected(object sender, GoogleVisionBarCodeScanner.OnDetectedEventArg e)
        {
            List<GoogleVisionBarCodeScanner.BarcodeResult> obj = e.BarcodeResults;

            string result = string.Empty;
            for (int i = 0; i < obj.Count; i++)
            {
                result += $"Type : {obj[i].BarcodeType}, Value : {obj[i].DisplayValue}{Environment.NewLine}";
            }
            Device.BeginInvokeOnMainThread(async () =>
            {
                await DisplayAlert("Result", result, "OK");
                Camera.IsScanning = true;
                //await Navigation.PopModalAsync();
            });

        }

    }
}