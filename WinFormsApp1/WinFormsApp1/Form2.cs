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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			Button btnExit = new Button();
			btnExit.Font = new Font("Hack Nerd Font", 18F);
			btnExit.ForeColor = Color.White;
			btnExit.FlatStyle = FlatStyle.Flat;
			btnExit.Text = "Выход";
			btnExit.BackColor = Color.Transparent;
			Controls.Add(btnExit);
			btnExit.Size = new Size(200, 50);
			btnExit.Location = new Point(Width / 2 - btnExit.Width/2,Height - 80);
			btnExit.Click += BtnExit_Click;
			Button btnAdd = new Button();
			btnAdd.Font = new Font("Hack Nerd Font", 18F);
			btnAdd.ForeColor = Color.White;
			btnAdd.FlatStyle = FlatStyle.Flat;
			btnAdd.Text = "Создать";
			btnAdd.BackColor = Color.Transparent;
			Controls.Add(btnAdd);
			btnAdd.Size = new Size(200, 50);
			btnAdd.Location = new Point(Width / 2 - btnExit.Width / 2, Height - 140);
			btnAdd.Click += BtnAdd_Click;
			Button btnEnter = new Button();
			btnEnter.Font = new Font("Hack Nerd Font", 18F);
			btnEnter.ForeColor = Color.White;
			btnEnter.FlatStyle = FlatStyle.Flat;
			btnEnter.Text = "Играть";
			btnEnter.BackColor = Color.Transparent;
			Controls.Add(btnEnter);
			btnEnter.Size = new Size(200, 50);
			btnEnter.Location = new Point(Width / 2 - btnEnter.Width / 2, Height - 200);
			btnEnter.Click += BtnEnter_Click;
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			int width, height;
			
		}

		private void BtnEnter_Click(object sender, EventArgs e)
		{
			Form1 form = new Form1();
			Hide();
			
			form.ShowDialog();
			form.Dispose();
			this.Dispose();
		}

		private void BtnExit_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
