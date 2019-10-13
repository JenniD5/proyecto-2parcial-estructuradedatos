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
    /// Lógica de interacción para Carnetipopollo.xaml
    /// </summary>
    public partial class Carnetipopollo : UserControl
    {
        public Carnetipopollo()
        {
            InitializeComponent();
        }

        private void Btngurdar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtdscripcioncarne.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtdscripcioncarne_Copy.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtkilos.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtkilos_Copy.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtlugar.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(cmbcantidad.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(cmbcantidd2.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtdscripcioncarne.Visibility = Visibility.Hidden;
                txtdscripcioncarne_Copy.Visibility = Visibility.Hidden;
                txtkilos.Visibility = Visibility.Hidden;
                txtkilos_Copy.Visibility = Visibility.Hidden;
                txtlugar.Visibility = Visibility.Hidden;
                lbextra3.Visibility = Visibility.Hidden;
                lbl2.Visibility = Visibility.Hidden;
                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lblc.Visibility = Visibility.Hidden;
                lblcanti.Visibility = Visibility.Hidden;
                lbldeccopy.Visibility = Visibility.Hidden;
                lbllugar.Visibility = Visibility.Hidden;
                lblseleccion.Visibility = Visibility.Hidden;
                extra1.Visibility = Visibility.Hidden;
                extra2.Visibility = Visibility.Hidden;
                cmbcantidad.Visibility = Visibility.Hidden;
                cmbcantidd2.Visibility = Visibility.Hidden;
            }
        }

        private void Btcancelar_Click(object sender, RoutedEventArgs e)
        {
            txtdscripcioncarne.Text = "";
            txtdscripcioncarne_Copy.Text = "";
            txtkilos.Text = "";
            txtkilos_Copy.Text = "";
            txtlugar.Text = "";

        }

        private void Txtkilos_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtdscripcioncarne_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtkilos_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtdscripcioncarne_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtlugar_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }
    }
}
    

