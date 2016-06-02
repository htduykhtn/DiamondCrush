using Diamond_Crush;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class CUser
    {
        private uint _id;
        private String _userName;
        private String _passWord;
        private uint _goldCount;
        private uint _lifeCount;
        private ushort _totalScore;
        private uint _currLevel;
        private CLevel[] _level;
        private CItem[][] _ownedItem;
        
        //public uint CurrLevel { get { return _currLevel; } set { _currLevel = value; } }
        //public uint ID { get { return _id; } set { _id = value; } }
        //public String UserName { get { return _userName; } set { _userName = value; } }
        //public String PassWord { get { return _passWord; } set { _passWord = value; } }
        //public uint Gold { get { return _gold; } set { _gold = value; } }
        //public ushort TotalScore { get { return _totalScore; } set { _totalScore = value; } }
        public static CUser _instance=null;
        public static String _staticUsername="";
        public static String _staticPassword="";
        public static CUser Instance()
        {
            if(_instance ==null)
            {
                _instance = new CUser();
                return _instance;
            }
            return _instance;
        }
        private CUser()
        {

            //Initialize from db
            //...
            //Initialize levels
            _currLevel = 8;
            _level = new CLevel[9];
            for (uint i = 0; i < 9; i++)
            {
                _level[i] = new CLevel(i, PickLevelScene.SetLevelLocation(i));
                if (i < _currLevel)
                {
                    _level[i].IsUnlocked = true;
                }
            }
            //Initialize items from db
            //_ownedItem = new CItem[3][...]
        }
        public bool BuyItem(uint ItemID)
        {
            //Waiting for Database
            return false;
        }
        public bool UseItem(uint ItemID)
        {
            //Waiting for Database
            return false;
        }
        public void Delete()
        {
            _instance = null;
        }
        public bool GetLevelUnlockState(uint levelID)
        {
            return _level[levelID].IsUnlocked;
        }
        public CLevel GetLevel(int i ) { return _level[i]; }
    }
}
