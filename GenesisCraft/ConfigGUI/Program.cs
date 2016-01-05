using System;
using System.Windows.Forms;

namespace ConfigGUI
{
	public class Program
	{
		public Program ()
		{

		}

		[STAThread]
		public static void Main(string[] args)
		{
			Form form = new Form ();
			form.Text = "ConfigGUI";
			form.ShowDialog ();
			TabControl tabControl = new TabControl ();
			TabPage page1 = new TabPage ("General");
			tabControl.TabPages.Add (page1);
			form.Controls.Add (tabControl);
			tabControl.Show ();
		}


	}
}

