using System;

namespace ExcData
{
	public class TuneSpec
	{
		public static float Tune_DragFactor = 0f;
		public static float Tune_ForwardAccel = 0f;
		public static float Tune_CornerDrawFactor = 0f;
		public static float Tune_TeamBoosterTime = 0f;
		public static float Tune_NormalBoosterTime = 0f;
		public static float Tune_StartBoosterTimeSpeed = 0f;
		public static float Tune_TransAccelFactor = 0f;
		public static float Tune_DriftMaxGauge = 0f;
		public static float Tune_DriftEscapeForce = 0f;

		public static float Plant43_TransAccelFactor = 0f;
		public static float Plant43_DragFactor = 0f;
		public static float Plant43_StartForwardAccelSpeed = 0f;
		public static float Plant43_ForwardAccel = 0f;
		public static float Plant43_StartBoosterTimeSpeed = 0f;

		public static float Plant44_SlipBrake = 0f;
		public static float Plant44_GripBrake = 0f;
		public static float Plant44_RearGripFactor = 0f;
		public static float Plant44_FrontGripFactor = 0f;
		public static float Plant44_CornerDrawFactor = 0f;
		public static float Plant44_SteerConstraint = 0f;

		public static float Plant45_DriftEscapeForce = 0f;
		public static float Plant45_DriftMaxGauge = 0f;
		public static float Plant45_CornerDrawFactor = 0f;
		public static float Plant45_SlipBrake = 0f;
		public static float Plant45_AnimalBoosterTime = 0f;
		public static float Plant45_AntiCollideBalance = 0f;
		public static float Plant45_DragFactor = 0f;

		public static float Plant46_DriftMaxGauge = 0f;
		public static float Plant46_NormalBoosterTime = 0f;
		public static float Plant46_DriftSlipFactor = 0f;
		public static float Plant46_ForwardAccel = 0f;
		public static float Plant46_AnimalBoosterTime = 0f;
		public static float Plant46_TeamBoosterTime = 0f;
		public static float Plant46_StartForwardAccelSpeed = 0f;
		public static float Plant46_StartForwardAccelItem = 0f;
		public static float Plant46_StartBoosterTimeSpeed = 0f;
		public static float Plant46_StartBoosterTimeItem = 0f;
		public static byte Plant46_ItemSlotCapacity = 0;
		public static byte Plant46_SpeedSlotCapacity = 0;
		public static float Plant46_GripBrake = 0f;
		public static float Plant46_SlipBrake = 0f;

		public static float KartLevel_DragFactor = 0f;
		public static float KartLevel_ForwardAccel = 0f;
		public static float KartLevel_CornerDrawFactor = 0f;
		public static float KartLevel_SteerConstraint = 0f;
		public static float KartLevel_DriftEscapeForce = 0f;
		public static float KartLevel_TransAccelFactor = 0f;
		public static float KartLevel_StartBoosterTimeSpeed = 0f;
		public static float KartLevel_StartBoosterTimeItem = 0f;
		public static float KartLevel_BoostAccelFactorOnlyItem = 0f;

		public static float PartSpec_TransAccelFactor = 0f; //엔진
		public static float PartSpec_SteerConstraint = 0f; //핸들
		public static float PartSpec_DriftEscapeForce = 0f; //바퀴
		public static float PartSpec_NormalBoosterTime = 0f; //부스터

		public static void Reset_PartSpec_SpecData()
		{
			TuneSpec.PartSpec_TransAccelFactor = 0f;
			TuneSpec.PartSpec_SteerConstraint = 0f;
			TuneSpec.PartSpec_DriftEscapeForce = 0f;
			TuneSpec.PartSpec_NormalBoosterTime = 0f;
			Console.WriteLine("Part_Spec: OFF");
		}

		public static void Reset_Tune_SpecData()
		{
			TuneSpec.Tune_DragFactor = 0f;
			TuneSpec.Tune_ForwardAccel = 0f;
			TuneSpec.Tune_CornerDrawFactor = 0f;
			TuneSpec.Tune_TeamBoosterTime = 0f;
			TuneSpec.Tune_NormalBoosterTime = 0f;
			TuneSpec.Tune_StartBoosterTimeSpeed = 0f;
			TuneSpec.Tune_TransAccelFactor = 0f;
			TuneSpec.Tune_DriftMaxGauge = 0f;
			TuneSpec.Tune_DriftEscapeForce = 0f;
			Console.WriteLine("Tune_Type: OFF");
		}

		public static void Reset_Plant_SpecData()
		{
			TuneSpec.Plant43_TransAccelFactor = 0f;
			TuneSpec.Plant43_DragFactor = 0f;
			TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
			TuneSpec.Plant43_ForwardAccel = 0f;
			TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;

			TuneSpec.Plant44_SlipBrake = 0f;
			TuneSpec.Plant44_GripBrake = 0f;
			TuneSpec.Plant44_RearGripFactor = 0f;
			TuneSpec.Plant44_FrontGripFactor = 0f;
			TuneSpec.Plant44_CornerDrawFactor = 0f;
			TuneSpec.Plant44_SteerConstraint = 0f;

			TuneSpec.Plant45_DriftEscapeForce = 0f;
			TuneSpec.Plant45_DriftMaxGauge = 0f;
			TuneSpec.Plant45_CornerDrawFactor = 0f;
			TuneSpec.Plant45_SlipBrake = 0f;
			TuneSpec.Plant45_AnimalBoosterTime = 0f;
			TuneSpec.Plant45_AntiCollideBalance = 0f;
			TuneSpec.Plant45_DragFactor = 0f;

			TuneSpec.Plant46_DriftMaxGauge = 0f;
			TuneSpec.Plant46_NormalBoosterTime = 0f;
			TuneSpec.Plant46_DriftSlipFactor = 0f;
			TuneSpec.Plant46_ForwardAccel = 0f;
			TuneSpec.Plant46_AnimalBoosterTime = 0f;
			TuneSpec.Plant46_TeamBoosterTime = 0f;
			TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
			TuneSpec.Plant46_StartForwardAccelItem = 0f;
			TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
			TuneSpec.Plant46_StartBoosterTimeItem = 0f;
			TuneSpec.Plant46_ItemSlotCapacity = 0;
			TuneSpec.Plant46_SpeedSlotCapacity = 0;
			TuneSpec.Plant46_GripBrake = 0f;
			TuneSpec.Plant46_SlipBrake = 0f;
			Console.WriteLine("Plant_Spec: OFF");
		}

		public static void Reset_KartLevel_SpecData()
		{
			TuneSpec.KartLevel_DragFactor = 0f;
			TuneSpec.KartLevel_ForwardAccel = 0f;
			TuneSpec.KartLevel_CornerDrawFactor = 0f;
			TuneSpec.KartLevel_SteerConstraint = 0f;
			TuneSpec.KartLevel_DriftEscapeForce = 0f;
			TuneSpec.KartLevel_TransAccelFactor = 0f;
			TuneSpec.KartLevel_StartBoosterTimeSpeed = 0f;
			TuneSpec.KartLevel_StartBoosterTimeItem = 0f;
			TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0f;
			Console.WriteLine("Level_Spec: OFF");
		}

		public static void Use_TuneSpec(short Set_Kart, short Set_KartSN)
		{
			int select = -1;
			for (var i = 0; i < KartExcData.TuneList.Count; i++)
			{
				if (KartExcData.TuneList[i][0] == Set_Kart && KartExcData.TuneList[i][1] == Set_KartSN)
				{
					select = i;
				}
			}
			if (select > -1)
			{
				if (KartExcData.TuneList[select][2] == 103 || KartExcData.TuneList[select][3] == 103 || KartExcData.TuneList[select][4] == 103)
				{
					TuneSpec.Tune_DragFactor = -0.0022f;
				}
				else if (KartExcData.TuneList[select][2] == 203 || KartExcData.TuneList[select][3] == 203 || KartExcData.TuneList[select][4] == 203)
				{
					TuneSpec.Tune_ForwardAccel = 3.5f;
				}
				else if (KartExcData.TuneList[select][2] == 303 || KartExcData.TuneList[select][3] == 303 || KartExcData.TuneList[select][4] == 303)
				{
					TuneSpec.Tune_CornerDrawFactor = 0.0020f;
				}
				else if (KartExcData.TuneList[select][2] == 403 || KartExcData.TuneList[select][3] == 403 || KartExcData.TuneList[select][4] == 403)
				{
					TuneSpec.Tune_TeamBoosterTime = 250f;
				}
				else if (KartExcData.TuneList[select][2] == 503 || KartExcData.TuneList[select][3] == 503 || KartExcData.TuneList[select][4] == 503)
				{
					TuneSpec.Tune_NormalBoosterTime = 190f;
				}
				else if (KartExcData.TuneList[select][2] == 603 || KartExcData.TuneList[select][3] == 603 || KartExcData.TuneList[select][4] == 603)
				{
					TuneSpec.Tune_StartBoosterTimeSpeed = 800f;
				}
				else if (KartExcData.TuneList[select][2] == 703 || KartExcData.TuneList[select][3] == 703 || KartExcData.TuneList[select][4] == 703)
				{
					TuneSpec.Tune_TransAccelFactor = 0.018f;
				}
				else if (KartExcData.TuneList[select][2] == 803 || KartExcData.TuneList[select][3] == 803 || KartExcData.TuneList[select][4] == 803)
				{
					TuneSpec.Tune_DriftMaxGauge = -200f;
				}
				else if (KartExcData.TuneList[select][2] == 903 || KartExcData.TuneList[select][3] == 903 || KartExcData.TuneList[select][4] == 903)
				{
					TuneSpec.Tune_DriftEscapeForce = 210f;
				}
			}
			else
			{
				TuneSpec.Reset_Tune_SpecData();
			}
		}

		public static void Use_PlantSpec(short Set_Kart, short Set_KartSN)
		{
			int select = -1;
			for (var i = 0; i < KartExcData.PlantList.Count; i++)
			{
				if (KartExcData.PlantList[i][0] == Set_Kart && KartExcData.PlantList[i][1] == Set_KartSN)
				{
					select = i;
				}
			}
			if (select > -1)
			{
				if (KartExcData.PlantList[select][2] == 43)
				{
					if (KartExcData.PlantList[select][3] == 1)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.02f;
						TuneSpec.Plant43_DragFactor = -0.0007f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.02f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 2)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.02f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 2f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 3)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.02f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 15f;
					}
					else if (KartExcData.PlantList[select][3] == 4)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.04f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 5)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.04f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 6)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0021f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 7)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0014f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 8)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.02f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 9)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0.02f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 10)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 2f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 11)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 2f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 12)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0007f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 13)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0007f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 14)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0007f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 15)
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = -0.0014f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 16)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0002f;
						TuneSpec.Plant43_DragFactor = -0.0014f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 17)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0004f;
						TuneSpec.Plant43_DragFactor = -0.0007f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 18)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0002f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 2f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 19)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0004f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 20)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0006f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 21)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0008f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 22)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.0012f;
						TuneSpec.Plant43_DragFactor = -0.0014f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
					else if (KartExcData.PlantList[select][3] == 23)
					{
						TuneSpec.Plant43_TransAccelFactor = 0.002f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 1f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 30f;
					}
					else
					{
						TuneSpec.Plant43_TransAccelFactor = 0f;
						TuneSpec.Plant43_DragFactor = 0f;
						TuneSpec.Plant43_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant43_ForwardAccel = 0f;
						TuneSpec.Plant43_StartBoosterTimeSpeed = 0f;
					}
				}
				else if (KartExcData.PlantList[select][4] == 44)
				{
					if (KartExcData.PlantList[select][5] == 1)
					{
						TuneSpec.Plant44_SlipBrake = -40f;
						TuneSpec.Plant44_GripBrake = -40f;
						TuneSpec.Plant44_RearGripFactor = 0.2f;
						TuneSpec.Plant44_FrontGripFactor = 0.2f;
						TuneSpec.Plant44_CornerDrawFactor = 0.0005f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 2)
					{
						TuneSpec.Plant44_SlipBrake = -12f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0.3f;
						TuneSpec.Plant44_FrontGripFactor = 0.3f;
						TuneSpec.Plant44_CornerDrawFactor = 0.001f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 3)
					{
						TuneSpec.Plant44_SlipBrake = -10f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0.2f;
						TuneSpec.Plant44_FrontGripFactor = 0.2f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 4)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0.1f;
						TuneSpec.Plant44_FrontGripFactor = 0.1f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 5)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = -20f;
						TuneSpec.Plant44_RearGripFactor = 0.05f;
						TuneSpec.Plant44_FrontGripFactor = 0.05f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 6)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = -20f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 7)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = -15f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 8)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0.2f;
					}
					else if (KartExcData.PlantList[select][5] == 9)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0.4f;
					}
					else if (KartExcData.PlantList[select][5] == 10)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0.8f;
					}
					else if (KartExcData.PlantList[select][5] == 11)
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = -0.4f;
					}
					else if (KartExcData.PlantList[select][5] == 12)
					{
						TuneSpec.Plant44_SlipBrake = -8f;
						TuneSpec.Plant44_GripBrake = -5f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 13)
					{
						TuneSpec.Plant44_SlipBrake = -6f;
						TuneSpec.Plant44_GripBrake = -7f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 14)
					{
						TuneSpec.Plant44_SlipBrake = -4f;
						TuneSpec.Plant44_GripBrake = -9f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else if (KartExcData.PlantList[select][5] == 15)
					{
						TuneSpec.Plant44_SlipBrake = -2f;
						TuneSpec.Plant44_GripBrake = -11f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
					else
					{
						TuneSpec.Plant44_SlipBrake = 0f;
						TuneSpec.Plant44_GripBrake = 0f;
						TuneSpec.Plant44_RearGripFactor = 0f;
						TuneSpec.Plant44_FrontGripFactor = 0f;
						TuneSpec.Plant44_CornerDrawFactor = 0f;
						TuneSpec.Plant44_SteerConstraint = 0f;
					}
				}
				else if (KartExcData.PlantList[select][6] == 45)
				{
					if (KartExcData.PlantList[select][7] == 0)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 1)
					{
						TuneSpec.Plant45_DriftEscapeForce = 70f;
						TuneSpec.Plant45_DriftMaxGauge = -40f;
						TuneSpec.Plant45_CornerDrawFactor = 0.001f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 2)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -60f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = -192f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 3)
					{
						TuneSpec.Plant45_DriftEscapeForce = 70f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 100f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 4)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -60f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 5)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -40f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 100f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 6)
					{
						TuneSpec.Plant45_DriftEscapeForce = 50f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 7)
					{
						TuneSpec.Plant45_DriftEscapeForce = 30f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0.0005f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 8)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -40f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 9)
					{
						TuneSpec.Plant45_DriftEscapeForce = -20f;
						TuneSpec.Plant45_DriftMaxGauge = -60f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 10)
					{
						TuneSpec.Plant45_DriftEscapeForce = -60f;
						TuneSpec.Plant45_DriftMaxGauge = -100f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 11)
					{
						TuneSpec.Plant45_DriftEscapeForce = -40f;
						TuneSpec.Plant45_DriftMaxGauge = -80f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 12)
					{
						TuneSpec.Plant45_DriftEscapeForce = 10f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 13)
					{
						TuneSpec.Plant45_DriftEscapeForce = 30f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 14)
					{
						TuneSpec.Plant45_DriftEscapeForce = 50f;
						TuneSpec.Plant45_DriftMaxGauge = 40f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 15)
					{
						TuneSpec.Plant45_DriftEscapeForce = 70f;
						TuneSpec.Plant45_DriftMaxGauge = 60f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 16)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0.0005f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.005f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 17)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.005f;
						TuneSpec.Plant45_DragFactor = -0.0007f;
					}
					else if (KartExcData.PlantList[select][7] == 18)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -40f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.005f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 19)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.01f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 20)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = -30f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.01f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 21)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.015f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 22)
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 30f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = -0.02f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else if (KartExcData.PlantList[select][7] == 23)
					{
						TuneSpec.Plant45_DriftEscapeForce = 90f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0.0005f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
					else
					{
						TuneSpec.Plant45_DriftEscapeForce = 0f;
						TuneSpec.Plant45_DriftMaxGauge = 0f;
						TuneSpec.Plant45_CornerDrawFactor = 0f;
						TuneSpec.Plant45_SlipBrake = 0f;
						TuneSpec.Plant45_AnimalBoosterTime = 0f;
						TuneSpec.Plant45_AntiCollideBalance = 0f;
						TuneSpec.Plant45_DragFactor = 0f;
					}
				}
				else if (KartExcData.PlantList[select][8] == 46)
				{
					if (KartExcData.PlantList[select][9] == 1)
					{
						TuneSpec.Plant46_DriftMaxGauge = -80f;
						TuneSpec.Plant46_NormalBoosterTime = 120f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 2)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = -0.03f;
						TuneSpec.Plant46_ForwardAccel = 2f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 3)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 200f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 5)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 90f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 50f;
						TuneSpec.Plant46_TeamBoosterTime = 60f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0.02f;
						TuneSpec.Plant46_StartForwardAccelItem = 0.02f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 7)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 105f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 8)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 105f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 11)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 3;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 12)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 3;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 15 || KartExcData.PlantList[select][9] == 16)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 100f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 10f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 17)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 100f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 9f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 18)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 120f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 23)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 60f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 24)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 60f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 25)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 90f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = -30f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else if (KartExcData.PlantList[select][9] == 26)
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = -30f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 90f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
					else
					{
						TuneSpec.Plant46_DriftMaxGauge = 0f;
						TuneSpec.Plant46_NormalBoosterTime = 0f;
						TuneSpec.Plant46_DriftSlipFactor = 0f;
						TuneSpec.Plant46_ForwardAccel = 0f;
						TuneSpec.Plant46_AnimalBoosterTime = 0f;
						TuneSpec.Plant46_TeamBoosterTime = 0f;
						TuneSpec.Plant46_StartForwardAccelSpeed = 0f;
						TuneSpec.Plant46_StartForwardAccelItem = 0f;
						TuneSpec.Plant46_StartBoosterTimeSpeed = 0f;
						TuneSpec.Plant46_StartBoosterTimeItem = 0f;
						TuneSpec.Plant46_ItemSlotCapacity = 0;
						TuneSpec.Plant46_SpeedSlotCapacity = 0;
						TuneSpec.Plant46_GripBrake = 0f;
						TuneSpec.Plant46_SlipBrake = 0f;
					}
				}
			}
			else
			{
				TuneSpec.Reset_Plant_SpecData();
			}
		}

		public static void Use_KartLevelSpec(short Set_Kart, short Set_KartSN)
		{
			int select = -1;
			for (var i = 0; i < KartExcData.LevelList.Count; i++)
			{
				if (KartExcData.LevelList[i][0] == Set_Kart && KartExcData.LevelList[i][1] == Set_KartSN)
				{
					select = i;
				}
			}
			if (select > -1)
			{
				if (KartExcData.LevelList[select][4] == 0)
				{
					TuneSpec.KartLevel_DragFactor = 0f;
					TuneSpec.KartLevel_ForwardAccel = 0f;
				}
				else if(KartExcData.LevelList[select][4] == 1)
				{
					TuneSpec.KartLevel_DragFactor = -0.0001f;
					TuneSpec.KartLevel_ForwardAccel = 0.1f;
				}
				else if (KartExcData.LevelList[select][4] == 2)
				{
					TuneSpec.KartLevel_DragFactor = -0.0002f;
					TuneSpec.KartLevel_ForwardAccel = 0.2f;
				}
				else if (KartExcData.LevelList[select][4] == 3)
				{
					TuneSpec.KartLevel_DragFactor = -0.0003f;
					TuneSpec.KartLevel_ForwardAccel = 0.3f;
				}
				else if (KartExcData.LevelList[select][4] == 4)
				{
					TuneSpec.KartLevel_DragFactor = -0.0004f;
					TuneSpec.KartLevel_ForwardAccel = 0.4f;
				}
				else if (KartExcData.LevelList[select][4] == 5)
				{
					TuneSpec.KartLevel_DragFactor = -0.0005f;
					TuneSpec.KartLevel_ForwardAccel = 0.5f;
				}
				else if (KartExcData.LevelList[select][4] == 6)
				{
					TuneSpec.KartLevel_DragFactor = -0.0006f;
					TuneSpec.KartLevel_ForwardAccel = 0.6f;
				}
				else if (KartExcData.LevelList[select][4] == 7)
				{
					TuneSpec.KartLevel_DragFactor = -0.0007f;
					TuneSpec.KartLevel_ForwardAccel = 0.7f;
				}
				else if (KartExcData.LevelList[select][4] == 8)
				{
					TuneSpec.KartLevel_DragFactor = -0.0008f;
					TuneSpec.KartLevel_ForwardAccel = 0.8f;
				}
				else if (KartExcData.LevelList[select][4] == 9)
				{
					TuneSpec.KartLevel_DragFactor = -0.001f;
					TuneSpec.KartLevel_ForwardAccel = 1f;
				}
				else if (KartExcData.LevelList[select][4] == 10)
				{
					TuneSpec.KartLevel_DragFactor = -0.0012f;
					TuneSpec.KartLevel_ForwardAccel = 1.5f;
				}
				if (KartExcData.LevelList[select][5] == 0)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0f;
					TuneSpec.KartLevel_SteerConstraint = 0f;
				}
				else if (KartExcData.LevelList[select][5] == 1)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0001f;
					TuneSpec.KartLevel_SteerConstraint = 0.01f;
				}
				else if (KartExcData.LevelList[select][5] == 2)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0002f;
					TuneSpec.KartLevel_SteerConstraint = 0.02f;
				}
				else if (KartExcData.LevelList[select][5] == 3)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0003f;
					TuneSpec.KartLevel_SteerConstraint = 0.03f;
				}
				else if (KartExcData.LevelList[select][5] == 4)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0004f;
					TuneSpec.KartLevel_SteerConstraint = 0.04f;
				}
				else if (KartExcData.LevelList[select][5] == 5)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0005f;
					TuneSpec.KartLevel_SteerConstraint = 0.05f;
				}
				else if (KartExcData.LevelList[select][5] == 6)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0006f;
					TuneSpec.KartLevel_SteerConstraint = 0.06f;
				}
				else if (KartExcData.LevelList[select][5] == 7)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0007f;
					TuneSpec.KartLevel_SteerConstraint = 0.08f;
				}
				else if (KartExcData.LevelList[select][5] == 8)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0008f;
					TuneSpec.KartLevel_SteerConstraint = 0.11f;
				}
				else if (KartExcData.LevelList[select][5] == 9)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.0009f;
					TuneSpec.KartLevel_SteerConstraint = 0.15f;
				}
				else if (KartExcData.LevelList[select][5] == 10)
				{
					TuneSpec.KartLevel_CornerDrawFactor = 0.001f;
					TuneSpec.KartLevel_SteerConstraint = 0.2f;
				}
				if (KartExcData.LevelList[select][6] == 0)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 0f;
				}
				else if (KartExcData.LevelList[select][6] == 1)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 1f;
				}
				else if (KartExcData.LevelList[select][6] == 2)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 3f;
				}
				else if (KartExcData.LevelList[select][6] == 3)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 6f;
				}
				else if (KartExcData.LevelList[select][6] == 4)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 10f;
				}
				else if (KartExcData.LevelList[select][6] == 5)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 15f;
				}
				else if (KartExcData.LevelList[select][6] == 6)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 20f;
				}
				else if (KartExcData.LevelList[select][6] == 7)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 26f;
				}
				else if (KartExcData.LevelList[select][6] == 8)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 33f;
				}
				else if (KartExcData.LevelList[select][6] == 9)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 40f;
				}
				else if (KartExcData.LevelList[select][6] == 10)
				{
					TuneSpec.KartLevel_DriftEscapeForce = 50f;
				}
				if (KartExcData.LevelList[select][7] == 0)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 0f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 0f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0f;
				}
				else if (KartExcData.LevelList[select][7] == 1)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0001f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 5f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 5f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.001f;
				}
				else if (KartExcData.LevelList[select][7] == 2)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0003f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 10f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 10f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.003f;
				}
				else if (KartExcData.LevelList[select][7] == 3)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0006f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 15f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 15f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.005f;
				}
				else if (KartExcData.LevelList[select][7] == 4)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.001f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 20f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 20f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.009f;
				}
				else if (KartExcData.LevelList[select][7] == 5)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0014f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 30f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 30f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.013f;
				}
				else if (KartExcData.LevelList[select][7] == 6)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0019f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 40f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 40f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.019f;
				}
				else if (KartExcData.LevelList[select][7] == 7)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0025f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 50f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 50f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.025f;
				}
				else if (KartExcData.LevelList[select][7] == 8)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.0032f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 65f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 65f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.033f;
				}
				else if (KartExcData.LevelList[select][7] == 9)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.004f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 80f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 80f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.041f;
				}
				else if (KartExcData.LevelList[select][7] == 10)
				{
					TuneSpec.KartLevel_TransAccelFactor = 0.005f;
					TuneSpec.KartLevel_StartBoosterTimeSpeed = 100f;
					TuneSpec.KartLevel_StartBoosterTimeItem = 100f;
					TuneSpec.KartLevel_BoostAccelFactorOnlyItem = 0.05f;
				}
			}
			else
			{
				TuneSpec.Reset_KartLevel_SpecData();
			}
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
						short Item_Id = KartExcData.PartsList[select][2];
						short Grade = KartExcData.PartsList[select][3];
						short PartsValue = KartExcData.PartsList[select][4];
						if (PartsValue != 0)
						{
							TuneSpec.PartSpec_TransAccelFactor = (KartExcData.PartsList[select][4] * 1.0f - 800.0f) / 25000.0f + 1.85f + -0.205f;
						}
						else
						{
							TuneSpec.PartSpec_TransAccelFactor = 0f;
						}
					}
					else if (i == 64)
					{
						short Item_Id = KartExcData.PartsList[select][5];
						short Grade = (byte)KartExcData.PartsList[select][6];
						short PartsValue = KartExcData.PartsList[select][7];
						if (PartsValue != 0)
						{
							TuneSpec.PartSpec_SteerConstraint = (KartExcData.PartsList[select][7] * 1.0f - 800.0f) / 250.0f + 2.1f + 20.3f;
						}
						else
						{
							TuneSpec.PartSpec_SteerConstraint = 0f;
						}
					}
					else if (i == 65)
					{
						short Item_Id = KartExcData.PartsList[select][8];
						short Grade = (byte)KartExcData.PartsList[select][9];
						short PartsValue = KartExcData.PartsList[select][10];
						if (PartsValue != 0)
						{
							TuneSpec.PartSpec_DriftEscapeForce = KartExcData.PartsList[select][10] * 2.0f + 2200.0f;
						}
						else
						{
							TuneSpec.PartSpec_DriftEscapeForce = 0f;
						}
					}
					else if (i == 66)
					{
						short Item_Id = KartExcData.PartsList[select][11];
						short Grade = (byte)KartExcData.PartsList[select][12];
						short PartsValue = KartExcData.PartsList[select][13];
						if (PartsValue != 0)
						{
							TuneSpec.PartSpec_NormalBoosterTime = KartExcData.PartsList[select][13] * 1.0f - 940.0f + 3000.0f;
						}
						else
						{
							TuneSpec.PartSpec_NormalBoosterTime = 0f;
						}
					}
					Console.WriteLine("-------------------------------------------------------------");
					Console.WriteLine("TransAccelFactor:{0}", PartSpec_TransAccelFactor);
					Console.WriteLine("SteerConstraint:{0}", PartSpec_SteerConstraint);
					Console.WriteLine("DriftEscapeForce:{0}", PartSpec_DriftEscapeForce);
					Console.WriteLine("NormalBoosterTime:{0}", PartSpec_NormalBoosterTime);
					Console.WriteLine("-------------------------------------------------------------");
				}
			}
			else
			{
				TuneSpec.Reset_PartSpec_SpecData();
			}
		}
	}
}
