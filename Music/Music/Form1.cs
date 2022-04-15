using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Music
{
	public partial class Form1 : Form
	{
		#region Перемещение окна
		const int WM_NCHITTEST = 0x84;
		const int HTCLIENT = 0x1;
		const int HTCAPTION = 0x2;
		protected override void WndProc(ref Message m)
		{
			if(m.Msg == WM_NCHITTEST)
			{
				base.WndProc(ref m);
				if(( int )m.Result == HTCLIENT)
					m.Result = ( IntPtr )HTCAPTION;
				return;
			}
			base.WndProc(ref m);
		}
		#endregion

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender,EventArgs e)
		{
			this.BackColor = Color.FromArgb(215,136,5);
			btnClose.BackColor = this.BackColor;
			btnCancel.BackColor = this.BackColor;
			btnFullScr.BackColor = this.BackColor;
			btnClose.FlatAppearance.BorderSize = 0;
			btnCancel.FlatAppearance.BorderSize = 0;
			btnFullScr.FlatAppearance.BorderSize = 0;
			button1.BackColor = this.BackColor;
			button1.FlatAppearance.BorderSize = 0;
			this.button3.Location = new Point((Width - button1.Width) / 2 + button3.Width + 15,Height- button1.Height - 5);
			this.button2.Location = new Point((Width - button1.Width)/ 2 - button2.Width - 10 , Height - button1.Height - 5);
			this.button1.Location = new Point((Width - button1.Width)/2,Height - button1.Height - 10);
		}

		#region Функционал кнопок
		private void btnFullScr_Click(object sender,EventArgs e)
		{
			if(WindowState == FormWindowState.Maximized)
			{
				WindowState = FormWindowState.Normal;
				btnFullScr.BackgroundImage = Music.Properties.Resources.full;
			}

			else
			{
				WindowState = FormWindowState.Maximized;
				btnFullScr.BackgroundImage = Music.Properties.Resources.exfull;
			}
		}

		private void btnCancel_Click(object sender,EventArgs e)
		{
			this.WindowState=FormWindowState.Minimized;
		}

		private void btnClose_Click(object sender,EventArgs e)
		{
			this.Close();
		}
		#endregion


		#region Закраска кнопок при наведении
		private void btnCancel_MouseEnter(object sender,EventArgs e)
		{
			btnCancel.BackColor = Color.White;
		}

		private void btnCancel_MouseLeave(object sender,EventArgs e)
		{
			btnCancel.BackColor = this.BackColor;
		}
		private void btnFullScr_MouseEnter(object sender,EventArgs e)
		{
			btnFullScr.BackColor = Color.White;
		}

		private void btnFullScr_MouseLeave(object sender,EventArgs e)
		{
			btnFullScr.BackColor = this.BackColor;
		}
		private void btnClose_MouseEnter(object sender,EventArgs e)
		{
			btnClose.BackColor = Color.Red;
		}

		private void btnClose_MouseLeave(object sender,EventArgs e)
		{
			btnClose.BackColor = this.BackColor;
		}


		//private void mainPanel_Paint(object sender,PaintEventArgs e)
		//{
		//	mainPanel.BackColor = Color.FromArgb(5,5,215);
		//}
		#endregion

		private void mainPanel_Paint(object sender,PaintEventArgs e)
		{
			mainPanel.BackColor = Color.FromArgb(0,0,143);
		}


		private void btnFullScr_Click_1(object sender,EventArgs e)
		{

		}

		private void btnCancel_Click_1(object sender,EventArgs e)
		{
			this.Close();
		}
	}
}
