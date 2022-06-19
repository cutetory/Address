namespace Address
{
	partial class AddrShowD
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
			this.btnAddrShowD = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtAddrShowDResult = new System.Windows.Forms.TextBox();
			this.lblShowDResult = new System.Windows.Forms.Label();
			this.btnAddrShowSearch = new System.Windows.Forms.Button();
			this.dgvAddrShowD = new System.Windows.Forms.DataGridView();
			this.lblAddrShowD = new System.Windows.Forms.Label();
			this.txtAddrShowD = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddrShowD)).BeginInit();
			this.SuspendLayout();
			// 
			// btnAddrShowD
			// 
			this.btnAddrShowD.Location = new System.Drawing.Point(652, 369);
			this.btnAddrShowD.Name = "btnAddrShowD";
			this.btnAddrShowD.Size = new System.Drawing.Size(95, 32);
			this.btnAddrShowD.TabIndex = 0;
			this.btnAddrShowD.Text = "확인";
			this.btnAddrShowD.UseVisualStyleBackColor = true;
			this.btnAddrShowD.Click += new System.EventHandler(this.btnAddrShowD_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.txtAddrShowDResult);
			this.panel1.Controls.Add(this.lblShowDResult);
			this.panel1.Controls.Add(this.btnAddrShowSearch);
			this.panel1.Controls.Add(this.dgvAddrShowD);
			this.panel1.Controls.Add(this.lblAddrShowD);
			this.panel1.Controls.Add(this.txtAddrShowD);
			this.panel1.Controls.Add(this.btnAddrShowD);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 426);
			this.panel1.TabIndex = 1;
			// 
			// txtAddrShowDResult
			// 
			this.txtAddrShowDResult.Location = new System.Drawing.Point(78, 375);
			this.txtAddrShowDResult.Name = "txtAddrShowDResult";
			this.txtAddrShowDResult.ReadOnly = true;
			this.txtAddrShowDResult.Size = new System.Drawing.Size(568, 21);
			this.txtAddrShowDResult.TabIndex = 6;
			// 
			// lblShowDResult
			// 
			this.lblShowDResult.AutoSize = true;
			this.lblShowDResult.Location = new System.Drawing.Point(31, 379);
			this.lblShowDResult.Name = "lblShowDResult";
			this.lblShowDResult.Size = new System.Drawing.Size(41, 12);
			this.lblShowDResult.TabIndex = 5;
			this.lblShowDResult.Text = "결과창";
			// 
			// btnAddrShowSearch
			// 
			this.btnAddrShowSearch.Location = new System.Drawing.Point(679, 33);
			this.btnAddrShowSearch.Name = "btnAddrShowSearch";
			this.btnAddrShowSearch.Size = new System.Drawing.Size(75, 23);
			this.btnAddrShowSearch.TabIndex = 4;
			this.btnAddrShowSearch.Text = "검색";
			this.btnAddrShowSearch.UseVisualStyleBackColor = true;
			this.btnAddrShowSearch.Click += new System.EventHandler(this.btnAddrShowSearch_Click);
			// 
			// dgvAddrShowD
			// 
			this.dgvAddrShowD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAddrShowD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAddrShowD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.dgvAddrShowD.Location = new System.Drawing.Point(15, 74);
			this.dgvAddrShowD.MultiSelect = false;
			this.dgvAddrShowD.Name = "dgvAddrShowD";
			this.dgvAddrShowD.ReadOnly = true;
			this.dgvAddrShowD.RowTemplate.Height = 23;
			this.dgvAddrShowD.Size = new System.Drawing.Size(742, 270);
			this.dgvAddrShowD.TabIndex = 3;
			this.dgvAddrShowD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAddrShowD_CellClick);
			// 
			// lblAddrShowD
			// 
			this.lblAddrShowD.AutoSize = true;
			this.lblAddrShowD.Location = new System.Drawing.Point(13, 36);
			this.lblAddrShowD.Name = "lblAddrShowD";
			this.lblAddrShowD.Size = new System.Drawing.Size(41, 12);
			this.lblAddrShowD.TabIndex = 2;
			this.lblAddrShowD.Text = "검색창";
			// 
			// txtAddrShowD
			// 
			this.txtAddrShowD.Location = new System.Drawing.Point(60, 33);
			this.txtAddrShowD.Name = "txtAddrShowD";
			this.txtAddrShowD.Size = new System.Drawing.Size(612, 21);
			this.txtAddrShowD.TabIndex = 1;
			// 
			// AddrShowD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "AddrShowD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddrShowD";
			this.Load += new System.EventHandler(this.AddrShowD_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvAddrShowD)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnAddrShowD;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvAddrShowD;
		private System.Windows.Forms.Label lblAddrShowD;
		private System.Windows.Forms.TextBox txtAddrShowD;
		private System.Windows.Forms.Button btnAddrShowSearch;
		private System.Windows.Forms.TextBox txtAddrShowDResult;
		private System.Windows.Forms.Label lblShowDResult;
	}
}