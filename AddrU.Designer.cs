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
			this.pnlAddrInput.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlAddrInput
			// 
			this.pnlAddrInput.Controls.Add(this.btnAddr);
			this.pnlAddrInput.Controls.Add(this.txtInput);
			this.pnlAddrInput.Controls.Add(this.lblAddr);
			this.pnlAddrInput.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlAddrInput.Location = new System.Drawing.Point(0, 0);
			this.pnlAddrInput.Name = "pnlAddrInput";
			this.pnlAddrInput.Size = new System.Drawing.Size(755, 353);
			this.pnlAddrInput.TabIndex = 0;
			// 
			// btnAddr
			// 
			this.btnAddr.Location = new System.Drawing.Point(305, 135);
			this.btnAddr.Name = "btnAddr";
			this.btnAddr.Size = new System.Drawing.Size(75, 23);
			this.btnAddr.TabIndex = 2;
			this.btnAddr.Text = "조회";
			this.btnAddr.UseVisualStyleBackColor = true;
			this.btnAddr.Click += new System.EventHandler(this.button1_Click);
			// 
			// txtInput
			// 
			this.txtInput.Location = new System.Drawing.Point(95, 79);
			this.txtInput.Name = "txtInput";
			this.txtInput.ReadOnly = true;
			this.txtInput.Size = new System.Drawing.Size(504, 21);
			this.txtInput.TabIndex = 1;
			this.txtInput.Click += new System.EventHandler(this.txtInput_Click);
			// 
			// lblAddr
			// 
			this.lblAddr.AutoSize = true;
			this.lblAddr.Location = new System.Drawing.Point(45, 79);
			this.lblAddr.Name = "lblAddr";
			this.lblAddr.Size = new System.Drawing.Size(29, 12);
			this.lblAddr.TabIndex = 0;
			this.lblAddr.Text = "주소";
			// 
			// AddrU
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(755, 353);
			this.Controls.Add(this.pnlAddrInput);
			this.Name = "AddrU";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.pnlAddrInput.ResumeLayout(false);
			this.pnlAddrInput.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddrInput;
        private System.Windows.Forms.Button btnAddr;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblAddr;
    }
}

