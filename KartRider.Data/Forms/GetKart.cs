using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using KartRider.IO;
using System.Threading;
using System.IO;
using System.Windows.Forms;

namespace KartRider
{
	public partial class GetKart : Form
	{
		public static short Item_Type = 0;
		public static short Item_Code = 0;

		public GetKart()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetKart.Item_Type = short.Parse(this.tx_ItemType.Text);
			GetKart.Item_Code = short.Parse(this.tx_ItemCode.Text);
			if (Launcher.OpenGetItem)
			{
				(new Thread(() =>
				{
					button1.Enabled = false;
					Thread.Sleep(300);
					if (GetKart.Item_Type == 3)
					{
						Launcher.KartSN++;
						Console.WriteLine("NewKart: {0}:{1}", GetKart.Item_Code, Launcher.KartSN);
						using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
						{
							outPacket.WriteByte(1);
							outPacket.WriteInt(1);
							outPacket.WriteShort(GetKart.Item_Type);
							outPacket.WriteShort(GetKart.Item_Code);
							outPacket.WriteShort(Launcher.KartSN);
							outPacket.WriteShort(1);//수량
							outPacket.WriteShort(0);
							outPacket.WriteShort(-1);
							outPacket.WriteShort(0);
							outPacket.WriteShort(0);
							outPacket.WriteShort(0);
							RouterListener.MySession.Client.Send(outPacket);
						}
					}
					else
					{
						using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
						{
							outPacket.WriteByte(1);
							outPacket.WriteInt(1);
							outPacket.WriteShort(GetKart.Item_Type);
							outPacket.WriteShort(GetKart.Item_Code);
							outPacket.WriteUShort(0);
							outPacket.WriteShort(1);//수량
							outPacket.WriteShort(0);
							outPacket.WriteShort(-1);
							outPacket.WriteShort(0);
							outPacket.WriteShort(0);
							outPacket.WriteShort(0);
							RouterListener.MySession.Client.Send(outPacket);
						}
					}
					Thread.Sleep(300);
					button1.Enabled = true;
				})).Start();
			}
		}

		private void FormItem_Load(object sender, EventArgs e)
		{
			this.tx_ItemType.Text = string.Concat(GetKart.Item_Type);
			this.tx_ItemCode.Text = string.Concat(GetKart.Item_Code);
		}

		private void tx_ItemType_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))          
			{
				e.Handled = true;
			}
		}

		private void tx_ItemCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))         
			{
				e.Handled = true;
			}
		}
	}
}