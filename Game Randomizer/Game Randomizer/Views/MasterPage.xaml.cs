using Game_Randomizer.Client;
using Game_Randomizer.Models;
using Game_Randomizer.Popups;
using Game_Randomizer.ViewModel;
using Newtonsoft.Json;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Game_Randomizer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
           
            BindingContext = new MasterPageViewModel();
            InitializeComponent();
            InitSports();
            GetTeamsInfo();
            TimerSetup();
        }

        private void TimerSetup()
        {
            int Hours = 24;
            int Mints = 60;
            Device.StartTimer(new TimeSpan(1, 0, 0), () =>
            {
                Hours--;
                if (Hours == 0)
                {
                    coins.Text = (int.Parse(coins.Text)+ 2000).ToString();
                    Hours = 23;
                }
                Device.BeginInvokeOnMainThread(() =>
                {
                    hours.Text = Hours.ToString();
                });
                
                return true;
            });
            Device.StartTimer(new TimeSpan(0, 1, 0), () =>
            {
                Mints--;
                if (Mints == 0)
                    Mints = 59;
                Device.BeginInvokeOnMainThread(() =>
                {
                    mints.Text = Mints.ToString();
                });
                return true;
            });

        }

        private async void GetTeamsInfo()
        {
            var result = await RestClient.Get();
            if (result.Successful)
            {
                try
                {
                    var weatherInfo = JsonConvert.DeserializeObject<Root>(result.Response);
                    var teamsCollection = new ObservableCollection<Team>();
                    teamsCollection.Add(new Team() { Id = 1, Name = "soccer",});
                    teamsCollection.Add(new Team() { Id = 2, Name = "basketball", });
                    teamsCollection.Add(new Team() { Id = 3, Name = "icehockey", });
                    teamsCollection.Add(new Team() { Id = 4, Name = "tennis", });
                    team1comboBox.DataSource = teamsCollection;
                    team2comboBox.DataSource = teamsCollection; 
                }
                catch (Exception ex)
                { }
            }
        }
        private void InitSports()
        {
            var sportsCollection = new ObservableCollection<Sport>();
            sportsCollection.Add(new Sport() { SportId = 1, NameOfRequest = "soccer", Translation = "Football", Name = "Soccer" });
            sportsCollection.Add(new Sport() { SportId = 2, NameOfRequest = "basketball", Translation = "Basketball", Name = "Basketball" });
            sportsCollection.Add(new Sport() { SportId = 3, NameOfRequest = "icehockey", Translation = "Hockey", Name = "Ice hockey" });
            sportsCollection.Add(new Sport() { SportId = 4, NameOfRequest = "tennis", Translation = "Tennis", Name = "Tennis" });
            sportsCollection.Add(new Sport() { SportId = 5, NameOfRequest = "Badminton", Translation = "badminton", Name = "Badminton" });
            sportsCollection.Add(new Sport() { SportId = 6, NameOfRequest = "volleyball", Translation = "Volleyball", Name = "Volleyball" });
            sportsCollection.Add(new Sport() { SportId = 7, NameOfRequest = "tabletennis", Translation = "Table tennis", Name = "Table tennis" });
            sportsCollection.Add(new Sport() { SportId = 8, NameOfRequest = "cricket", Translation = "Cricket", Name = "Cricket" });
            sportsCollection.Add(new Sport() { SportId = 9, NameOfRequest = "rugbyunion", Translation = "Rugby (youth)", Name = "Rugby union" });
            sportsCollection.Add(new Sport() { SportId = 10, NameOfRequest = "boxing", Translation = "Boxing / UFC", Name = "Boxing / UFC" });
            sportsCollection.Add(new Sport() { SportId = 11, NameOfRequest = "football", Translation = "American football", Name = "American football" });
            sportsCollection.Add(new Sport() { SportId = 12, NameOfRequest = "snooker", Translation = "Snooker", Name = "Snooker" });
            sportsCollection.Add(new Sport() { SportId = 13, NameOfRequest = "darts", Translation = "Darts", Name = "Darts" });
            sportsCollection.Add(new Sport() { SportId = 14, NameOfRequest = "baseball", Translation = "Baseball", Name = "Baseball" });
            sportsCollection.Add(new Sport() { SportId = 15, NameOfRequest = "rugbyleague", Translation = "Rugby", Name = "Rugby League" });
            sportsCollection.Add(new Sport() { SportId = 16, NameOfRequest = "australianrules", Translation = "Australian football", Name = "Australian Rules" });
            sportsCollection.Add(new Sport() { SportId = 17, NameOfRequest = "bowls", Translation = "Bowling", Name = "Bowls" });
            sportsCollection.Add(new Sport() { SportId = 18, NameOfRequest = "gaelicfootball", Translation = "Gaelic sports", Name = "Gaelic Sports" });
            sportsCollection.Add(new Sport() { SportId = 19, NameOfRequest = "handball", Translation = "Handball", Name = "Handball" });
            sportsCollection.Add(new Sport() { SportId = 20, NameOfRequest = "futsal", Translation = "Futsal", Name = "Futsal" });
            sportsCollection.Add(new Sport() { SportId = 21, NameOfRequest = "floorball", Translation = "Floorball", Name = "Floorball" });
            sportsCollection.Add(new Sport() { SportId = 22, NameOfRequest = "beachvolleyball", Translation = "Beach volleyball", Name = "Beach Volleyball" });
            sportsCollection.Add(new Sport() { SportId = 23, NameOfRequest = "waterpolo", Translation = "Water polo", Name = "Water polo" });
            sportsCollection.Add(new Sport() { SportId = 24, NameOfRequest = "squash", Translation = "Squash", Name = "Squash" });
            sportsCollection.Add(new Sport() { SportId = 25, NameOfRequest = "esport", Translation = "Cybersport", Name = "E-sport" });
            comboBox.DataSource = sportsCollection.ToList();
        }

       
    }
}