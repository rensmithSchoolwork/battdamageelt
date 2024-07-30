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

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Pokemon pokeChari = new Pokemon("FireDragon", 60, 100);
        Pokemon pokePika = new Pokemon("WeakMouse", 11, 5);
        Pokemon pokeLapra = new Pokemon("WaterDragon", 100, 100);
        Pokemon pokeMonke = new Pokemon("Monke", 10, 50);

        Pokemon[] arrPoke = new Pokemon[4];

        public MainWindow()
        {
            InitializeComponent();

            arrPoke[0] = pokeChari;
            arrPoke[1] = pokePika;
            arrPoke[2] = pokeLapra;
            arrPoke[3] = pokeMonke;

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
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PokeADesc.Content = arrPoke[PokeAChoose.SelectedIndex].getDescription();
            
        }

        private void PokeBChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            PokeBDesc.Content = arrPoke[PokeBChoose.SelectedIndex].getDescription();
        }
    }
}
