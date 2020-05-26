using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoBase.Model;
using ProyectoBase.Access;

namespace ProyectoBase
{
	public partial class App : Application
	{
		public App(String filename)
		{
			InitializeComponent();

			UserRepository.Inicializador(filename);
			MainPage = new ProyectoBase.Principal();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
