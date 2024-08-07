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
        public int intSpecial;
        public int intHP;
        public string strType;
        public Pokemon(string strNicknameA, int intLevelA, int intAttackA, int intDefenceA, int intSpecialA, int inHPA, string strTypeA)
        {
            strNickname = strNicknameA;
            intLevel = intLevelA;
            intAttack = intAttackA;
            intDefence = intDefenceA;
            intSpecial = intSpecialA;
            intHP = inHPA;
            strType = strTypeA;
        }

        public string getDescription()

        {
            string strRetVal = "Name: " + strNickname + "\n" + "level: " + intLevel;
            strRetVal += "\n" + "attack: " + intAttack;
            strRetVal += "\n" + "Defence: " + intDefence;
            strRetVal += "\n" + "Special: " + intSpecial;
            strRetVal += "\n" + "HP: " + intHP;
            strRetVal += "\n" + "Type: " + strType;
            return strRetVal;

        }

    }
}