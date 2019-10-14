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
    /// Lógica de interacción para Frutas_y_verduras.xaml
    /// </summary>
    public partial class Frutas_y_verduras : UserControl
    {
        public Frutas_y_verduras()
        {
            InitializeComponent();
        }

        private void Btngurdar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtkilo.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtprecio.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtpuntos.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txttienda.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            
            else
            {

                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtkilo.Visibility = Visibility.Hidden;
                txtdescuento.Visibility = Visibility.Hidden;
                txtprecio.Visibility = Visibility.Hidden;
                txtpuntos.Visibility = Visibility.Hidden;
                txttienda.Visibility = Visibility.Hidden;
                cmbpiezas.Visibility = Visibility.Hidden;
                cmbproducto.Visibility = Visibility.Hidden;
                lb1.Visibility = Visibility.Hidden;
                lb2.Visibility = Visibility.Hidden;
                lbdescuento.Visibility = Visibility.Hidden;
                lbentrega.Visibility = Visibility.Hidden;
                lbkilo.Visibility = Visibility.Hidden;
                lbpiezas.Visibility = Visibility.Hidden;
                lbprecio.Visibility = Visibility.Hidden;
                lbproducto.Visibility = Visibility.Hidden;
                lbpuntos.Visibility = Visibility.Hidden;
                lbtienda.Visibility = Visibility.Hidden;
                btncancelar.Visibility = Visibility.Hidden;
                btnguardar.Visibility = Visibility.Hidden;
                c1.Visibility = Visibility.Hidden;
                c2.Visibility = Visibility.Hidden;
                c3.Visibility = Visibility.Hidden;
                lbpuntos_Copy.Visibility = Visibility.Hidden;


            }


        }

        private void Btcancelar_Click(object sender, RoutedEventArgs e)
        {
            txtdescuento.Text = "";
            txtkilo.Text = "";
            txtprecio.Text = "";
            txtpuntos.Text = "";
            txttienda.Text = "";
            txtdesaparecer.Visibility = Visibility.Hidden;
            MessageBox.Show("Usted va a cancelar el proceso");
            txtkilo.Visibility = Visibility.Hidden;
            txtdescuento.Visibility = Visibility.Hidden;
            txtprecio.Visibility = Visibility.Hidden;
            txtpuntos.Visibility = Visibility.Hidden;
            txttienda.Visibility = Visibility.Hidden;
            cmbpiezas.Visibility = Visibility.Hidden;
            cmbproducto.Visibility = Visibility.Hidden;
            lb1.Visibility = Visibility.Hidden;
            lb2.Visibility = Visibility.Hidden;
            lbdescuento.Visibility = Visibility.Hidden;
            lbentrega.Visibility = Visibility.Hidden;
            lbkilo.Visibility = Visibility.Hidden;
            lbpiezas.Visibility = Visibility.Hidden;
            lbprecio.Visibility = Visibility.Hidden;
            lbproducto.Visibility = Visibility.Hidden;
            lbpuntos.Visibility = Visibility.Hidden;
            lbtienda.Visibility = Visibility.Hidden;
            btncancelar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            c1.Visibility = Visibility.Hidden;
            c2.Visibility = Visibility.Hidden;
            c3.Visibility = Visibility.Hidden;
            lbpuntos_Copy.Visibility = Visibility.Hidden;
        }

        private void Cmbproducto_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Cmbpiezas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtkilo_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txttienda_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtprecio_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtpuntos_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtdescuento_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }
    }
}
