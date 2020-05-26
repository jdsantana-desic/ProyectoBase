using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProyectoBase.Model;
using ProyectoBase.Access;

namespace ProyectoBase
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Principal : ContentPage
	{
		public Principal()
		{
			InitializeComponent();
		}

		private void BtnInsertUser_Clicked(object sender, EventArgs e)
		{
			statusMessage.Text = string.Empty;
			UserRepository.Instance.AddNewUser(txtUsername.Text, txtEmail.Text, txtPassword.Text);
			statusMessage.Text = UserRepository.Instance.StatusMessage;
		}

		private void BtnGetAllUsers_Clicked(object sender, EventArgs e)
		{
			var allUsers = UserRepository.Instance.GetAllUsers();
			userList.ItemsSource = allUsers;
			statusMessage.Text = UserRepository.Instance.StatusMessage;
		}
	}
}