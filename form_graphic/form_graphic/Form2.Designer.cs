namespace form_graphic
{
	partial class Form2
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
			this.txt2 = new System.Windows.Forms.TextBox();
			this.buttoToMainPage = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttonFigure = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txt2
			// 
			this.txt2.Location = new System.Drawing.Point(418, 89);
			this.txt2.Name = "txt2";
			this.txt2.Size = new System.Drawing.Size(100, 20);
			this.txt2.TabIndex = 0;
			// 
			// buttoToMainPage
			// 
			this.buttoToMainPage.Location = new System.Drawing.Point(200, 89);
			this.buttoToMainPage.Name = "buttoToMainPage";
			this.buttoToMainPage.Size = new System.Drawing.Size(75, 23);
			this.buttoToMainPage.TabIndex = 1;
			this.buttoToMainPage.Text = "To Main";
			this.buttoToMainPage.UseVisualStyleBackColor = true;
			this.buttoToMainPage.Click += new System.EventHandler(this.buttonToMainPage_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Moccasin;
			this.panel1.Location = new System.Drawing.Point(73, 152);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(653, 272);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
			this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
			// 
			// buttonFigure
			// 
			this.buttonFigure.Location = new System.Drawing.Point(600, 111);
			this.buttonFigure.Name = "buttonFigure";
			this.buttonFigure.Size = new System.Drawing.Size(75, 23);
			this.buttonFigure.TabIndex = 3;
			this.buttonFigure.Text = "Figure";
			this.buttonFigure.UseVisualStyleBackColor = true;
			this.buttonFigure.Click += new System.EventHandler(this.buttonFigure_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightCoral;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonFigure);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.buttoToMainPage);
			this.Controls.Add(this.txt2);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttoToMainPage;
		public System.Windows.Forms.TextBox txt2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonFigure;
	}
}