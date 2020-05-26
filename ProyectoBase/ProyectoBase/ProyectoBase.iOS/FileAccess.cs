using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using UIKit;

namespace ProyectoBase.iOS
{
	public class FileAccess
	{
		public static string GetLocalFilePath(String filename)
		{
			string personalFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string libraryFolder = Path.Combine(personalFolder, "..", "Library");
			var path = Path.Combine(libraryFolder, filename);
			return path;
		}
	}
}
