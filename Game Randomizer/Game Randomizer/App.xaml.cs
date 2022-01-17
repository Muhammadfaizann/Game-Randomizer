using Game_Randomizer.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly: ExportFont("GermaltBold.ttf", Alias = "GermaltBold")]
namespace Game_Randomizer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MasterPage();
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
