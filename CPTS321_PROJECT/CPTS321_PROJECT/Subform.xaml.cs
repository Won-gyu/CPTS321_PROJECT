using CPTS321_PROJECT.Src;
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
using System.Windows.Shapes;

namespace CPTS321_PROJECT
{
    /// <summary>
    /// Interaction logic for Subform.xaml
    /// </summary>
    public partial class Subform : Window
    {
        public Subform()
        {
            InitializeComponent();
        }

        private void ButtonFa_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Fa);
        }

        private void ButtonSol_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Sol);
        }

        private void ButtonLa_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.La);
        }
        private void ButtonSi_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Si);
        }
    }
}
