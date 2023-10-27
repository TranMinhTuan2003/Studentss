using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentss
{
	public partial class SignUp : Form
	{
		private bool SignInVisible = false;
		private bool SignUpVisible = false;
		public SignUp()
		{
			InitializeComponent();
			btnSignUp.Click += new EventHandler(btnSignUpClick);
			labelSignIn.Click += new EventHandler(SignInClick);
		}

		private void btnSignUpClick(object sender, EventArgs e)
		{
			// đang ki xong di toi trnag dang nhap
			if (!SignUpVisible)
			{
				Form newForm = new SignIn();
				newForm.Show();
				SignUpVisible = true;
			}

			String text = txtEmail.Text;
			String text1 = txtName.Text;
			String text2 = txtPassword.Text;
			string text3 = txtRePasword.Text;

// Nếu có textbox nào để trống, hãy hiển thị thông báo lỗi
			
			if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2)||string.IsNullOrEmpty(text) || string.IsNullOrEmpty(text3))
			{
				MessageBox.Show("Vui lòng nhập thông tin vào tất cả các textbox", "Lỗi");
				return;
			}
			string password = txtPassword.Text;
			string confirmPassword = txtRePasword.Text;
			confirmPassword = confirmPassword.Trim();
			int result = password.CompareTo(confirmPassword);
			if (result != 0)
			{
				MessageBox.Show("Mật khẩu không khớp", "Lỗi");
			}
			else if(!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(text) && string.IsNullOrEmpty(text3))
			{
				MessageBox.Show("Name : " + text1 + "\n" + "Email : " + text + "\n" + "tài khoản của bạn đang kí thành công");
			}
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
