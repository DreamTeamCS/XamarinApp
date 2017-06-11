using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    public class Team
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public int Won { get; set; }
        public int Drawn { get; set; }
        public int Lost { get; set; }
        public int Scored { get; set; }
        public int Conceded { get; set; }
        public Team()
        {
        }

        public override string ToString()
        {
            return "Position: " + Position + " Name: " + Name + " Played: " + Played + " Won: " + Won + " Drawn: " + Drawn + " Lost: " + Lost + " Scored: " + Scored + " Conceded: " + Conceded + " Goal Difference: " + GoalDifference+ " Points: " + Points;
        }

        public int GoalDifference
        {
            get
            {
                return Scored - Conceded;
            }
        }

        public int Played
        {
            get
            {
                return Won + Drawn + Lost;
            }
        }

        public int Points
        {
            get
            {
                return Won * 3 + Drawn;
            }
        }
    }
}
