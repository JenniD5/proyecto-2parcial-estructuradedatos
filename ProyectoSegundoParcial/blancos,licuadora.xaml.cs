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
    /// Lógica de interacción para blancos_licuadora.xaml
    /// </summary>
    public partial class blancos_licuadora : UserControl 
    {
        public blancos_licuadora()
        {
            InitializeComponent();
        }

        
        private void Button_Click(object sender, RoutedEventArgs e)  //
        {
            if (string.IsNullOrEmpty(txtpotencia.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }

            //aqui pondrias el codigo de guardar
            else if (string.IsNullOrEmpty(txtastas.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtmarca.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }

            else if (string.IsNullOrEmpty(txtpotencia.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }

            else if (string.IsNullOrEmpty(txtpotencia_Copy.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }

            else if (string.IsNullOrEmpty(txtvasos.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }

            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtastas.Visibility = Visibility.Hidden;  
                txtluz.Visibility = Visibility.Hidden;
                txtmarca.Visibility = Visibility.Hidden;
                txtpotencia.Visibility = Visibility.Hidden;
                txtpotencia_Copy.Visibility = Visibility.Hidden;
                txtvasos.Visibility = Visibility.Hidden;
                txtcantidaddevasos.Visibility = Visibility.Hidden;
                txtformadepago.Visibility = Visibility.Hidden;
                txtpreciomaximo.Visibility = Visibility.Hidden;
                txtseleccione.Visibility = Visibility.Hidden;
                precio1.Visibility = Visibility.Hidden;
                precio2.Visibility = Visibility.Hidden;
                precio3.Visibility = Visibility.Hidden;
                txtseleccione.Visibility = Visibility.Hidden;
                bliockacce.Visibility = Visibility.Hidden;
                blockluz.Visibility = Visibility.Hidden;
                blockpotencia.Visibility = Visibility.Hidden;
                blockastas.Visibility = Visibility.Hidden;
                blmarca.Visibility = Visibility.Hidden;
                cbformadepago.Visibility = Visibility.Hidden;
                txtpotencia_Copy1.Visibility = Visibility.Hidden;
                pago.Visibility = Visibility.Hidden;



            }

        }

        private void Btncancelar_Click(object sender, RoutedEventArgs e)
        {
            txtastas.Text = "";
            txtluz.Text = "";
            txtmarca.Text = "";
            txtpotencia.Text = "";
            txtpotencia_Copy.Text = "";
            txtvasos.Text = "";

        }

        private void Txtpotencia_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtluz_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtpotencia_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtastas_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtmarca_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtvasos_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Pago_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(pago.SelectedIndex)
            {
                case 0:
                    txtpotencia_Copy1.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    txtpotencia_Copy1.Visibility = Visibility.Visible;
                    break;
                default:
                    break;

            }
        }

        private void Btncancelar_Click_1(object sender, RoutedEventArgs e)
        {
            txtpotencia.Text = "";
            txtluz.Text = "";
            txtpotencia_Copy.Text = "";
            txtastas.Text = "";
            txtmarca.Text = "";
            txtvasos.Text = "";
            txtpotencia_Copy1.Text = "";
            


        }
    }
}

    