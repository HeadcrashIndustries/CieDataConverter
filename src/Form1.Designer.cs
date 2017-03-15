namespace CieDataConverter
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
		protected override void Dispose( bool disposing )
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
		private void InitializeComponent( )
		{
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxCie10Obs = new System.Windows.Forms.TextBox();
            this.textBoxCie2Obs = new System.Windows.Forms.TextBox();
            this.textBoxCieD65 = new System.Windows.Forms.TextBox();
            this.textBoxCieA = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 29);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(851, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxCie10Obs);
            this.panel2.Controls.Add(this.textBoxCie2Obs);
            this.panel2.Controls.Add(this.textBoxCieD65);
            this.panel2.Controls.Add(this.textBoxCieA);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(929, 334);
            this.panel2.TabIndex = 2;
            // 
            // textBoxCie10Obs
            // 
            this.textBoxCie10Obs.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCie10Obs.Location = new System.Drawing.Point(702, 0);
            this.textBoxCie10Obs.Multiline = true;
            this.textBoxCie10Obs.Name = "textBoxCie10Obs";
            this.textBoxCie10Obs.Size = new System.Drawing.Size(412, 334);
            this.textBoxCie10Obs.TabIndex = 3;
            // 
            // textBoxCie2Obs
            // 
            this.textBoxCie2Obs.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCie2Obs.Location = new System.Drawing.Point(309, 0);
            this.textBoxCie2Obs.Multiline = true;
            this.textBoxCie2Obs.Name = "textBoxCie2Obs";
            this.textBoxCie2Obs.Size = new System.Drawing.Size(393, 334);
            this.textBoxCie2Obs.TabIndex = 2;
            // 
            // textBoxCieD65
            // 
            this.textBoxCieD65.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCieD65.Location = new System.Drawing.Point(148, 0);
            this.textBoxCieD65.Multiline = true;
            this.textBoxCieD65.Name = "textBoxCieD65";
            this.textBoxCieD65.Size = new System.Drawing.Size(161, 334);
            this.textBoxCieD65.TabIndex = 1;
            // 
            // textBoxCieA
            // 
            this.textBoxCieA.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxCieA.Location = new System.Drawing.Point(0, 0);
            this.textBoxCieA.Multiline = true;
            this.textBoxCieA.Name = "textBoxCieA";
            this.textBoxCieA.Size = new System.Drawing.Size(148, 334);
            this.textBoxCieA.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 1048576;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(929, 96);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 459);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "CIE Data Converter";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox textBoxCie10Obs;
		private System.Windows.Forms.TextBox textBoxCie2Obs;
		private System.Windows.Forms.TextBox textBoxCieD65;
		private System.Windows.Forms.TextBox textBoxCieA;
		private System.Windows.Forms.TextBox textBox1;
	}
}

