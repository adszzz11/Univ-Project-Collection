namespace Project.Cfinal
{
    partial class SignUpForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.QnA = new System.Windows.Forms.ComboBox();
            this.id = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.pw2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.bir = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "회원가입";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // QnA
            // 
            this.QnA.FormattingEnabled = true;
            this.QnA.Items.AddRange(new object[] {
            "초등학교 이름",
            "어머니 성함",
            "아버지 성함",
            "자주타는 버스번호",
            "키우는 애완동물 이름"});
            this.QnA.Location = new System.Drawing.Point(146, 232);
            this.QnA.Name = "QnA";
            this.QnA.Size = new System.Drawing.Size(135, 20);
            this.QnA.TabIndex = 2;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(146, 91);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(134, 21);
            this.id.TabIndex = 3;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(146, 118);
            this.pw.Name = "pw";
            this.pw.Size = new System.Drawing.Size(134, 21);
            this.pw.TabIndex = 4;
            this.pw.TextChanged += new System.EventHandler(this.pw_TextChanged);
            // 
            // pw2
            // 
            this.pw2.Location = new System.Drawing.Point(146, 149);
            this.pw2.Name = "pw2";
            this.pw2.Size = new System.Drawing.Size(134, 21);
            this.pw2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "아이디";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "비밀번호";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "비밀번호 확인";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "QnA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "이름";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(146, 176);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(134, 21);
            this.name.TabIndex = 10;
            // 
            // bir
            // 
            this.bir.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.bir.Location = new System.Drawing.Point(146, 203);
            this.bir.Name = "bir";
            this.bir.Size = new System.Drawing.Size(134, 21);
            this.bir.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "생일";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "휴대폰 번호";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(146, 285);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(134, 21);
            this.phone.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 12);
            this.label9.TabIndex = 17;
            this.label9.Text = "QnA Answer";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(146, 258);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(134, 21);
            this.answer.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(301, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "아이디 중복 확인";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(301, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "비밀번호 확인";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "아이디생성";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 23);
            this.button4.TabIndex = 21;
            this.button4.Text = "로그인폼 이동";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 348);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pw2);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.id);
            this.Controls.Add(this.QnA);
            this.Controls.Add(this.label2);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox QnA;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.TextBox pw2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DateTimePicker bir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}