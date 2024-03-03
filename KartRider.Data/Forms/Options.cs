using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Set_Data;

namespace KartRider
{
	public partial class Options : Form
	{
		public Options()
		{
			InitializeComponent();
		}

		private void DataPack_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (DataPack_CheckBox.Checked == true)
			{
				Set_ETC.DataPack_Use = 1;
			}
			else if (DataPack_CheckBox.Checked == false)
			{
				Set_ETC.DataPack_Use = 0;
			}
			Set_ETC.Save_DataPack();
			Set_ETC.Check_DataPack();
		}

		private void Options_Load(object sender, EventArgs e)
		{
			Set_ETC.Load_ALL2();
		}
	}
}