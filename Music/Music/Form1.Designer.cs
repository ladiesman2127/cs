namespace Music
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows


		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.mainPanel = new System.Windows.Forms.Panel();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnFullScr = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainPanel
			// 
			this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mainPanel.Location = new System.Drawing.Point(-8, 26);
			this.mainPanel.Name = "mainPanel";
			this.mainPanel.Size = new System.Drawing.Size(816, 411);
			this.mainPanel.TabIndex = 3;
			this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
			// 
			// button3
			// 
			this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button3.BackgroundImage = global::Music.Properties.Resources.forward;
			this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(447, 445);
			this.button3.Margin = new System.Windows.Forms.Padding(0);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(40, 40);
			this.button3.TabIndex = 5;
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button2.BackgroundImage = global::Music.Properties.Resources.rewind;
			this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(326, 445);
			this.button2.Margin = new System.Windows.Forms.Padding(0);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(40, 40);
			this.button2.TabIndex = 4;
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.BackgroundImage = global::Music.Properties.Resources.plays;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(378, 440);
			this.button1.Margin = new System.Windows.Forms.Padding(0);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(50, 50);
			this.button1.TabIndex = 0;
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnFullScr);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Location = new System.Drawing.Point(596, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(204, 23);
			this.panel1.TabIndex = 0;
			// 
			// btnClose
			// 
			this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
			this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Location = new System.Drawing.Point(132, 0);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(24, 23);
			this.btnClose.TabIndex = 10;
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// btnFullScr
			// 
			this.btnFullScr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFullScr.BackgroundImage")));
			this.btnFullScr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnFullScr.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnFullScr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFullScr.Location = new System.Drawing.Point(156, 0);
			this.btnFullScr.Name = "btnFullScr";
			this.btnFullScr.Size = new System.Drawing.Size(24, 23);
			this.btnFullScr.TabIndex = 11;
			this.btnFullScr.UseVisualStyleBackColor = true;
			this.btnFullScr.Click += new System.EventHandler(this.btnFullScr_Click_1);
			// 
			// btnCancel
			// 
			this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
			this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Location = new System.Drawing.Point(180, 0);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(24, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CausesValidation = false;
			this.ClientSize = new System.Drawing.Size(800, 500);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.mainPanel);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.TopMost = true;
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel mainPanel;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnFullScr;
		private System.Windows.Forms.Button btnCancel;
	}
}

