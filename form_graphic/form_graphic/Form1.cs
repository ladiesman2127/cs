using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_graphic
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonToSecondPage_Click(object sender, EventArgs e)
		{
			Form2 frm = new Form2();
			Hide();
			frm.A2 = 72;
			frm.txt2.Text = txt1.Text;
			frm.ShowDialog();
			txt1.Text = frm.txt2.Text;
			Show();
			frm.Dispose();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}
	}
}
