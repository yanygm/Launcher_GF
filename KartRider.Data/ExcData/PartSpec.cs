using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KartRider_SN;

namespace ExcData
{
	public class PartSpec
	{
		public static byte SpeedType; //3보통, 0빠름, 1매우빠름, 2가장빠름, 4무부
		public static short PartsValue;
		public static byte Grade; //1유니크, 2레전드, 3레어, 4일반
		public static short Item_Id; //1X파츠, 2V1파츠
		public static short Item_Cat_Id; //63엔진, 64핸들, 65바퀴, 66부스터

		public static float TransAccelFactor = 0f; //엔진
		public static float SteerConstraint = 0f; //핸들
		public static float DriftEscapeForce = 0f; //바퀴
		public static float NormalBoosterTime = 0f; //부스터

		public static void PartSpecData()
		{
			//보통채널 속도 기준으로 수치값 나열             
			//-------------------------------------------------------------------------------------------------------------------------------엔진
			if (Item_Cat_Id == 63)
			{
				if (PartsValue == 0)
				{
					TransAccelFactor = 0f;
				}
				//-----------------------------------------------------X 파츠
				if (Item_Id == 1)
				{
					//-----------------------------------------------------일반 등급 +0.0004
					if (Grade == 4)
					{
						if (PartsValue == 810)
							TransAccelFactor = 1.6454f;
						else if (PartsValue == 820)
							TransAccelFactor = 1.6458f;
						else if (PartsValue == 830)
							TransAccelFactor = 1.6462f;
						else if (PartsValue == 840)
							TransAccelFactor = 1.6466f;
						else if (PartsValue == 850)
							TransAccelFactor = 1.647f;
						else if (PartsValue == 860)
							TransAccelFactor = 1.6474f;
						else if (PartsValue == 870)
							TransAccelFactor = 1.6478f;
						else if (PartsValue == 880)
							TransAccelFactor = 1.6482f;
						else if (PartsValue == 890)
							TransAccelFactor = 1.6486f;
						else if (PartsValue == 900)
							TransAccelFactor = 1.649f;
					}
					//-----------------------------------------------------레어 등급 +0.0004
					else if (Grade == 3)
					{
						if (PartsValue == 910)
							TransAccelFactor = 1.6494f;
						else if (PartsValue == 920)
							TransAccelFactor = 1.6498f;
						else if (PartsValue == 930)
							TransAccelFactor = 1.6502f;
						else if (PartsValue == 940)
							TransAccelFactor = 1.6506f;
						else if (PartsValue == 950)
							TransAccelFactor = 1.651f;
						else if (PartsValue == 960)
							TransAccelFactor = 1.6514f;
						else if (PartsValue == 970)
							TransAccelFactor = 1.6518f;
						else if (PartsValue == 980)
							TransAccelFactor = 1.6522f;
						else if (PartsValue == 990)
							TransAccelFactor = 1.6526f;
						else if (PartsValue == 1000)
							TransAccelFactor = 1.653f;
					}
					//-----------------------------------------------------레전드 등급 +0.0002
					else if (Grade == 2)
					{
						if (PartsValue == 1005)
							TransAccelFactor = 1.6532f;
						else if (PartsValue == 1010)
							TransAccelFactor = 1.6534f;
						else if (PartsValue == 1015)
							TransAccelFactor = 1.6536f;
						else if (PartsValue == 1020)
							TransAccelFactor = 1.6538f;
						else if (PartsValue == 1025)
							TransAccelFactor = 1.654f;
						else if (PartsValue == 1030)
							TransAccelFactor = 1.6542f;
						else if (PartsValue == 1035)
							TransAccelFactor = 1.6544f;
						else if (PartsValue == 1040)
							TransAccelFactor = 1.6546f;
						else if (PartsValue == 1045)
							TransAccelFactor = 1.6548f;
						else if (PartsValue == 1050)
							TransAccelFactor = 1.655f;
					}
					//-----------------------------------------------------유니크 등급 +0.00012
					else if (Grade == 1)
					{
						if (PartsValue == 1053)
							TransAccelFactor = 1.65512f;
						else if (PartsValue == 1056)
							TransAccelFactor = 1.65524f;
						else if (PartsValue == 1059)
							TransAccelFactor = 1.65536f;
						else if (PartsValue == 1062)
							TransAccelFactor = 1.65548f;
						else if (PartsValue == 1065)
							TransAccelFactor = 1.6556f;
						else if (PartsValue == 1068)
							TransAccelFactor = 1.65572f;
						else if (PartsValue == 1071)
							TransAccelFactor = 1.65584f;
						else if (PartsValue == 1074)
							TransAccelFactor = 1.65596f;
						else if (PartsValue == 1077)
							TransAccelFactor = 1.65608f;
						else if (PartsValue == 1080)
							TransAccelFactor = 1.6562f;
					}
				}
				//-----------------------------------------------------V1 파츠
				if (Item_Id == 2)
				{
					//-----------------------------------------------------일반 등급 +0.0004
					if (Grade == 4)
					{
						if (PartsValue == 910)
							TransAccelFactor = 1.6494f;
						else if (PartsValue == 920)
							TransAccelFactor = 1.6498f;
						else if (PartsValue == 930)
							TransAccelFactor = 1.6502f;
						else if (PartsValue == 940)
							TransAccelFactor = 1.6506f;
						else if (PartsValue == 950)
							TransAccelFactor = 1.651f;
						else if (PartsValue == 960)
							TransAccelFactor = 1.6514f;
						else if (PartsValue == 970)
							TransAccelFactor = 1.6518f;
						else if (PartsValue == 980)
							TransAccelFactor = 1.6522f;
						else if (PartsValue == 990)
							TransAccelFactor = 1.6526f;
						else if (PartsValue == 1000)
							TransAccelFactor = 1.653f;
					}
					//-----------------------------------------------------레어 등급 +0.0004
					else if (Grade == 3)
					{
						if (PartsValue == 1010)
							TransAccelFactor = 1.6534f;
						else if (PartsValue == 1020)
							TransAccelFactor = 1.6538f;
						else if (PartsValue == 1030)
							TransAccelFactor = 1.6542f;
						else if (PartsValue == 1040)
							TransAccelFactor = 1.6546f;
						else if (PartsValue == 1050)
							TransAccelFactor = 1.655f;
						else if (PartsValue == 1060)
							TransAccelFactor = 1.6554f;
						else if (PartsValue == 1070)
							TransAccelFactor = 1.6558f;
						else if (PartsValue == 1080)
							TransAccelFactor = 1.6562f;
						else if (PartsValue == 1090)
							TransAccelFactor = 1.6566f;
						else if (PartsValue == 1100)
							TransAccelFactor = 1.657f;
					}
					//-----------------------------------------------------레전드 등급 +0.0002
					else if (Grade == 2)
					{
						if (PartsValue == 1105)
							TransAccelFactor = 1.6572f;
						else if (PartsValue == 1110)
							TransAccelFactor = 1.6574f;
						else if (PartsValue == 1115)
							TransAccelFactor = 1.6576f;
						else if (PartsValue == 1120)
							TransAccelFactor = 1.6578f;
						else if (PartsValue == 1125)
							TransAccelFactor = 1.658f;
						else if (PartsValue == 1130)
							TransAccelFactor = 1.6582f;
						else if (PartsValue == 1135)
							TransAccelFactor = 1.6584f;
						else if (PartsValue == 1140)
							TransAccelFactor = 1.6586f;
						else if (PartsValue == 1145)
							TransAccelFactor = 1.6588f;
						else if (PartsValue == 1150)
							TransAccelFactor = 1.659f;
					}
					//-----------------------------------------------------유니크 등급 +0.00012
					else if (Grade == 1)
					{
						if (PartsValue == 1153)
							TransAccelFactor = 1.65912f;
						else if (PartsValue == 1156)
							TransAccelFactor = 1.65924f;
						else if (PartsValue == 1159)
							TransAccelFactor = 1.65936f;
						else if (PartsValue == 1162)
							TransAccelFactor = 1.65948f;
						else if (PartsValue == 1165)
							TransAccelFactor = 1.6596f;
						else if (PartsValue == 1168)
							TransAccelFactor = 1.65972f;
						else if (PartsValue == 1171)
							TransAccelFactor = 1.65984f;
						else if (PartsValue == 1174)
							TransAccelFactor = 1.65996f;
						else if (PartsValue == 1177)
							TransAccelFactor = 1.66008f;
						else if (PartsValue == 1180)
							TransAccelFactor = 1.6602f;
					}
				}
			}
			//-------------------------------------------------------------------------------------------------------------------------------핸들
			if (Item_Cat_Id == 64)
			{
				if (PartsValue == 0)
				{
					SteerConstraint = 0f;
				}
				//-----------------------------------------------------X 파츠, V1 파츠
				if (Item_Id == 1 || Item_Id == 2)
				{
					//-----------------------------------------------------일반 등급 +0.04
					if (Grade == 4)
					{
						if (PartsValue == 810)
							SteerConstraint = 22.44f;
						else if (PartsValue == 820)
							SteerConstraint = 22.48f;
						else if (PartsValue == 830)
							SteerConstraint = 22.52f;
						else if (PartsValue == 840)
							SteerConstraint = 22.56f;
						else if (PartsValue == 850)
							SteerConstraint = 22.6f;
						else if (PartsValue == 860)
							SteerConstraint = 22.64f;
						else if (PartsValue == 870)
							SteerConstraint = 22.68f;
						else if (PartsValue == 880)
							SteerConstraint = 22.72f;
						else if (PartsValue == 890)
							SteerConstraint = 22.76f;
						else if (PartsValue == 900)
							SteerConstraint = 22.8f;
					}
					//-----------------------------------------------------레어 등급 +0.04
					else if (Grade == 3)
					{
						if (PartsValue == 910)
							SteerConstraint = 22.84f;
						else if (PartsValue == 920)
							SteerConstraint = 22.88f;
						else if (PartsValue == 930)
							SteerConstraint = 22.92f;
						else if (PartsValue == 940)
							SteerConstraint = 22.96f;
						else if (PartsValue == 950)
							SteerConstraint = 23f;
						else if (PartsValue == 960)
							SteerConstraint = 23.04f;
						else if (PartsValue == 970)
							SteerConstraint = 23.08f;
						else if (PartsValue == 980)
							SteerConstraint = 23.12f;
						else if (PartsValue == 990)
							SteerConstraint = 23.16f;
						else if (PartsValue == 1000)
							SteerConstraint = 23.2f;
					}
					//-----------------------------------------------------레전드 등급 +0.02
					else if (Grade == 2)
					{
						if (PartsValue == 1005)
							SteerConstraint = 23.22f;
						else if (PartsValue == 1010)
							SteerConstraint = 23.24f;
						else if (PartsValue == 1015)
							SteerConstraint = 23.26f;
						else if (PartsValue == 1020)
							SteerConstraint = 23.28f;
						else if (PartsValue == 1025)
							SteerConstraint = 23.3f;
						else if (PartsValue == 1030)
							SteerConstraint = 23.32f;
						else if (PartsValue == 1035)
							SteerConstraint = 23.34f;
						else if (PartsValue == 1040)
							SteerConstraint = 23.36f;
						else if (PartsValue == 1045)
							SteerConstraint = 23.38f;
						else if (PartsValue == 1050)
							SteerConstraint = 23.4f;
					}
					//-----------------------------------------------------유니크 등급 +0.012
					else if (Grade == 1)
					{
						if (PartsValue == 1053)
							SteerConstraint = 23.412f;
						else if (PartsValue == 1056)
							SteerConstraint = 23.424f;
						else if (PartsValue == 1059)
							SteerConstraint = 23.436f;
						else if (PartsValue == 1062)
							SteerConstraint = 23.448f;
						else if (PartsValue == 1065)
							SteerConstraint = 23.46f;
						else if (PartsValue == 1068)
							SteerConstraint = 23.472f;
						else if (PartsValue == 1071)
							SteerConstraint = 23.484f;
						else if (PartsValue == 1074)
							SteerConstraint = 23.496f;
						else if (PartsValue == 1077)
							SteerConstraint = 23.508f;
						else if (PartsValue == 1080)
							SteerConstraint = 23.52f;
					}
				}
			}
			//-------------------------------------------------------------------------------------------------------------------------------바퀴
			if (Item_Cat_Id == 65)
			{
				if (PartsValue == 0)
				{
					DriftEscapeForce = 0f;
				}
				//-----------------------------------------------------X 파츠
				if (Item_Id == 1)
				{
					//-----------------------------------------------------일반 등급 +20
					if (Grade == 4)
					{
						if (PartsValue == 810)
							DriftEscapeForce = 3820f;
						else if (PartsValue == 820)
							DriftEscapeForce = 3840f;
						else if (PartsValue == 830)
							DriftEscapeForce = 3860f;
						else if (PartsValue == 840)
							DriftEscapeForce = 3880f;
						else if (PartsValue == 850)
							DriftEscapeForce = 3900f;
						else if (PartsValue == 860)
							DriftEscapeForce = 3920f;
						else if (PartsValue == 870)
							DriftEscapeForce = 3940f;
						else if (PartsValue == 880)
							DriftEscapeForce = 3960f;
						else if (PartsValue == 890)
							DriftEscapeForce = 3980f;
						else if (PartsValue == 900)
							DriftEscapeForce = 4000f;
					}
					//-----------------------------------------------------레어 등급 +20
					else if (Grade == 3)
					{
						if (PartsValue == 910)
							DriftEscapeForce = 4020f;
						else if (PartsValue == 920)
							DriftEscapeForce = 4040f;
						else if (PartsValue == 930)
							DriftEscapeForce = 4060f;
						else if (PartsValue == 940)
							DriftEscapeForce = 4080f;
						else if (PartsValue == 950)
							DriftEscapeForce = 4100f;
						else if (PartsValue == 960)
							DriftEscapeForce = 4120f;
						else if (PartsValue == 970)
							DriftEscapeForce = 4140f;
						else if (PartsValue == 980)
							DriftEscapeForce = 4160f;
						else if (PartsValue == 990)
							DriftEscapeForce = 4180f;
						else if (PartsValue == 1000)
							DriftEscapeForce = 4200f;
					}
					//-----------------------------------------------------레전드 등급 +10
					else if (Grade == 2)
					{
						if (PartsValue == 1005)
							DriftEscapeForce = 4210f;
						else if (PartsValue == 1010)
							DriftEscapeForce = 4220f;
						else if (PartsValue == 1015)
							DriftEscapeForce = 4230f;
						else if (PartsValue == 1020)
							DriftEscapeForce = 4240f;
						else if (PartsValue == 1025)
							DriftEscapeForce = 4250f;
						else if (PartsValue == 1030)
							DriftEscapeForce = 4260f;
						else if (PartsValue == 1035)
							DriftEscapeForce = 4270f;
						else if (PartsValue == 1040)
							DriftEscapeForce = 4280f;
						else if (PartsValue == 1045)
							DriftEscapeForce = 4290f;
						else if (PartsValue == 1050)
							DriftEscapeForce = 4300f;
					}
					//-----------------------------------------------------유니크 등급 +6
					else if (Grade == 1)
					{
						if (PartsValue == 1053)
							DriftEscapeForce = 4306f;
						else if (PartsValue == 1056)
							DriftEscapeForce = 4312f;
						else if (PartsValue == 1059)
							DriftEscapeForce = 4318f;
						else if (PartsValue == 1062)
							DriftEscapeForce = 4324f;
						else if (PartsValue == 1065)
							DriftEscapeForce = 4330f;
						else if (PartsValue == 1068)
							DriftEscapeForce = 4336f;
						else if (PartsValue == 1071)
							DriftEscapeForce = 4342f;
						else if (PartsValue == 1074)
							DriftEscapeForce = 4348f;
						else if (PartsValue == 1077)
							DriftEscapeForce = 4354f;
						else if (PartsValue == 1080)
							DriftEscapeForce = 4360f;
					}
				}
				//-----------------------------------------------------V1 파츠
				if (Item_Id == 2)
				{
					//-----------------------------------------------------일반 등급 +20
					if (Grade == 4)
					{
						if (PartsValue == 910)
							DriftEscapeForce = 4020f;
						else if (PartsValue == 920)
							DriftEscapeForce = 4040f;
						else if (PartsValue == 930)
							DriftEscapeForce = 4060f;
						else if (PartsValue == 940)
							DriftEscapeForce = 4080f;
						else if (PartsValue == 950)
							DriftEscapeForce = 4100f;
						else if (PartsValue == 960)
							DriftEscapeForce = 4120f;
						else if (PartsValue == 970)
							DriftEscapeForce = 4140f;
						else if (PartsValue == 980)
							DriftEscapeForce = 4160f;
						else if (PartsValue == 990)
							DriftEscapeForce = 4180f;
						else if (PartsValue == 1000)
							DriftEscapeForce = 4200f;
					}
					//-----------------------------------------------------레어 등급 +20
					else if (Grade == 3)
					{
						if (PartsValue == 1010)
							DriftEscapeForce = 4220f;
						else if (PartsValue == 1020)
							DriftEscapeForce = 4240f;
						else if (PartsValue == 1030)
							DriftEscapeForce = 4260f;
						else if (PartsValue == 1040)
							DriftEscapeForce = 4280f;
						else if (PartsValue == 1050)
							DriftEscapeForce = 4300f;
						else if (PartsValue == 1060)
							DriftEscapeForce = 4320f;
						else if (PartsValue == 1070)
							DriftEscapeForce = 4340f;
						else if (PartsValue == 1080)
							DriftEscapeForce = 4360f;
						else if (PartsValue == 1090)
							DriftEscapeForce = 4380f;
						else if (PartsValue == 1100)
							DriftEscapeForce = 4400f;
					}
					//-----------------------------------------------------레전드 등급 +10
					else if (Grade == 2)
					{
						if (PartsValue == 1105)
							DriftEscapeForce = 4410f;
						else if (PartsValue == 1110)
							DriftEscapeForce = 4420f;
						else if (PartsValue == 1115)
							DriftEscapeForce = 4430f;
						else if (PartsValue == 1120)
							DriftEscapeForce = 4440f;
						else if (PartsValue == 1125)
							DriftEscapeForce = 4450f;
						else if (PartsValue == 1130)
							DriftEscapeForce = 4460f;
						else if (PartsValue == 1135)
							DriftEscapeForce = 4470f;
						else if (PartsValue == 1140)
							DriftEscapeForce = 4480f;
						else if (PartsValue == 1145)
							DriftEscapeForce = 4490f;
						else if (PartsValue == 1150)
							DriftEscapeForce = 4500f;
					}
					//-----------------------------------------------------유니크 등급 +6
					else if (Grade == 1)
					{
						if (PartsValue == 1153)
							DriftEscapeForce = 4506f;
						else if (PartsValue == 1156)
							DriftEscapeForce = 4512f;
						else if (PartsValue == 1159)
							DriftEscapeForce = 4518f;
						else if (PartsValue == 1162)
							DriftEscapeForce = 4524f;
						else if (PartsValue == 1165)
							DriftEscapeForce = 4530f;
						else if (PartsValue == 1168)
							DriftEscapeForce = 4536f;
						else if (PartsValue == 1171)
							DriftEscapeForce = 4542f;
						else if (PartsValue == 1174)
							DriftEscapeForce = 4548f;
						else if (PartsValue == 1177)
							DriftEscapeForce = 4554f;
						else if (PartsValue == 1180)
							DriftEscapeForce = 4560f;
					}
				}
			}
			//-------------------------------------------------------------------------------------------------------------------------------부스터
			if (Item_Cat_Id == 66)
			{
				if (PartsValue == 0)
				{
					NormalBoosterTime = 0f;
				}
				//-----------------------------------------------------X 파츠, V1 파츠
				if (Item_Id == 1 || Item_Id == 2)
				{
					//-----------------------------------------------------일반 등급 +10
					if (Grade == 4)
					{
						if (PartsValue == 810)
							NormalBoosterTime = 2870f;
						else if (PartsValue == 820)
							NormalBoosterTime = 2880f;
						else if (PartsValue == 830)
							NormalBoosterTime = 2890f;
						else if (PartsValue == 840)
							NormalBoosterTime = 2900f;
						else if (PartsValue == 850)
							NormalBoosterTime = 2910f;
						else if (PartsValue == 860)
							NormalBoosterTime = 2920f;
						else if (PartsValue == 870)
							NormalBoosterTime = 2930f;
						else if (PartsValue == 880)
							NormalBoosterTime = 2940f;
						else if (PartsValue == 890)
							NormalBoosterTime = 2950f;
						else if (PartsValue == 900)
							NormalBoosterTime = 2960f;
					}
					//-----------------------------------------------------레어 등급 +10
					else if (Grade == 3)
					{
						if (PartsValue == 910)
							NormalBoosterTime = 2970f;
						else if (PartsValue == 920)
							NormalBoosterTime = 2980f;
						else if (PartsValue == 930)
							NormalBoosterTime = 2990f;
						else if (PartsValue == 940)
							NormalBoosterTime = 3000f;
						else if (PartsValue == 950)
							NormalBoosterTime = 3010f;
						else if (PartsValue == 960)
							NormalBoosterTime = 3020f;
						else if (PartsValue == 970)
							NormalBoosterTime = 3030f;
						else if (PartsValue == 980)
							NormalBoosterTime = 3040f;
						else if (PartsValue == 990)
							NormalBoosterTime = 3050f;
						else if (PartsValue == 1000)
							NormalBoosterTime = 3060f;
					}
					//-----------------------------------------------------레전드 등급 +5
					else if (Grade == 2)
					{
						if (PartsValue == 1005)
							NormalBoosterTime = 3065f;
						else if (PartsValue == 1010)
							NormalBoosterTime = 3070f;
						else if (PartsValue == 1015)
							NormalBoosterTime = 3075f;
						else if (PartsValue == 1020)
							NormalBoosterTime = 3080f;
						else if (PartsValue == 1025)
							NormalBoosterTime = 3085f;
						else if (PartsValue == 1030)
							NormalBoosterTime = 3090f;
						else if (PartsValue == 1035)
							NormalBoosterTime = 3095f;
						else if (PartsValue == 1040)
							NormalBoosterTime = 3100f;
						else if (PartsValue == 1045)
							NormalBoosterTime = 3105f;
						else if (PartsValue == 1050)
							NormalBoosterTime = 3110f;
					}
					//-----------------------------------------------------유니크 등급 +3
					else if (Grade == 1)
					{
						if (PartsValue == 1053)
							NormalBoosterTime = 3113f;
						else if (PartsValue == 1056)
							NormalBoosterTime = 3116f;
						else if (PartsValue == 1059)
							NormalBoosterTime = 3119f;
						else if (PartsValue == 1062)
							NormalBoosterTime = 3122f;
						else if (PartsValue == 1065)
							NormalBoosterTime = 3125f;
						else if (PartsValue == 1068)
							NormalBoosterTime = 3128f;
						else if (PartsValue == 1071)
							NormalBoosterTime = 3131f;
						else if (PartsValue == 1074)
							NormalBoosterTime = 3134f;
						else if (PartsValue == 1077)
							NormalBoosterTime = 3137f;
						else if (PartsValue == 1080)
							NormalBoosterTime = 3140f;
					}
				}
			}
			Console.WriteLine("PartSpec : Item: {0}:{1}, Grade: {2}, PartsValue: {3}", Item_Cat_Id, Item_Id, Grade, PartsValue);
			KartSN_Parts.KartSN_Data();
		}
	}
}