using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace UmContraX
{
	class Serializer
	{
		public Serializer()
		{
		}

		~Serializer()
		{
		}

		public void SerializeObject(string filename, PlayerRank objectToSerialize)
		{
			Stream stream = File.Open(filename, FileMode.Create);
			BinaryFormatter bFormatter = new BinaryFormatter();
			bFormatter.Serialize(stream, objectToSerialize);
			stream.Close();
		}

		public PlayerRank DeSerializeObject(string filename)
		{
			PlayerRank objectToSerialize;
			Stream stream = File.Open(filename, FileMode.Open);
			BinaryFormatter bFormatter = new BinaryFormatter();
			objectToSerialize = (PlayerRank)bFormatter.Deserialize(stream);
			stream.Close();
			return objectToSerialize;
		}
	}
}
