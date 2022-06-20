using Android.Annotation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Service.Controls;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using MobileLibrary.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MobileLibrary.MyWebView), typeof(MyWebViewRenderer))]
namespace MobileLibrary.Droid
{
    public class MyWebViewRenderer : WebViewRenderer
    {
      
        public MyWebViewRenderer(Context context) : base(context)
        {
           
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.WebView> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                Control.SetWebChromeClient(new MyWebClient(MainActivity.Instance));
                Control.Settings.JavaScriptEnabled = true;
            }
        }
        public class MyWebClient : WebChromeClient
        {
            Activity mContext=null;
            public MyWebClient(Activity context)
            {
                this.mContext = context;
            }
            [TargetApi(Value = 21)]
            public override void OnPermissionRequest(PermissionRequest request)
            {
                mContext.RunOnUiThread(() =>
                {
                    request.Grant(request.GetResources());

                });

            }
        }
    }
}