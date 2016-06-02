using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CLevel
    {
        public static uint _chosenLevelID;
        private uint LevelID
        {
            get; set;
        }
        private bool _isUnlocked;
        public bool IsUnlocked { get { return _isUnlocked; } set { _isUnlocked = value; } }
        private uint _invidualScore;
        private uint _invidualStar;
        private uint [] _rankedScore;
        private Rectangle _lvBoundBox;
        public Point LevelImageLocation { get; set; }
        //This variable get data from Table["Level"]
        private uint _numberUnlocked;

        public CLevel(uint ID, Point imageLocation)
        {
            _lvBoundBox = new Rectangle(imageLocation.X
                , imageLocation.Y, 140, 140);
        }
        public uint ReadyToStart(uint LifeCount)
        {
            if (_isUnlocked && (LifeCount > 0))
            {
                //Show game scene;
                return 1;
            }
            //Not enough life
            else if (LifeCount == 0) return 2;
            //Level is locked.
            return 0;
        }
        public bool IsClicked(int x, int y)
        {
            if (_lvBoundBox.Contains(new Point(x, y)))
                return true;
            return false;
        }
    }
}
