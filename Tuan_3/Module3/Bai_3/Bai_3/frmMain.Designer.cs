namespace Bai_3
{
    partial class frmMain
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
            this.lblBanKinh = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.txtBanKinh = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnTiep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBanKinh
            // 
            this.lblBanKinh.AutoSize = true;
            this.lblBanKinh.Location = new System.Drawing.Point(52, 43);
            this.lblBanKinh.Name = "lblBanKinh";
            this.lblBanKinh.Size = new System.Drawing.Size(52, 13);
            this.lblBanKinh.TabIndex = 0;
            this.lblBanKinh.Text = "Bán Kính";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(52, 76);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(38, 13);
            this.lblChuVi.TabIndex = 1;
            this.lblChuVi.Text = "Chu Vi";
            // 
            // txtBanKinh
            // 
            this.txtBanKinh.Location = new System.Drawing.Point(118, 40);
            this.txtBanKinh.Name = "txtBanKinh";
            this.txtBanKinh.Size = new System.Drawing.Size(244, 20);
            this.txtBanKinh.TabIndex = 2;
            this.txtBanKinh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBanKinh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBanKinh_KeyPress);
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(118, 73);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.ReadOnly = true;
            this.txtChuVi.Size = new System.Drawing.Size(244, 20);
            this.txtChuVi.TabIndex = 3;
            this.txtChuVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(55, 125);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(75, 23);
            this.btnTinh.TabIndex = 4;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnTiep
            // 
            this.btnTiep.Location = new System.Drawing.Point(168, 125);
            this.btnTiep.Name = "btnTiep";
            this.btnTiep.Size = new System.Drawing.Size(75, 23);
            this.btnTiep.TabIndex = 5;
            this.btnTiep.Text = "Tiếp";
            this.btnTiep.UseVisualStyleBackColor = true;
            this.btnTiep.Click += new System.EventHandler(this.btnTiep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(287, 125);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnTinh;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTiep);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtBanKinh);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblBanKinh);
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình tính chu vi hình tròn";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBanKinh;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.TextBox txtBanKinh;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnTiep;
        private System.Windows.Forms.Button btnThoat;
    }
}

