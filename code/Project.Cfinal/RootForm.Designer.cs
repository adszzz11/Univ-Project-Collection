namespace Project.Cfinal
{
    partial class RootForm
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
            this.orderView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Rootbookerbot = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.makeView = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clock = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.makeCheck = new System.Windows.Forms.Button();
            this.orderCheck = new System.Windows.Forms.Button();
            this.waitpeople = new System.Windows.Forms.Label();
            this.orderedpeople = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makeView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderView
            // 
            this.orderView.AllowUserToAddRows = false;
            this.orderView.AllowUserToDeleteRows = false;
            this.orderView.BackgroundColor = System.Drawing.Color.Wheat;
            this.orderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.orderView.GridColor = System.Drawing.Color.Peru;
            this.orderView.Location = new System.Drawing.Point(230, 70);
            this.orderView.Name = "orderView";
            this.orderView.ReadOnly = true;
            this.orderView.RowHeadersVisible = false;
            this.orderView.RowTemplate.Height = 23;
            this.orderView.Size = new System.Drawing.Size(562, 158);
            this.orderView.TabIndex = 3;
            this.orderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "에약시간";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
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
            this.Column3.HeaderText = "메뉴 옵션";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 242;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "예약자";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 70;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3,
            this.Rootbookerbot});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Peru;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem1.Text = "메뉴관리";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Peru;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(174, 26);
            this.toolStripMenuItem3.Text = "로그아웃";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Rootbookerbot
            // 
            this.Rootbookerbot.BackColor = System.Drawing.Color.Peru;
            this.Rootbookerbot.ForeColor = System.Drawing.Color.White;
            this.Rootbookerbot.Name = "Rootbookerbot";
            this.Rootbookerbot.Size = new System.Drawing.Size(174, 26);
            this.Rootbookerbot.Text = "예약자 관리";
            this.Rootbookerbot.Click += new System.EventHandler(this.Rootbookerbot_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-11, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(820, 29);
            this.label4.TabIndex = 28;
            // 
            // makeView
            // 
            this.makeView.AllowUserToAddRows = false;
            this.makeView.AllowUserToDeleteRows = false;
            this.makeView.BackgroundColor = System.Drawing.Color.Wheat;
            this.makeView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.makeView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.makeView.GridColor = System.Drawing.Color.Peru;
            this.makeView.Location = new System.Drawing.Point(230, 261);
            this.makeView.Name = "makeView";
            this.makeView.ReadOnly = true;
            this.makeView.RowHeadersVisible = false;
            this.makeView.RowTemplate.Height = 23;
            this.makeView.Size = new System.Drawing.Size(562, 158);
            this.makeView.TabIndex = 29;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "예약시간";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "메뉴";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "메뉴 옵션";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 242;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "예약자";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 70;
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("한컴산뜻돋움", 23.75F);
            this.clock.Location = new System.Drawing.Point(4, 70);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(78, 42);
            this.clock.TabIndex = 31;
            this.clock.Text = "시계";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(228, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "신청 왔어요";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(228, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 16);
            this.label7.TabIndex = 34;
            this.label7.Text = "만들어야해요";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // makeCheck
            // 
            this.makeCheck.BackColor = System.Drawing.Color.Peru;
            this.makeCheck.FlatAppearance.BorderSize = 0;
            this.makeCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeCheck.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.makeCheck.ForeColor = System.Drawing.Color.White;
            this.makeCheck.Location = new System.Drawing.Point(12, 332);
            this.makeCheck.Name = "makeCheck";
            this.makeCheck.Size = new System.Drawing.Size(125, 27);
            this.makeCheck.TabIndex = 41;
            this.makeCheck.Text = "제작 전부 확인";
            this.makeCheck.UseVisualStyleBackColor = false;
            this.makeCheck.Click += new System.EventHandler(this.makeCheck_Click);
            // 
            // orderCheck
            // 
            this.orderCheck.BackColor = System.Drawing.Color.Peru;
            this.orderCheck.FlatAppearance.BorderSize = 0;
            this.orderCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.orderCheck.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.orderCheck.ForeColor = System.Drawing.Color.White;
            this.orderCheck.Location = new System.Drawing.Point(12, 266);
            this.orderCheck.Name = "orderCheck";
            this.orderCheck.Size = new System.Drawing.Size(125, 25);
            this.orderCheck.TabIndex = 41;
            this.orderCheck.Text = "주문신청 전부 확인";
            this.orderCheck.UseVisualStyleBackColor = false;
            this.orderCheck.Click += new System.EventHandler(this.orderCheck_Click);
            // 
            // waitpeople
            // 
            this.waitpeople.AutoSize = true;
            this.waitpeople.Location = new System.Drawing.Point(12, 171);
            this.waitpeople.Name = "waitpeople";
            this.waitpeople.Size = new System.Drawing.Size(38, 12);
            this.waitpeople.TabIndex = 42;
            this.waitpeople.Text = "label1";
            // 
            // orderedpeople
            // 
            this.orderedpeople.AutoSize = true;
            this.orderedpeople.Location = new System.Drawing.Point(12, 216);
            this.orderedpeople.Name = "orderedpeople";
            this.orderedpeople.Size = new System.Drawing.Size(38, 12);
            this.orderedpeople.TabIndex = 43;
            this.orderedpeople.Text = "label1";
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.orderedpeople);
            this.Controls.Add(this.waitpeople);
            this.Controls.Add(this.orderCheck);
            this.Controls.Add(this.makeCheck);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.makeView);
            this.Controls.Add(this.orderView);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "RootForm";
            this.Text = "RootForm";
            this.Load += new System.EventHandler(this.RootForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makeView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView orderView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem Rootbookerbot;
        private System.Windows.Forms.DataGridView makeView;
        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button makeCheck;
        private System.Windows.Forms.Button orderCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label waitpeople;
        private System.Windows.Forms.Label orderedpeople;
    }
}