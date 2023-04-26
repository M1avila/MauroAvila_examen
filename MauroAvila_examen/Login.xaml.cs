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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtPasword.Text;
            
            if (usuario == "estudiante2023" && clave == "uisrael2023")
            {
                //await Navigation.PushAsync(new Registro(usuario));
                Navigation.PushAsync(new Registro(usuario));
                txtUsuario.Text = usuario;

            }

            else {
                DisplayAlert("Advertencia", "Usuario y/o Contraseña son incorrectas", "OK");
                txtUsuario.Text = "";
                txtPasword.Text = "";
            }
                



        }
    }
}