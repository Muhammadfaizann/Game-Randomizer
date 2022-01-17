using System;
using System.Collections.Generic;
using System.Text;

namespace Game_Randomizer.Models
{
    public class League
    {
        public string name { get; set; }
        public string cc { get; set; }
        public string id { get; set; }
    }
    public class Home
    {
        public string name { get; set; }
        public string id { get; set; }
        public string image_id { get; set; }
        public string cc { get; set; }
    }
    public class Away
    {
        public string name { get; set; }
        public string id { get; set; }
        public string image_id { get; set; }
        public string cc { get; set; }
    }
    public class GamesLive
    {
        public string game_id { get; set; }
        public string time { get; set; }
        public string time_status { get; set; }
        public League league { get; set; }
        public Home home { get; set; }
        public Away away { get; set; }
        public string timer { get; set; }
        public string score { get; set; }
        public string bet365_id { get; set; }
    }
    public class Root
    {
        public double time_request { get; set; }
        public string capacity_requests { get; set; }
        public string remain_requests { get; set; }
        public string last_time_your_key { get; set; }
        public List<GamesLive> games_live { get; set; }
    }
}
