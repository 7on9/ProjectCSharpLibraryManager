namespace Library_Manager
{
    partial class RouterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouterForm));
            this.imgBook = new System.Windows.Forms.PictureBox();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.imgBorrow = new System.Windows.Forms.PictureBox();
            this.imgData = new System.Windows.Forms.PictureBox();
            this.toolTipBook = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipUser = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipBorrow = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipData = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBook
            // 
            this.imgBook.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBook.Image = ((System.Drawing.Image)(resources.GetObject("imgBook.Image")));
            this.imgBook.Location = new System.Drawing.Point(30, 30);
            this.imgBook.Name = "imgBook";
            this.imgBook.Size = new System.Drawing.Size(180, 180);
            this.imgBook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBook.TabIndex = 0;
            this.imgBook.TabStop = false;
            this.imgBook.Click += new System.EventHandler(this.imgBook_Click);
            // 
            // imgUser
            // 
            this.imgUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(240, 30);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(180, 180);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 1;
            this.imgUser.TabStop = false;
            this.imgUser.Click += new System.EventHandler(this.imgUser_Click);
            // 
            // imgBorrow
            // 
            this.imgBorrow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgBorrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgBorrow.Image = ((System.Drawing.Image)(resources.GetObject("imgBorrow.Image")));
            this.imgBorrow.Location = new System.Drawing.Point(30, 240);
            this.imgBorrow.Name = "imgBorrow";
            this.imgBorrow.Size = new System.Drawing.Size(180, 180);
            this.imgBorrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBorrow.TabIndex = 2;
            this.imgBorrow.TabStop = false;
            this.imgBorrow.Click += new System.EventHandler(this.imgBorrow_Click);
            // 
            // imgData
            // 
            this.imgData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgData.Image = ((System.Drawing.Image)(resources.GetObject("imgData.Image")));
            this.imgData.Location = new System.Drawing.Point(240, 240);
            this.imgData.Name = "imgData";
            this.imgData.Size = new System.Drawing.Size(180, 180);
            this.imgData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgData.TabIndex = 3;
            this.imgData.TabStop = false;
            this.imgData.Click += new System.EventHandler(this.imgData_Click);
            // 
            // toolTipBook
            // 
            this.toolTipBook.AutomaticDelay = 100;
            this.toolTipBook.AutoPopDelay = 10000;
            this.toolTipBook.InitialDelay = 100;
            this.toolTipBook.ReshowDelay = 20;
            // 
            // toolTipUser
            // 
            this.toolTipUser.AutomaticDelay = 100;
            this.toolTipUser.AutoPopDelay = 10000;
            this.toolTipUser.InitialDelay = 100;
            this.toolTipUser.ReshowDelay = 20;
            // 
            // toolTipBorrow
            // 
            this.toolTipBorrow.AutomaticDelay = 100;
            this.toolTipBorrow.AutoPopDelay = 10000;
            this.toolTipBorrow.InitialDelay = 100;
            this.toolTipBorrow.ReshowDelay = 20;
            // 
            // toolTipData
            // 
            this.toolTipData.AutomaticDelay = 100;
            this.toolTipData.AutoPopDelay = 10000;
            this.toolTipData.InitialDelay = 100;
            this.toolTipData.ReshowDelay = 20;
            // 
            // RouterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 453);
            this.Controls.Add(this.imgData);
            this.Controls.Add(this.imgBorrow);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.imgBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RouterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chọn tác vụ";
            this.Load += new System.EventHandler(this.RouterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBorrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgBook;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.PictureBox imgBorrow;
        private System.Windows.Forms.PictureBox imgData;
        private System.Windows.Forms.ToolTip toolTipBook;
        private System.Windows.Forms.ToolTip toolTipUser;
        private System.Windows.Forms.ToolTip toolTipBorrow;
        private System.Windows.Forms.ToolTip toolTipData;
    }
}