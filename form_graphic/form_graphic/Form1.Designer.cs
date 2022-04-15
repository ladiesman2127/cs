namespace form_graphic
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
			if (disposing && (components != null))
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
			this.buttonToSecondPage = new System.Windows.Forms.Button();
			this.txt1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonToSecondPage
			// 
			this.buttonToSecondPage.Location = new System.Drawing.Point(232, 98);
			this.buttonToSecondPage.Name = "buttonToSecondPage";
			this.buttonToSecondPage.Size = new System.Drawing.Size(75, 23);
			this.buttonToSecondPage.TabIndex = 0;
			this.buttonToSecondPage.Text = "2nd Page";
			this.buttonToSecondPage.UseVisualStyleBackColor = true;
			this.buttonToSecondPage.Click += new System.EventHandler(this.buttonToSecondPage_Click);
			// 
			// txt1
			// 
			this.txt1.Location = new System.Drawing.Point(437, 100);
			this.txt1.Name = "txt1";
			this.txt1.Size = new System.Drawing.Size(100, 20);
			this.txt1.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.IndianRed;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txt1);
			this.Controls.Add(this.buttonToSecondPage);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonToSecondPage;
		private System.Windows.Forms.TextBox txt1;
	}
}

