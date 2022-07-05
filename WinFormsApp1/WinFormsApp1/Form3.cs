using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonogram
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		
		
		

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
			Button btnExit = new Button();
			btnExit.Font = new Font("Hack Nerd Font", 18F);
			btnExit.ForeColor = Color.White;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Text = "Выход";
			btnExit.BackColor = Color.Transparent;
			Controls.Add(btnExit);
			btnExit.Size = new Size(200, 50);
			btnExit.Location = new Point(Width / 2 - btnExit.Width / 2, Height - 80);
			btnExit.Click += BtnExit_Click;
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
