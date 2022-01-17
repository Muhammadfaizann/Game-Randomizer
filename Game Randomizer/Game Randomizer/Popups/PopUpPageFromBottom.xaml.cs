using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game_Randomizer.Popups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopUpPageFromBottom : PopupPage
    {
        
        public PopUpPageFromBottom(string oddValue)
        {
            InitializeComponent();
            textOdd.Text = oddValue;
        }
        private async void Confirm_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(betEntry.Text) && !string.IsNullOrWhiteSpace(betEntry.Text))
            await Navigation.PopPopupAsync();
        }
    }
}