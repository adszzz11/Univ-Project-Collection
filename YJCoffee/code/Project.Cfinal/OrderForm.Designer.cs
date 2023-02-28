namespace Project.Cfinal
{
    partial class OrderForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.Orderbot = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.OptionList = new System.Windows.Forms.CheckedListBox();
            this.wish = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.Button();
            this.nowMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.orderMenuList = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderMenuList)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(416, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "옵션";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(133, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "전체 메뉴";
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
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem3});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Peru;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.toolStripMenuItem1.Text = "메인 화면";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Peru;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(159, 26);
            this.toolStripMenuItem3.Text = "로그아웃";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // Orderbot
            // 
            this.Orderbot.BackColor = System.Drawing.Color.Peru;
            this.Orderbot.Cursor = System.Windows.Forms.Cursors.Default;
            this.Orderbot.FlatAppearance.BorderSize = 0;
            this.Orderbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orderbot.ForeColor = System.Drawing.Color.White;
            this.Orderbot.Location = new System.Drawing.Point(456, 377);
            this.Orderbot.Name = "Orderbot";
            this.Orderbot.Size = new System.Drawing.Size(120, 30);
            this.Orderbot.TabIndex = 8;
            this.Orderbot.Text = "주문 하기";
            this.Orderbot.UseVisualStyleBackColor = false;
            this.Orderbot.Click += new System.EventHandler(this.Orderbot_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(-6, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(820, 29);
            this.label5.TabIndex = 28;
            // 
            // OptionList
            // 
            this.OptionList.BackColor = System.Drawing.Color.BurlyWood;
            this.OptionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OptionList.FormattingEnabled = true;
            this.OptionList.Items.AddRange(new object[] {
            "샷 추가\t+ 500\\",
            "샷 추가2\t+ 1000\\",
            "샷 추가3\t+ 1500\\",
            "휘핑 추가\t+ 500\\",
            "휘핑 추가2\t+ 1000\\",
            "휘핑 추가3\t+ 1500\\"});
            this.OptionList.Location = new System.Drawing.Point(367, 69);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(195, 108);
            this.OptionList.TabIndex = 32;
            this.OptionList.SelectedIndexChanged += new System.EventHandler(this.OptionList_SelectedIndexChanged);
            // 
            // wish
            // 
            this.wish.FormattingEnabled = true;
            this.wish.Items.AddRange(new object[] {
            "ex) 아메리카노에 샷 2번 추가 카푸치노에 샷 1번 추가해주세요",
            "라떼는말이야에 휘핑 2번추가 아메리카노 3잔중에 1잔에만 샷 3번다 추가해주세요",
            "전화번호좀 주세요"});
            this.wish.Location = new System.Drawing.Point(367, 233);
            this.wish.Name = "wish";
            this.wish.Size = new System.Drawing.Size(410, 24);
            this.wish.TabIndex = 43;
            this.wish.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(364, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "요청사항";
            // 
            // check
            // 
            this.check.BackColor = System.Drawing.Color.Peru;
            this.check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.check.ForeColor = System.Drawing.Color.White;
            this.check.Location = new System.Drawing.Point(211, 377);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(130, 30);
            this.check.TabIndex = 45;
            this.check.Text = "가격 확인";
            this.check.UseVisualStyleBackColor = false;
            this.check.Click += new System.EventHandler(this.check_Click);
            // 
            // nowMoney
            // 
            this.nowMoney.BackColor = System.Drawing.Color.Moccasin;
            this.nowMoney.Location = new System.Drawing.Point(597, 154);
            this.nowMoney.Name = "nowMoney";
            this.nowMoney.Size = new System.Drawing.Size(100, 23);
            this.nowMoney.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(701, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(19, 16);
            this.label8.TabIndex = 46;
            this.label8.Text = "원";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(599, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "가격";
            // 
            // orderMenuList
            // 
            this.orderMenuList.AllowUserToAddRows = false;
            this.orderMenuList.AllowUserToDeleteRows = false;
            this.orderMenuList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderMenuList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4});
            this.orderMenuList.Location = new System.Drawing.Point(12, 69);
            this.orderMenuList.Name = "orderMenuList";
            this.orderMenuList.RowHeadersVisible = false;
            this.orderMenuList.RowTemplate.Height = 23;
            this.orderMenuList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.orderMenuList.Size = new System.Drawing.Size(329, 256);
            this.orderMenuList.TabIndex = 51;
            this.orderMenuList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column2
            // 
            this.Column2.HeaderText = "메뉴";
            this.Column2.Name = "Column2";
            this.Column2.Width = 175;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "가격";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "수량";
            this.Column4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.Column4.Name = "Column4";
            this.Column4.Width = 50;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.orderMenuList);
            this.Controls.Add(this.nowMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.check);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.wish);
            this.Controls.Add(this.OptionList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Orderbot);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "OrderForm";
            this.Text = "Orderform";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderMenuList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button Orderbot;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox OptionList;
        private System.Windows.Forms.ComboBox wish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox nowMoney;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView orderMenuList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
    }
}