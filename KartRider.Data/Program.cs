using System;
using System.Windows.Forms;

namespace KartRider
{
	internal static class Program
	{
		public static Launcher LauncherDlg;
		public static GetKart GetKartDlg;
		public static bool SpeedPatch;
		public static bool PreventItem;
		public static bool Developer_Name;

		static Program()
		{
			Program.Developer_Name = true;
		}

		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Launcher StartLauncher = new Launcher();
			Program.LauncherDlg = StartLauncher;
			Application.Run(StartLauncher);
		}
	}
}