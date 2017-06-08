﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Table : ContentPage
    {
        Team team;
        public Table()
        {
            InitializeComponent();
            List<int> positions = new List<int>();

            
        }

        private static TeamDatabase _database;

        public static TeamDatabase Database
        {
            get
            {
                if (_database == null)
                {
                    var fileHelper = new FileHelper();
                    _database = new TeamDatabase(fileHelper.GetLocalFilePath("TodoSQLite.db3"));
                }
                return _database;
            }
        }

        private async void ShowTable()
        {

            for (int i = 0; i < 20; i++)
            {
                team = await Database.GetTeam(i);

                var label = new Label { Text = team.ToString() };
            }
            /*var label2 = new Label { Text = team.Name};
            var label3 = new Label { Text = team.Played().ToString() };
            var label4 = new Label { Text = team.Won.ToString() };
            var label5 = new Label { Text = team.Drawn.ToString() };
            var label6 = new Label { Text = team.Lost.ToString() };
            var label7 = new Label { Text = team.Scored.ToString() };
            var label8 = new Label { Text = team.Conceded.ToString() };
            var label9 = new Label { Text = team.GoalDifference().ToString() };
            var label10 = new Label { Text = team.Points().ToString() };
            */
            //grid.Children.Add(label1);

        }

    }
}
