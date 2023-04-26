using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MauroAvila_examen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            
         
            string nombre = txtNombre.Text;
            string pinicial=txtPagoinicial.Text;
            string mensual = txtPagomensual.Text; 
            string total=txtTotal.Text;
            string usuario = lblUsuario.Text;
            DisplayAlert("GUARDAR", "Elemento guardado con éxito", "OK");
            
            //  Navigation.PushAsync(new  nombre,pinicial,mensual,user ());
            Navigation.PushAsync(new Resumen(nombre, total, usuario));
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double pago = Convert.ToDouble(txtPagoinicial.Text);
             double pagom= Convert.ToDouble(txtPagomensual.Text);

             double rest = (pagom*3)-pago;
            double total = (pagom  * 0.05) *3 +pagom*3;
            double pagpf = (total +pago);
             txtTotal.Text = total.ToString();
             lblTotalF.Text = pagpf.ToString();




        }

        private void txtPagoinicial_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double pago = Convert.ToDouble(txtPagoinicial.Text);
                if (pago<1 && pago>2990) {
                    DisplayAlert("MESAJE", "rango permitido-3000", "cerrar");
                    txtPagoinicial.Text = "";
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("MESAJE", ex.Message,"CERRAR");
            }
        }

        private void txtPagomensual_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double pagom = Convert.ToDouble(txtPagomensual.Text);
                if (pagom < 1 && pagom > 900)
                {
                    DisplayAlert("MESAJE", "rango permitido-900", "cerrar");
                    txtPagomensual.Text = "";
                }
            }
            catch (Exception ex)
            {

                DisplayAlert("MESAJE", ex.Message, "CERRAR");
            }

        }
    }
}