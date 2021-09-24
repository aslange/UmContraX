using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UmContraX
{
	class ConfigItem
	{
		private String name;
		private String itemValue;

		public String Name
		{
			get { return name; }
			set { name = value;}
		}

		public String ItemValue
		{
			get { return itemValue; }
			set { itemValue = value; }
		}

		public ConfigItem(String n, String iv)
		{
			name = n;
			itemValue = iv;
		}
	}
}
