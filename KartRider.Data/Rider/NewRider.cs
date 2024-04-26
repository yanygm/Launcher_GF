using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using KartRider.IO;
using KartRider;
using ExcData;
using Set_Data;
using System.Xml;

namespace RiderData
{
	public static class NewRider
	{
		public static void LoadItemData()
		{
			NewRider.Pet();
			NewRider.FlyingPet();
			NewRider.Character();
			NewRider.BonusCard();
			NewRider.HandGearL();
			NewRider.HeadBand();
			NewRider.Goggle();
			NewRider.Balloon();
			NewRider.Tachometer();
			NewRider.SlotItem();
			NewRider.slotBg();
			NewRider.MyRoom();
			NewRider.RenameRid();
			NewRider.ReplayTicket();
			NewRider.LucciBag();
			NewRider.Uniform();
			NewRider.Plate();
			NewRider.RidColor();
			NewRider.SkidMark();
			NewRider.Aura();
			NewRider.Dye();
			NewRider.Paint();
			NewRider.tuneEnginePatch();
			NewRider.tuneHandle();
			NewRider.tuneWheel();
			NewRider.tuneSupportKit();
			NewRider.socket();
			NewRider.tune();
			NewRider.resetSocket();
			NewRider.XUniquePartsData();
			NewRider.XLegendPartsData();
			NewRider.XRarePartsData();
			NewRider.XNormalPartsData();
			NewRider.V1UniquePartsData();
			NewRider.V1LegendPartsData();
			NewRider.V1RarePartsData();
			NewRider.V1NormalPartsData();
			NewRider.V1EffectData();
			NewRider.V1BoosterEffectData();
			NewRider.upgradeKit();
			NewRider.Kart();
			NewRider.NewRiderData();//라이더 인식
			Launcher.OpenGetItem = true;
		}

		public static void NewRiderData()
		{
			using (OutPacket oPacket = new OutPacket("PrGetRider"))
			{
				oPacket.WriteByte(1);
				oPacket.WriteByte(0);
				oPacket.WriteString(SetRider.Nickname);
				oPacket.WriteShort(0);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.Emblem1);
				oPacket.WriteShort(SetRider.Emblem2);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_Character);
				oPacket.WriteShort(SetRiderItem.Set_Paint);
				oPacket.WriteShort(SetRiderItem.Set_Kart);
				oPacket.WriteShort(SetRiderItem.Set_Plate);
				oPacket.WriteShort(SetRiderItem.Set_Goggle);
				oPacket.WriteShort(SetRiderItem.Set_Balloon);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_HeadBand);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_HandGearL);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_Uniform);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_Pet);
				oPacket.WriteShort(SetRiderItem.Set_FlyingPet);
				oPacket.WriteShort(SetRiderItem.Set_Aura);
				oPacket.WriteShort(SetRiderItem.Set_SkidMark);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_RidColor);
				oPacket.WriteShort(SetRiderItem.Set_BonusCard);
				oPacket.WriteShort(0);
				int Plant = -1;
				for (var i = 0; i < KartExcData.PlantList.Count; i++)
				{
					if (KartExcData.PlantList[i][0] == SetRiderItem.Set_Kart && KartExcData.PlantList[i][1] == SetRiderItem.Set_KartSN)
					{
						Plant = i;
					}
				}
				if (Plant > -1)
				{
					oPacket.WriteShort(23);
					oPacket.WriteShort(23);
					oPacket.WriteShort(2);
					oPacket.WriteShort(1);
				}
				else
				{
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
				}
				oPacket.WriteShort(0);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRiderItem.Set_Tachometer);
				oPacket.WriteShort(SetRiderItem.Set_Dye);
				oPacket.WriteShort(SetRiderItem.Set_KartSN);
				int Level = -1;
				for (var i = 0; i < KartExcData.LevelList.Count; i++)
				{
					if (KartExcData.LevelList[i][0] == SetRiderItem.Set_Kart && KartExcData.LevelList[i][1] == SetRiderItem.Set_KartSN)
					{
						Level = i;
					}
				}
				if (Level > -1)
				{
					oPacket.WriteShort(7);
					oPacket.WriteShort(0);
				}
				else
				{
					int Parts = -1;
					for (var i = 0; i < KartExcData.PartsList.Count; i++)
					{
						if (KartExcData.PartsList[i][2] == 2 || KartExcData.PartsList[i][5] == 2 || KartExcData.PartsList[i][8] == 2 || KartExcData.PartsList[i][11] == 2)
						{
							Parts = i;
						}
					}
					if (Parts > -1)
					{
						oPacket.WriteShort(1536);
						oPacket.WriteShort(768);
					}
					else
					{
						oPacket.WriteShort(0);
						oPacket.WriteShort(0);
					}
				}
				oPacket.WriteByte(0);
				oPacket.WriteShort(SetRiderItem.Set_slotBg);
				oPacket.WriteString("");
				oPacket.WriteUInt(SetRider.Lucci);
				oPacket.WriteInt(SetRider.RP);
				for (int i = 0; i < 25; i++)
				{
					oPacket.WriteInt(0);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void Kart()
		{
			if (File.Exists(@"Profile\NewKart.xml"))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\NewKart.xml");
				if (!(doc.GetElementsByTagName("Kart") == null))
				{
					XmlNodeList lis = doc.GetElementsByTagName("Kart");
					List<List<short>> item = new List<List<short>>();
					foreach (XmlNode xn in lis)
					{
						XmlElement xe = (XmlElement)xn;
						short i = short.Parse(xe.GetAttribute("id"));
						short sn = short.Parse(xe.GetAttribute("sn"));
						short num = 1;
						List<short> add = new List<short>();
						add.Add(i);
						add.Add(sn);
						add.Add(num);
						item.Add(add);
						XmlDocument PartsData = new XmlDocument();
						doc.Load(@"Profile\PartsData.xml");
						XmlElement AddPartsData = PartsData.SelectSingleNode("//Kart[@id='" + i + "' and @sn='" + sn + "']") as XmlElement;
						if (AddPartsData == null && i > 0)
						{
							KartExcData.AddPartsList(i, sn, 63, 0, 0, 0);
						}
					}
					LoRpGetRiderItemPacket(3, item);
				}
			}
			KartExcData.Tune_ExcData();
			KartExcData.Plant_ExcData();
			KartExcData.Level_ExcData();
			KartExcData.Parts_ExcData();
		}

		public static void Paint()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Paint") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Paint");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(2, item);
			}
		}

		public static void Dye()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Dye") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Dye");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(70, item);
			}
		}

		public static void Character()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Character") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Character");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(1, item);
			}
		}

		public static void Pet()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Pet") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Pet");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(21, item);
			}
		}

		public static void FlyingPet()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("FlyingPet") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("FlyingPet");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(52, item);
			}
		}

		public static void Uniform()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Uniform") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Uniform");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(18, item);
			}
		}

		public static void Aura()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Aura") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Aura");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(26, item);
			}
		}

		public static void SkidMark()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("SkidMark") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("SkidMark");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(27, item);
			}
		}

		public static void Plate()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Plate") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Plate");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(4, item);
			}
		}

		public static void Balloon()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Balloon") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Balloon");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = SetRider.SlotChanger;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(9, item);
			}
		}

		public static void Goggle()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Goggle") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Goggle");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(8, item);
			}
		}

		public static void HeadBand()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("HeadBand") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("HeadBand");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(11, item);
			}
		}

		public static void HandGearL()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("HandGearL") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("HandGearL");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(16, item);
			}
		}

		public static void MyRoom()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("MyRoom") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("MyRoom");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(28, item);
			}
		}

		public static void RidColor()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("RidColor") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("RidColor");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(31, item);
			}
		}

		public static void BonusCard()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("BonusCard") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("BonusCard");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(32, item);
			}
		}

		public static void SlotItem()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("SlotItem") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("SlotItem");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = SetRider.SlotChanger;
					if (i == 3 || i == 4)
					{
						num = 1;
					}
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(7, item);
			}
		}

		public static void slotBg()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("slotBg") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("slotBg");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(71, item);
			}
		}

		public static void RenameRid()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("RenameRid") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("RenameRid");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = SetRider.SlotChanger;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(23, item);
			}
		}

		public static void ReplayTicket()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("ReplayTicket") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("ReplayTicket");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(13, item);
			}
		}

		public static void LucciBag()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("LucciBag") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("LucciBag");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(23, item);
			}
		}

		public static void Tachometer()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("Tachometer") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("Tachometer");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(61, item);
			}
		}

		public static void tuneEnginePatch()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(43);
				oPacket.WriteShort(23);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void tuneHandle()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(44);
				oPacket.WriteShort(2);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void tuneWheel()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(45);
				oPacket.WriteShort(23);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void tuneSupportKit()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(46);
				oPacket.WriteShort(1);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void socket()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(37);
				oPacket.WriteShort(1);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void tune()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(4);
				for (short i = 3; i <= 6; i++)
				{
					oPacket.WriteShort(38);
					oPacket.WriteShort(i);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(0);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void resetSocket()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteShort(39);
				oPacket.WriteShort(1);
				oPacket.WriteShort(0);
				oPacket.WriteShort(SetRider.SlotChanger);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(-1);
				oPacket.WriteShort(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteShort(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void XUniquePartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 1;
				//-----------------------------------------------------------------X 유니크 파츠
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void XLegendPartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 2;
				//-----------------------------------------------------------------X 레전드 파츠
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void XRarePartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 3;
				//-----------------------------------------------------------------X 레어 파츠
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void XNormalPartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 4;
				//-----------------------------------------------------------------X 일반 파츠
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(1);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		//-----------------------------------------------------------------------------------------------V1 파츠 관련
		public static void V1UniquePartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 1;
				//-----------------------------------------------------------------V1 유니크 파츠
				for (short i = 1153; i <= 1180; i += 3)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1153; i <= 1180; i += 3)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1053; i <= 1080; i += 3)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void V1LegendPartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 2;
				//-----------------------------------------------------------------V1 레전드 파츠
				for (short i = 1105; i <= 1150; i += 5)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1105; i <= 1150; i += 5)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1005; i <= 1050; i += 5)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void V1RarePartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 3;
				//-----------------------------------------------------------------V1 레어 파츠
				for (short i = 1010; i <= 1100; i += 10)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 1010; i <= 1100; i += 10)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void V1NormalPartsData()
		{
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
			{
				oPacket.WriteInt(1);
				oPacket.WriteInt(1);
				oPacket.WriteInt(40);
				byte Grade = 4;
				//-----------------------------------------------------------------V1 일반 파츠
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(63);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(64);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 910; i <= 1000; i += 10)
				{
					oPacket.WriteShort(65);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				for (short i = 810; i <= 900; i += 10)
				{
					oPacket.WriteShort(66);
					oPacket.WriteShort(2);
					oPacket.WriteShort(0);
					oPacket.WriteShort(SetRider.SlotChanger);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteShort(-1);
					oPacket.WriteShort(-1);
					oPacket.WriteByte(1);
					oPacket.WriteByte(Grade);
					oPacket.WriteShort(i);
				}
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void V1EffectData()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("V1EffectData") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("V1EffectData");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = SetRider.SlotChanger;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(68, item);
			}
		}

		public static void V1BoosterEffectData()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("V1BoosterEffectData") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("V1BoosterEffectData");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = SetRider.SlotChanger;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(69, item);
			}
		}

		public static void upgradeKit()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(@"Profile\Item.xml");
			if (!(doc.GetElementsByTagName("upgradeKit") == null))
			{
				XmlNodeList lis = doc.GetElementsByTagName("upgradeKit");
				List<List<short>> item = new List<List<short>>();
				foreach (XmlNode xn in lis)
				{
					XmlElement xe = (XmlElement)xn;
					short i = short.Parse(xe.GetAttribute("id"));
					short sn = 0;
					short num = 1;
					List<short> add = new List<short>();
					add.Add(i);
					add.Add(sn);
					add.Add(num);
					item.Add(add);
				}
				LoRpGetRiderItemPacket(14, item);
			}
		}

		public static void LoRpGetRiderItemPacket(short itemCat, List<List<short>> item)
		{
			int range = 200;//分批次数
			int times = item.Count / range + (item.Count % range > 0 ? 1 : 0);
			for (int i = 0; i < times; i++)
			{
				var tempList = item.GetRange(i * range, (i + 1) * range > item.Count ? (item.Count - i * range) : range);
				for (int f = 0; f < tempList.Count; f++)
				{
					using (OutPacket oPacket = new OutPacket("LoRpGetRiderItemPacket"))
					{
						oPacket.WriteInt(1);
						oPacket.WriteInt(1);
						oPacket.WriteInt(1);
						oPacket.WriteShort(itemCat);
						oPacket.WriteShort(tempList[f][0]);
						oPacket.WriteShort(tempList[f][1]);
						oPacket.WriteShort(tempList[f][2]);
						oPacket.WriteByte((byte)((Program.PreventItem ? 1 : 0)));
						oPacket.WriteByte(0);
						oPacket.WriteShort(-1);
						oPacket.WriteShort(0);
						oPacket.WriteByte(0);
						oPacket.WriteByte(0);
						oPacket.WriteShort(0);
						RouterListener.MySession.Client.Send(oPacket);
					}
				}
			}
		}
	}
}
