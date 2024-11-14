using System;
using KartRider.IO;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using ExcData;
using Launcher.Properties;

namespace KartRider
{
	public partial class GetKart : Form
	{
		public static short Item_Type = 0;
		public static short Item_Code = 0;

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tx_ItemCode;
		private System.Windows.Forms.TextBox tx_ItemType;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.ComponentModel.IContainer components = null;

		public GetKart()
		{
			InitializeComponent();
		}

		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.tx_ItemCode = new System.Windows.Forms.TextBox();
			this.tx_ItemType = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(141, 10);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(64, 50);
			this.button1.TabIndex = 0;
			this.button1.Text = "添加";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tx_ItemCode
			// 
			this.tx_ItemCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tx_ItemCode.Location = new System.Drawing.Point(46, 42);
			this.tx_ItemCode.MaxLength = 5;
			this.tx_ItemCode.Name = "tx_ItemCode";
			this.tx_ItemCode.Size = new System.Drawing.Size(86, 14);
			this.tx_ItemCode.TabIndex = 360;
			this.tx_ItemCode.WordWrap = false;
			this.tx_ItemCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ItemCode_KeyPress);
			// 
			// tx_ItemType
			// 
			this.tx_ItemType.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tx_ItemType.Location = new System.Drawing.Point(46, 15);
			this.tx_ItemType.MaxLength = 5;
			this.tx_ItemType.Name = "tx_ItemType";
			this.tx_ItemType.Size = new System.Drawing.Size(86, 14);
			this.tx_ItemType.TabIndex = 361;
			this.tx_ItemType.WordWrap = false;
			this.tx_ItemType.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tx_ItemType_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 12);
			this.label1.TabIndex = 362;
			this.label1.Text = "类型:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 12);
			this.label2.TabIndex = 363;
			this.label2.Text = "代码:";
			// 
			// GetKart
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(216, 69);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tx_ItemCode);
			this.Controls.Add(this.tx_ItemType);
			this.Controls.Add(this.button1);
			this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = Resources.Icon;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GetKart";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "添加道具";
			this.Load += new System.EventHandler(this.FormItem_Load);
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			GetKart.Item_Type = short.Parse(this.tx_ItemType.Text);
			GetKart.Item_Code = short.Parse(this.tx_ItemCode.Text);
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
						XmlNodeList lis = doc.SelectNodes("//Kart[@id='" + GetKart.Item_Code + "']");
						foreach (XmlNode xn in lis)
						{
							XmlElement xe = (XmlElement)xn;
							previous_sn = sn;
							sn = short.Parse(xe.GetAttribute("sn"));
							if (previous_sn > sn) sn = previous_sn;
						}
						XmlElement newElement = doc.CreateElement("Kart");
						newElement.SetAttribute("id", GetKart.Item_Code.ToString());
						sn += 1;
						newElement.SetAttribute("sn", sn.ToString());
						XmlElement NewKart = doc.DocumentElement;
						NewKart.AppendChild(newElement);
						doc.Save(@"Profile\NewKart.xml");
					}
					Console.WriteLine("NewKart: {0}:{1}", GetKart.Item_Code, sn);
					KartExcData.AddPartsList(GetKart.Item_Code, sn, 63, 0, 0, 0);
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