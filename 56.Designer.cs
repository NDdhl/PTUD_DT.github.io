namespace _56_28
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
			this.label1 = new System.Windows.Forms.Label();
			this.rbNu = new System.Windows.Forms.RadioButton();
			this.rbNam = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(43, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "Giới Tính:";
			// 
			// rbNu
			// 
			this.rbNu.AutoSize = true;
			this.rbNu.Location = new System.Drawing.Point(46, 95);
			this.rbNu.Name = "rbNu";
			this.rbNu.Size = new System.Drawing.Size(45, 20);
			this.rbNu.TabIndex = 1;
			this.rbNu.TabStop = true;
			this.rbNu.Text = "Nữ";
			this.rbNu.UseVisualStyleBackColor = true;
			this.rbNu.CheckedChanged += new System.EventHandler(this.rbNu_CheckedChanged);
			// 
			// rbNam
			// 
			this.rbNam.AutoSize = true;
			this.rbNam.Location = new System.Drawing.Point(46, 121);
			this.rbNam.Name = "rbNam";
			this.rbNam.Size = new System.Drawing.Size(57, 20);
			this.rbNam.TabIndex = 2;
			this.rbNam.TabStop = true;
			this.rbNam.Text = "Nam";
			this.rbNam.UseVisualStyleBackColor = true;
			this.rbNam.CheckedChanged += new System.EventHandler(this.rbNam_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.rbNam);
			this.Controls.Add(this.rbNu);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbNu;
		private System.Windows.Forms.RadioButton rbNam;
	}
}

