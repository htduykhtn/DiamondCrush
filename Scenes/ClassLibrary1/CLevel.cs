using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class CLevel
    {
        
        public static CLevel _currLevel = new CLevel();
        public uint LevelID { get; set; }
        private bool _isUnlocked;
        public bool IsUnlocked { get { return _isUnlocked; } set { _isUnlocked = value; } }
        public uint _highestScore { get; set; }
        public uint _highestStar { get; set; }
        //This variable get data from Table["Level"]
        private uint _numberUnlocked;
        public static void UpdateOfflineLevelInfo(int lvID)
        {
            var user = CUser.Instance();
            var level = user.GetLevel(lvID);
            string[] str = { level._highestScore.ToString(), level._highestStar.ToString() };
            System.IO.File.WriteAllLines("Level_" + lvID.ToString() + ".txt", str);
        }
        public CLevel()
        {
            //Waiting for database
            
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
        public void UpdateInvidualScore(uint newScore)
        {
            //Update db
        }
        public uint UpdateInvidualStarOffset(uint newStar)
        {
            if (newStar > _highestStar)
            {
                //Update db
                _highestStar = newStar;
                return (newStar - _highestStar);
            }
            return 0;
        }
        public void InitializeRank()
        {
            //Waiting for database
            //_rankedScore = new uint[_numberUnlocked];
            // Initialize from database
        }
    }
}
