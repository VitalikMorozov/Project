﻿using System;
using System.Windows.Forms;

namespace Test
{
	static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Главная());
		}
	}

	class repos {
		public static string fName { get; set; }
	}

}
