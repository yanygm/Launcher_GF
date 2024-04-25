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
using System.Xml;

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
					short sn = 0, previous_sn;
					if (GetKart.Item_Type == 3)
					{
						if (File.Exists(@"Profile\NewKart.xml"))
						{
							XmlDocument doc = new XmlDocument();
							doc.Load(@"Profile\NewKart.xml");
							if (!(doc.GetElementsByTagName("Kart") == null))
							{
								XmlNodeList lis = doc.GetElementsByTagName("Kart");
								foreach (XmlNode xn in lis)
								{
									XmlElement xe = (XmlElement)xn;
									short i = short.Parse(xe.GetAttribute("id"));
									if (i == GetKart.Item_Code)
									{
										previous_sn = sn;
										sn = short.Parse(xe.GetAttribute("sn"));
										if(previous_sn > sn) sn = previous_sn;
									}
								}
								XmlElement newElement = doc.CreateElement("Kart");
								newElement.SetAttribute("id", GetKart.Item_Code.ToString());
								newElement.SetAttribute("sn", sn++.ToString());
								XmlElement NewKart = doc.DocumentElement;
								NewKart.AppendChild(newElement);
								doc.Save(@"Profile\NewKart.xml");
							}
						}
						Console.WriteLine("NewKart: {0}:{1}", GetKart.Item_Code, sn);
						using (OutPacket outPacket = new OutPacket("PrRequestKartInfoPacket"))
						{
							outPacket.WriteByte(1);
							outPacket.WriteInt(1);
							outPacket.WriteShort(GetKart.Item_Type);
							outPacket.WriteShort(GetKart.Item_Code);
							outPacket.WriteShort(sn);
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