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

namespace ProyectoSegundoParcial
{
    /// <summary>
    /// Lógica de interacción para CarnesFrias.xaml
    /// </summary>
    public partial class CarnesFrias : UserControl
    {
        public CarnesFrias()
        {
            InitializeComponent();
        }

        private void CmbCarnes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            grisdecarnesfrias.Children.Clear();
            switch (cmbCarnes.SelectedIndex)
                {
                case 0:
                    grisdecarnesfrias.Children.Add(new Restipodecarne());
                    break;
                case 1:
                    grisdecarnesfrias.Children.Add(new Carnetipopollo());
                    break;
                default:
                    break;
            }
        }
    }
}
