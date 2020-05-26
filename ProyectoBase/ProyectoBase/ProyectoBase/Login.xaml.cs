using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProyectoBase
{
	// Learn more about making custom code visible in the Xamarin.Forms previewer
	// by visiting https://aka.ms/xamarinforms-previewer
	[DesignTimeVisible(false)]
	public partial class Login : ContentPage
	{
		private bool login = false;


		public Login()
		{
			InitializeComponent();
		}

		private void LoginToggle_Clicked(object sender, EventArgs e)
		{
			if (!login)
			{
				ResultadoLabel.Text = "Sesión iniciada con éxito.";
				LoginToggle.Text = "Logout";

				UserInput.IsEnabled = false;
				PasswordInput.IsEnabled = false;

				login = true;
			}
			else
			{
				ResultadoLabel.Text = "Ha cerrado su sesión.";
				LoginToggle.Text = "Login";

				UserInput.IsEnabled = true;
				PasswordInput.IsEnabled = true;

				login = false;
			}
		}

	}
}
