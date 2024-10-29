using ExcData;
using KartRider.Common.Utilities;
using KartRider.IO;
using KartRider_PacketName;
using KartRider_TrackName;
using Set_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KartRider
{
    public static class MultyPlayer
    {
        static string RoomName;
        static byte[] RoomUnkBytes;
        static uint ArrivalTicks, EndTicks, SettleTicks;
        static uint track = 0;
        public static uint BootTicksPrev, BootTicksNow;
        public static uint StartTicks = 0;
        static uint FinishTime;

        [DllImport("kernel32")]
        extern static UInt32 GetTickCount();

        public static void milTime(int time)
        {
            GameType.min = time / 60000;
            int sec = time - GameType.min * 60000;
            GameType.sec = sec / 1000;
            GameType.mil = time % 1000;
        }

        public static uint GetUpTime()
        {
            var temp = TimeSpan.FromMilliseconds(GetTickCount()).Ticks;
            temp /= 10000;
            return (uint)temp;
        }

        static void Set_settleTrigger()
        {
            var onceTimer = new System.Timers.Timer();
            onceTimer.Interval = 10000;
            onceTimer.Elapsed += new System.Timers.ElapsedEventHandler((s, _event) => settleTrigger(s, _event));
            onceTimer.AutoReset = false;
            onceTimer.Start();
        }
        static void settleTrigger(object sender, System.Timers.ElapsedEventArgs e)
        {
            SettleTicks = EndTicks + 3100;
            using (OutPacket outPacket = new OutPacket("GameNextStagePacket"))
            {
                outPacket.WriteByte(2);
                outPacket.WriteInt();
                outPacket.WriteInt();
                RouterListener.MySession.Client.Send(outPacket);
            }
            using (OutPacket outPacket = new OutPacket("GameResultPacket"))
            {
                outPacket.WriteByte();
                outPacket.WriteInt(1);
                outPacket.WriteInt();
                outPacket.WriteUInt(FinishTime);
                outPacket.WriteByte();
                outPacket.WriteShort(SetRiderItem.Set_Kart);
                outPacket.WriteShort();
                outPacket.WriteShort();
                outPacket.WriteHexString("d0 78");
                outPacket.WriteByte();
                outPacket.WriteInt(SetRider.RP);
                outPacket.WriteInt(0); //Earned RP
                outPacket.WriteInt(25); //Earned Lucci
                outPacket.WriteUInt(SetRider.Lucci);
                outPacket.WriteBytes(new byte[41]);
                outPacket.WriteInt(1);
                outPacket.WriteShort(768);
                outPacket.WriteBytes(new byte[50]);
                outPacket.WriteInt(255);
                outPacket.WriteInt();
                outPacket.WriteHexString("a8 b8 65 40");
                outPacket.WriteBytes(new byte[162]);
                outPacket.WriteHexString("01 77 00 2d 00 66 00 6f");
                outPacket.WriteBytes(new byte[20]);
                outPacket.WriteHexString("20 00 74 00 ff ff ff ff");
                RouterListener.MySession.Client.Send(outPacket);
            }
            using (OutPacket outPacket = new OutPacket("GameControlPacket"))
            {
                outPacket.WriteInt(4);
                outPacket.WriteHexString("fa 10 69 7f 6a ff 7f 00");
                outPacket.WriteByte();
                outPacket.WriteUInt(SettleTicks);
                outPacket.WriteInt(32767);
                outPacket.WriteInt();
                outPacket.WriteInt(1);
                outPacket.WriteBytes(new byte[21]);
                outPacket.WriteInt(1);
                outPacket.WriteBytes(new byte[28]);
                outPacket.WriteInt(8);
                outPacket.WriteBytes(new byte[6]);
                outPacket.WriteByte(10);
                RouterListener.MySession.Client.Send(outPacket);
            }
            Console.WriteLine("GameSlotPacket, Settle. Ticks = {0}", SettleTicks);
        }

        public static void Clientsession(uint hash, InPacket iPacket)
        {
            if (hash == Adler32Helper.GenerateAdler32_ASCII("GameSlotPacket", 0))
            {
                iPacket.ReadInt();
                iPacket.ReadInt();
                iPacket.ReadInt();
                var nextpacketlenth = iPacket.ReadInt();
                var nextpackethash = iPacket.ReadUInt();
                if (nextpackethash == Adler32Helper.GenerateAdler32_ASCII("GopCourse", 0))
                {
                    iPacket.ReadBytes(nextpacketlenth - 4 - 4);
                    ArrivalTicks = iPacket.ReadUInt();
                }
                Console.WriteLine("GameSlotPacket, Arrivaled. Ticks = {0}", ArrivalTicks);
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GameControlPacket"))
            {
                var state = iPacket.ReadByte();
                //start
                if (state == 0)
                {
                    BootTicksNow = GetUpTime();
                    StartTicks += (StartTicks == 0) ? (BootTicksNow + 15780) : (BootTicksNow - BootTicksPrev);
                    BootTicksPrev = BootTicksNow;
                    using (OutPacket oPacket = new OutPacket("GameAiMasterSlotNoticePacket"))
                    {
                        oPacket.WriteInt();
                        RouterListener.MySession.Client.Send(oPacket);
                    }
                    using (OutPacket oPacket = new OutPacket("GameControlPacket"))
                    {
                        oPacket.WriteInt(1);
                        oPacket.WriteByte();
                        oPacket.WriteUInt(StartTicks);
                        oPacket.WriteBytes(new byte[71]);
                        oPacket.WriteByte(0x0a);
                        RouterListener.MySession.Client.Send(oPacket);
                    }
                    Console.WriteLine("GameControlPacket, Start. Ticks = {0}", StartTicks);
                }
                //finish
                else if (state == 2)
                {
                    iPacket.ReadInt();
                    FinishTime = iPacket.ReadUInt();
                    using (OutPacket oPacket = new OutPacket("GameRaceTimePacket"))
                    {
                        oPacket.WriteInt();
                        oPacket.WriteUInt(FinishTime);
                        RouterListener.MySession.Client.Send(oPacket);
                    }
                    using (OutPacket oPacket = new OutPacket("GameControlPacket"))
                    {
                        EndTicks = ArrivalTicks + 10180;
                        oPacket.WriteByte(3);
                        oPacket.WriteInt();
                        oPacket.WriteUInt(EndTicks);
                        oPacket.WriteBytes(new byte[71]);
                        oPacket.WriteByte(0x85);
                    }
                    Console.Write("GameControlPacket, Finish. Finish Time = {0}", FinishTime);
                    Console.WriteLine(" , End - Start Ticks : {0}", EndTicks - StartTicks - 10180);
                    Set_settleTrigger();
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("ChGetRoomListRequestPacket"))
            {
                using (OutPacket oPacket = new OutPacket("ChGetRoomListReplyPacket"))
                {
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("PqChannelSwitch", 0))
            {
                //Console.WriteLine("Channel Switch, avaliable = {0}", iPacket.Available);
                //Console.WriteLine(BitConverter.ToString(iPacket.ReadBytes(iPacket.Available)).Replace("-", " "));
                //iPacket.ReadInt();
                //iPacket.ReadBytes(14);
                byte[] DateTime1 = iPacket.ReadBytes(18);
                byte channel = iPacket.ReadByte();
                Console.WriteLine("Channel Switch, channel = {0}", channel);
                if (channel == 70)
                {
                    using (OutPacket oPacket = new OutPacket("PrChannelSwitch"))
                    {
                        oPacket.WriteInt(0);
                        oPacket.WriteInt(4);
                        oPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39312);
                        RouterListener.MySession.Client.Send(oPacket);
                    }
                }
                else
                {
                    using (OutPacket oPacket = new OutPacket("ChGetCurrentGpReplyPacket"))
                    {
                        oPacket.WriteInt(0);
                        oPacket.WriteInt(0);
                        oPacket.WriteInt(0);
                        oPacket.WriteInt(0);
                        oPacket.WriteInt(0);
                        oPacket.WriteByte(0);
                        RouterListener.MySession.Client.Send(oPacket);
                    }
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("PqChannelMovein", 0))
            {
                using (OutPacket oPacket = new OutPacket("PrChannelMoveIn"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39311);
                    oPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39312);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("PqMissionAttendPacket", 0))
            {
                using (OutPacket oPacket = new OutPacket("PrMissionAttendPacket"))
                {
                    oPacket.WriteInt(3);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(15);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(-1);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(109);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("ChCreateRoomRequestPacket", 0))
            {
                Console.Write("Avaiable = {0}", iPacket.Available);
                RoomName = iPacket.ReadString();    //room name
                Console.WriteLine(" RoomName = {0}, len = {1}", RoomName, RoomName.Length);
                iPacket.ReadInt();
                var unk1 = iPacket.ReadByte(); //7c
                var Playernum = iPacket.ReadInt();
                iPacket.ReadInt();
                iPacket.ReadInt();
                RoomUnkBytes = iPacket.ReadBytes(32);
                using (OutPacket oPacket = new OutPacket("ChCreateRoomReplyPacket"))
                {
                    //oPacket.WriteInt(0);
                    oPacket.WriteHexString("01 00");
                    oPacket.WriteByte((byte)Playernum);
                    oPacket.WriteByte(unk1);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrFirstRequestPacket"))
            {
                GrSessionDataPacket();
                //Thread.Sleep(10);
                GrSlotDataPacket();
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrChangeTrackPacket"))
            {
                track = iPacket.ReadUInt();
                iPacket.ReadInt();
                RoomUnkBytes = iPacket.ReadBytes(32);
                Console.WriteLine("Gr Track Changed : {0}", (TrackName)track);
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrRequestSetSlotStatePacket"))
            {
                int Data = iPacket.ReadInt();
                GrSlotDataPacket();
                GrSlotStatePacket(Data);
                GrReplySetSlotStatePacket(Data);
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrRequestClosePacket"))
            {
                using (OutPacket oPacket = new OutPacket("GrReplyClosePacket"))
                {
                    //oPacket.WriteHexString("ff 76 05 5d 01");
                    oPacket.WriteUInt(SetRider.UserNO);
                    oPacket.WriteByte(1);
                    oPacket.WriteInt(7);
                    oPacket.WriteInt(7);
                    oPacket.WriteInt(0);
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrRequestStartPacket"))
            {
                using (OutPacket oPacket = new OutPacket("GrReplyStartPacket"))
                {
                    oPacket.WriteInt(0);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                using (OutPacket oPacket = new OutPacket("GrCommandStartPacket"))
                {
                    oPacket.WriteUInt(Adler32Helper.GenerateAdler32(Encoding.ASCII.GetBytes("GrSessionDataPacket")));
                    GrSessionDataPacket(oPacket);

                    oPacket.WriteUInt(Adler32Helper.GenerateAdler32(Encoding.ASCII.GetBytes("GrSlotDataPacket")));
                    GrSlotDataPacket(oPacket);

                    //kart data
                    //WriteKartdata(oPacket);
                    oPacket.WriteHexString("1B1B90B326B57089714B38B363707089BA7C726970707C7CBA7CBA7CC74DBA7CB386149302B3BA7CD4CEBA925AD7BA6889CEBA1A28D7BA7CF0B10C0C7AB1BA7C8F86BA7C8F861B1B35091B1B35091B1B3509BA62B2CE3FBDF709A333FDC9A2FC3FF1BA0925CEBA09C8CEBA62B7CEBA92E7CEBA7C11CEBA52BCCEB0F617B348EA52B3BA7C11D7BA6212D7BA092DCE240488CE0C0C47B3BABA7C99B365ABC6B3BA297C7089517C7089338043B3BA7CC74DBABABA7CBABACA5425F13D33FDC90C0C4709697BB2B38AFF7089BA62B7CEBA7CDAD7BA7C7089BA7C7E4DBA8AFF7089BA7C7E69BA7C7E69BA7C7E4DBA7C7089BA7C7089");

                    // 6x6 EncFloat
                    oPacket.WriteInt(1);
                    oPacket.WriteEncFloat(0.67f);
                    oPacket.WriteEncFloat(2300);
                    oPacket.WriteEncFloat(2930);
                    oPacket.WriteEncFloat(1.494f);
                    oPacket.WriteEncFloat(1000);
                    oPacket.WriteEncFloat(1500);

                    oPacket.WriteUInt(track); //track name hash
                    oPacket.WriteInt(10000);

                    oPacket.WriteInt();
                    oPacket.WriteUInt(Adler32Helper.GenerateAdler32(Encoding.ASCII.GetBytes("MissionInfo")));
                    oPacket.WriteHexString("00 00 00 00 00 00 00 00 00 00 ff ff ff ff 00 00 00 00 00");
                    oPacket.WriteString("[applied param]\r\ntransAccelFactor='1.8555' driftEscapeForce='4720' steerConstraint='24.95' normalBoosterTime='3860' \r\npartsBoosterLock='1' \r\n\r\n[equipped / default parts param]\r\ntransAccelFactor='1.86' driftEscapeForce='2120' steerConstraint='2.7' normalBoosterTime='860' \r\n\r\n\r\n[gamespeed param]\r\ntransAccelFactor='-0.0045' driftEscapeForce='2600' steerConstraint='22.25' normalBoosterTime='3000' \r\n\r\n\r\n[factory enchant param]\r\n");
                    RouterListener.MySession.Client.Send(oPacket);
                }
                //StartGameRacing.KartSpecLog();
                Console.WriteLine("Track : {0}", (TrackName)track);
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("PcReportStateInGame", 0))
            {
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("ChLeaveRoomRequestPacket"))
            {
                using (OutPacket oPacket = new OutPacket("ChLeaveRoomReplyPacket"))
                {
                    oPacket.WriteByte(1);
                    RouterListener.MySession.Client.Send(oPacket);
                }
                return;
            }
            else if (hash == Adler32Helper.GenerateAdler32_ASCII("GrRequestBasicAiPacket"))
            {
                int unk1 = iPacket.ReadInt();
                Console.WriteLine("GrRequestBasicAiPacket, unk1 = {0}", unk1);
                using (OutPacket oPacket = new OutPacket("GrSlotDataBasicAi"))
                {
                    oPacket.WriteInt(0);
                    oPacket.WriteByte(1);
                    oPacket.WriteInt(unk1);
                    oPacket.WriteHexString("1400150053040000000016000000000000FFFFFFFF01000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF");
                    RouterListener.MySession.Client.Send(oPacket);
                }
                using (OutPacket oPacket = new OutPacket("GrReplyBasicAiPacket"))
                {
                    oPacket.WriteByte(1);
                    oPacket.WriteHexString("2CFB6605");
                    RouterListener.MySession.Client.Send(oPacket);
                }
            }
        }

        static void GrSlotDataPacket()
        {
            using (OutPacket oPacket = new OutPacket("GrSlotDataPacket"))
            {
                GrSlotDataPacket(oPacket);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        static void GrSlotDataPacket(OutPacket outPacket)
        {
            outPacket.WriteUInt(track); //track name hash
            outPacket.WriteInt(0);
            outPacket.WriteBytes(RoomUnkBytes);
            outPacket.WriteInt(0); //RoomMaster
            outPacket.WriteInt(2);
            outPacket.WriteInt(65535); // outPacket.WriteShort(); outPacket.WriteShort(3);
            outPacket.WriteShort(0); // 797
            outPacket.WriteByte(0);
            var unk1 = 0;
            outPacket.WriteInt(unk1);
            for (int i = 0; i < unk1; i++) outPacket.WriteByte();
            for (int i = 0; i < 4; i++) outPacket.WriteInt();

            /* ---- One/First player ---- */
            outPacket.WriteInt(2);//Player Type, 2 = RoomMaster, 3 = AutoReady, 4 = Observer, 5 = ? , 7 = AI
            outPacket.WriteUInt(SetRider.UserNO);

            outPacket.WriteEndPoint(IPAddress.Parse(RouterListener.client.Address.ToString()), (ushort)RouterListener.client.Port);
            //outPacket.WriteEndPoint(IPAddress.Parse(RouterListener.forceConnect), 39311);
            //outPacket.WriteHexString("3a 16 01 31 7d 48");
            outPacket.WriteInt();
            outPacket.WriteShort();

            outPacket.WriteString(SetRider.Nickname);
            outPacket.WriteShort(SetRider.Emblem1);
            outPacket.WriteShort(SetRider.Emblem2);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_Character);
            outPacket.WriteShort(SetRiderItem.Set_Paint);
            outPacket.WriteShort(SetRiderItem.Set_Kart);
            outPacket.WriteShort(SetRiderItem.Set_Plate);
            outPacket.WriteShort(SetRiderItem.Set_Goggle);
            outPacket.WriteShort(SetRiderItem.Set_Balloon);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_HeadBand);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_HandGearL);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_Uniform);
            outPacket.WriteShort(0); //decal
            outPacket.WriteShort(SetRiderItem.Set_Pet);
            outPacket.WriteShort(SetRiderItem.Set_FlyingPet);
            outPacket.WriteShort(SetRiderItem.Set_Aura);
            outPacket.WriteShort(SetRiderItem.Set_SkidMark);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_RidColor);
            outPacket.WriteShort(SetRiderItem.Set_BonusCard);
            outPacket.WriteShort(0); //bossModeCard
            var PlantKartAndSN = new { Kart = SetRiderItem.Set_Kart, SN = SetRiderItem.Set_KartSN };
            var plantList = KartExcData.PlantList;
            var existingPlant = plantList.FirstOrDefault(list => list[0] == PlantKartAndSN.Kart && list[1] == PlantKartAndSN.SN);
            if (existingPlant != null)
            {
                outPacket.WriteShort(existingPlant[3]);
                outPacket.WriteShort(existingPlant[7]);
                outPacket.WriteShort(existingPlant[5]);
                outPacket.WriteShort(existingPlant[9]);
            }
            else
            {
                outPacket.WriteShort(0);
                outPacket.WriteShort(0);
                outPacket.WriteShort(0);
                outPacket.WriteShort(0);
            }
            outPacket.WriteShort(0);
            outPacket.WriteShort(0);
            outPacket.WriteShort(SetRiderItem.Set_Tachometer);
            outPacket.WriteShort(SetRiderItem.Set_Dye);
            outPacket.WriteShort(SetRiderItem.Set_KartSN);
            outPacket.WriteByte(0);
            var ExcKartAndSN = new { Kart = SetRiderItem.Set_Kart, SN = SetRiderItem.Set_KartSN };
            var partsList = KartExcData.PartsList;
            var existingParts = partsList.FirstOrDefault(list => list[0] == ExcKartAndSN.Kart && list[1] == ExcKartAndSN.SN);
            if (existingParts != null)
            {
                outPacket.WriteShort(existingParts[14]);
                outPacket.WriteShort(existingParts[15]);
            }
            else
            {
                var levelList = KartExcData.LevelList;
                var existingLevel = levelList.FirstOrDefault(list => list[0] == ExcKartAndSN.Kart && list[1] == ExcKartAndSN.SN);
                if (existingLevel != null)
                {
                    outPacket.WriteShort(7);
                    outPacket.WriteShort(0);
                }
                else
                {
                    outPacket.WriteShort(0);
                    outPacket.WriteShort(0);
                }
            }
            outPacket.WriteShort(SetRiderItem.Set_slotBg);
            outPacket.WriteString("");
            outPacket.WriteInt(SetRider.RP);
            outPacket.WriteByte();
            outPacket.WriteByte();
            outPacket.WriteByte();
            for (int i = 0; i < 8; i++) outPacket.WriteInt();
            outPacket.WriteInt(1500); //outPacket.WriteInt(1500);
            outPacket.WriteInt(1499); //outPacket.WriteInt(2000);
            outPacket.WriteInt(0); //outPacket.WriteInt();
            outPacket.WriteInt(2000); //outPacket.WriteInt(2000);
            outPacket.WriteInt(5); //outPacket.WriteInt(5);
            outPacket.WriteByte(255); //outPacket.WriteInt(1677721855);
            outPacket.WriteByte(0);
            outPacket.WriteByte(0);
            outPacket.WriteByte(0);

            outPacket.WriteByte(3); //3
            outPacket.WriteHexString("000000000000000000000000000000000000000000000000000700000014001500530400000000160000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FFFFFFFF01000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000");
            /*
            outPacket.WriteString("");
            outPacket.WriteInt();
            outPacket.WriteInt();
            outPacket.WriteInt();
            outPacket.WriteInt();
            outPacket.WriteByte();
            outPacket.WriteInt();
            */
            /*---- One/First player ----*/

            // AI Data
            //outPacket.WriteHexString("07000000070034007604000000001F0000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000FFFFFFFF01000000FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000");
        }

        static void GrSlotStatePacket(int Data)
        {
            using (OutPacket oPacket = new OutPacket("GrSlotStatePacket"))
            {
                oPacket.WriteInt(Data);
                oPacket.WriteBytes(new byte[60]);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        static void GrReplySetSlotStatePacket(int Data)
        {
            using (OutPacket oPacket = new OutPacket("GrReplySetSlotStatePacket"))
            {
                oPacket.WriteUInt(SetRider.UserNO);
                oPacket.WriteInt(1);
                oPacket.WriteByte(0);
                oPacket.WriteInt(Data);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }

        static void GrSessionDataPacket()
        {
            using (OutPacket oPacket = new OutPacket("GrSessionDataPacket"))
            {
                GrSessionDataPacket(oPacket);
                RouterListener.MySession.Client.Send(oPacket);
            }
        }
        static void GrSessionDataPacket(OutPacket outPacket)
        {
            outPacket.WriteString(RoomName);
            outPacket.WriteInt(0);
            outPacket.WriteByte(1);
            outPacket.WriteByte(7); //(byte)channeldata2
            outPacket.WriteInt(0);
            outPacket.WriteHexString("089637AF70"); //08 24 72 F5 9E
            outPacket.WriteInt(0);
            outPacket.WriteByte(0);
            outPacket.WriteByte(0);
        }
    }
}
