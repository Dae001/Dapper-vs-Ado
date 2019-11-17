namespace Dapper_vs_Ado
{
    partial class frmCustomer
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
            this.btnAdo = new System.Windows.Forms.Button();
            this.btnDapper = new System.Windows.Forms.Button();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdo
            // 
            this.btnAdo.Location = new System.Drawing.Point(220, 529);
            this.btnAdo.Name = "btnAdo";
            this.btnAdo.Size = new System.Drawing.Size(83, 29);
            this.btnAdo.TabIndex = 0;
            this.btnAdo.Text = "ADO Load";
            this.btnAdo.UseVisualStyleBackColor = true;
            this.btnAdo.Click += new System.EventHandler(this.btnAdo_Click);
            // 
            // btnDapper
            // 
            this.btnDapper.Location = new System.Drawing.Point(478, 529);
            this.btnDapper.Name = "btnDapper";
            this.btnDapper.Size = new System.Drawing.Size(83, 29);
            this.btnDapper.TabIndex = 1;
            this.btnDapper.Text = "Dapper Load";
            this.btnDapper.UseVisualStyleBackColor = true;
            this.btnDapper.Click += new System.EventHandler(this.btnDapper_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(2, 3);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 26;
            this.dgvCustomer.Size = new System.Drawing.Size(1015, 504);
            this.dgvCustomer.TabIndex = 2;
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 570);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnDapper);
            this.Controls.Add(this.btnAdo);
            this.Name = "frmCustomer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdo;
        private System.Windows.Forms.Button btnDapper;
        private System.Windows.Forms.DataGridView dgvCustomer;
    }
}

