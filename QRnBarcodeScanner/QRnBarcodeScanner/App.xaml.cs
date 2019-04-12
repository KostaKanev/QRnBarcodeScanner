using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using QRnBarcodeScanner.Views;
using QRnBarcodeScanner.Services.ScannerService;
using ZXing.Net.Mobile.Forms;
using QRnBarcodeScanner.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QRnBarcodeScanner
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
