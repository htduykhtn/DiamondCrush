using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1
{
    public class CUser
    {
        public static bool _isOfflineUserExist = false;
        private uint _id;
        private String _userName;
        private String _passWord;
        public uint _goldCount { get; set; }
        public uint _lifeCount { get; set; }
        public uint _totalScore { get; set; }
        public uint _currLevel { get; set; }
        private CLevel[] _level;
        public uint _harmmerCount { get; set; }
        public uint _flashCount { get; set; }
        public uint _sandClockCount { get; set; }

        //public uint CurrLevel { get { return _currLevel; } set { _currLevel = value; } }
        //public uint ID { get { return _id; } set { _id = value; } }
        //public String UserName { get { return _userName; } set { _userName = value; } }
        //public String PassWord { get { return _passWord; } set { _passWord = value; } }
        //public uint Gold { get { return _gold; } set { _gold = value; } }
        //public ushort TotalScore { get { return _totalScore; } set { _totalScore = value; } }
        private static CUser _instance=null;
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
        public static void UpdateOfflineUserInfo()
        {
            var user = CUser.Instance();
            string[] str = { user._goldCount.ToString(), user._lifeCount.ToString(), user._totalScore.ToString(), user._currLevel.ToString() };
            System.IO.File.WriteAllLines("User.txt", str);
        }
        public static void UpdateOfflineItemCount()
        {
            var user = CUser.Instance();
            string[] str = { user._harmmerCount.ToString(), user._flashCount.ToString(), user._sandClockCount.ToString() };
            System.IO.File.WriteAllLines("Item.txt", str);
        }
        private CUser()
        {

            //Initialize from db
            //...
            //Initialize levels
            _level = new CLevel[9];
            for (int i = 0; i < 9; i++)
                _level[i] = new CLevel();
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
