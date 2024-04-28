using System;
using KartRider.Common.Utilities;
using ExcData;
using System.Xml;

namespace KartRider
{
	public class RandomTrack
	{
		public static string GameType = "item";
		public static string SetRandomTrack = "allRandom";
		public static string GameTrack = "forest_I01";

		public static void SetGameType()
		{
			if (StartGameData.StartTimeAttack_RandomTrackGameType == 0)
			{
				RandomTrack.GameType = "speed";
			}
			else if (StartGameData.StartTimeAttack_RandomTrackGameType == 1)
			{
				RandomTrack.GameType = "item";
			}
			RandomTrack.SetRandomType();
		}

		public static void SetRandomType()
		{
			if (StartGameData.StartTimeAttack_Track == 0)
			{
				RandomTrack.SetRandomTrack = "allRandom";
			}
			else if (StartGameData.StartTimeAttack_Track == 1)
			{
				RandomTrack.SetRandomTrack = "leagueRandom";
			}
			else if (StartGameData.StartTimeAttack_Track == 3)
			{
				RandomTrack.SetRandomTrack = "hot1Random";
			}
			else if (StartGameData.StartTimeAttack_Track == 4)
			{
				RandomTrack.SetRandomTrack = "hot2Random";
			}
			else if (StartGameData.StartTimeAttack_Track == 5)
			{
				RandomTrack.SetRandomTrack = "hot3Random";
			}
			else if (StartGameData.StartTimeAttack_Track == 6)
			{
				RandomTrack.SetRandomTrack = "hot4Random";
			}
			else if (StartGameData.StartTimeAttack_Track == 7)
			{
				RandomTrack.SetRandomTrack = "hot5Random";
			}
			else if (StartGameData.StartTimeAttack_Track == 8)
			{
				RandomTrack.SetRandomTrack = "newRandom";
			}
			else if (StartGameData.StartTimeAttack_Track == 30)
			{
				RandomTrack.SetRandomTrack = "reverseRandom";
			}
			else if (StartGameData.StartTimeAttack_Track == 40)
			{
				RandomTrack.SetRandomTrack = "speedAllRandom";
			}
			else
			{
				RandomTrack.SetRandomTrack = "Unknown";
			}
			RandomTrack.RandomTrackSetList();
		}

		public static void RandomTrackSetList()
		{
			Random random = new Random();
			if (RandomTrack.SetRandomTrack == "allRandom")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("allitem");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("allspeed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "leagueRandom")
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\RandomTrack.xml");
				XmlNodeList lis = doc.GetElementsByTagName("league");
				int track = random.Next(0, lis.Count);
				XmlNode xn = lis[track];
				XmlElement xe = (XmlElement)xn;
				RandomTrack.GameTrack = xe.GetAttribute("Track");
			}
			else if (RandomTrack.SetRandomTrack == "hot1Random")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot1item");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");

				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot1speed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "hot2Random")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot2item");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot2speed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "hot3Random")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot3item");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot3speed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "hot4Random")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot4item");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot4speed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "hot5Random")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot5item");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("hot5speed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "newRandom")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("newitem");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("newspeed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "reverseRandom")
			{
				if (RandomTrack.GameType == "item")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("reverseitem");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
				else if (RandomTrack.GameType == "speed")
				{
					XmlDocument doc = new XmlDocument();
					doc.Load(@"Profile\RandomTrack.xml");
					XmlNodeList lis = doc.GetElementsByTagName("reversespeed");
					int track = random.Next(0, lis.Count);
					XmlNode xn = lis[track];
					XmlElement xe = (XmlElement)xn;
					RandomTrack.GameTrack = xe.GetAttribute("Track");
				}
			}
			else if (RandomTrack.SetRandomTrack == "speedAllRandom")
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\RandomTrack.xml");
				XmlNodeList lis = doc.GetElementsByTagName("speedAll");
				int track = random.Next(0, lis.Count);
				XmlNode xn = lis[track];
				XmlElement xe = (XmlElement)xn;
				RandomTrack.GameTrack = xe.GetAttribute("Track");
			}
			if (RandomTrack.SetRandomTrack != "Unknown")
			{
				StartGameData.StartTimeAttack_Track = Adler32Helper.GenerateAdler32_UNICODE(RandomTrack.GameTrack, 0);
				Console.WriteLine("RandomTrack: {0} / {1} / {2}", RandomTrack.GameType, RandomTrack.SetRandomTrack, RandomTrack.GameTrack);
			}
			SpeedType.SpeedTypeData();
		}
	}
}