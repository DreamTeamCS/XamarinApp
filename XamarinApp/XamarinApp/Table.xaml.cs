using Newtonsoft.Json;
using RestSharp.Portable;
using RestSharp.Portable.HttpClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    public partial class Table : ContentPage
    {
        Standing standing = new Standing();

        private string json;
        public Table()
        {
            InitializeComponent();

            Request();

            //label.Text = standing.teamName;

            

            //for (int i = 1; i < 21; i++)
            //{

            //tablePage.DataContext = new Team();
            /*
            team = new Team {
                Position = 1,
                Name = "Team",
                Won = 24,
                Drawn = 10,
                Lost = 4,
                Scored = 35,
                Conceded = 15
            };
            

            App.Database.GetItemAsync(1);
            

            team.Position = 1;
            team.Name = "Team";
            team.Won = 24;
            team.Drawn = 10;
            team.Lost = 4;
            team.Scored = 20;
            team.Conceded = 10;

            App.Database.SaveItemAsync(team);
            //}*/
        }

        private async void ResultsNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Results());
        }

        private async void StatNav_Click(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Statistics());
        }
        //request je vytvořen na RestSharp, ale v projektu musím mít RestSharp.Portable, tak by mohly být nějaké problémy
        private async void Request()
        {
            var client = new RestClient("http://api.football-data.org/v1/competitions/398/leagueTable");
            var request = new RestRequest(Method.GET);
            request.AddHeader("postman-token", "dbbb00a5-f483-027d-3ecd-a0143a309688");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("x-auth-token", "5e8fbb04451a42898368631f3256e7fa");
           
            IRestResponse<RootObject> result = await client.Execute<RootObject>(request);
            
            RootObject r = JsonConvert.DeserializeObject<RootObject>(json);
        }

        public class Self
        {
            public string href { get; set; }
        }

        public class Competition
        {
            public string href { get; set; }
        }

        public class Links
        {
            public Self self { get; set; }
            public Competition competition { get; set; }
        }

        public class Team
        {
            public string href { get; set; }
        }

        public class Links2
        {
            public Team team { get; set; }
        }

        public class Home
        {
            public int goals { get; set; }
            public int goalsAgainst { get; set; }
            public int wins { get; set; }
            public int draws { get; set; }
            public int losses { get; set; }
        }

        public class Away
        {
            public int goals { get; set; }
            public int goalsAgainst { get; set; }
            public int wins { get; set; }
            public int draws { get; set; }
            public int losses { get; set; }
        }

        public class Standing
        {
            public Links2 _links { get; set; }
            public int position { get; set; }
            public string teamName { get; set; }
            public string crestURI { get; set; }
            public int playedGames { get; set; }
            public int points { get; set; }
            public int goals { get; set; }
            public int goalsAgainst { get; set; }
            public int goalDifference { get; set; }
            public int wins { get; set; }
            public int draws { get; set; }
            public int losses { get; set; }
            public Home home { get; set; }
            public Away away { get; set; }
        }

        public class RootObject
        {
            public Links _links { get; set; }
            public string leagueCaption { get; set; }
            public int matchday { get; set; }
            public List<Standing> standing { get; set; }
        }
    }
}
