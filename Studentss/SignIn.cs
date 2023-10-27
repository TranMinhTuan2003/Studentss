using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studentss
{
	public partial class SignIn : Form
	{
		private bool SignUpVisible = false;
		public SignIn()
		{
			InitializeComponent();
			btnSignIn.Click += new EventHandler(SignInClickToSignIn);
//// dịnh dạng email
//			txtEmail.SetMask("[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,64}");
//			txtEmail.MaxLength = 255;
//			txtEmail.Text = "";
//			txtEmail.Text = txtEmail.Text.Trim();
//// Kiểm tra định dạng email
//			if (!IsValidEmail(txtEmail.Text))
//			{
//				MessageBox.Show("Email không hợp lệ", "Lỗi");
//			}
//// Định dạng textbox password
//			txtPassword.PasswordChar = '*';
//			txtPassword.MaxLength = 255;
//// Kiểm tra định dạng password
//			if (!IsValidPassword(txtPassword.Text))
//			{
//				MessageBox.Show("Password không hợp lệ", "Lỗi");
//			}
		}

		private void MenuClickTo(object sender, EventArgs e)
		{

		}

		private void SignUpClick(object sender, EventArgs e)
		{
			if (!SignUpVisible)
			{
				Form newForm = new SignUp();
				newForm.Show();
				SignUpVisible = true;
			}
		}

		private void SignInClickToSignIn(object sender, EventArgs e)
		{
			string text1 = txtEmail.Text;
			string text2 = txtPassword.Text;
			// Nếu có textbox nào để trống, hãy hiển thị thông báo lỗi
			if (string.IsNullOrEmpty(text1) || string.IsNullOrEmpty(text2))
			{
				MessageBox.Show("Vui lòng nhập thông tin vào tất cả các textbox", "Lỗi");
				return;
			}
			else if (!string.IsNullOrEmpty(text1) && !string.IsNullOrEmpty(text2))
			{
				MessageBox.Show("bạn muốn lưu thông tinđăng nhập chứ");
			}
		}
	}
}
