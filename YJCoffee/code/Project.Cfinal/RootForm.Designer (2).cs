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
            this.Menubot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Userbot = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ToLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Menubot
            // 
            this.Menubot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Menubot.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Menubot.Location = new System.Drawing.Point(12, 12);
            this.Menubot.Name = "Menubot";
            this.Menubot.Size = new System.Drawing.Size(90, 28);
            this.Menubot.TabIndex = 0;
            this.Menubot.Text = "메뉴 관리";
            this.Menubot.UseVisualStyleBackColor = true;
            this.Menubot.Click += new System.EventHandler(this.Menubot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(344, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "대충 현재 예약자 목록을 표시 해주는 창 만들어야함";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Userbot
            // 
            this.Userbot.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Userbot.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Userbot.Location = new System.Drawing.Point(12, 46);
            this.Userbot.Name = "Userbot";
            this.Userbot.Size = new System.Drawing.Size(90, 28);
            this.Userbot.TabIndex = 2;
            this.Userbot.Text = "사용자 관리";
            this.Userbot.UseVisualStyleBackColor = true;
            this.Userbot.Click += new System.EventHandler(this.Userbot_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(346, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(430, 374);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ToLogin
            // 
            this.ToLogin.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ToLogin.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ToLogin.Location = new System.Drawing.Point(12, 80);
            this.ToLogin.Name = "ToLogin";
            this.ToLogin.Size = new System.Drawing.Size(90, 28);
            this.ToLogin.TabIndex = 4;
            this.ToLogin.Text = "로그인 화면";
            this.ToLogin.UseVisualStyleBackColor = true;
            this.ToLogin.Click += new System.EventHandler(this.ToLogin_Click);
            // 
            // RootForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ToLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Userbot);
            this.Controls.Add(this.Menubot);
            this.MaximizeBox = false;
            this.Name = "RootForm";
            this.Text = "RootForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Menubot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Userbot;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ToLogin;
    }
}