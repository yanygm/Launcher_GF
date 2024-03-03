using System;

namespace KartRider.IO
{
	public sealed class PacketReadException : Exception
	{
		public PacketReadException(string message) : base(message)
		{
		}
	}
}