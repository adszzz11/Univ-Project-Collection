namespace Project.Cfinal
{
    partial class CashForm
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
            this.Title = new System.Windows.Forms.Label();
            this.goCashForm = new System.Windows.Forms.Button();
            this.showmoney = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wantcash = new System.Windows.Forms.TextBox();
            this.nowcash = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-45, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(820, 29);
            this.label4.TabIndex = 50;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("한컴산뜻돋움", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.Title.Location = new System.Drawing.Point(116, 66);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(146, 42);
            this.Title.TabIndex = 59;
            this.Title.Text = "캐쉬 충전";
            // 
            // goCashForm
            // 
            this.goCashForm.BackColor = System.Drawing.Color.Peru;
            this.goCashForm.FlatAppearance.BorderSize = 0;
            this.goCashForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goCashForm.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.goCashForm.ForeColor = System.Drawing.Color.White;
            this.goCashForm.Location = new System.Drawing.Point(237, 238);
            this.goCashForm.Name = "goCashForm";
            this.goCashForm.Size = new System.Drawing.Size(90, 23);
            this.goCashForm.TabIndex = 57;
            this.goCashForm.Text = "캐쉬 충전";
            this.goCashForm.UseVisualStyleBackColor = false;
            this.goCashForm.Click += new System.EventHandler(this.goCashForm_Click);
            // 
            // showmoney
            // 
            this.showmoney.BackColor = System.Drawing.Color.Peru;
            this.showmoney.FlatAppearance.BorderSize = 0;
            this.showmoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showmoney.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showmoney.ForeColor = System.Drawing.Color.White;
            this.showmoney.Location = new System.Drawing.Point(237, 158);
            this.showmoney.Name = "showmoney";
            this.showmoney.Size = new System.Drawing.Size(90, 23);
            this.showmoney.TabIndex = 58;
            this.showmoney.Text = "잔액 확인";
            this.showmoney.UseVisualStyleBackColor = false;
            this.showmoney.Click += new System.EventHandler(this.showmoney_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(84, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "충전할 금액";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(84, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "현재 잔액";
            // 
            // wantcash
            // 
            this.wantcash.BackColor = System.Drawing.Color.Moccasin;
            this.wantcash.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wantcash.Location = new System.Drawing.Point(86, 239);
            this.wantcash.Name = "wantcash";
            this.wantcash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wantcash.Size = new System.Drawing.Size(133, 23);
            this.wantcash.TabIndex = 54;
            // 
            // nowcash
            // 
            this.nowcash.BackColor = System.Drawing.Color.Moccasin;
            this.nowcash.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nowcash.Location = new System.Drawing.Point(86, 158);
            this.nowcash.Name = "nowcash";
            this.nowcash.ReadOnly = true;
            this.nowcash.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nowcash.Size = new System.Drawing.Size(133, 23);
            this.nowcash.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-134, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(548, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "D";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Peru;
            this.menuStrip1.Font = new System.Drawing.Font("한컴산뜻돋움", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(389, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.goCashForm);
            this.Controls.Add(this.showmoney);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wantcash);
            this.Controls.Add(this.nowcash);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.MaximizeBox = false;
            this.Name = "CashForm";
            this.Text = "ksemsr";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button goCashForm;
        private System.Windows.Forms.Button showmoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wantcash;
        private System.Windows.Forms.TextBox nowcash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}