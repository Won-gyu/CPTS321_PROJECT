using CPTS321_PROJECT.Src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace CPTS321_PROJECT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonDo_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Do);
        }

        private void ButtonRe_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Re);
        }

        private void ButtonMi_Click(object sender, RoutedEventArgs e)
        {
            Piano.Instance.Play(Piano.Scale.Mi);
        }

        private void ButtonOpenSubform_Click(object sender, RoutedEventArgs e)
        {
            Subform subform = new Subform();
            subform.Show();
        }
    }
}
