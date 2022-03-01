/*
 * Created by SharpDevelop.
 * User: acer
 * Date: 01/03/2022
 * Time: 19:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tugas2
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.Tambahbtn = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(306, 76);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input Jersey";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(172, 102);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(360, 22);
			this.textBox1.TabIndex = 1;
			// 
			// Tambahbtn
			// 
			this.Tambahbtn.Location = new System.Drawing.Point(569, 101);
			this.Tambahbtn.Name = "Tambahbtn";
			this.Tambahbtn.Size = new System.Drawing.Size(75, 23);
			this.Tambahbtn.TabIndex = 2;
			this.Tambahbtn.Text = "Tambah";
			this.Tambahbtn.UseVisualStyleBackColor = true;
			this.Tambahbtn.Click += new System.EventHandler(this.TambahbtnClick);
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 16;
			this.listBox1.Location = new System.Drawing.Point(172, 204);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(360, 180);
			this.listBox1.TabIndex = 3;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 452);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.Tambahbtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Tugas2";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button Tambahbtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
