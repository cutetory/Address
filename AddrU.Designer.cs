namespace Address
{
	partial class AddrU
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.pnlAddrInput = new System.Windows.Forms.Panel();
			this.btnAddr = new System.Windows.Forms.Button();
			this.txtInput = new System.Windows.Forms.TextBox();
			this.lblAddr = new System.Windows.Forms.Label();
			this.pnlGridView = new System.Windows.Forms.Panel();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.pnlAddrOutput = new System.Windows.Forms.Panel();
			this.txtOutput = new System.Windows.Forms.TextBox();
			this.pnlAddrInput.SuspendLayout();
			this.pnlGridView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.pnlAddrOutput.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAddrInput
			// 
			this.pnlAddrInput.Controls.Add(this.btnAddr);
			this.pnlAddrInput.Controls.Add(this.txtInput);
			this.pnlAddrInput.Controls.Add(this.lblAddr);
			this.pnlAddrInput.Location = new System.Drawing.Point(61, 62);
			this.pnlAddrInput.Name = "pnlAddrInput";
			this.pnlAddrInput.Size = new System.Drawing.Size(651, 223);
			this.pnlAddrInput.TabIndex = 0;
			// 
			// btnAddr
			// 
			this.btnAddr.Location = new System.Drawing.Point(511, 182);
			this.btnAddr.Name = "btnAddr";
			this.btnAddr.Size = new System.Drawing.Size(75, 23);
			this.btnAddr.TabIndex = 2;
			this.btnAddr.Text = "조회";
			this.btnAddr.UseVisualStyleBackColor = true;
			this.btnAddr.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(82, 121);
			this.txtInput.Name = "txtInput";
			this.txtInput.ReadOnly = true;
			this.txtInput.Size = new System.Drawing.Size(504, 21);
			this.txtInput.TabIndex = 1;
			// 
			// lblAddr
			// 
			this.lblAddr.AutoSize = true;
			this.lblAddr.Location = new System.Drawing.Point(32, 121);
			this.lblAddr.Name = "lblAddr";
			this.lblAddr.Size = new System.Drawing.Size(29, 12);
			this.lblAddr.TabIndex = 0;
			this.lblAddr.Text = "주소";
			// 
			// pnlGridView
			// 
			this.pnlGridView.Controls.Add(this.dgv);
			this.pnlGridView.Location = new System.Drawing.Point(21, 306);
			this.pnlGridView.Name = "pnlGridView";
			this.pnlGridView.Size = new System.Drawing.Size(717, 278);
			this.pnlGridView.TabIndex = 1;
			// 
			// dgv
			// 
			this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv.BackgroundColor = System.Drawing.Color.White;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Location = new System.Drawing.Point(3, 0);
			this.dgv.Name = "dgv";
			this.dgv.RowTemplate.Height = 23;
			this.dgv.Size = new System.Drawing.Size(711, 275);
			this.dgv.TabIndex = 0;
			// 
			// pnlAddrOutput
			// 
			this.pnlAddrOutput.Controls.Add(this.txtOutput);
			this.pnlAddrOutput.Location = new System.Drawing.Point(747, 62);
			this.pnlAddrOutput.Name = "pnlAddrOutput";
			this.pnlAddrOutput.Size = new System.Drawing.Size(574, 373);
			this.pnlAddrOutput.TabIndex = 2;
			// 
			// txtOutput
			// 
			this.txtOutput.Location = new System.Drawing.Point(4, 4);
			this.txtOutput.Multiline = true;
			this.txtOutput.Name = "txtOutput";
			this.txtOutput.Size = new System.Drawing.Size(567, 366);
			this.txtOutput.TabIndex = 0;
			// 
			// AddrU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1720, 596);
			this.Controls.Add(this.pnlAddrOutput);
			this.Controls.Add(this.pnlGridView);
			this.Controls.Add(this.pnlAddrInput);
			this.Name = "AddrU";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AddrU_Load);
			this.pnlAddrInput.ResumeLayout(false);
			this.pnlAddrInput.PerformLayout();
			this.pnlGridView.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.pnlAddrOutput.ResumeLayout(false);
			this.pnlAddrOutput.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddrInput;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAddr;
        private System.Windows.Forms.Panel pnlGridView;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel pnlAddrOutput;
        private System.Windows.Forms.TextBox txtOutput;
    }
}

