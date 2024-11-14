using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
			int range = 100;//分批次数
			int times = TuneList.Count / range + (TuneList.Count % range > 0 ? 1 : 0);
			for (int i = 0; i < times; i++)
			{
				var tempList = TuneList.GetRange(i * range, (i + 1) * range > TuneList.Count ? (TuneList.Count - i * range) : range);
				int TuneCount = tempList.Count;
				using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
				{
					if (i == 0)
					{
						oPacket.WriteByte(1);
					}
					else
					{
						oPacket.WriteByte(0);
					}
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteInt(TuneCount);
					for (var f = 0; f < TuneCount; f++)
					{
						oPacket.WriteShort(3);
						oPacket.WriteShort(tempList[f][0]);
						oPacket.WriteShort(tempList[f][1]);
						oPacket.WriteShort(0);
						oPacket.WriteShort(0);
						oPacket.WriteShort(tempList[f][2]);
						oPacket.WriteShort(tempList[f][3]);
						oPacket.WriteShort(tempList[f][4]);
						oPacket.WriteShort(tempList[f][5]);
						oPacket.WriteShort(tempList[f][6]);
						oPacket.WriteShort(tempList[f][7]);
						oPacket.WriteShort(tempList[f][8]);
					}
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					RouterListener.MySession.Client.Send(oPacket);
				}
			}
		}

		public static void Plant_ExcData()
		{
			int range = 100;//分批次数
			int times = PlantList.Count / range + (PlantList.Count % range > 0 ? 1 : 0);
			for (int i = 0; i < times; i++)
			{
				var tempList = PlantList.GetRange(i * range, (i + 1) * range > PlantList.Count ? (PlantList.Count - i * range) : range);
				int PlantCount = tempList.Count;
				using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
				{
					oPacket.WriteByte(0);
					if (i == 0)
					{
						oPacket.WriteByte(1);
					}
					else
					{
						oPacket.WriteByte(0);
					}
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(PlantCount);
					for (var f = 0; f < PlantCount; f++)
					{
						oPacket.WriteShort(tempList[f][0]);
						oPacket.WriteShort(tempList[f][1]);
						oPacket.WriteInt(4);
						oPacket.WriteShort(tempList[f][2]);
						oPacket.WriteShort(tempList[f][3]);
						oPacket.WriteShort(tempList[f][4]);
						oPacket.WriteShort(tempList[f][5]);
						oPacket.WriteShort(tempList[f][6]);
						oPacket.WriteShort(tempList[f][7]);
						oPacket.WriteShort(tempList[f][8]);
						oPacket.WriteShort(tempList[f][9]);
					}
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					RouterListener.MySession.Client.Send(oPacket);
				}
			}
		}

		public static void Level_ExcData()
		{
			int range = 100;//分批次数
			int times = LevelList.Count / range + (LevelList.Count % range > 0 ? 1 : 0);
			for (int i = 0; i < times; i++)
			{
				var tempList = LevelList.GetRange(i * range, (i + 1) * range > LevelList.Count ? (LevelList.Count - i * range) : range);
				int LevelCount = tempList.Count;
				using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
				{
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					if (i == 0)
					{
						oPacket.WriteByte(1);
					}
					else
					{
						oPacket.WriteByte(0);
					}
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(LevelCount);
					for (var f = 0; f < LevelCount; f++)
					{
						oPacket.WriteShort(tempList[f][0]);
						oPacket.WriteShort(tempList[f][1]);
						oPacket.WriteShort(tempList[f][2]);
						oPacket.WriteShort(tempList[f][3]);
						oPacket.WriteShort(tempList[f][4]);
						oPacket.WriteShort(tempList[f][5]);
						oPacket.WriteShort(tempList[f][6]);
						oPacket.WriteShort(tempList[f][7]);
						oPacket.WriteShort(tempList[f][8]); //코팅
					}
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					RouterListener.MySession.Client.Send(oPacket);
				}
			}
		}

		public static void Parts_ExcData()
		{
			int range = 100;//分批次数
			int times = PartsList.Count / range + (PartsList.Count % range > 0 ? 1 : 0);
			for (int i = 0; i < times; i++)
			{
				var tempList = PartsList.GetRange(i * range, (i + 1) * range > PartsList.Count ? (PartsList.Count - i * range) : range);
				int parts = tempList.Count;
				using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
				{
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					if (i == 0)
					{
						oPacket.WriteByte(1);
					}
					else
					{
						oPacket.WriteByte(0);
					}
					oPacket.WriteByte(0);
					oPacket.WriteByte(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					oPacket.WriteInt(parts);
					for (var f = 0; f < parts; f++)
					{
						oPacket.WriteShort(tempList[f][0]);
						oPacket.WriteShort(tempList[f][1]);
						oPacket.WriteShort(0);
						oPacket.WriteShort(-1);
						oPacket.WriteShort(0);
						oPacket.WriteShort(tempList[f][2]);
						oPacket.WriteByte((byte)tempList[f][3]);
						oPacket.WriteShort(tempList[f][4]);
						oPacket.WriteShort(tempList[f][5]);
						oPacket.WriteByte((byte)tempList[f][6]);
						oPacket.WriteShort(tempList[f][7]);
						oPacket.WriteShort(tempList[f][8]);
						oPacket.WriteByte((byte)tempList[f][9]);
						oPacket.WriteShort(tempList[f][10]);
						oPacket.WriteShort(tempList[f][11]);
						oPacket.WriteByte((byte)tempList[f][12]);
						oPacket.WriteShort(tempList[f][13]);
						oPacket.WriteShort(tempList[f][14]);
						oPacket.WriteByte(0);
						oPacket.WriteShort(0);
						oPacket.WriteShort(tempList[f][15]);
						oPacket.WriteByte(0);
						oPacket.WriteShort(0);
					}
					oPacket.WriteInt(0);
					oPacket.WriteInt(0);
					RouterListener.MySession.Client.Send(oPacket);
				}
			}
		}

		public static void AddTuneList(short id, short sn, short tune1, short tune2, short tune3, short slot1, short count1, short slot2, short count2)
		{
			var existingList = TuneList.FirstOrDefault(list => list[0] == id && list[1] == sn);
			if (existingList == null)
			{
				var newList = new List<short> { id, sn, tune1, tune2, tune3, slot1, count1, slot2, count2 };
				TuneList.Add(newList);
				SaveTuneList(TuneList);
			}
			else
			{
				existingList[2] = tune1;
				existingList[3] = tune2;
				existingList[4] = tune3;
				existingList[5] = slot1;
				existingList[6] = count1;
				existingList[7] = slot2;
				existingList[8] = count2;
				SaveTuneList(TuneList);
			}
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
				xe1.SetAttribute("slot1", List[i][5].ToString());
				xe1.SetAttribute("count1", List[i][6].ToString());
				xe1.SetAttribute("slot2", List[i][7].ToString());
				xe1.SetAttribute("count2", List[i][8].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\TuneData.xml");
			}
		}

		public static void AddPlantList(short id, short sn, short item, short item_id)
		{
			var existingList = PlantList.FirstOrDefault(list => list[0] == id && list[1] == sn);
			if (existingList == null)
			{
				var newList = new List<short> { id, sn, 0, 0, 0, 0, 0, 0, 0, 0 };
				switch (item)
				{
					case 43:
						newList[2] = item;
						newList[3] = item_id;
						break;
					case 44:
						newList[4] = item;
						newList[5] = item_id;
						break;
					case 45:
						newList[6] = item;
						newList[7] = item_id;
						break;
					case 46:
						newList[8] = item;
						newList[9] = item_id;
						break;
				}
				PlantList.Add(newList);
				SavePlantList(PlantList);
			}
			else
			{
				switch (item)
				{
					case 43:
						existingList[2] = item;
						existingList[3] = item_id;
						break;
					case 44:
						existingList[4] = item;
						existingList[5] = item_id;
						break;
					case 45:
						existingList[6] = item;
						existingList[7] = item_id;
						break;
					case 46:
						existingList[8] = item;
						existingList[9] = item_id;
						break;
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

		public static void AddLevelList(short id, short sn, short level, short point, short v1, short v2, short v3, short v4, short Effect)
		{
			var existingList = LevelList.FirstOrDefault(list => list[0] == id && list[1] == sn);
			if (existingList == null)
			{
				var newList = new List<short> { id, sn, level, point, v1, v2, v3, v4, Effect };
				LevelList.Add(newList);
				SaveLevelList(LevelList);
			}
			else
			{
				existingList[3] = point;
				existingList[4] = v1;
				existingList[5] = v2;
				existingList[6] = v3;
				existingList[7] = v4;
				existingList[8] = Effect;
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
				xe1.SetAttribute("point", List[i][3].ToString());
				xe1.SetAttribute("v1", List[i][4].ToString());
				xe1.SetAttribute("v2", List[i][5].ToString());
				xe1.SetAttribute("v3", List[i][6].ToString());
				xe1.SetAttribute("v4", List[i][7].ToString());
				xe1.SetAttribute("Effect", List[i][8].ToString());
				root.AppendChild(xe1);
				xmlDoc.Save(@"Profile\LevelData.xml");
			}
		}

		public static void AddPartsList(short id, short sn, short Item_Cat_Id, short Item_Id, byte Grade, short PartsValue)
		{
			var existingList = PartsList.FirstOrDefault(list => list[0] == id && list[1] == sn);
			if (existingList == null)
			{
				var newList = new List<short> { id, sn, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
				switch (Item_Cat_Id)
				{
					case 63:
						newList[2] = Item_Id;
						newList[3] = Grade;
						newList[4] = PartsValue;
						break;
					case 64:
						newList[5] = Item_Id;
						newList[6] = Grade;
						newList[7] = PartsValue;
						break;
					case 65:
						newList[8] = Item_Id;
						newList[9] = Grade;
						newList[10] = PartsValue;
						break;
					case 66:
						newList[11] = Item_Id;
						newList[12] = Grade;
						newList[13] = PartsValue;
						break;
					case 68:
						newList[14] = Item_Id;
						break;
					case 69:
						newList[15] = Item_Id;
						break;
				}
				PartsList.Add(newList);
				SavePartsList(PartsList);
			}
			else
			{
				switch (Item_Cat_Id)
				{
					case 63:
						existingList[2] = Item_Id;
						existingList[3] = Grade;
						existingList[4] = PartsValue;
						break;
					case 64:
						existingList[5] = Item_Id;
						existingList[6] = Grade;
						existingList[7] = PartsValue;
						break;
					case 65:
						existingList[8] = Item_Id;
						existingList[9] = Grade;
						existingList[10] = PartsValue;
						break;
					case 66:
						existingList[11] = Item_Id;
						existingList[12] = Grade;
						existingList[13] = PartsValue;
						break;
					case 68:
						existingList[14] = Item_Id;
						break;
					case 69:
						existingList[15] = Item_Id;
						break;
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