using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KartRider_SN
{
	public class PartsDataReset
	{
		public static void PartsSpecReset()
		{
			TransAccelFactor_Count.TransAccelFactor = 0;
			SteerConstraint_Count.SteerConstraint = 0;
			DriftEscapeForce_Count.DriftEscapeForce = 0;
			NormalBoosterTime_Count.NormalBoosterTime = 0;
		}
	}
}