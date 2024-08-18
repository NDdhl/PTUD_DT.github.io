namespace _52_26
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
			this.lbDanhsach = new System.Windows.Forms.ListBox();
			this.lbDanhsachchon = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbDanhsach
			// 
			this.lbDanhsach.FormattingEnabled = true;
			this.lbDanhsach.ItemHeight = 16;
			this.lbDanhsach.Location = new System.Drawing.Point(34, 117);
			this.lbDanhsach.Name = "lbDanhsach";
			this.lbDanhsach.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lbDanhsach.Size = new System.Drawing.Size(238, 228);
			this.lbDanhsach.TabIndex = 0;
			// 
			// lbDanhsachchon
			// 
			this.lbDanhsachchon.FormattingEnabled = true;
			this.lbDanhsachchon.ItemHeight = 16;
			this.lbDanhsachchon.Location = new System.Drawing.Point(380, 117);
			this.lbDanhsachchon.Name = "lbDanhsachchon";
			this.lbDanhsachchon.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lbDanhsachchon.Size = new System.Drawing.Size(238, 228);
			this.lbDanhsachchon.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(31, 98);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(126, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Danh sách sv lớp";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(377, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(222, 16);
			this.label2.TabIndex = 3;
			this.label2.Text = "danh sách sv tham gia bóng đá";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(294, 172);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 32);
			this.button1.TabIndex = 4;
			this.button1.Text = "Chọn";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(294, 220);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 32);
			this.button2.TabIndex = 5;
			this.button2.Text = "Xóa";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lbDanhsachchon);
			this.Controls.Add(this.lbDanhsach);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbDanhsach;
		private System.Windows.Forms.ListBox lbDanhsachchon;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}

