using System;
using KartRider.IO;
using KartRider;
using ExcData;

namespace RiderData
{
		public static void PrStartRiderSchool()
		{
			using (OutPacket oPacket = new OutPacket("PrStartRiderSchool"))
			{
				oPacket.WriteByte(1);
				oPacket.WriteEncFloat(1.1f);
				oPacket.WriteEncInt(2000);
				oPacket.WriteEncFloat(1.4f);
				oPacket.WriteEncInt(500);
				oPacket.WriteEncFloat(350f);
				oPacket.WriteEncByte(2);
				oPacket.WriteEncByte(2);
				oPacket.WriteEncByte(1);
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((false ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncFloat(100f);
				oPacket.WriteEncFloat(3f);
				oPacket.WriteEncFloat(0.667f + SpeedPatch.DragFactor);
				oPacket.WriteEncFloat(2304f + SpeedPatch.ForwardAccelForce);
				oPacket.WriteEncFloat(1825f);
				oPacket.WriteEncFloat(2070f);
				oPacket.WriteEncFloat(1415f);
				oPacket.WriteEncFloat(10f);
				oPacket.WriteEncFloat(24.61f);
				oPacket.WriteEncFloat(5f);
				oPacket.WriteEncFloat(5f);
				oPacket.WriteEncFloat(0.2f);
				oPacket.WriteEncFloat(0.2f);
				oPacket.WriteEncFloat(0.2f);
				oPacket.WriteEncFloat(4200f + SpeedPatch.DriftEscapeForce);
				oPacket.WriteEncFloat(0.254f + SpeedPatch.CornerDrawFactor);
				oPacket.WriteEncFloat(0.06f);
				oPacket.WriteEncFloat(0.01f);
				oPacket.WriteEncFloat(3860f + SpeedPatch.DriftMaxGauge);
				oPacket.WriteEncFloat(2900f);
				oPacket.WriteEncFloat(3000f);
				oPacket.WriteEncFloat(4350f);
				oPacket.WriteEncFloat(4000f);
				oPacket.WriteEncFloat(3500f);
				oPacket.WriteEncFloat(1.8495f + SpeedPatch.TransAccelFactor);
				oPacket.WriteEncFloat(1.494f + SpeedPatch.BoostAccelFactor);
				oPacket.WriteEncFloat(1000f);
				oPacket.WriteEncFloat(1500f);
				oPacket.WriteEncFloat(2304f + SpeedPatch.StartForwardAccelForceItem);
				oPacket.WriteEncFloat(3745.588f + SpeedPatch.StartForwardAccelForceSpeed);
				oPacket.WriteEncFloat(0.5f);
				oPacket.WriteEncByte((byte)((false ? 1 : 0)));
				oPacket.WriteEncFloat(1.5f);
				oPacket.WriteEncFloat(0.91f);
				oPacket.WriteEncByte((byte)((false ? 1 : 0)));
				oPacket.WriteEncInt(20);
				oPacket.WriteEncInt(30);
				oPacket.WriteEncFloat(1.04f);
				oPacket.WriteEncFloat(100f);
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncByte((byte)((true ? 1 : 0)));
				oPacket.WriteEncFloat(0.02f);
				oPacket.WriteEncFloat(0.06f);
				oPacket.WriteEncFloat(0.15f);
				oPacket.WriteEncFloat(1.11f);
				oPacket.WriteEncInt(3000);
				oPacket.WriteEncFloat(2500f);
				oPacket.WriteEncFloat(750f);
				oPacket.WriteEncFloat(0f);
				oPacket.WriteEncFloat(50f);
				oPacket.WriteEncByte((byte)((false ? 1 : 0)));
				oPacket.WriteEncInt(3000);
				oPacket.WriteEncFloat(200f);
				oPacket.WriteEncFloat(200f);
				oPacket.WriteEncFloat(50f);
				oPacket.WriteEncInt(0);
				oPacket.WriteEncInt(0);
				RouterListener.MySession.Client.Send(oPacket);
			}
		}
	}
}