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
	public partial class Resumen : ContentPage
	{
		public Resumen (string  nombre, string total, string usuario)
		{
			InitializeComponent ();
			lblNombre.Text = nombre;
			lblMensual.Text = total;
			lblUser.Text = usuario;
			
		}
	}
}