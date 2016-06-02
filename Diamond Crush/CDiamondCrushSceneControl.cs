using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond_Crush
{
    class CDiamondCrushSceneControl
    {
        public enum Scene
        {
            SignIn,
            SignUp,
            MainMenu,
            PickLevel,
            PreviewLevel,
            Gaming,
            Setting,
            Shop
        }
        public static Scene _nextScene{get;set ;}
    }
}
