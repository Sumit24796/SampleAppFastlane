using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JenkinsFastLaneTestApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new MainPage();
            //test
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
