using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    class Teams
    {
        List<int> position = new List<int>();
        Dictionary<int, string> teamList = new Dictionary<int, string>();
        Dictionary<int, int> won = new Dictionary<int, int>();
        Dictionary<int, int> drawn = new Dictionary<int, int>();
        Dictionary<int, int> lost = new Dictionary<int, int>();
        Dictionary<int, int> scored = new Dictionary<int, int>();
        Dictionary<int, int> conceded = new Dictionary<int, int>();

        public Teams()
        {
            teamList.Add(5, "Arsenal");
            teamList.Add(9, "Bournemouth");
            teamList.Add(16, "Burnley");
            teamList.Add(1, "Chelsea");
            teamList.Add(14, "Crystal Palace");
            teamList.Add(7, "Everton");
            teamList.Add(18, "Hull City");
            teamList.Add(12, "Leicester City");
            teamList.Add(4, "Liverpool");
            teamList.Add(3, "Manchester City");
            teamList.Add(6, "Manchester United");
            teamList.Add(19, "Middlesbrough");
            teamList.Add(8, "Southampton");
            teamList.Add(13, "Stoke City");
            teamList.Add(20, "Sunderland");
            teamList.Add(15, "Swansea");
            teamList.Add(2, "Tottenham Hotspur");
            teamList.Add(17, "Watford");
            teamList.Add(10, "West Bromvich Albion");
            teamList.Add(11, "West Ham United");

            position.Add(5);
            position.Add(9);
            position.Add(16);
            position.Add(1);
            position.Add(14);
            position.Add(7);
            position.Add(18);
            position.Add(12);
            position.Add(4);
            position.Add(3);
            position.Add(6);
            position.Add(19);
            position.Add(8);
            position.Add(13);
            position.Add(20);
            position.Add(15);
            position.Add(2);
            position.Add(17);
            position.Add(10);
            position.Add(11);

            won.Add(1, 25);
            won.Add(2, 15);
            won.Add(3, 10);
            won.Add(4, 30);
            won.Add(5, 7);
            won.Add(6, 18);
            won.Add(7, 3);
            won.Add(8, 9);
            won.Add(9, 23);
            won.Add(10, 24);
            won.Add(11, 20);
            won.Add(12, 12);
            won.Add(13, 14);
            won.Add(14, 15);
            won.Add(15, 2);
            won.Add(16, 6);
            won.Add(17, 28);
            won.Add(18, 14);
            won.Add(19, 10);
            won.Add(20, 13);

            drawn.Add(1, 5);
            drawn.Add(2, 8);
            drawn.Add(3, 10);
            drawn.Add(4, 3);
            drawn.Add(5, 16);
            drawn.Add(6, 17);
            drawn.Add(7, 10);
            drawn.Add(8, 13);
            drawn.Add(9, 9);
            drawn.Add(10, 8);
            drawn.Add(11, 12);
            drawn.Add(12, 5);
            drawn.Add(13, 8);
            drawn.Add(14, 7);
            drawn.Add(15, 9);
            drawn.Add(16, 14);
            drawn.Add(17, 6);
            drawn.Add(18, 14);
            drawn.Add(19, 11);
            drawn.Add(20, 13);

            lost.Add(1, 6);
            lost.Add(2, 12);
            lost.Add(3, 18);
            lost.Add(4, 3);
            lost.Add(5, 14);
            lost.Add(6, 8);
            lost.Add(7, 13);
            lost.Add(8, 14);
            lost.Add(9, 7);
            lost.Add(10, 9);
            lost.Add(11, 5);
            lost.Add(12, 10);
            lost.Add(13, 11);
            lost.Add(14, 11);
            lost.Add(15, 17);
            lost.Add(16, 13);
            lost.Add(17, 4);
            lost.Add(18, 9);
            lost.Add(19, 10);
            lost.Add(20, 9);

            scored.Add(1, 65);
            scored.Add(2, 58);
            scored.Add(3, 45);
            scored.Add(4, 70);
            scored.Add(5, 42);
            scored.Add(6, 53);
            scored.Add(7, 41);
            scored.Add(8, 40);
            scored.Add(9, 67);
            scored.Add(10, 65);
            scored.Add(11, 52);
            scored.Add(12, 49);
            scored.Add(13, 48);
            scored.Add(14, 64);
            scored.Add(15, 20);
            scored.Add(16, 45);
            scored.Add(17, 68);
            scored.Add(18, 51);
            scored.Add(19, 48);
            scored.Add(20, 45);

            conceded.Add(1, 30);
            conceded.Add(2, 36);
            conceded.Add(3, 45);
            conceded.Add(4, 28);
            conceded.Add(5, 42);
            conceded.Add(6, 36);
            conceded.Add(7, 46);
            conceded.Add(8, 39);
            conceded.Add(9, 46);
            conceded.Add(10, 40);
            conceded.Add(11, 25);
            conceded.Add(12, 43);
            conceded.Add(13, 34);
            conceded.Add(14, 32);
            conceded.Add(15, 60);
            conceded.Add(16, 33);
            conceded.Add(17, 23);
            conceded.Add(18, 48);
            conceded.Add(19, 45);
            conceded.Add(20, 43);
        }

        public string GetName(int cc)
        {
            return teamList[cc];
        }

        public int GetWon(int cc)
        {
            return won[cc];
        }

        public int GetDrawn(int cc)
        {
            return drawn[cc];
        }

        public int GetLost(int xD)
        {
            return lost[xD];
        }

        public int GetScored(int cc)
        {
            return scored[cc];
        }

        public int GetConceded(int cc)
        {
            return conceded[cc];
        }
    }
}
