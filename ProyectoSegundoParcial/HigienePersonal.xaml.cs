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
    /// Lógica de interacción para HigienePersonal.xaml
    /// </summary>
    public partial class HigienePersonal : UserControl
    {
        public HigienePersonal()
        {
            InitializeComponent();
        }

        private void Cmbaccesorios_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (cmbaccesorios.SelectedIndex)
            {
                case 0:
                    
                    cmbhidratacion.Visibility = Visibility.Visible;
                    lbalarante.Visibility = Visibility.Visible;

                    lbltoallatamaño.Visibility = Visibility.Hidden;
                    grande.Visibility = Visibility.Hidden;
                    pequeño.Visibility = Visibility.Hidden;
                   
                    break;
                case 1:
                    lbltoallatamaño.Visibility = Visibility.Visible;
                    grande.Visibility = Visibility.Visible;
                    pequeño.Visibility = Visibility.Visible;
                    lbalarante.Visibility = Visibility.Hidden;
                    cmbhidratacion.Visibility = Visibility.Hidden;
                    
                    break;
                default:
                    break;
            }
        }

        private void Txttoallatamaño_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Txtmililitros_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Cmbfragancias_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(cmbfragancias.SelectedIndex)
            {
                case 0:
                    cmbfragancias_Copy.Visibility = Visibility.Visible;
                    lblmililitros.Visibility = Visibility.Visible;
                    
                    
                    break;
                case 1:
                    cmbfragancias_Copy.Visibility = Visibility.Visible;
                    lblmililitros.Visibility = Visibility.Visible;
                    

                    break;
                default:
                    break;
            }
        }

        private void Txtunidades_TextChanged(object sender, TextChangedEventArgs e)
        {

            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Btngurdar_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtbarras.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcaducidad.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcaducidad_Copy.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
           
            
            else if (string.IsNullOrEmpty(txtunidades.Text))///////////////////////////////////
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txtbarras.Visibility = Visibility.Hidden;
                txtcaducidad.Visibility = Visibility.Hidden;
                txtcaducidad_Copy.Visibility = Visibility.Hidden;
                txtdesaparecer.Visibility = Visibility.Hidden;
                txtunidades.Visibility = Visibility.Hidden;
                cmbaccesorios.Visibility = Visibility.Hidden;
                cmbfragancias.Visibility = Visibility.Hidden;
                cmbhidratacion.Visibility = Visibility.Hidden;
                lbalarante.Visibility = Visibility.Hidden;
                lblaccesorios.Visibility = Visibility.Hidden;
                lblcaducidad.Visibility = Visibility.Hidden;
                lblcaducidad_Copy.Visibility = Visibility.Hidden;
                lblcantidad.Visibility = Visibility.Hidden;
                lblfragancias.Visibility = Visibility.Hidden;
                lblmililitros.Visibility = Visibility.Hidden;
                lbltoallatamaño.Visibility = Visibility.Hidden;
                lblviaje.Visibility = Visibility.Hidden;
                lblviaje_Copy.Visibility = Visibility.Hidden;
                lblviaje_Copy1.Visibility = Visibility.Hidden;
                viaje.Visibility = Visibility.Hidden;
                Viaje2.Visibility = Visibility.Hidden;
                check1.Visibility = Visibility.Hidden;
                check2.Visibility = Visibility.Hidden;
                check2_Copy.Visibility = Visibility.Hidden;
                checknatural.Visibility = Visibility.Hidden;
                cmbfragancias_Copy.Visibility = Visibility.Hidden;
                btncancear3.Visibility = Visibility.Hidden;
                btnguardar2.Visibility = Visibility.Hidden;
                grande.Visibility = Visibility.Hidden;
                pequeño.Visibility = Visibility.Hidden;

            }


        }

        private void Btncan_Click(object sender, RoutedEventArgs e)
        {
            txtbarras.Text = "";
            txtcaducidad.Text = "";
            txtcaducidad_Copy.Text = "";
            txtunidades.Text = "";
            txtdesaparecer.Visibility = Visibility.Hidden;
            MessageBox.Show("Usted va a cancelar el proceso");
            txtbarras.Visibility = Visibility.Hidden;
            txtcaducidad.Visibility = Visibility.Hidden;
            txtcaducidad_Copy.Visibility = Visibility.Hidden;
            txtdesaparecer.Visibility = Visibility.Hidden;
            txtunidades.Visibility = Visibility.Hidden;
            cmbaccesorios.Visibility = Visibility.Hidden;
            cmbfragancias.Visibility = Visibility.Hidden;
            cmbhidratacion.Visibility = Visibility.Hidden;
            lbalarante.Visibility = Visibility.Hidden;
            lblaccesorios.Visibility = Visibility.Hidden;
            lblcaducidad.Visibility = Visibility.Hidden;
            lblcaducidad_Copy.Visibility = Visibility.Hidden;
            lblcantidad.Visibility = Visibility.Hidden;
            lblfragancias.Visibility = Visibility.Hidden;
            lblmililitros.Visibility = Visibility.Hidden;
            lbltoallatamaño.Visibility = Visibility.Hidden;
            lblviaje.Visibility = Visibility.Hidden;
            lblviaje_Copy.Visibility = Visibility.Hidden;
            lblviaje_Copy1.Visibility = Visibility.Hidden;
            viaje.Visibility = Visibility.Hidden;
            Viaje2.Visibility = Visibility.Hidden;
            check1.Visibility = Visibility.Hidden;
            check2.Visibility = Visibility.Hidden;
            check2_Copy.Visibility = Visibility.Hidden;
            checknatural.Visibility = Visibility.Hidden;
            cmbfragancias_Copy.Visibility = Visibility.Hidden;
            btncancear3.Visibility = Visibility.Hidden;
            btnguardar2.Visibility = Visibility.Hidden;
            grande.Visibility = Visibility.Hidden;
            pequeño.Visibility = Visibility.Hidden;

        }
    }
}
