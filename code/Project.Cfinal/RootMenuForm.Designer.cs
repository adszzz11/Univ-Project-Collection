namespace Project.Cfinal
{
    partial class RootMenuForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.ComboBox();
            this.activenoactive = new System.Windows.Forms.Button();
            this.soldout = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuprice = new System.Windows.Forms.TextBox();
            this.menutext = new System.Windows.Forms.TextBox();
            this.addmenu = new System.Windows.Forms.Button();
            this.nowsellView = new System.Windows.Forms.DataGridView();
            this.Menu_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Menu_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manu_done = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MenuSetbot = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToRootForm = new System.Windows.Forms.ToolStripMenuItem();
            this.TOusercontrol = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.myTextBox4 = new Project.Cfinal.MyTextBox();
            this.myTextBox3 = new Project.Cfinal.MyTextBox();
            this.myTextBox2 = new Project.Cfinal.MyTextBox();
            this.myTextBox1 = new Project.Cfinal.MyTextBox();
            this.notsellView = new System.Windows.Forms.DataGridView();
            this.menu_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_price1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menu_done1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nowsellView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notsellView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(573, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "재고 상태";
            // 
            // Stock
            // 
            this.Stock.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stock.FormattingEnabled = true;
            this.Stock.Items.AddRange(new object[] {
            "품절",
            "재고있음"});
            this.Stock.Location = new System.Drawing.Point(643, 186);
            this.Stock.Name = "Stock";
            this.Stock.Size = new System.Drawing.Size(131, 24);
            this.Stock.TabIndex = 46;
            // 
            // activenoactive
            // 
            this.activenoactive.BackColor = System.Drawing.Color.Peru;
            this.activenoactive.FlatAppearance.BorderSize = 0;
            this.activenoactive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activenoactive.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.activenoactive.ForeColor = System.Drawing.Color.White;
            this.activenoactive.Location = new System.Drawing.Point(688, 247);
            this.activenoactive.Name = "activenoactive";
            this.activenoactive.Size = new System.Drawing.Size(100, 25);
            this.activenoactive.TabIndex = 45;
            this.activenoactive.Text = "활성화/비활성화";
            this.activenoactive.UseVisualStyleBackColor = false;
            this.activenoactive.Click += new System.EventHandler(this.activenoactive_Click);
            // 
            // soldout
            // 
            this.soldout.BackColor = System.Drawing.Color.Peru;
            this.soldout.FlatAppearance.BorderSize = 0;
            this.soldout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldout.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.soldout.ForeColor = System.Drawing.Color.White;
            this.soldout.Location = new System.Drawing.Point(688, 285);
            this.soldout.Name = "soldout";
            this.soldout.Size = new System.Drawing.Size(100, 25);
            this.soldout.TabIndex = 44;
            this.soldout.Text = "메뉴 품절";
            this.soldout.UseVisualStyleBackColor = false;
            this.soldout.Click += new System.EventHandler(this.soldout_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(573, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "메뉴 가격";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(573, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "메뉴 이름";
            // 
            // menuprice
            // 
            this.menuprice.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuprice.Location = new System.Drawing.Point(643, 159);
            this.menuprice.Name = "menuprice";
            this.menuprice.Size = new System.Drawing.Size(131, 23);
            this.menuprice.TabIndex = 41;
            // 
            // menutext
            // 
            this.menutext.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menutext.Location = new System.Drawing.Point(643, 132);
            this.menutext.Name = "menutext";
            this.menutext.Size = new System.Drawing.Size(131, 23);
            this.menutext.TabIndex = 40;
            // 
            // addmenu
            // 
            this.addmenu.BackColor = System.Drawing.Color.Peru;
            this.addmenu.FlatAppearance.BorderSize = 0;
            this.addmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addmenu.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.addmenu.ForeColor = System.Drawing.Color.White;
            this.addmenu.Location = new System.Drawing.Point(576, 247);
            this.addmenu.Name = "addmenu";
            this.addmenu.Size = new System.Drawing.Size(100, 25);
            this.addmenu.TabIndex = 39;
            this.addmenu.Text = "메뉴 추가";
            this.addmenu.UseVisualStyleBackColor = false;
            this.addmenu.Click += new System.EventHandler(this.addmenu_Click);
            // 
            // nowsellView
            // 
            this.nowsellView.AllowUserToAddRows = false;
            this.nowsellView.AllowUserToDeleteRows = false;
            this.nowsellView.BackgroundColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.nowsellView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.nowsellView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nowsellView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Menu_name,
            this.Menu_price,
            this.Manu_done});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.nowsellView.DefaultCellStyle = dataGridViewCellStyle5;
            this.nowsellView.Location = new System.Drawing.Point(40, 77);
            this.nowsellView.Name = "nowsellView";
            this.nowsellView.ReadOnly = true;
            this.nowsellView.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.nowsellView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.nowsellView.RowTemplate.Height = 23;
            this.nowsellView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.nowsellView.Size = new System.Drawing.Size(244, 304);
            this.nowsellView.TabIndex = 37;
            this.nowsellView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Menu_name
            // 
            this.Menu_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Moccasin;
            this.Menu_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.Menu_name.FillWeight = 50F;
            this.Menu_name.HeaderText = "메   뉴";
            this.Menu_name.Name = "Menu_name";
            this.Menu_name.ReadOnly = true;
            this.Menu_name.Width = 165;
            // 
            // Menu_price
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Moccasin;
            this.Menu_price.DefaultCellStyle = dataGridViewCellStyle3;
            this.Menu_price.HeaderText = "가격";
            this.Menu_price.Name = "Menu_price";
            this.Menu_price.ReadOnly = true;
            this.Menu_price.Width = 38;
            // 
            // Manu_done
            // 
            this.Manu_done.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.Manu_done.DefaultCellStyle = dataGridViewCellStyle4;
            this.Manu_done.FillWeight = 50F;
            this.Manu_done.HeaderText = "품절";
            this.Manu_done.Name = "Manu_done";
            this.Manu_done.ReadOnly = true;
            this.Manu_done.Width = 38;
            // 
            // MenuSetbot
            // 
            this.MenuSetbot.BackColor = System.Drawing.Color.Peru;
            this.MenuSetbot.FlatAppearance.BorderSize = 0;
            this.MenuSetbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuSetbot.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MenuSetbot.ForeColor = System.Drawing.Color.White;
            this.MenuSetbot.Location = new System.Drawing.Point(576, 285);
            this.MenuSetbot.Name = "MenuSetbot";
            this.MenuSetbot.Size = new System.Drawing.Size(100, 25);
            this.MenuSetbot.TabIndex = 34;
            this.MenuSetbot.Text = "메뉴 수정";
            this.MenuSetbot.UseVisualStyleBackColor = false;
            this.MenuSetbot.Click += new System.EventHandler(this.MenuSetbot_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Wheat;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox2.Location = new System.Drawing.Point(259, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 14);
            this.textBox2.TabIndex = 33;
            this.textBox2.Text = "비판매 메뉴";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.textBox1.Location = new System.Drawing.Point(9, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 14);
            this.textBox1.TabIndex = 32;
            this.textBox1.Text = "현제 판매중인 메뉴";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.menuStrip1.TabIndex = 48;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToLogin,
            this.ToRootForm,
            this.TOusercontrol});
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 25);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // ToLogin
            // 
            this.ToLogin.BackColor = System.Drawing.Color.Peru;
            this.ToLogin.ForeColor = System.Drawing.Color.White;
            this.ToLogin.Name = "ToLogin";
            this.ToLogin.Size = new System.Drawing.Size(208, 26);
            this.ToLogin.Text = "로그아웃";
            this.ToLogin.Click += new System.EventHandler(this.ToLogin_Click);
            // 
            // ToRootForm
            // 
            this.ToRootForm.BackColor = System.Drawing.Color.Peru;
            this.ToRootForm.ForeColor = System.Drawing.Color.White;
            this.ToRootForm.Name = "ToRootForm";
            this.ToRootForm.Size = new System.Drawing.Size(208, 26);
            this.ToRootForm.Text = "관리자 메인 화면";
            this.ToRootForm.Click += new System.EventHandler(this.ToRootForm_Click);
            // 
            // TOusercontrol
            // 
            this.TOusercontrol.BackColor = System.Drawing.Color.Peru;
            this.TOusercontrol.ForeColor = System.Drawing.Color.White;
            this.TOusercontrol.Name = "TOusercontrol";
            this.TOusercontrol.Size = new System.Drawing.Size(208, 26);
            this.TOusercontrol.Text = "예약자 관리";
            this.TOusercontrol.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-8, 432);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(820, 29);
            this.label4.TabIndex = 49;
            this.label4.Text = "D";
            // 
            // myTextBox4
            // 
            this.myTextBox4.BackColor = System.Drawing.Color.Black;
            this.myTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox4.Location = new System.Drawing.Point(40, 70);
            this.myTextBox4.Name = "myTextBox4";
            this.myTextBox4.Size = new System.Drawing.Size(134, 1);
            this.myTextBox4.TabIndex = 52;
            // 
            // myTextBox3
            // 
            this.myTextBox3.BackColor = System.Drawing.Color.Black;
            this.myTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox3.Location = new System.Drawing.Point(309, 70);
            this.myTextBox3.Name = "myTextBox3";
            this.myTextBox3.Size = new System.Drawing.Size(134, 1);
            this.myTextBox3.TabIndex = 52;
            // 
            // myTextBox2
            // 
            this.myTextBox2.BackColor = System.Drawing.Color.Peru;
            this.myTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox2.Location = new System.Drawing.Point(681, 252);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(1, 55);
            this.myTextBox2.TabIndex = 51;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.Peru;
            this.myTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox1.Location = new System.Drawing.Point(598, 278);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(170, 1);
            this.myTextBox1.TabIndex = 50;
            // 
            // notsellView
            // 
            this.notsellView.AllowUserToAddRows = false;
            this.notsellView.AllowUserToDeleteRows = false;
            this.notsellView.AllowUserToResizeColumns = false;
            this.notsellView.AllowUserToResizeRows = false;
            this.notsellView.BackgroundColor = System.Drawing.Color.Moccasin;
            this.notsellView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notsellView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.menu_name1,
            this.menu_price1,
            this.menu_done1});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notsellView.DefaultCellStyle = dataGridViewCellStyle8;
            this.notsellView.Location = new System.Drawing.Point(309, 77);
            this.notsellView.Name = "notsellView";
            this.notsellView.ReadOnly = true;
            this.notsellView.RowHeadersVisible = false;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            this.notsellView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.notsellView.RowTemplate.Height = 23;
            this.notsellView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notsellView.Size = new System.Drawing.Size(244, 304);
            this.notsellView.TabIndex = 53;
            this.notsellView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // menu_name1
            // 
            this.menu_name1.HeaderText = "메   뉴";
            this.menu_name1.Name = "menu_name1";
            this.menu_name1.ReadOnly = true;
            this.menu_name1.Width = 165;
            // 
            // menu_price1
            // 
            this.menu_price1.HeaderText = "가격";
            this.menu_price1.Name = "menu_price1";
            this.menu_price1.ReadOnly = true;
            this.menu_price1.Width = 38;
            // 
            // menu_done1
            // 
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.menu_done1.DefaultCellStyle = dataGridViewCellStyle7;
            this.menu_done1.HeaderText = "품절";
            this.menu_done1.Name = "menu_done1";
            this.menu_done1.ReadOnly = true;
            this.menu_done1.Width = 38;
            // 
            // RootMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.myTextBox4);
            this.Controls.Add(this.myTextBox3);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stock);
            this.Controls.Add(this.activenoactive);
            this.Controls.Add(this.soldout);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.menuprice);
            this.Controls.Add(this.menutext);
            this.Controls.Add(this.addmenu);
            this.Controls.Add(this.nowsellView);
            this.Controls.Add(this.MenuSetbot);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.notsellView);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "RootMenuForm";
            this.Text = "RootMenuForm";
            this.Load += new System.EventHandler(this.RootMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nowsellView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notsellView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Stock;
        private System.Windows.Forms.Button activenoactive;
        private System.Windows.Forms.Button soldout;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox menuprice;
        private System.Windows.Forms.TextBox menutext;
        private System.Windows.Forms.Button addmenu;
        private System.Windows.Forms.Button MenuSetbot;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToLogin;
        private System.Windows.Forms.ToolStripMenuItem ToRootForm;
        private System.Windows.Forms.ToolStripMenuItem TOusercontrol;
        private System.Windows.Forms.Label label4;
        private MyTextBox myTextBox1;
        private MyTextBox myTextBox2;
        private MyTextBox myTextBox3;
        private MyTextBox myTextBox4;
        private System.Windows.Forms.DataGridView nowsellView;
        private System.Windows.Forms.DataGridView notsellView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Menu_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manu_done;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_price1;
        private System.Windows.Forms.DataGridViewTextBoxColumn menu_done1;
    }
}