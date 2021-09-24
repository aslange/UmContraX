using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UmContraX
{
	[Serializable()]
	class PlayerRank : ISerializable
	{
		private List<Player> lstPlayerRank = new List<Player>();

		public List<Player> LstPlayerRank
		{
			get { return this.lstPlayerRank; }
			set { this.lstPlayerRank = value; }
		}

		public PlayerRank()
		{
		}

		public PlayerRank(SerializationInfo info, StreamingContext ctxt)
		{
			this.lstPlayerRank = (List<Player>)info.GetValue("PlayerRanks", typeof(List<Player>));
		}

		public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
		{
			info.AddValue("PlayerRanks", this.lstPlayerRank);
		}
	}
}
