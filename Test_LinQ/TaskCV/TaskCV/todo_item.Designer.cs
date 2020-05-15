namespace TaskCV
{
    partial class todo_item
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(todo_item));
            this.ckbTodoItem = new Bunifu.Framework.UI.BunifuCheckbox();
            this.lblTodoItem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.btnDelTodoItem = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelTodoItem)).BeginInit();
            this.SuspendLayout();
            // 
            // ckbTodoItem
            // 
            this.ckbTodoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbTodoItem.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ckbTodoItem.Checked = false;
            this.ckbTodoItem.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ckbTodoItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ckbTodoItem.ForeColor = System.Drawing.Color.White;
            this.ckbTodoItem.Location = new System.Drawing.Point(21, 18);
            this.ckbTodoItem.Name = "ckbTodoItem";
            this.ckbTodoItem.Size = new System.Drawing.Size(20, 20);
            this.ckbTodoItem.TabIndex = 0;
            this.ckbTodoItem.OnChange += new System.EventHandler(this.ckbTodoItem_OnChange);
            // 
            // lblTodoItem
            // 
            this.lblTodoItem.AutoSize = true;
            this.lblTodoItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodoItem.ForeColor = System.Drawing.Color.Black;
            this.lblTodoItem.Location = new System.Drawing.Point(61, 13);
            this.lblTodoItem.Name = "lblTodoItem";
            this.lblTodoItem.Size = new System.Drawing.Size(100, 25);
            this.lblTodoItem.TabIndex = 1;
            this.lblTodoItem.Text = "To do Item";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // btnDelTodoItem
            // 
            this.btnDelTodoItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelTodoItem.Image = ((System.Drawing.Image)(resources.GetObject("btnDelTodoItem.Image")));
            this.btnDelTodoItem.ImageActive = null;
            this.btnDelTodoItem.Location = new System.Drawing.Point(356, 3);
            this.btnDelTodoItem.Name = "btnDelTodoItem";
            this.btnDelTodoItem.Size = new System.Drawing.Size(52, 48);
            this.btnDelTodoItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnDelTodoItem.TabIndex = 2;
            this.btnDelTodoItem.TabStop = false;
            this.btnDelTodoItem.Zoom = 10;
            this.btnDelTodoItem.Click += new System.EventHandler(this.btnDelTodoItem_Click);
            // 
            // todo_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.btnDelTodoItem);
            this.Controls.Add(this.lblTodoItem);
            this.Controls.Add(this.ckbTodoItem);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "todo_item";
            this.Size = new System.Drawing.Size(410, 54);
            this.Load += new System.EventHandler(this.todo_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnDelTodoItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox ckbTodoItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTodoItem;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton btnDelTodoItem;
    }
}
