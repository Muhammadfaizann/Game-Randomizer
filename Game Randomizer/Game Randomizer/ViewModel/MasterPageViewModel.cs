using Game_Randomizer.Client;
using Game_Randomizer.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Game_Randomizer.ViewModel
{
    
    public class MasterPageViewModel : BaseViewModel
    {
        #region Properties  

        private bool _IsAddNewMatchViewVisible;
        public bool IsAddNewMatchViewVisible
        {
            get
            {
                return _IsAddNewMatchViewVisible;
            }
            set
            {
                _IsAddNewMatchViewVisible = value;
                OnPropertyChanged("IsAddNewMatchViewVisible");
            }
        }
        private bool _IsMatchListingVisible;
        public bool IsMatchListingVisible
        {
            get
            {
                return _IsMatchListingVisible;
            }
            set
            {
                _IsMatchListingVisible = value;
                OnPropertyChanged("IsMatchListingVisible");
            }
        }

        private Sport _SelectedSport;
        public Sport SelectedSport
        {
            get
            {
                return _SelectedSport;
            }
            set
            {
               
                _SelectedSport = value;
                OnPropertyChanged("SelectedSport");
            }
        }
        private Team _SelectedTeam1;
        public Team SelectedTeam1
        {
            get
            {
                return _SelectedTeam1;
            }
            set
            {

                _SelectedTeam1 = value;
                OnPropertyChanged("SelectedTeam1");
            }
        }
        private Team _SelectedTeam2;
        public Team SelectedTeam2
        {
            get
            {
                return _SelectedTeam2;
            }
            set
            {

                _SelectedTeam2 = value;
                OnPropertyChanged("SelectedTeam2");
            }
        }

        

        private ObservableCollection<Sport> sportsCollection;
        public ObservableCollection<Sport> SportsCollection
        {
            get { return sportsCollection; }
            set { sportsCollection = value; OnPropertyChanged("SportsCollection"); }
        }
        private ObservableCollection<Match> matchesCollection;
        public ObservableCollection<Match> MatchesCollection
        {
            get { return matchesCollection; }
            set { matchesCollection = value; OnPropertyChanged("MatchesCollection"); }
        }
        #endregion

        #region Commands  
        public ICommand ShowAddNewMatchCommand { get; private set; }
         public ICommand CancelCommand { get; private set; }
        public ICommand SaveNewMatchCommand { get; private set; }
        #endregion

        #region Methods  

        #endregion
        public MasterPageViewModel()
        {
            IsMatchListingVisible = true;
            IsAddNewMatchViewVisible = false;
            MatchesCollection=new ObservableCollection<Match>();
            ShowAddNewMatchCommand = new Command(() =>
            {
                try
                {
                   
                    IsAddNewMatchViewVisible = true;
                    IsMatchListingVisible = false;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }); 
            CancelCommand = new Command(() =>
            {
                try
                {
                    IsAddNewMatchViewVisible = false;
                    IsMatchListingVisible = true;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }); 
            SaveNewMatchCommand = new Command(() =>
            {
                try
                {
                    Match match = new Match();
                    match.Team1 = SelectedTeam1.Name;
                    match.Team2 = SelectedTeam2.Name;
                    match.Odd1 = GetRandomNumber();
                    match.Odd2 = GetRandomNumber();
                    MatchesCollection.Add(match);
                    IsAddNewMatchViewVisible = false;
                    IsMatchListingVisible = true;
                    SelectedTeam1 = SelectedTeam2 = null;
                    SelectedSport = null;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }
        private double GetRandomNumber()
        {
            double minimum = 1.5; double maximum = 5.0;
            Random random = new Random();
            return Math.Round(random.NextDouble() * (maximum - minimum) + minimum, 2); 
        }


    }
}