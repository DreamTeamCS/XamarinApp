using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XamarinApp
{
    public class Team
    {
        Teams position = new Teams();

        private int _position;
        public int Position
        {
            get { return _position; }
            set { _position = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _scored;
        public int Scored
        {
            get { return _scored; }
            set { _scored = value; }
        }
        private int _conceded;
        public int Conceded
        {
            get { return _conceded; }
            set { _conceded = value; }
        }
        private int _won;
        public int Won
        {
            get { return _won; }
            set { _won = value; }
        }
        private int _drawn;
        public int Drawn
        {
            get { return _drawn; }
            set { _drawn = value; }
        }
        private int _lost;
        public int Lost
        {
            get { return _lost; }
            set { _lost = value; }
        }

        public int GoalDifference()
        {
            return _scored - _conceded;
        }
        public int Played()
        {
            return _won + _drawn + _lost;
        }
        public int Points()
        {
            return _won * 3 + _drawn;
        }

        public void GetTeam(int pos)
        {
            _position = pos;
            _name = position.GetName(pos);
            _won = position.GetWon(pos);
            _drawn = position.GetDrawn(pos);
            _lost = position.GetLost(pos);
            _scored = position.GetScored(pos);
            _conceded = position.GetConceded(pos);
        }
    }
}
