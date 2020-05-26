using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProyectoBase.Model;
using SQLite;

namespace ProyectoBase.Access
{
	public class UserRepository
	{
		private SQLiteConnection connection;
		private static UserRepository instance;
		public String StatusMessage;

		public static UserRepository Instance
		{
			get
			{
				if (instance == null)
				{
					throw new Exception("Debe llamar al inicializador.");
				}


				return Instance;
			}
		}

		public static void Inicializador(String filename)
		{
			if (filename == null)
			{
				throw new ArgumentNullException("El parametro filename no puede ser nulo.");
			}

			if (instance != null)
			{
				instance.connection.Close();
			}

			instance = new UserRepository(filename);
		}

		private UserRepository(String dbPath)
		{
			connection = new SQLiteConnection(dbPath);
			connection.CreateTable<User>();
		}

		public int AddNewUser(string username, string email, string password)
		{
			int affectedRows = 0;

			try
			{
				affectedRows = connection.Insert(new User()
				{
					Username = username,
					Email = email,
					Password = password
				});

				StatusMessage = string.Format("Cantidad de filas afectadas: {0}", affectedRows);
			}
			catch (Exception e)
			{
				StatusMessage = e.Message;
			}

			return affectedRows;
		}

		public IEnumerable<User> GetAllUsers()
		{
			try
			{
				return connection.Table<User>();
			}
			catch (Exception e)
			{
				StatusMessage = e.Message;
			}

			return Enumerable.Empty<User>();
		}
	}
}
