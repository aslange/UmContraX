using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace UmContraX
{
	[Serializable()]
	class Player : ISerializable
	{
		private String name;
		private int points;
		private int position;

		public String Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Points
		{
			get { return points; }
			set { points = value; }
		}

		public int Position
		{
			get { return position; }
			set { position = value; }
		}

		public void Score()
		{
			Points++;
		}

		public void ClearScore()
		{
			Points = 0;
		}

		public Player()
		{
		}

		public Player(SerializationInfo info, StreamingContext ctxt)
        {
			this.position = (int)info.GetValue("Position", typeof(int));
            this.name = (String)info.GetValue("Name", typeof(String));
			this.points = (int)info.GetValue("Points", typeof(int));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
			info.AddValue("Position", this.position);
			info.AddValue("Name", this.name);
			info.AddValue("Points", this.points);
        }
	}
}
