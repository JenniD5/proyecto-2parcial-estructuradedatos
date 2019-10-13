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
    /// Lógica de interacción para Electronicos.xaml
    /// </summary>
    public partial class Electronicos : UserControl
    {
        public Electronicos()
        {
            InitializeComponent();
        }

        

        private void Txtgarantia_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtmarca_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txttienda_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txttienda_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtdescripcion_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtdescripcion_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Cmbtipos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Checked_2(object sender, RoutedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        

        private void Btng_Click(object sender, RoutedEventArgs e)
        {
            
                if (string.IsNullOrEmpty(txtdescripcion.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(txtdescripcion_Copy.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(txtgarantia.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(txtmarca.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(txttienda.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(txttienda_Copy.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                else if (string.IsNullOrEmpty(cmbtipos.Text))
                {

                    txtdesaparecer.Visibility = Visibility.Visible;

                    return;

                }
                

                else
                {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtdescripcion.Visibility = Visibility.Hidden;
                txtdescripcion_Copy.Visibility = Visibility.Hidden;
                txtgarantia.Visibility = Visibility.Hidden;
                txtmarca.Visibility = Visibility.Hidden;
                txttienda.Visibility = Visibility.Hidden;
                txttienda_Copy.Visibility = Visibility.Hidden;
                lbgarantia.Visibility = Visibility.Hidden;
                lbl2.Visibility = Visibility.Hidden;
                lbl3.Visibility = Visibility.Hidden;
                lbldescription.Visibility = Visibility.Hidden;
                lblextra1.Visibility = Visibility.Hidden;
                lblextra2.Visibility = Visibility.Hidden;
                lblmarca.Visibility = Visibility.Hidden;
                lbltienda.Visibility = Visibility.Hidden;
                lbltipo.Visibility = Visibility.Hidden;
                cmbtipos.Visibility = Visibility.Hidden;
                lborden.Visibility = Visibility.Hidden;
                ll1.Visibility = Visibility.Hidden;
            }

        }

        private void Btncan_Click(object sender, RoutedEventArgs e)
        {
            txtdescripcion.Text = "";
            txtdescripcion_Copy.Text = "";
            txtgarantia.Text = "";
            txtmarca.Text = "";
            txttienda.Text = "";
            txttienda_Copy.Text = "";
            cmbtipos.Text = "";
        }
    }
}
