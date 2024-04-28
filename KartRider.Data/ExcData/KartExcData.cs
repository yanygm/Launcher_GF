using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using KartRider;
using KartRider.IO;

namespace ExcData
{
	public static class KartExcData
	{
		public static List<List<short>> TuneList = new List<List<short>>();
		public static List<List<short>> PlantList = new List<List<short>>();
		public static List<List<short>> LevelList = new List<List<short>>();
		public static List<List<short>> PartsList = new List<List<short>>();

		public static void Tune_ExcData()
		{
			int All_Kart = TuneList.Count;
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
			{
				oPacket.WriteByte(1);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteInt(All_Kart);
				for (var i = 0; i < All_Kart; i++)
				{
					oPacket.WriteShort(3);
					oPacket.WriteShort(TuneList[i][0]);
					oPacket.WriteShort(TuneList[i][1]);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(TuneList[i][2]);
					oPacket.WriteShort(TuneList[i][3]);
					oPacket.WriteShort(TuneList[i][4]);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(0);
				}
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void Plant_ExcData()
		{
			int PlantCount = PlantList.Count;
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
			{
				oPacket.WriteByte(0);
				oPacket.WriteByte(1);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(PlantCount);
				for (var i = 0; i < PlantCount; i++)
				{
					oPacket.WriteShort(PlantList[i][0]);
					oPacket.WriteShort(PlantList[i][1]);
					oPacket.WriteInt(4);
					oPacket.WriteShort(PlantList[i][2]);
					oPacket.WriteShort(PlantList[i][3]);
					oPacket.WriteShort(PlantList[i][4]);
					oPacket.WriteShort(PlantList[i][5]);
					oPacket.WriteShort(PlantList[i][6]);
					oPacket.WriteShort(PlantList[i][7]);
					oPacket.WriteShort(PlantList[i][8]);
					oPacket.WriteShort(PlantList[i][9]);
				}
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void Level_ExcData()
		{
			int LevelCount = LevelList.Count;
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
			{
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(1);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(LevelCount);
				for (var i = 0; i < LevelCount; i++)
				{
					oPacket.WriteShort(LevelList[i][0]);
					oPacket.WriteShort(LevelList[i][1]);
					oPacket.WriteShort(LevelList[i][2]);
					oPacket.WriteShort(LevelList[i][3]);
					oPacket.WriteShort(LevelList[i][4]);
					oPacket.WriteShort(LevelList[i][5]);
					oPacket.WriteShort(LevelList[i][6]);
					oPacket.WriteShort(LevelList[i][7]);
					oPacket.WriteShort(0); //코팅
				}
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void Parts_ExcData()
		{
			int Parts = PartsList.Count;
			using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
			{
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteByte(4);
				oPacket.WriteByte(0);
				oPacket.WriteByte(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				oPacket.WriteInt(Parts);
				for (var i = 0; i < Parts; i++)
				{
					oPacket.WriteShort(PartsList[i][0]);
					oPacket.WriteShort(PartsList[i][1]);
					oPacket.WriteShort(0);
					for (byte l = 0; l < 4; l++)
					{
						oPacket.WriteByte(255);
					}
					oPacket.WriteShort(PartsList[i][2]);
					oPacket.WriteByte((byte)PartsList[i][3]);
					oPacket.WriteShort(PartsList[i][4]);
					oPacket.WriteShort(PartsList[i][5]);
					oPacket.WriteByte((byte)PartsList[i][6]);
					oPacket.WriteShort(PartsList[i][7]);
					oPacket.WriteShort(PartsList[i][8]);
					oPacket.WriteByte((byte)PartsList[i][9]);
					oPacket.WriteShort(PartsList[i][10]);
					oPacket.WriteShort(PartsList[i][11]);
					oPacket.WriteByte((byte)PartsList[i][12]);
					oPacket.WriteShort(PartsList[i][13]);
					oPacket.WriteShort(PartsList[i][14]);
					oPacket.WriteByte(0);
					oPacket.WriteShort(0);
					oPacket.WriteShort(PartsList[i][15]);
					oPacket.WriteByte(0);
					oPacket.WriteShort(0);
				}
				//oPacket.WriteHexString("00 00 FF FF 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00");
				oPacket.WriteInt(0);
				oPacket.WriteInt(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}

		public static void AddTuneList(short id, short sn, short tune1, short tune2, short tune3)
		{
			int Add = -1;
			for (var i = 0; i < TuneList.Count; i++)
			{
				if (TuneList[i][0] == id && TuneList[i][1] == sn)
				{
					Add = i;
				}
			}
			if (Add == -1)
			{
				List<short> AddList = new List<short>();
				AddList.Add(id);
				AddList.Add(sn);
				AddList.Add(tune1);
				AddList.Add(tune2);
				AddList.Add(tune3);
				TuneList.Add(AddList);
				SaveTuneList(TuneList);
			}
			else if (Add > -1)
			{
				TuneList[Add][2] = tune1;
				TuneList[Add][3] = tune2;
				TuneList[Add][4] = tune3;
				SaveTuneList(TuneList);
			}
		}

		public static void DelTuneList(short id, short sn)
		{
			int Dell = -1;
			for (var i = 0; i < TuneList.Count; i++)
			{
				if (TuneList[i][0] == id && TuneList[i][1] == sn)
				{
					Dell = i;
				}
			}
			if (Dell > -1)
			{
				TuneList.RemoveAt(Dell);
			}
			SaveTuneList(TuneList);
		}

		public static void SaveTuneList(List<List<short>> List)
		{
			File.Delete(@"Profile\TuneData.xml");
			XmlTextWriter writer = new XmlTextWriter(@"Profile\TuneData.xml", System.Text.Encoding.UTF8);
			writer.Formatting = Formatting.Indented;
			writer.WriteStartDocument();
			writer.WriteStartElement("TuneData");
			writer.WriteEndElement();
			writer.Close();
			for (var i = 0; i < List.Count; i++)
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(@"Profile\TuneData.xml");
				XmlNode root = xmlDoc.SelectSingleNode("TuneData");
				XmlElement xe1 = xmlDoc.CreateElement("Kart");
				xe1.SetAttribute("id", List[i][0].ToString());
				xe1.SetAttribute("sn", List[i][1].ToString());
				xe1.SetAttribute("tune1", List[i][2].ToString());
				xe1.SetAttribute("tune2", List[i][3].ToString());
				xe1.SetAttribute("tune3", List[i][4].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\TuneData.xml");
			}
		}

		public static void AddPlantList(short id, short sn, short item, short item_id)
		{
			int Add = -1;
			for (var i = 0; i < PlantList.Count; i++)
			{
				if (PlantList[i][0] == id && PlantList[i][1] == sn)
				{
					Add = i;
				}
			}
			if (Add == -1)
			{
				List<short> AddList = new List<short>();
				AddList.Add(id);
				AddList.Add(sn);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				if (item == 43)
				{
					AddList[2] = item;
					AddList[3] = item_id;
				}
				else if (item == 44)
				{
					AddList[4] = item;
					AddList[5] = item_id;
				}
				else if (item == 45)
				{
					AddList[6] = item;
					AddList[7] = item_id;
				}
				else if (item == 46)
				{
					AddList[8] = item;
					AddList[9] = item_id;
				}
				PlantList.Add(AddList);
				SavePlantList(PlantList);
			}
			else if (Add > -1)
			{
				if (item == 43)
				{
					PlantList[Add][2] = item;
					PlantList[Add][3] = item_id;
				}
				else if (item == 44)
				{
					PlantList[Add][4] = item;
					PlantList[Add][5] = item_id;
				}
				else if (item == 45)
				{
					PlantList[Add][6] = item;
					PlantList[Add][7] = item_id;
				}
				else if (item == 46)
				{
					PlantList[Add][8] = item;
					PlantList[Add][9] = item_id;
				}
				SavePlantList(PlantList);
			}
		}

		public static void SavePlantList(List<List<short>> List)
		{
			File.Delete(@"Profile\PlantData.xml");
			XmlTextWriter writer = new XmlTextWriter(@"Profile\PlantData.xml", System.Text.Encoding.UTF8);
			writer.Formatting = Formatting.Indented;
			writer.WriteStartDocument();
			writer.WriteStartElement("PlantData");
			writer.WriteEndElement();
			writer.Close();
			for (var i = 0; i < List.Count; i++)
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(@"Profile\PlantData.xml");
				XmlNode root = xmlDoc.SelectSingleNode("PlantData");
				XmlElement xe1 = xmlDoc.CreateElement("Kart");
				xe1.SetAttribute("id", List[i][0].ToString());
				xe1.SetAttribute("sn", List[i][1].ToString());
				xe1.SetAttribute("item1", List[i][2].ToString());
				xe1.SetAttribute("item_id1", List[i][3].ToString());
				xe1.SetAttribute("item2", List[i][4].ToString());
				xe1.SetAttribute("item_id2", List[i][5].ToString());
				xe1.SetAttribute("item3", List[i][6].ToString());
				xe1.SetAttribute("item_id3", List[i][7].ToString());
				xe1.SetAttribute("item4", List[i][8].ToString());
				xe1.SetAttribute("item_id4", List[i][9].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\PlantData.xml");
			}
		}

		public static void AddLevelList(short id, short sn, short level, short pointleft, short v1, short v2, short v3, short v4)
		{
			int Add = -1;
			for (var i = 0; i < LevelList.Count; i++)
			{
				if (LevelList[i][0] == id && LevelList[i][1] == sn)
				{
					Add = i;
				}
			}
			if (Add == -1)
			{
				List<short> AddList = new List<short>();
				AddList.Add(id);
				AddList.Add(sn);
				AddList.Add(level);
				AddList.Add(pointleft);
				AddList.Add(v1);
				AddList.Add(v2);
				AddList.Add(v3);
				AddList.Add(v4);
				LevelList.Add(AddList);
				SaveLevelList(LevelList);
			}
			else if (Add > -1)
			{
				LevelList[Add][3] = pointleft;
				LevelList[Add][4] = v1;
				LevelList[Add][5] = v2;
				LevelList[Add][6] = v3;
				LevelList[Add][7] = v4;
				SaveLevelList(LevelList);
			}
		}

		public static void SaveLevelList(List<List<short>> List)
		{
			File.Delete(@"Profile\LevelData.xml");
			XmlTextWriter writer = new XmlTextWriter(@"Profile\LevelData.xml", System.Text.Encoding.UTF8);
			writer.Formatting = Formatting.Indented;
			writer.WriteStartDocument();
			writer.WriteStartElement("LevelData");
			writer.WriteEndElement();
			writer.Close();
			for (var i = 0; i < List.Count; i++)
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(@"Profile\LevelData.xml");
				XmlNode root = xmlDoc.SelectSingleNode("LevelData");
				XmlElement xe1 = xmlDoc.CreateElement("Kart");
				xe1.SetAttribute("id", List[i][0].ToString());
				xe1.SetAttribute("sn", List[i][1].ToString());
				xe1.SetAttribute("level", List[i][2].ToString());
				xe1.SetAttribute("pointleft", List[i][3].ToString());
				xe1.SetAttribute("v1", List[i][4].ToString());
				xe1.SetAttribute("v2", List[i][5].ToString());
				xe1.SetAttribute("v3", List[i][6].ToString());
				xe1.SetAttribute("v4", List[i][7].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\LevelData.xml");
			}
		}

		public static void AddPartsList(short id, short sn, short Item_Cat_Id, short Item_Id, byte Grade, short PartsValue)
		{
			int Add = -1;
			for (var i = 0; i < PartsList.Count; i++)
			{
				if (PartsList[i][0] == id && PartsList[i][1] == sn)
				{
					Add = i;
				}
			}
			if (Add == -1)
			{
				List<short> AddList = new List<short>();
				AddList.Add(id);
				AddList.Add(sn);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				AddList.Add(0);
				if (Item_Cat_Id == 63)
				{
					AddList[2] = Item_Id;
					AddList[3] = Grade;
					AddList[4] = PartsValue;
				}
				else if (Item_Cat_Id == 64)
				{
					AddList[5] = Item_Id;
					AddList[6] = Grade;
					AddList[7] = PartsValue;
				}
				else if (Item_Cat_Id == 65)
				{
					AddList[8] = Item_Id;
					AddList[9] = Grade;
					AddList[10] = PartsValue;
				}
				else if (Item_Cat_Id == 66)
				{
					AddList[11] = Item_Id;
					AddList[12] = Grade;
					AddList[13] = PartsValue;
				}
				else if (Item_Cat_Id == 68)
				{
					AddList[14] = Item_Id;
				}
				else if (Item_Cat_Id == 69)
				{
					AddList[15] = Item_Id;
				}
				PartsList.Add(AddList);
				SavePartsList(PartsList);
			}
			else if (Add > -1)
			{
				if (Item_Cat_Id == 63)
				{
					PartsList[Add][2] = Item_Id;
					PartsList[Add][3] = Grade;
					PartsList[Add][4] = PartsValue;
				}
				else if (Item_Cat_Id == 64)
				{
					PartsList[Add][5] = Item_Id;
					PartsList[Add][6] = Grade;
					PartsList[Add][7] = PartsValue;
				}
				else if (Item_Cat_Id == 65)
				{
					PartsList[Add][8] = Item_Id;
					PartsList[Add][9] = Grade;
					PartsList[Add][10] = PartsValue;
				}
				else if (Item_Cat_Id == 66)
				{
					PartsList[Add][11] = Item_Id;
					PartsList[Add][12] = Grade;
					PartsList[Add][13] = PartsValue;
				}
				else if (Item_Cat_Id == 68)
				{
					PartsList[Add][14] = Item_Id;
				}
				else if (Item_Cat_Id == 69)
				{
					PartsList[Add][15] = Item_Id;
				}
				SavePartsList(PartsList);
			}
		}

		public static void SavePartsList(List<List<short>> List)
		{
			File.Delete(@"Profile\PartsData.xml");
			XmlTextWriter writer = new XmlTextWriter(@"Profile\PartsData.xml", System.Text.Encoding.UTF8);
			writer.Formatting = Formatting.Indented;
			writer.WriteStartDocument();
			writer.WriteStartElement("PartsData");
			writer.WriteEndElement();
			writer.Close();
			for (var i = 0; i < List.Count; i++)
			{
				XmlDocument xmlDoc = new XmlDocument();
				xmlDoc.Load(@"Profile\PartsData.xml");
				XmlNode root = xmlDoc.SelectSingleNode("PartsData");
				XmlElement xe1 = xmlDoc.CreateElement("Kart");
				xe1.SetAttribute("id", List[i][0].ToString());
				xe1.SetAttribute("sn", List[i][1].ToString());
				xe1.SetAttribute("Item_Id1", List[i][2].ToString());
				xe1.SetAttribute("Grade1", List[i][3].ToString());
				xe1.SetAttribute("PartsValue1", List[i][4].ToString());
				xe1.SetAttribute("Item_Id2", List[i][5].ToString());
				xe1.SetAttribute("Grade2", List[i][6].ToString());
				xe1.SetAttribute("PartsValue2", List[i][7].ToString());
				xe1.SetAttribute("Item_Id3", List[i][8].ToString());
				xe1.SetAttribute("Grade3", List[i][9].ToString());
				xe1.SetAttribute("PartsValue3", List[i][10].ToString());
				xe1.SetAttribute("Item_Id4", List[i][11].ToString());
				xe1.SetAttribute("Grade4", List[i][12].ToString());
				xe1.SetAttribute("PartsValue4", List[i][13].ToString());
				xe1.SetAttribute("partsCoating", List[i][14].ToString());
				xe1.SetAttribute("partsTailLamp", List[i][15].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\PartsData.xml");
			}
		}
	}
}