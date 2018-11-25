using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> extList = GetExtensions(
			$@"{Directory.GetCurrentDirectory()}\folder\", "*.*");
			extList.ForEach(Console.WriteLine);
		}

		public static List<string> GetExtensions(string path, string file)
		{
			DirectoryInfo directory = new DirectoryInfo(path);
			FileInfo[] Files = directory.GetFiles(file);
			List<string> extList = new List<string>();
			foreach (FileInfo f in Files)
			{
				extList.Add(Path.GetExtension(f.ToString()));
			}
			List<string> extensions = extList.Distinct().ToList();
			return extensions;
		}
	}
}
