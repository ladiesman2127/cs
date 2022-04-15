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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		public int A2 = 5;
		private Graphics _gr;
		Pen _pen = new Pen(Color.PaleVioletRed, 3);
		private void buttonToMainPage_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			txt2.Text = A2.ToString();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private int x, y;
		private void panel1_MouseClick(object sender, MouseEventArgs e)
		{
			x = e.X;
			y = e.Y;
		}

		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			_gr = Graphics.FromHwnd(panel1.Handle);
			if (e.Button == MouseButtons.Left)
			{
				_gr.DrawLine(_pen, x, y, e.X, e.Y);
				x = e.X;
				y = e.Y;

			}
		}

		private void buttonFigure_Click(object sender, EventArgs e)
		{
			_gr = Graphics.FromHwnd(panel1.Handle);
			_gr.DrawEllipse(_pen, x, y, 50, 50);
			_gr.DrawRectangle(_pen, x, y, 100, 200);
			_gr.DrawLine(_pen, x, y, x + 50, x + 20);
			_pen.Dispose();
		}
	}
}
