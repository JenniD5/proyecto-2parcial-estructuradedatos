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
    /// Lógica de interacción para Blancos.xaml
    /// </summary>
    public partial class Blancos : UserControl
    {
        public Blancos()
        {
            InitializeComponent();
        }

        private void Cmbelectrodomesticos__SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            gridelectrodomesticos.Children.Clear();
            switch (cmbelectrodomesticos_.SelectedIndex)
            {
                case 0:
                    gridelectrodomesticos.Children.Add(new blancos_licuadora());
                    break;
            }
        }


    }
}

