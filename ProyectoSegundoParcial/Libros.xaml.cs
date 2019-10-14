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
    /// Lógica de interacción para Libros.xaml
    /// </summary>
    public partial class Libros : UserControl
    {
        public Libros()
        {
            InitializeComponent();
        }

        /*private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(txtaño.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcolor.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtedicion.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtpaginas.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtpaginas_Copy.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txttitulo.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txttitulo.Visibility = Visibility.Hidden;
                txtpaginas_Copy.Visibility = Visibility.Hidden;
                txtpaginas.Visibility = Visibility.Hidden;
                txtedicion.Visibility = Visibility.Hidden;
                txtcolor.Visibility = Visibility.Hidden;
                lblaño.Visibility = Visibility.Hidden;
                lblcantidad.Visibility = Visibility.Hidden;
                lblcolor.Visibility = Visibility.Hidden;
                lbledicion.Visibility = Visibility.Hidden;
                lblgenero.Visibility = Visibility.Hidden;
                lblpaginas.Visibility = Visibility.Hidden;
                lblpopularidad.Visibility = Visibility.Hidden;
                lblsubgenero.Visibility = Visibility.Hidden;
                lbltitulo.Visibility = Visibility.Hidden;
                _1.Visibility = Visibility.Hidden;
                _2.Visibility = Visibility.Hidden;
                _3.Visibility = Visibility.Hidden;
                _4.Visibility = Visibility.Hidden;
                _5.Visibility = Visibility.Hidden;
                _6.Visibility = Visibility.Hidden;
                _7.Visibility = Visibility.Hidden;
                txtaño.Visibility = Visibility.Hidden;
                cmbcantidadlibros.Visibility = Visibility.Hidden;
                btncancelar.Visibility = Visibility.Hidden;





            }*/
        

        private void Btncancelar_Click(object sender, RoutedEventArgs e)
        {
            txtpaginas.Text = "";
            txtpaginas_Copy.Text = "";
            txtcolor.Text = "";
            txttitulo.Text = "";
            txtedicion.Text = "";
            txtaño.Text = "";
            txtdesaparecer.Visibility = Visibility.Hidden;
            MessageBox.Show("Usted va a cancelar el proceso");
            txttitulo.Visibility = Visibility.Hidden;
            txtpaginas_Copy.Visibility = Visibility.Hidden;
            txtpaginas.Visibility = Visibility.Hidden;
            txtedicion.Visibility = Visibility.Hidden;
            txtcolor.Visibility = Visibility.Hidden;
            lblaño.Visibility = Visibility.Hidden;
            lblcantidad.Visibility = Visibility.Hidden;
            lblcolor.Visibility = Visibility.Hidden;
            lbledicion.Visibility = Visibility.Hidden;
            lblgenero.Visibility = Visibility.Hidden;
            lblpaginas.Visibility = Visibility.Hidden;
            lblpopularidad.Visibility = Visibility.Hidden;
            lblsubgenero.Visibility = Visibility.Hidden;
            lbltitulo.Visibility = Visibility.Hidden;
            _1.Visibility = Visibility.Hidden;
            _2.Visibility = Visibility.Hidden;
            _3.Visibility = Visibility.Hidden;
            _4.Visibility = Visibility.Hidden;
            _5.Visibility = Visibility.Hidden;
            _6.Visibility = Visibility.Hidden;
            _7.Visibility = Visibility.Hidden;
            txtaño.Visibility = Visibility.Hidden;
            cmbcantidadlibros.Visibility = Visibility.Hidden;
            btncancelar.Visibility = Visibility.Hidden;
            btnguardar.Visibility = Visibility.Hidden;
            cmbpopularidad.Visibility = Visibility.Hidden;
            c1.Visibility = Visibility.Hidden;
            c2.Visibility = Visibility.Hidden;
            c3.Visibility = Visibility.Hidden;
            lblaño_Copy.Visibility = Visibility.Hidden;

        }

        private void Txtpaginas_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtpaginas_Copy_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtcolor_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txttitulo_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtaño_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Txtedicion_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtdesaparecer.Visibility = Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtaño.Text))
            {

                txtdesaparecer.Visibility = Visibility.Visible;

                return;

            }
            else if (string.IsNullOrEmpty(txtcolor.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtedicion.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtpaginas.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txtpaginas_Copy.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else if (string.IsNullOrEmpty(txttitulo.Text))
            {
                txtdesaparecer.Visibility = Visibility.Visible;
                return;
            }
            else
            {
                txtdesaparecer.Visibility = Visibility.Hidden;
                MessageBox.Show("se a guardado con exito");
                txttitulo.Visibility = Visibility.Hidden;
                txtpaginas_Copy.Visibility = Visibility.Hidden;
                txtpaginas.Visibility = Visibility.Hidden;
                txtedicion.Visibility = Visibility.Hidden;
                txtcolor.Visibility = Visibility.Hidden;
                lblaño.Visibility = Visibility.Hidden;
                lblcantidad.Visibility = Visibility.Hidden;
                lblcolor.Visibility = Visibility.Hidden;
                lbledicion.Visibility = Visibility.Hidden;
                lblgenero.Visibility = Visibility.Hidden;
                lblpaginas.Visibility = Visibility.Hidden;
                lblpopularidad.Visibility = Visibility.Hidden;
                lblsubgenero.Visibility = Visibility.Hidden;
                lbltitulo.Visibility = Visibility.Hidden;
                _1.Visibility = Visibility.Hidden;
                _2.Visibility = Visibility.Hidden;
                _3.Visibility = Visibility.Hidden;
                _4.Visibility = Visibility.Hidden;
                _5.Visibility = Visibility.Hidden;
                _6.Visibility = Visibility.Hidden;
                _7.Visibility = Visibility.Hidden;
                txtaño.Visibility = Visibility.Hidden;
                cmbcantidadlibros.Visibility = Visibility.Hidden;
                btncancelar.Visibility = Visibility.Hidden;
                btnguardar.Visibility = Visibility.Hidden;
                cmbpopularidad.Visibility = Visibility.Hidden;
                c1.Visibility = Visibility.Hidden;
                c2.Visibility = Visibility.Hidden;
                c3.Visibility = Visibility.Hidden;
                lblaño_Copy.Visibility = Visibility.Hidden;


            }
        }
    }
}
