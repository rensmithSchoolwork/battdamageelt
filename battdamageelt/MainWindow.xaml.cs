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

    public partial class MainWindow : Window
    {
        Pokemon pokeChari = new Pokemon("FireDragon", 60, 100, 200, 10, 100, "Fire");
        Pokemon pokePika = new Pokemon("WeakMouse", 11, 5, 6, 50, 100, "Electricity");
        Pokemon pokeLapra = new Pokemon("WaterDragon", 100, 100, 8, 0, 95, "Water");
        Pokemon pokeMonke = new Pokemon("Monke", 10, 50, 50, 1000, 1000, "Monke");
        Pokemon pokeChar = new Pokemon("TinyFireDragon", 60, 100, 200, 10, 100, "Fire");
        Pokemon pokeTest = new Pokemon("Test", 100, 100, 100, 100, 100, "Fire");

        Pokemon[] arrPoke = new Pokemon[6];
        string[] effect = { "0", "0.25", "0.5", "1", "2", "4" };



        public MainWindow()
        {
            InitializeComponent();

            arrPoke[0] = pokeChari;
            arrPoke[1] = pokePika;
            arrPoke[2] = pokeLapra;
            arrPoke[3] = pokeMonke;
            arrPoke[4] = pokeChar;
            arrPoke[5] = pokeTest;

            for (int i = 0; i < arrPoke.Length; i++)
            {
                PokeAChoose.Items.Add(arrPoke[i].strNickname);
            }

            for (int i = 0; i < arrPoke.Length; i++)
            {
                PokeBChoose.Items.Add(arrPoke[i].strNickname);
            }
            PokeAChoose.SelectedIndex = 0;

            PokeBChoose.SelectedIndex = 0;


            for (int i = 0; i < effect.Length; i++)
            {
                drpdwneffect.Items.Add(effect[i]);
            }

            drpdwneffect.SelectedIndex = 3;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void CalcDamage()
        {
            //int intLevel, int intAttack, int intDefence, int intSpecial

            // get handle on attacking pokemon
            int A = arrPoke[PokeAChoose.SelectedIndex].intLevel;
            bool checkvalidtxt = int.TryParse(txtpokemove.Text, out int C);
            int D = arrPoke[PokeBChoose.SelectedIndex].intDefence; // defending pokemon
            double X = 1;
            if (chkSTAB.IsChecked == true)
            {
                X = 1.5;
            }
            double Y = 1;
            if (drpdwneffect.SelectedIndex == 0)
            {
                Y = 0;

            }

            if (drpdwneffect.SelectedIndex == 1)
            {
                Y = 0.25;

            }

            if (drpdwneffect.SelectedIndex == 2)
            {
                Y = 0.5;

            }

            if (drpdwneffect.SelectedIndex == 3)
            {
                Y = 1;

            }

            if (drpdwneffect.SelectedIndex == 4)
            {
                Y = 2;

            }

            if (drpdwneffect.SelectedIndex == 5)
            {
                Y = 4;

            }




            int intPokeLvl = -999;
            bool booValid = int.TryParse(txtpokemove.Text, out intPokeLvl);

            bool booNumInRange = true;
            // With this logic, we accept the number (don't turn booNumInRange to false) if it is between 1-100 inclusive.
            if (intPokeLvl <= 0 || intPokeLvl > 255)
            {
                booNumInRange = false;
            }

            double B;


            if (SpecHitchbox.IsChecked == true)
            {

                B = arrPoke[PokeAChoose.SelectedIndex].intSpecial;

            }
            else
            {
                B = arrPoke[PokeAChoose.SelectedIndex].intAttack;

            }

            int L;

            if (Crithitckbox.IsChecked == true)
            {

                L = 2;

            }
            else
            {
                L = 1;
            }

            double minmath = ((((((((2 * A * L / 5 + 2) * B * C) / D) / 50) + 2) * X) * Y) * 217) / 255;
            double maxmath = ((((((((2 * A * L / 5 + 2) * B * C) / D) / 50) + 2) * X) * Y) * 255) / 255;
            double percenmin = (minmath / arrPoke[PokeBChoose.SelectedIndex].intHP) * 100;
            double percenmax = (maxmath / arrPoke[PokeBChoose.SelectedIndex].intHP) * 100;

            double roundminper = Math.Round(percenmin, 2);
            double roundmaxper = Math.Round(percenmax, 2);

            double roundmin = Math.Round(minmath, 3);
            double roundmax = Math.Round(maxmath, 3);

            

            string fgtretval = "Minimum: " + roundmin;
            fgtretval += $"\nMinimum Percent: {roundminper}%";
            fgtretval += '\n' + "Maximum: " + roundmax;
            fgtretval += $"\nMaximum Percent: {roundmaxper}%";

            if (roundmax >= 100)
            {
                fgtretval += "\n";
                fgtretval += $"\n Guaranteed 1 Hit KO";


            }

            if (booValid == false || booNumInRange == false)
            {
                MessageBox.Show("The Move effectiveness must be a number!");
            }
            else
            {
                FIghtlbl.Content = fgtretval;
            }

           




        }





        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            PokeADesc.Content = arrPoke[PokeAChoose.SelectedIndex].getDescription();

        }

        private void PokeBChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PokeBDesc.Content = arrPoke[PokeBChoose.SelectedIndex].getDescription();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // fight clicked
            CalcDamage();
        }

        private void CheckBox_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
