namespace IPSMART_CLOTHPOS
{
    partial class FrmLogin
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
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbLocation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFinyr = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tranToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashMemoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stbUid = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbCompnm = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.stbFinyr = new System.Windows.Forms.ToolStripStatusLabel();
            this.GroupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(79)))), ((int)(((byte)(100)))));
            this.GroupBoxLogin.Controls.Add(this.label7);
            this.GroupBoxLogin.Controls.Add(this.label4);
            this.GroupBoxLogin.Controls.Add(this.pictureBox1);
            this.GroupBoxLogin.Controls.Add(this.txtPassword);
            this.GroupBoxLogin.Controls.Add(this.cmbCompany);
            this.GroupBoxLogin.Controls.Add(this.cmbLocation);
            this.GroupBoxLogin.Controls.Add(this.label6);
            this.GroupBoxLogin.Controls.Add(this.label5);
            this.GroupBoxLogin.Controls.Add(this.label3);
            this.GroupBoxLogin.Controls.Add(this.txtUserId);
            this.GroupBoxLogin.Controls.Add(this.label2);
            this.GroupBoxLogin.Controls.Add(this.label1);
            this.GroupBoxLogin.Controls.Add(this.cmbFinyr);
            this.GroupBoxLogin.Controls.Add(this.btnLogin);
            this.GroupBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBoxLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBoxLogin.Location = new System.Drawing.Point(76, 82);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(896, 372);
            this.GroupBoxLogin.TabIndex = 0;
            this.GroupBoxLogin.TabStop = false;
            this.GroupBoxLogin.Text = "Login Section";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::IPSMART_CLOTHPOS.Properties.Resources.IpsmartLogo;
            this.pictureBox1.Location = new System.Drawing.Point(37, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 165);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(460, 86);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(392, 30);
            this.txtPassword.TabIndex = 11;
            // 
            // cmbCompany
            // 
            this.cmbCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(460, 134);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(392, 30);
            this.cmbCompany.TabIndex = 10;
            this.cmbCompany.SelectedIndexChanged += new System.EventHandler(this.cmbCompany_SelectedIndexChanged);
            // 
            // cmbLocation
            // 
            this.cmbLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLocation.FormattingEnabled = true;
            this.cmbLocation.Location = new System.Drawing.Point(460, 182);
            this.cmbLocation.Name = "cmbLocation";
            this.cmbLocation.Size = new System.Drawing.Size(392, 30);
            this.cmbLocation.TabIndex = 9;
            this.cmbLocation.SelectedIndexChanged += new System.EventHandler(this.cmbLocation_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(296, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(296, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fin Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Company:";
            // 
            // txtUserId
            // 
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserId.Location = new System.Drawing.Point(460, 40);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(392, 30);
            this.txtUserId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(296, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "User Id:";
            // 
            // cmbFinyr
            // 
            this.cmbFinyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFinyr.FormattingEnabled = true;
            this.cmbFinyr.Location = new System.Drawing.Point(460, 231);
            this.cmbFinyr.Name = "cmbFinyr";
            this.cmbFinyr.Size = new System.Drawing.Size(392, 30);
            this.cmbFinyr.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(79)))), ((int)(((byte)(150)))));
            this.btnLogin.Location = new System.Drawing.Point(460, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(392, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tranToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stbUid,
            this.stbCompnm,
            this.stbLocation,
            this.stbFinyr});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1099, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pos Sales";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Welcome to Ip-smart";
            // 
            // tranToolStripMenuItem
            // 
            this.tranToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cashMemoToolStripMenuItem});
            this.tranToolStripMenuItem.Name = "tranToolStripMenuItem";
            this.tranToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.tranToolStripMenuItem.Text = "Transaction";
            // 
            // cashMemoToolStripMenuItem
            // 
            this.cashMemoToolStripMenuItem.Name = "cashMemoToolStripMenuItem";
            this.cashMemoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.cashMemoToolStripMenuItem.Text = "Cash Memo";
            // 
            // stbUid
            // 
            this.stbUid.BackColor = System.Drawing.Color.Transparent;
            this.stbUid.Name = "stbUid";
            this.stbUid.Size = new System.Drawing.Size(151, 20);
            this.stbUid.Text = "toolStripStatusLabel1";
            // 
            // stbCompnm
            // 
            this.stbCompnm.BackColor = System.Drawing.Color.Transparent;
            this.stbCompnm.Name = "stbCompnm";
            this.stbCompnm.Size = new System.Drawing.Size(151, 20);
            this.stbCompnm.Text = "toolStripStatusLabel1";
            // 
            // stbLocation
            // 
            this.stbLocation.BackColor = System.Drawing.Color.Transparent;
            this.stbLocation.Name = "stbLocation";
            this.stbLocation.Size = new System.Drawing.Size(151, 20);
            this.stbLocation.Text = "toolStripStatusLabel1";
            // 
            // stbFinyr
            // 
            this.stbFinyr.BackColor = System.Drawing.Color.Transparent;
            this.stbFinyr.Name = "stbFinyr";
            this.stbFinyr.Size = new System.Drawing.Size(151, 20);
            this.stbFinyr.Text = "toolStripStatusLabel1";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(79)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(1099, 681);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.GroupBoxLogin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbLocation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFinyr;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem tranToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashMemoToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel stbUid;
        private System.Windows.Forms.ToolStripStatusLabel stbCompnm;
        private System.Windows.Forms.ToolStripStatusLabel stbLocation;
        private System.Windows.Forms.ToolStripStatusLabel stbFinyr;
    }
}

