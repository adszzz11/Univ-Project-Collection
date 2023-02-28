namespace Project.Cfinal
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.주문하기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goOrderForm = new System.Windows.Forms.ToolStripMenuItem();
            this.goCashForm = new System.Windows.Forms.ToolStripMenuItem();
            this.goLoginForm = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.UserMainView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.goUserProfile = new System.Windows.Forms.Button();
            this.moneytext = new System.Windows.Forms.TextBox();
            this.lastmoneylabel = new System.Windows.Forms.Label();
            this.nametext = new System.Windows.Forms.TextBox();
            this.namelabel = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.주문하기ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 29);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 주문하기ToolStripMenuItem
            // 
            this.주문하기ToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.주문하기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goOrderForm,
            this.goCashForm,
            this.goLoginForm});
            this.주문하기ToolStripMenuItem.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.주문하기ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.주문하기ToolStripMenuItem.Name = "주문하기ToolStripMenuItem";
            this.주문하기ToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.주문하기ToolStripMenuItem.Text = "Menu";
            // 
            // goOrderForm
            // 
            this.goOrderForm.BackColor = System.Drawing.Color.Peru;
            this.goOrderForm.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goOrderForm.ForeColor = System.Drawing.Color.White;
            this.goOrderForm.Name = "goOrderForm";
            this.goOrderForm.Size = new System.Drawing.Size(159, 26);
            this.goOrderForm.Text = "주문하기";
            this.goOrderForm.Click += new System.EventHandler(this.goOrderForm_Click);
            // 
            // goCashForm
            // 
            this.goCashForm.BackColor = System.Drawing.Color.Peru;
            this.goCashForm.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goCashForm.ForeColor = System.Drawing.Color.White;
            this.goCashForm.Name = "goCashForm";
            this.goCashForm.Size = new System.Drawing.Size(159, 26);
            this.goCashForm.Text = "잔액 충전";
            this.goCashForm.Click += new System.EventHandler(this.goCashForm_Click);
            // 
            // goLoginForm
            // 
            this.goLoginForm.BackColor = System.Drawing.Color.Peru;
            this.goLoginForm.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goLoginForm.ForeColor = System.Drawing.Color.White;
            this.goLoginForm.Name = "goLoginForm";
            this.goLoginForm.Size = new System.Drawing.Size(159, 26);
            this.goLoginForm.Text = "로그아웃";
            this.goLoginForm.Click += new System.EventHandler(this.goLoginForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("한컴산뜻돋움", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(392, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 27);
            this.label1.TabIndex = 25;
            this.label1.Text = "주문 정보";
            // 
            // UserMainView
            // 
            this.UserMainView.AllowUserToAddRows = false;
            this.UserMainView.AllowUserToDeleteRows = false;
            this.UserMainView.BackgroundColor = System.Drawing.Color.Bisque;
            this.UserMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserMainView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.UserMainView.Location = new System.Drawing.Point(121, 93);
            this.UserMainView.Name = "UserMainView";
            this.UserMainView.ReadOnly = true;
            this.UserMainView.RowHeadersVisible = false;
            this.UserMainView.RowTemplate.Height = 23;
            this.UserMainView.Size = new System.Drawing.Size(660, 273);
            this.UserMainView.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-9, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(820, 29);
            this.label4.TabIndex = 27;
            // 
            // goUserProfile
            // 
            this.goUserProfile.BackColor = System.Drawing.Color.Peru;
            this.goUserProfile.FlatAppearance.BorderSize = 0;
            this.goUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goUserProfile.ForeColor = System.Drawing.Color.White;
            this.goUserProfile.Location = new System.Drawing.Point(12, 405);
            this.goUserProfile.Name = "goUserProfile";
            this.goUserProfile.Size = new System.Drawing.Size(100, 25);
            this.goUserProfile.TabIndex = 14;
            this.goUserProfile.Text = "회원정보 수정";
            this.goUserProfile.UseVisualStyleBackColor = false;
            this.goUserProfile.Click += new System.EventHandler(this.goUserProfile_Click_1);
            // 
            // moneytext
            // 
            this.moneytext.BackColor = System.Drawing.Color.Moccasin;
            this.moneytext.Location = new System.Drawing.Point(692, 32);
            this.moneytext.Name = "moneytext";
            this.moneytext.ReadOnly = true;
            this.moneytext.Size = new System.Drawing.Size(100, 23);
            this.moneytext.TabIndex = 6;
            // 
            // lastmoneylabel
            // 
            this.lastmoneylabel.AutoSize = true;
            this.lastmoneylabel.Location = new System.Drawing.Point(656, 35);
            this.lastmoneylabel.Name = "lastmoneylabel";
            this.lastmoneylabel.Size = new System.Drawing.Size(30, 16);
            this.lastmoneylabel.TabIndex = 5;
            this.lastmoneylabel.Text = "잔액";
            // 
            // nametext
            // 
            this.nametext.BackColor = System.Drawing.Color.Wheat;
            this.nametext.Location = new System.Drawing.Point(12, 376);
            this.nametext.Name = "nametext";
            this.nametext.ReadOnly = true;
            this.nametext.Size = new System.Drawing.Size(100, 23);
            this.nametext.TabIndex = 6;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(118, 379);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(41, 16);
            this.namelabel.TabIndex = 1;
            this.namelabel.Text = "접속중";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "예약시간";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "메뉴";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "세부사항";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "예약자";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "예약접수";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 78;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "완성";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 60;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.moneytext);
            this.Controls.Add(this.lastmoneylabel);
            this.Controls.Add(this.nametext);
            this.Controls.Add(this.goUserProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.UserMainView);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "MainForm";
            this.Text = "MainForm1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserMainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 주문하기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goOrderForm;
        private System.Windows.Forms.ToolStripMenuItem goCashForm;
        private System.Windows.Forms.ToolStripMenuItem goLoginForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView UserMainView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button goUserProfile;
        private System.Windows.Forms.TextBox moneytext;
        private System.Windows.Forms.Label lastmoneylabel;
        private System.Windows.Forms.TextBox nametext;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}