using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace ProyectoBase.Droid
{
	public class FileAccess
	{
		public static string GetLocalFilePath(string filename)
		{
			string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
			return System.IO.Path.Combine(path, filename);
		}
	}
}