using System;

namespace GenesisCraftCLI
{
	class MainClass
	{
		static bool xmlConfigLoaded = false;

		[STAThread]
		public static void Main (string[] args)
		{
			Console.WriteLine ("Starting Server...");
			if (xmlConfigLoaded) {
				Console.WriteLine ("Server Configuration Loaded");
			} else {
				Console.WriteLine ("Configuration Loading Failed. The file is either corrupt or missing.");
				return;
			}
		}
	}
}
