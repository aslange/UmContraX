namespace UmContraX
{
	partial class Rank
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
			this.lblRank = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblRank
			// 
			this.lblRank.AutoSize = true;
			this.lblRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRank.Location = new System.Drawing.Point(13, 13);
			this.lblRank.Name = "lblRank";
			this.lblRank.Size = new System.Drawing.Size(0, 31);
			this.lblRank.TabIndex = 0;
			// 
			// Rank
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(449, 504);
			this.Controls.Add(this.lblRank);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Rank";
			this.Text = "Rank";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblRank;
	}
}