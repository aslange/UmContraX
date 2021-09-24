using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace UmContraX
{
	class Config
	{
		private const String CONFIG_FILENAME = "UmContraX.cfg";
		private static List<ConfigItem> lstConfigItem;

		public String FileName
		{
			get { return CONFIG_FILENAME; }
		}

		public List<ConfigItem> LstConfigItem
		{
			get { return lstConfigItem; }
			set { lstConfigItem = value; }
		}

		public bool SaveConfig()
		{
			TextWriter twConfigFile;

			try
			{
				if (File.Exists(CONFIG_FILENAME))
				{
					File.Delete(CONFIG_FILENAME);
				}

				twConfigFile = new StreamWriter(CONFIG_FILENAME);

				twConfigFile.WriteLine("Um Contra X - Configuration File: \n");

				foreach (ConfigItem ci in lstConfigItem)
				{
					twConfigFile.WriteLine(ci.Name + " = " + ci.ItemValue);
				}

				twConfigFile.Close();

				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
				return false;
			}
		}

		public bool GetConfig()
		{
			TextReader trConfigFile;
			String strConfig;
			int aux;
			String name, itemvalue;
			lstConfigItem = new List<ConfigItem>();

			try
			{
				if (File.Exists(CONFIG_FILENAME))
				{
					trConfigFile = new StreamReader(CONFIG_FILENAME);

					while ((strConfig = trConfigFile.ReadLine()) != null)
					{
						if (strConfig.Contains("="))
						{
							aux = strConfig.LastIndexOf("=");
							
							name = strConfig.Substring(0, aux).Trim();
							itemvalue = strConfig.Substring(aux + 1).Trim();

							lstConfigItem.Add(new ConfigItem(name, itemvalue));
						}
					}

					trConfigFile.Close();

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}

			return false;
		}
	}
}
