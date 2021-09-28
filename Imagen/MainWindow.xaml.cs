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

namespace Imagen
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AltaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 1;
        }

        private void MediaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 0.6;
        }

        private void BajaRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Opacity = 0.3;
        }

        private void RellenoRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.Fill;
        }

        private void UniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.Uniform;
        }

        private void RellenoUniformeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.UniformToFill;
        }

        private void NoneRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            StarWarsImage.Stretch = Stretch.None;
        }
    }
}
