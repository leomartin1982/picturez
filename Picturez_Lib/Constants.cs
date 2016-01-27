﻿using System;
using System.IO;
using System.Net;
using System.Globalization;
using System.Threading;

namespace Picturez_Lib
{
	public delegate void OnUpdateAvailableDelegate(float newVersion);

	public class Constants
	{
		private static Constants instance;
		public static Constants I
		{
			get
			{
				if (instance == null) {
					instance = new Constants ();
				}
				return instance;
			}
		}

		public OnUpdateAvailableDelegate OnUpdateAvailable;

		public const int TIME_DOUBLECLICK = 500; 
		public const string AUTHOR = "Picturez Group";
		public const string EXENAME = "Picturez.exe";
		public const string ICONNAME = "icon.ico";
		public const string WEBSITE = "www.picturez-project.de";
		public const string UPDATESERVERFILE = 
			"http://www.picturez-project.de/PicturezVersion";
		public const string TITLE = "Picturez";
		public const string TITLE_LIB = "Picturez_Lib";
		public const string DESCRIPTION_FIX_IN_ENGLISH = "A slender tool to convert and edit photos.";
		public const string VERSION = "3.0.0.1";
		public static DateTime PUBLISHDATE = new DateTime (2016, 01, 27);
		public static string PUBLISHDATE_STRING {
			get {
//				return PICTUREZ_PUBLISHDATE.ToString ("d", new CultureInfo("en-US"));
				 return PUBLISHDATE.ToString ("d", CultureInfo.CurrentUICulture);
			}
		}

		private float versionFloat;
		public float VERSION_FLOAT { get {	return versionFloat; } }

		private string description;
		public string DESCRIPTION { get {	return description; } }

		private bool editmode;
		public bool EDITMODE { get { return editmode; }}

		private bool windows;
		public bool WINDOWS { get { return windows; }}
				
		private string exepath;
		public string EXEPATH { get { return exepath; }}

		private string homepath;
		public string HOMEPATH { get { return homepath; }}

		public void Init()
		{
			editmode = true;
			windows = IsWindows ();
			exepath = AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar;
			homepath = windows ? Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%")
				: Environment.GetEnvironmentVariable("HOME");
			homepath += Path.DirectorySeparatorChar;

			// picturezName = Language.I.L[52]; // Now: Constants.TITLE
//			picturezVersion = Language.I.L[53];
			description = Language.I.L[54];
//			picturezPublishdate = Language.I.L[55];
			versionFloat = GetFloatVersionNumber (VERSION);
			CheckUpdateAsThread ();
		}	

		private bool IsWindows()
		{
			switch (Environment.OSVersion.Platform)
			{
			case PlatformID.Unix:
				return false;
			case PlatformID.MacOSX:
				return false;
			default:
				return true;
			}
		}

		private void CheckUpdateAsThread()
		{
			Thread thread = new Thread(CheckUpdate);
			thread.IsBackground = true;
			thread.Start();
		}

		private void CheckUpdate()
		{
			try
			{
				WebRequest request = WebRequest.Create(UPDATESERVERFILE);
				WebResponse response = request.GetResponse();
				StreamReader r = new StreamReader(response.GetResponseStream());
				string serverVersion = r.ReadLine();
				r.Close();
				float serverVersionFloat = GetFloatVersionNumber(serverVersion);
				bool updateAvailable = versionFloat < serverVersionFloat;

				//fire the event now
				if (updateAvailable && this.OnUpdateAvailable != null) //is there a EventHandler?
				{
					this.OnUpdateAvailable.Invoke(serverVersionFloat); //calls its EventHandler                
				} //if not, ignore

				Console.WriteLine("serverVersionFloat: " + serverVersionFloat);
//				Console.WriteLine("updateAvailable: " + updateAvailable);
			}
			catch (/*System.Net.WebException*/Exception e)
			{
				// when catching here, no internet is available or
				// server is not available.
				Console.WriteLine(e.Message);
//				Console.WriteLine(e.StackTrace);
			}
		}
			
		private static float GetFloatVersionNumber(string version)
		{
			int pos = version.IndexOf ('.');
			string subs = version.Substring(0, pos + 1) + version.Substring (pos).Replace (".", "");
			return float.Parse (subs, CultureInfo.CreateSpecificCulture("en-us"));			
		}
	}
}
