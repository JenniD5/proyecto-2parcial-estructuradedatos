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
    /// Lógica de interacción para Congelados.xaml
    /// </summary>
    public partial class Congelados : UserControl
    {
        public Congelados()
        {
            InitializeComponent();
        }

        private void Btngurdar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcant1.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcan2.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcant3.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcant4.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;
                
                return;

            }
            else if (string.IsNullOrEmpty(txtcant5.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcant6.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtcan2.Visibility = Visibility.Hidden;
                txtcant1.Visibility = Visibility.Hidden;
                txtcant3.Visibility = Visibility.Hidden;
                txtcant4.Visibility = Visibility.Hidden;
                txtcant5.Visibility = Visibility.Hidden;
                txtcant6.Visibility = Visibility.Hidden;
                lbl1.Visibility = Visibility.Hidden;
                lbl10.Visibility = Visibility.Hidden;
                lbl11.Visibility = Visibility.Hidden;
                lbl12.Visibility = Visibility.Hidden;
                lbl13.Visibility = Visibility.Hidden;
                lbl14.Visibility = Visibility.Hidden;
                lbl15.Visibility = Visibility.Hidden;
                lbl16.Visibility = Visibility.Hidden;
                lbl17.Visibility = Visibility.Hidden;
                lbl2.Visibility = Visibility.Hidden;
                lbl21.Visibility = Visibility.Hidden;
                lbl20.Visibility = Visibility.Hidden;
                lbl3.Visibility = Visibility.Hidden;
                lbl4.Visibility = Visibility.Hidden;
                lbl5.Visibility = Visibility.Hidden;
                lbl6.Visibility = Visibility.Hidden;
                lbl7.Visibility = Visibility.Hidden;
                lbl8.Visibility = Visibility.Hidden;
                lbl9.Visibility = Visibility.Hidden;
                cbm1.Visibility = Visibility.Hidden;
                btncan.Visibility = Visibility.Hidden;
                btnguardar.Visibility = Visibility.Hidden;
                lblcongelados.Visibility = Visibility.Hidden;
                

            }
            
            
        }

        private void Btncan_Click(object sender, RoutedEventArgs e)
        {
            txtcan2.Text = "";
            txtcant1.Text = "";
            txtcant3.Text = "";
            txtcant4.Text = "";
            txtcant5.Text = "";
            txtcant6.Text = "";
            txtdesaparecer.Visibility = Visibility.Hidden;
            MessageBox.Show("Usted va a cancelar el proceso");
            txtcan2.Visibility = Visibility.Hidden;
            txtcant1.Visibility = Visibility.Hidden;
            txtcant3.Visibility = Visibility.Hidden;
            txtcant4.Visibility = Visibility.Hidden;
            txtcant5.Visibility = Visibility.Hidden;
            txtcant6.Visibility = Visibility.Hidden;
            lbl1.Visibility = Visibility.Hidden;
            lbl10.Visibility = Visibility.Hidden;
            lbl11.Visibility = Visibility.Hidden;
            lbl12.Visibility = Visibility.Hidden;
            lbl13.Visibility = Visibility.Hidden;
            lbl14.Visibility = Visibility.Hidden;
            lbl15.Visibility = Visibility.Hidden;
            lbl16.Visibility = Visibility.Hidden;
            lbl17.Visibility = Visibility.Hidden;
            lbl2.Visibility = Visibility.Hidden;
            lbl21.Visibility = Visibility.Hidden;
            lbl20.Visibility = Visibility.Hidden;
            lbl3.Visibility = Visibility.Hidden;
            lbl4.Visibility = Visibility.Hidden;
            lbl5.Visibility = Visibility.Hidden;
            lbl6.Visibility = Visibility.Hidden;
            lbl7.Visibility = Visibility.Hidden;
            lbl8.Visibility = Visibility.Hidden;
            lbl9.Visibility = Visibility.Hidden;
            cbm1.Visibility = Visibility.Hidden;
            btncan.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            lblcongelados.Visibility = Visibility.Hidden;
        }

        private void Txtcant1_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcant3_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcant5_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcant6_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcan2_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcant4_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }
    }
}
