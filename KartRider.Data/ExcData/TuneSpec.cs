using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using KartRider;
using KartRider.IO;
using Set_Data;

namespace ExcData
{
	public class TuneSpec
	{
		public static float Tune_DriftEscapeForce = 0f;
		public static float Tune_TransAccelFactor = 0f;
		public static float Tune_StartBoosterTimeSpeed = 0f;

		public static float Plant_ForwardAccelForce = 0f;
		public static float Plant_TransAccelFactor = 0f;
		public static float Plant_StartBoosterTimeSpeed = 0f;
		public static float Plant_GripBrakeForce = 0f;
		public static float Plant_RearGripFactor = 0f;
		public static float Plant_FrontGripFactor = 0f;
		public static float Plant_CornerDrawFactor = 0f;
		public static float Plant_DriftEscapeForce = 0f;
		public static float Plant_DriftMaxGauge = 0f;
		public static float Plant_NormalBoosterTime = 0f;

		public static float KartLevel_ForwardAccelForce = 0f;
		public static float KartLevel_CornerDrawFactor = 0f;
		public static float KartLevel_DriftEscapeForce = 0f;
		public static float KartLevel_StartBoosterTimeItem = 0f;
		public static float KartLevel_StartBoosterTimeSpeed = 0f;
		public static float KartLevel_TransAccelFactor = 0f;

		public static void Tune_TypeC()
		{
			TuneSpec.Tune_DriftEscapeForce = 210f;//3
			TuneSpec.Tune_TransAccelFactor = 0.012f;//2
			TuneSpec.Tune_StartBoosterTimeSpeed = 530f;//2
			Console.WriteLine("Tune_Type: C");
		}

		public static void Tune_TypeH()
		{
			TuneSpec.Tune_DriftEscapeForce = 210f;//3
			TuneSpec.Tune_TransAccelFactor = 0.012f;//2
			TuneSpec.Tune_StartBoosterTimeSpeed = 800f;//3
			Console.WriteLine("Tune_Type: H");
		}

		public static void Tune_TypeA()
		{
			TuneSpec.Tune_DriftEscapeForce = 210f;//3
			TuneSpec.Tune_TransAccelFactor = 0.018f;//3
			TuneSpec.Tune_StartBoosterTimeSpeed = 800f;//3
			Console.WriteLine("Tune_Type: A");
		}

		public static void Reset_Tune_SpecData()
		{
			TuneSpec.Tune_DriftEscapeForce = 0f;
			TuneSpec.Tune_TransAccelFactor = 0f;
			TuneSpec.Tune_StartBoosterTimeSpeed = 0f;
			Console.WriteLine("Tune_Type: OFF");
		}

		public static void Plant_SpecData()
		{
			//태고의 빛
			TuneSpec.Plant_ForwardAccelForce = 1f;
			TuneSpec.Plant_TransAccelFactor = 0.002f;
			TuneSpec.Plant_StartBoosterTimeSpeed = 30f;

			//엑스 스트림
			TuneSpec.Plant_GripBrakeForce = -12f;
			TuneSpec.Plant_RearGripFactor = 0.3f;
			TuneSpec.Plant_FrontGripFactor = 0.3f;
			//TuneSpec.Plant_CornerDrawFactor = 0.001f;

			//와일드 서클
			TuneSpec.Plant_DriftEscapeForce = 90f;
			//TuneSpec.Plant_CornerDrawFactor = 0.0005f;

			//골든 로제타 킷
			TuneSpec.Plant_DriftMaxGauge = -80f;
			TuneSpec.Plant_NormalBoosterTime = 120f;

			//엑스 스트림 + 와일드 서클 통합
			TuneSpec.Plant_CornerDrawFactor = 0.0015f;
			//Console.WriteLine("플랜트 적용됨");
			Console.WriteLine("Plant_Spec: ON");
		}

		public static void Reset_Plant_SpecData()
		{
			//태고의 빛
			TuneSpec.Plant_ForwardAccelForce = 0f;
			TuneSpec.Plant_TransAccelFactor = 0f;
			TuneSpec.Plant_StartBoosterTimeSpeed = 0f;

			//엑스 스트림
			TuneSpec.Plant_GripBrakeForce = 0f;
			TuneSpec.Plant_RearGripFactor = 0f;
			TuneSpec.Plant_FrontGripFactor = 0f;
			//TuneSpec.Plant_CornerDrawFactor = 0f;

			//와일드 서클
			TuneSpec.Plant_DriftEscapeForce = 0f;
			//TuneSpec.Plant_CornerDrawFactor = 0f;

			//골든 로제타 킷
			TuneSpec.Plant_DriftMaxGauge = 0f;
			TuneSpec.Plant_NormalBoosterTime = 0f;

			//엑스 스트림 + 와일드 서클 통합
			TuneSpec.Plant_CornerDrawFactor = 0f;
			Console.WriteLine("Plant_Spec: OFF");
		}

		public static void KartLevel_SpecData()
		{
			TuneSpec.KartLevel_ForwardAccelForce = 1.5f;
			TuneSpec.KartLevel_CornerDrawFactor = 0.0005f;
			TuneSpec.KartLevel_DriftEscapeForce = 50f;
			TuneSpec.KartLevel_StartBoosterTimeItem = 100f;
			TuneSpec.KartLevel_StartBoosterTimeSpeed = 100f;
			TuneSpec.KartLevel_TransAccelFactor = 0.005f;
			Console.WriteLine("Level_Spec: ON");
		}

		public static void Reset_KartLevel_SpecData()
		{
			TuneSpec.KartLevel_ForwardAccelForce = 0f;
			TuneSpec.KartLevel_CornerDrawFactor = 0f;
			TuneSpec.KartLevel_DriftEscapeForce = 0f;
			TuneSpec.KartLevel_StartBoosterTimeItem = 0f;
			TuneSpec.KartLevel_StartBoosterTimeSpeed = 0f;
			TuneSpec.KartLevel_TransAccelFactor = 0f;
			Console.WriteLine("Level_Spec: OFF");
		}

		public static void Use_TuneSpec()
		{
			if (File.Exists(@"Profile\TuneData.xml"))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\TuneData.xml");
				if (!(doc.GetElementsByTagName("Kart") == null))
				{
					XmlNodeList lis = doc.GetElementsByTagName("Kart");
					foreach (XmlNode xn in lis)
					{
						XmlElement xe = (XmlElement)xn;
						short i = short.Parse(xe.GetAttribute("id"));
						short sn = short.Parse(xe.GetAttribute("sn"));
						if (SetRiderItem.Set_Kart == i && SetRiderItem.Set_KartSN == sn)
						{
							TuneSpec.Tune_TypeA();
							return;
						}
					}
				}
			}
			TuneSpec.Reset_Tune_SpecData();
		}

		public static void Use_PlantSpec()
		{
			if (File.Exists(@"Profile\PlantData.xml"))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\PlantData.xml");
				if (!(doc.GetElementsByTagName("Kart") == null))
				{
					XmlNodeList lis = doc.GetElementsByTagName("Kart");
					using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
					{
						foreach (XmlNode xn in lis)
						{
							XmlElement xe = (XmlElement)xn;
							short i = short.Parse(xe.GetAttribute("id"));
							short sn = short.Parse(xe.GetAttribute("sn"));
							if (SetRiderItem.Set_Kart == i && SetRiderItem.Set_KartSN == sn)
							{
								TuneSpec.Plant_SpecData();
								return;
							}
						}
					}
				}
			}
			TuneSpec.Reset_Plant_SpecData();
		}

		public static void Use_KartLevelSpec()
		{
			if (File.Exists(@"Profile\LevelData.xml"))
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\LevelData.xml");
				if (!(doc.GetElementsByTagName("Kart") == null))
				{
					XmlNodeList lis = doc.GetElementsByTagName("Kart");
					using (OutPacket oPacket = new OutPacket("LoRpGetRiderExcDataPacket"))
					{
						foreach (XmlNode xn in lis)
						{
							XmlElement xe = (XmlElement)xn;
							short i = short.Parse(xe.GetAttribute("id"));
							short sn = short.Parse(xe.GetAttribute("sn"));
							if (SetRiderItem.Set_Kart == i && SetRiderItem.Set_KartSN == sn)
							{
								TuneSpec.KartLevel_SpecData();
								return;
							}
						}
					}
				}
			}
			TuneSpec.Reset_KartLevel_SpecData();
		}

		public static void Use_PartsSpec(short id, short sn)
		{
			int select = -1;
			for (var i = 0; i < KartExcData.PartsList.Count; i++)
			{
				if (KartExcData.PartsList[i][0] == id && KartExcData.PartsList[i][1] == sn)
				{
					select = i;
				}
			}
			if (select > -1)
			{
				for (short i = 63; i < 67; i++)
				{
					if (i == 63)
					{
						PartSpec.Item_Cat_Id = i;
						PartSpec.Item_Id = KartExcData.PartsList[select][2];
						PartSpec.Grade = (byte)KartExcData.PartsList[select][3];
						PartSpec.PartsValue = KartExcData.PartsList[select][4];
					}
					else if (i == 64)
					{
						PartSpec.Item_Cat_Id = i;
						PartSpec.Item_Id = KartExcData.PartsList[select][5];
						PartSpec.Grade = (byte)KartExcData.PartsList[select][6];
						PartSpec.PartsValue = KartExcData.PartsList[select][7];
					}
					else if (i == 65)
					{
						PartSpec.Item_Cat_Id = i;
						PartSpec.Item_Id = KartExcData.PartsList[select][8];
						PartSpec.Grade = (byte)KartExcData.PartsList[select][9];
						PartSpec.PartsValue = KartExcData.PartsList[select][10];
					}
					else if (i == 66)
					{
						PartSpec.Item_Cat_Id = i;
						PartSpec.Item_Id = KartExcData.PartsList[select][11];
						PartSpec.Grade = (byte)KartExcData.PartsList[select][12];
						PartSpec.PartsValue = KartExcData.PartsList[select][13];
					}
					PartSpec.PartSpecData();
				}
			}
		}
	}
}
