using System;
using System.Windows.Forms;

namespace KartRider
{
	public static class LauncherSystem
	{
		public static void MessageBoxType1()
		{
			MessageBox.Show("跑跑卡丁车已经运行了，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
			System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("KartRider");
			foreach (System.Diagnostics.Process p in process)
			{
				p.Kill();
			}
		}

		public static void MessageBoxType2()
		{
			MessageBox.Show("跑跑卡丁车已经运行了，请重试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
			System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("KartRider");
			foreach (System.Diagnostics.Process p in process)
			{
				p.Kill();
			}
		}

		public static void MessageBoxType3()
		{
			MessageBox.Show(Launcher.KartRider + " 找不到文件！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Environment.Exit(1);
		}
	}
}