using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using KartSpec;

namespace KartRider
{
	public class FlyingPet
	{
		public static float DragFactor;
		public static float ForwardAccelForce;
		public static float DriftEscapeForce;
		public static float CornerDrawFactor;
		public static float NormalBoosterTime;
		public static float ItemBoosterTime;
		public static float TeamBoosterTime;
		public static float StartForwardAccelForceItem;
		public static float StartForwardAccelForceSpeed;

		public static void FlyingPet_Spec()
		{
			if (StartGameData.FlyingPet_id == 0)
			{
				FlyingPet.DragFactor = 0f;
				FlyingPet.ForwardAccelForce = 0f;
				FlyingPet.DriftEscapeForce = 0f;
				FlyingPet.CornerDrawFactor = 0f;
				FlyingPet.NormalBoosterTime = 0f;
				FlyingPet.ItemBoosterTime = 0f;
				FlyingPet.TeamBoosterTime = 0f;
				FlyingPet.StartForwardAccelForceItem = 0f;
				FlyingPet.StartForwardAccelForceSpeed = 0f;
			}
			else
			{
				XmlDocument doc = new XmlDocument();
				doc.Load(@"Profile\FlyingPetSpec.xml");
				if (!(doc.GetElementsByTagName("id" + StartGameData.FlyingPet_id.ToString()) == null))
				{
					XmlNodeList lis = doc.GetElementsByTagName("id" + StartGameData.FlyingPet_id.ToString());
					foreach (XmlNode xn in lis)
					{
						XmlElement xe = (XmlElement)xn;
						FlyingPet.DragFactor = float.Parse(xe.GetAttribute("DragFactor"));
						FlyingPet.ForwardAccelForce = float.Parse(xe.GetAttribute("ForwardAccelForce"));
						FlyingPet.DriftEscapeForce = float.Parse(xe.GetAttribute("DriftEscapeForce"));
						FlyingPet.CornerDrawFactor = float.Parse(xe.GetAttribute("CornerDrawFactor"));
						FlyingPet.NormalBoosterTime = float.Parse(xe.GetAttribute("NormalBoosterTime"));
						FlyingPet.ItemBoosterTime = float.Parse(xe.GetAttribute("ItemBoosterTime"));
						FlyingPet.TeamBoosterTime = float.Parse(xe.GetAttribute("TeamBoosterTime"));
						FlyingPet.StartForwardAccelForceItem = float.Parse(xe.GetAttribute("StartForwardAccelForceItem"));
						FlyingPet.StartForwardAccelForceSpeed = float.Parse(xe.GetAttribute("StartForwardAccelForceSpeed"));
					}
				}
				else
				{
					FlyingPet.DragFactor = 0f;
					FlyingPet.ForwardAccelForce = 0f;
					FlyingPet.DriftEscapeForce = 0f;
					FlyingPet.CornerDrawFactor = 0f;
					FlyingPet.NormalBoosterTime = 0f;
					FlyingPet.ItemBoosterTime = 0f;
					FlyingPet.TeamBoosterTime = 0f;
					FlyingPet.StartForwardAccelForceItem = 0f;
					FlyingPet.StartForwardAccelForceSpeed = 0f;
				}
			}
			Kart_Spec.KartAll();
		}
	}
}