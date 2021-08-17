namespace Project.Cfinal
{
    partial class RootBookerForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.ToRootForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.complete = new System.Windows.Forms.Button();
            this.reservation_Reject = new System.Windows.Forms.Button();
            this.reservation_OK = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ordernum = new System.Windows.Forms.TextBox();
            this.menuView = new System.Windows.Forms.DataGridView();
            this.myTextBox2 = new Project.Cfinal.MyTextBox();
            this.myTextBox1 = new Project.Cfinal.MyTextBox();
            this.myTextBox4 = new Project.Cfinal.MyTextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-11, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(820, 29);
            this.label4.TabIndex = 28;
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
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.Color.Peru;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToLogin,
            this.ToRootForm,
            this.toolStripMenuItem3});
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
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.Color.Peru;
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(208, 26);
            this.toolStripMenuItem3.Text = "메뉴관리";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // complete
            // 
            this.complete.BackColor = System.Drawing.Color.Peru;
            this.complete.FlatAppearance.BorderSize = 0;
            this.complete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.complete.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.complete.ForeColor = System.Drawing.Color.White;
            this.complete.Location = new System.Drawing.Point(633, 274);
            this.complete.Name = "complete";
            this.complete.Size = new System.Drawing.Size(100, 25);
            this.complete.TabIndex = 63;
            this.complete.Text = "완  료";
            this.complete.UseVisualStyleBackColor = false;
            this.complete.Click += new System.EventHandler(this.complete_Click);
            // 
            // reservation_Reject
            // 
            this.reservation_Reject.BackColor = System.Drawing.Color.Peru;
            this.reservation_Reject.FlatAppearance.BorderSize = 0;
            this.reservation_Reject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_Reject.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_Reject.ForeColor = System.Drawing.Color.White;
            this.reservation_Reject.Location = new System.Drawing.Point(633, 230);
            this.reservation_Reject.Name = "reservation_Reject";
            this.reservation_Reject.Size = new System.Drawing.Size(100, 25);
            this.reservation_Reject.TabIndex = 62;
            this.reservation_Reject.Text = "예약 거절";
            this.reservation_Reject.UseVisualStyleBackColor = false;
            this.reservation_Reject.Click += new System.EventHandler(this.reservation_Reject_Click);
            // 
            // reservation_OK
            // 
            this.reservation_OK.BackColor = System.Drawing.Color.Peru;
            this.reservation_OK.FlatAppearance.BorderSize = 0;
            this.reservation_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_OK.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.reservation_OK.ForeColor = System.Drawing.Color.White;
            this.reservation_OK.Location = new System.Drawing.Point(633, 185);
            this.reservation_OK.Name = "reservation_OK";
            this.reservation_OK.Size = new System.Drawing.Size(100, 25);
            this.reservation_OK.TabIndex = 61;
            this.reservation_OK.Text = "예약 접수";
            this.reservation_OK.UseVisualStyleBackColor = false;
            this.reservation_OK.Click += new System.EventHandler(this.reservation_OK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴산뜻돋움", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(628, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 60;
            this.label2.Text = "주문번호";
            // 
            // ordernum
            // 
            this.ordernum.BackColor = System.Drawing.Color.Wheat;
            this.ordernum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordernum.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ordernum.Location = new System.Drawing.Point(633, 150);
            this.ordernum.Name = "ordernum";
            this.ordernum.Size = new System.Drawing.Size(106, 16);
            this.ordernum.TabIndex = 59;
            this.ordernum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuView
            // 
            this.menuView.AllowUserToAddRows = false;
            this.menuView.AllowUserToDeleteRows = false;
            this.menuView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menuView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.menuView.Location = new System.Drawing.Point(12, 57);
            this.menuView.Name = "menuView";
            this.menuView.ReadOnly = true;
            this.menuView.RowHeadersVisible = false;
            this.menuView.RowTemplate.Height = 23;
            this.menuView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menuView.Size = new System.Drawing.Size(551, 362);
            this.menuView.TabIndex = 58;
            this.menuView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menuView_CellContentClick);
            // 
            // myTextBox2
            // 
            this.myTextBox2.BackColor = System.Drawing.Color.Peru;
            this.myTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox2.Location = new System.Drawing.Point(673, 264);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(20, 1);
            this.myTextBox2.TabIndex = 66;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.Peru;
            this.myTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox1.Location = new System.Drawing.Point(673, 219);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(20, 1);
            this.myTextBox1.TabIndex = 65;
            // 
            // myTextBox4
            // 
            this.myTextBox4.BackColor = System.Drawing.Color.Peru;
            this.myTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox4.Location = new System.Drawing.Point(631, 165);
            this.myTextBox4.Name = "myTextBox4";
            this.myTextBox4.Size = new System.Drawing.Size(106, 1);
            this.myTextBox4.TabIndex = 64;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "주문번호";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 78;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "주문시간";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "메뉴";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "세부사항";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "수량";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 60;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "예약자";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "준비";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 60;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "접수";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // RootBookerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.myTextBox4);
            this.Controls.Add(this.complete);
            this.Controls.Add(this.reservation_Reject);
            this.Controls.Add(this.reservation_OK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ordernum);
            this.Controls.Add(this.menuView);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(820, 500);
            this.MinimumSize = new System.Drawing.Size(820, 500);
            this.Name = "RootBookerForm";
            this.Text = "RootBookerForm";
            this.Load += new System.EventHandler(this.RootBookerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToLogin;
        private System.Windows.Forms.ToolStripMenuItem ToRootForm;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.Button complete;
        private System.Windows.Forms.Button reservation_Reject;
        private System.Windows.Forms.Button reservation_OK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ordernum;
        private System.Windows.Forms.DataGridView menuView;
        private MyTextBox myTextBox4;
        private MyTextBox myTextBox1;
        private MyTextBox myTextBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}