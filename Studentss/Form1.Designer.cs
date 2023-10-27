namespace Studentss
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSignIn = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuSignUp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuTraCD = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuLopMH = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuQLHB = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuNhapDiem = new System.Windows.Forms.ToolStripMenuItem();
			this.MenuDuLieu = new System.Windows.Forms.ToolStripMenuItem();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.pictbSeach = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictbSeach)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Cornsilk;
			this.menuStrip1.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.MenuTraCD,
            this.MenuLopHoc,
            this.MenuLopMH,
            this.MenuQLHB,
            this.MenuNhapDiem,
            this.MenuDuLieu});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1139, 34);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSignIn,
            this.MenuSignUp});
			this.toolStripMenuItem1.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(100, 30);
			this.toolStripMenuItem1.Text = "Tài khoản";
			// 
			// MenuSignIn
			// 
			this.MenuSignIn.Name = "MenuSignIn";
			this.MenuSignIn.Size = new System.Drawing.Size(224, 30);
			this.MenuSignIn.Text = "Đăng nhập";
			this.MenuSignIn.Click += new System.EventHandler(this.SignInClick);
			// 
			// MenuSignUp
			// 
			this.MenuSignUp.Name = "MenuSignUp";
			this.MenuSignUp.Size = new System.Drawing.Size(224, 30);
			this.MenuSignUp.Text = "Đăng kí";
			this.MenuSignUp.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(30, 30);
			this.toolStripMenuItem2.Text = " ";
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(30, 30);
			this.toolStripMenuItem3.Text = " ";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(30, 30);
			this.toolStripMenuItem4.Text = " ";
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(30, 30);
			this.toolStripMenuItem5.Text = " ";
			// 
			// MenuTraCD
			// 
			this.MenuTraCD.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuTraCD.Name = "MenuTraCD";
			this.MenuTraCD.Size = new System.Drawing.Size(127, 30);
			this.MenuTraCD.Text = "Tra cứu điểm";
			this.MenuTraCD.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// MenuLopHoc
			// 
			this.MenuLopHoc.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuLopHoc.Name = "MenuLopHoc";
			this.MenuLopHoc.Size = new System.Drawing.Size(86, 30);
			this.MenuLopHoc.Text = "Lớp học";
			this.MenuLopHoc.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// MenuLopMH
			// 
			this.MenuLopMH.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuLopMH.Name = "MenuLopMH";
			this.MenuLopMH.Size = new System.Drawing.Size(123, 30);
			this.MenuLopMH.Text = "Lớp môn học";
			this.MenuLopMH.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// MenuQLHB
			// 
			this.MenuQLHB.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuQLHB.Name = "MenuQLHB";
			this.MenuQLHB.Size = new System.Drawing.Size(152, 30);
			this.MenuQLHB.Text = "Quản lí học bổng";
			this.MenuQLHB.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// MenuNhapDiem
			// 
			this.MenuNhapDiem.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuNhapDiem.Name = "MenuNhapDiem";
			this.MenuNhapDiem.Size = new System.Drawing.Size(111, 30);
			this.MenuNhapDiem.Text = "Nhập điểm ";
			this.MenuNhapDiem.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// MenuDuLieu
			// 
			this.MenuDuLieu.BackColor = System.Drawing.Color.Cornsilk;
			this.MenuDuLieu.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.MenuDuLieu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.MenuDuLieu.Name = "MenuDuLieu";
			this.MenuDuLieu.Size = new System.Drawing.Size(82, 30);
			this.MenuDuLieu.Text = "Dữ liệu";
			this.MenuDuLieu.Click += new System.EventHandler(this.MenuClickTo);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Sitka Display", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.textBox1.Location = new System.Drawing.Point(719, 62);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(345, 30);
			this.textBox1.TabIndex = 1;
			// 
			// pictbSeach
			// 
			this.pictbSeach.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictbSeach.ErrorImage")));
			this.pictbSeach.Image = ((System.Drawing.Image)(resources.GetObject("pictbSeach.Image")));
			this.pictbSeach.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictbSeach.InitialImage")));
			this.pictbSeach.Location = new System.Drawing.Point(682, 62);
			this.pictbSeach.Name = "pictbSeach";
			this.pictbSeach.Size = new System.Drawing.Size(31, 30);
			this.pictbSeach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictbSeach.TabIndex = 3;
			this.pictbSeach.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1139, 610);
			this.Controls.Add(this.pictbSeach);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Click += new System.EventHandler(this.Click_Seach);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictbSeach)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem MenuTraCD;
		private System.Windows.Forms.ToolStripMenuItem MenuLopHoc;
		private System.Windows.Forms.ToolStripMenuItem MenuLopMH;
		private System.Windows.Forms.ToolStripMenuItem MenuQLHB;
		private System.Windows.Forms.ToolStripMenuItem MenuNhapDiem;
		private System.Windows.Forms.ToolStripMenuItem MenuDuLieu;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ToolStripMenuItem MenuSignIn;
		private System.Windows.Forms.ToolStripMenuItem MenuSignUp;
		private System.Windows.Forms.PictureBox pictbSeach;
	}
}

