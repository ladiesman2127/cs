using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nonogram
{
	internal class Nonogram
	{
		private readonly int _Width;
		private readonly int _OverallHeight;
		private readonly int _OverallWidth;
		private readonly int _topIndicesLegth;
		private readonly Button addButton;
		private readonly int _leftIndicesLenght;
		private PictureBox pictureBox;
		private Label label;
		private readonly List<List<PictureBox>> _pBoxes = new List<List<PictureBox>>();
		private readonly List<List<Label>> _labels = new List<List<Label>>();
		private readonly List<int> SingleNonogramList;
		private readonly List<List<int>> _allNonograms = new List<List<int>>();
		private readonly Panel _mainPanel = new Panel();
		private readonly Form1 _gameForm = new Form1();


		public Nonogram(int Width, int Height)
		{
			addButton = new Button();
			addButton.Size = new Size(50, 50);
			SingleNonogramList = new List<int>();
			addButton.BackgroundImage = Properties.Resources.Add;
			addButton.Click += AddButton_Click;
			_mainPanel.Controls.Add(addButton);
			addButton.BackgroundImageLayout = ImageLayout.Zoom;
			_Width = Width;
			_gameForm.Controls.Add(_mainPanel);
			_topIndicesLegth = Height / 2;
			_leftIndicesLenght = Width / 2;
			if (Height % 2 != 0)
				_topIndicesLegth++;
			if (Width % 2 != 0)
				_leftIndicesLenght++;
			_OverallHeight = Height + _topIndicesLegth;
			_OverallWidth = Width + _leftIndicesLenght;
			_mainPanel.Location = new Point(20, 20);
			_gameForm.Size = new Size(38 * _OverallWidth + 60, 38 * _OverallHeight + 80);
			_gameForm.StartPosition = FormStartPosition.CenterScreen;
			SingleNonogramList.Add(Width);
			SingleNonogramList.Add(Height);
			SingleNonogramList.Add(_leftIndicesLenght);
			SingleNonogramList.Add(_topIndicesLegth);
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			addNonogram();
		}

		public void MakeGameFields()
		{
			int x = 0, y = 0;
			_mainPanel.Size = new Size(38 * _OverallWidth, 38 * _OverallHeight);
			for (int i = 0; i < _OverallHeight; i++)
			{
				List<PictureBox> linePictureBoxes = new List<PictureBox>();
				List<Label> lineLabels = new List<Label>();
				for (int j = 0; j < _OverallWidth; j++)
				{
					if (i < _topIndicesLegth ^ j < _leftIndicesLenght)
					{
						label = new Label();
						_mainPanel.Controls.Add(label);
						label.Size = new Size(38, 38);
						label.BorderStyle = BorderStyle.FixedSingle;
						label.Location = new Point(x, y);
						label.BackColor = Color.Linen;
						lineLabels.Add(label);
					}
					else if (i >= _topIndicesLegth && j >= _leftIndicesLenght)
					{
						pictureBox = new PictureBox
						{
							BackgroundImageLayout = ImageLayout.Zoom
						};
						pictureBox.Size = new Size(38, 38);
						pictureBox.BorderStyle = BorderStyle.FixedSingle;
						pictureBox.Location = new Point(x, y);
						pictureBox.BackColor = Color.GhostWhite;
						pictureBox.MouseClick += PictureBox_MouseClick;
						pictureBox.MouseDoubleClick += PictureBox_MouseDoubleClick;
						_mainPanel.Controls.Add(pictureBox);
						linePictureBoxes.Add(pictureBox);
					}
					x += 38;
				}
				x = 0;
				y += 38;
				_pBoxes.Add(linePictureBoxes);
				_labels.Add(lineLabels);
			}
		}

		private void FillIndices()
		{
			int horizontalK,
				verticalK,
				LeftIndicesIndex,
				TopIndicesIndex;
			for (int i = _OverallHeight - 1; i >= _topIndicesLegth; i--)
			{
				LeftIndicesIndex = _leftIndicesLenght - 1;
				horizontalK = 0;
				for (int j = _Width - 1; j >= 0; j--)
				{
					if (_pBoxes[i][j].BackColor == Color.Black)
					{
						horizontalK++;
						SingleNonogramList.Add(1);
					}

					if (_pBoxes[i][j].BackColor != Color.Black && horizontalK != 0)
					{
						SingleNonogramList.Add(0);
						_labels[i][LeftIndicesIndex--].Text = horizontalK.ToString();
						SingleNonogramList.Add(horizontalK);
						horizontalK = 0;
					}
				}
			}


			for (int i = _Width - 1; i >= 0; i--)
			{
				verticalK = 0;
				TopIndicesIndex = _topIndicesLegth - 1;
				for (int j = _OverallHeight - 1; j >= _topIndicesLegth; j--)
				{
					if (_pBoxes[j][i].BackColor == Color.Black)
					{
						verticalK++;
						SingleNonogramList.Add(1);
					}

					if (verticalK != 0 && _pBoxes[j][i].BackColor != Color.Black)
					{
						SingleNonogramList.Add(0);
						_labels[TopIndicesIndex--][i].Text = verticalK.ToString();
						SingleNonogramList.Add(verticalK);
						verticalK = 0;
					}
				}
			}
			_allNonograms.Add(SingleNonogramList);
		}

		public void addNonogram()
		{
			FillIndices();

		}

		private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			if (e.Button == MouseButtons.Left)
			{
				pictureBox.BackgroundImage = Properties.Resources.Not;
				pictureBox.BackColor = Color.WhiteSmoke;
			}
		}

		private void PictureBox_MouseClick(object sender, MouseEventArgs e)
		{
			PictureBox pictureBox = sender as PictureBox;
			if (e.Button == MouseButtons.Left)
			{
				pictureBox.BackgroundImage = null;
				pictureBox.BackColor = Color.Black;
			}
			else if (e.Button == MouseButtons.Right)
			{
				pictureBox.BackgroundImage = Properties.Resources.Not;
				pictureBox.BackColor = Color.WhiteSmoke;
			}

		}
	}
}
