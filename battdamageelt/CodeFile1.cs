using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace battdamageelt
{
    class Pokemon
    {
        public string strNickname;
        public int intLevel;
        public int intAttack;
        public int intDefence;
        public Pokemon(string strNicknameA, int intLevelA, int intAttackA, int intDefenceA)
        {
            strNickname = strNicknameA;
            intLevel = intLevelA;
            intAttack = intAttackA;
            intDefence = intDefenceA;
        }

        public string getDescription()

        {
            string strRetVal = "this Pokemon is named: " + strNickname + "\n" + strNickname + "'s level is: " + intLevel;
            strRetVal += "\n" + strNickname + "/s attack is:" + intAttack;
            return strRetVal;

        }
    }
}