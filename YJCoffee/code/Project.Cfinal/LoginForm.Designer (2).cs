namespace Project.Cfinal
{
    partial class LoginForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Loginbot = new System.Windows.Forms.Button();
            this.SignUpbot = new System.Windows.Forms.Button();
            this.PWbox = new System.Windows.Forms.TextBox();
            this.IDbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.myTextBox5 = new Project.Cfinal.MyTextBox();
            this.myTextBox4 = new Project.Cfinal.MyTextBox();
            this.myTextBox2 = new Project.Cfinal.MyTextBox();
            this.myTextBox1 = new Project.Cfinal.MyTextBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(0, 508);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(515, 53);
            this.label4.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Wheat;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.textBox1.Location = new System.Drawing.Point(231, 359);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 14);
            this.textBox1.TabIndex = 34;
            this.textBox1.Text = "or";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Loginbot
            // 
            this.Loginbot.BackColor = System.Drawing.Color.SaddleBrown;
            this.Loginbot.Cursor = System.Windows.Forms.Cursors.Default;
            this.Loginbot.FlatAppearance.BorderColor = System.Drawing.Color.Wheat;
            this.Loginbot.FlatAppearance.BorderSize = 0;
            this.Loginbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbot.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Loginbot.ForeColor = System.Drawing.Color.White;
            this.Loginbot.Location = new System.Drawing.Point(121, 308);
            this.Loginbot.Name = "Loginbot";
            this.Loginbot.Size = new System.Drawing.Size(257, 36);
            this.Loginbot.TabIndex = 29;
            this.Loginbot.Text = "Login";
            this.Loginbot.UseVisualStyleBackColor = false;
            this.Loginbot.Click += new System.EventHandler(this.Loginbot_Click_1);
            // 
            // SignUpbot
            // 
            this.SignUpbot.BackColor = System.Drawing.Color.SaddleBrown;
            this.SignUpbot.Cursor = System.Windows.Forms.Cursors.Default;
            this.SignUpbot.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.SignUpbot.FlatAppearance.BorderSize = 0;
            this.SignUpbot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpbot.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.SignUpbot.ForeColor = System.Drawing.Color.White;
            this.SignUpbot.Location = new System.Drawing.Point(120, 392);
            this.SignUpbot.Name = "SignUpbot";
            this.SignUpbot.Size = new System.Drawing.Size(257, 36);
            this.SignUpbot.TabIndex = 28;
            this.SignUpbot.Text = "SignUp / Find Pw";
            this.SignUpbot.UseVisualStyleBackColor = false;
            this.SignUpbot.Click += new System.EventHandler(this.SignUpbot_Click);
            // 
            // PWbox
            // 
            this.PWbox.BackColor = System.Drawing.Color.Wheat;
            this.PWbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWbox.Font = new System.Drawing.Font("한컴산뜻돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PWbox.ForeColor = System.Drawing.Color.White;
            this.PWbox.Location = new System.Drawing.Point(119, 250);
            this.PWbox.Name = "PWbox";
            this.PWbox.Size = new System.Drawing.Size(258, 36);
            this.PWbox.TabIndex = 27;
            // 
            // IDbox
            // 
            this.IDbox.BackColor = System.Drawing.Color.Wheat;
            this.IDbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDbox.Font = new System.Drawing.Font("한컴산뜻돋움", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.IDbox.ForeColor = System.Drawing.Color.White;
            this.IDbox.Location = new System.Drawing.Point(120, 148);
            this.IDbox.Name = "IDbox";
            this.IDbox.Size = new System.Drawing.Size(258, 36);
            this.IDbox.TabIndex = 26;
            this.IDbox.Text = "zdz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Wheat;
            this.label3.Font = new System.Drawing.Font("한컴산뜻돋움", 6.249999F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 12);
            this.label3.TabIndex = 25;
            this.label3.Text = "User PW";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Wheat;
            this.label2.Font = new System.Drawing.Font("한컴산뜻돋움", 6.249999F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 24;
            this.label2.Text = "User ID";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("한컴산뜻돋움", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Title.Location = new System.Drawing.Point(91, 71);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(335, 46);
            this.Title.TabIndex = 23;
            this.Title.Text = "영진전문대 카페 예약";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 51);
            this.label1.TabIndex = 35;
            // 
            // myTextBox5
            // 
            this.myTextBox5.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.myTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox5.Location = new System.Drawing.Point(120, 366);
            this.myTextBox5.Name = "myTextBox5";
            this.myTextBox5.Size = new System.Drawing.Size(109, 1);
            this.myTextBox5.TabIndex = 33;
            // 
            // myTextBox4
            // 
            this.myTextBox4.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.myTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox4.Location = new System.Drawing.Point(268, 366);
            this.myTextBox4.Name = "myTextBox4";
            this.myTextBox4.Size = new System.Drawing.Size(109, 1);
            this.myTextBox4.TabIndex = 32;
            // 
            // myTextBox2
            // 
            this.myTextBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.myTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox2.Location = new System.Drawing.Point(119, 284);
            this.myTextBox2.Name = "myTextBox2";
            this.myTextBox2.Size = new System.Drawing.Size(257, 1);
            this.myTextBox2.TabIndex = 30;
            // 
            // myTextBox1
            // 
            this.myTextBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.myTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTextBox1.Location = new System.Drawing.Point(120, 182);
            this.myTextBox1.Name = "myTextBox1";
            this.myTextBox1.Size = new System.Drawing.Size(257, 1);
            this.myTextBox1.TabIndex = 31;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(515, 562);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myTextBox5);
            this.Controls.Add(this.myTextBox4);
            this.Controls.Add(this.myTextBox2);
            this.Controls.Add(this.myTextBox1);
            this.Controls.Add(this.Loginbot);
            this.Controls.Add(this.SignUpbot);
            this.Controls.Add(this.PWbox);
            this.Controls.Add(this.IDbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "로그인";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private MyTextBox myTextBox5;
        private MyTextBox myTextBox4;
        private MyTextBox myTextBox2;
        private MyTextBox myTextBox1;
        private System.Windows.Forms.Button Loginbot;
        private System.Windows.Forms.Button SignUpbot;
        private System.Windows.Forms.TextBox PWbox;
        private System.Windows.Forms.TextBox IDbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
    }
}

