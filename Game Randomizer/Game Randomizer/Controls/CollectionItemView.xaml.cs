using Game_Randomizer.Popups;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game_Randomizer.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CollectionItemView : ContentView
    {
        public static readonly BindableProperty Team1Property =
 BindableProperty.Create("Team1", typeof(string), typeof(CollectionItemView), null,
           defaultBindingMode: BindingMode.TwoWay);

        public static readonly BindableProperty Team2Property =
 BindableProperty.Create("Team2", typeof(string), typeof(CollectionItemView), null,
           defaultBindingMode: BindingMode.TwoWay);
        
        public static readonly BindableProperty Odd1Property =
 BindableProperty.Create("Odd1", typeof(double), typeof(CollectionItemView), null,
           defaultBindingMode: BindingMode.TwoWay);

        public static readonly BindableProperty Odd2Property =
 BindableProperty.Create("Odd2", typeof(double), typeof(CollectionItemView), null,
           defaultBindingMode: BindingMode.TwoWay);
        public CollectionItemView()
        {
            InitializeComponent();
        }
        private async void FrameOdd1_Tapped(object sender, EventArgs e)
        {
            frameOdd1.BackgroundColor = Color.FromHex("#E21A21");
            textOdd1.TextColor = Color.White;
            frameOdd2.BackgroundColor = Color.FromHex("#EEEEEE");
            textOdd2.TextColor = Color.Black;
            await Navigation.PushPopupAsync(new PopUpPageFromBottom(textOdd1.Text));
        }
        private async void FrameOdd2_Tapped(object sender, EventArgs e)
        {
            frameOdd1.BackgroundColor = Color.FromHex("#EEEEEE");
            textOdd1.TextColor = Color.Black;
            frameOdd2.BackgroundColor = Color.FromHex("#E21A21");
            textOdd2.TextColor = Color.White;
            await Navigation.PushPopupAsync(new PopUpPageFromBottom(textOdd2.Text));
        }
        public string Team1
        {
            get { return (string)GetValue(Team1Property); }
            set { SetValue(Team1Property, value); }
        }
        public string Team2
        {
            get { return (string)GetValue(Team2Property); }
            set { SetValue(Team2Property, value); }
        }
        public double Odd1
        {
            get { return (double)GetValue(Team1Property); }
            set { SetValue(Team1Property, value); }
        }
        public double Odd2
        {
            get { return (double)GetValue(Odd1Property); }
            set { SetValue(Odd2Property, value); }
        }
    }
}