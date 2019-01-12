﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnesInstaller
{
	static class Program
	{

		public static Mutex instanceMutex;

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			instanceMutex = new Mutex(false, "SnesInstaller_SingleInstanceMutex");
			if (instanceMutex.WaitOne(1000, true))
			{
				try
				{
					Application.Run(new SplashScreen());
					instanceMutex.ReleaseMutex();
				}
				catch (Exception) { }
			}
			else
			{
				System.Media.SystemSounds.Beep.Play();
				Console.Out.WriteLine("Exiting because another instance of the application is already open.");
				Console.Out.WriteLine("If it actually isn't, restart the computer.");
			}
		}
	}
}
