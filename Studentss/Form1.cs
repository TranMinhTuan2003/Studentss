using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentss
{
	public partial class Form1 : Form
	{
	private bool SignUpVisible = false;
		private bool SignInVisible = false;
		public Form1()
		{
			InitializeComponent();
			MenuSignUp.Click += new EventHandler(MenuClickTo);
		}
		private void MenuClickTo(object sender, EventArgs e)
		{
			if (!SignUpVisible)
			{
				Form newForm = new SignUp();
				newForm.Show();
				SignUpVisible = true;
			}
		}

		private void Click_Seach(object sender, EventArgs e)
		{

		}

		private void SignInClick(object sender, EventArgs e)
		{
			if (!SignInVisible)
			{
				Form newForm = new SignIn();
				newForm.Show();
				SignInVisible = true;
			}
		}
	}
}
