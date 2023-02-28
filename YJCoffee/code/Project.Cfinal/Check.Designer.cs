namespace Project.Cfinal
{
    partial class Check
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
            this.nobutton = new System.Windows.Forms.Button();
            this.yesbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nobutton
            // 
            this.nobutton.BackColor = System.Drawing.Color.Peru;
            this.nobutton.FlatAppearance.BorderSize = 0;
            this.nobutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nobutton.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nobutton.ForeColor = System.Drawing.Color.White;
            this.nobutton.Location = new System.Drawing.Point(175, 113);
            this.nobutton.Name = "nobutton";
            this.nobutton.Size = new System.Drawing.Size(90, 23);
            this.nobutton.TabIndex = 4;
            this.nobutton.Text = "아니오";
            this.nobutton.UseVisualStyleBackColor = false;
            this.nobutton.Click += new System.EventHandler(this.nobutton_Click_1);
            // 
            // yesbutton
            // 
            this.yesbutton.BackColor = System.Drawing.Color.Peru;
            this.yesbutton.FlatAppearance.BorderSize = 0;
            this.yesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yesbutton.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.yesbutton.ForeColor = System.Drawing.Color.White;
            this.yesbutton.Location = new System.Drawing.Point(48, 113);
            this.yesbutton.Name = "yesbutton";
            this.yesbutton.Size = new System.Drawing.Size(90, 23);
            this.yesbutton.TabIndex = 3;
            this.yesbutton.Text = "예";
            this.yesbutton.UseVisualStyleBackColor = false;
            this.yesbutton.Click += new System.EventHandler(this.yesbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴산뜻돋움", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "10000원을 충전하시겠습니까?";
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(307, 168);
            this.Controls.Add(this.nobutton);
            this.Controls.Add(this.yesbutton);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Check";
            this.Text = "Check";
            this.Load += new System.EventHandler(this.Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nobutton;
        private System.Windows.Forms.Button yesbutton;
        private System.Windows.Forms.Label label1;
    }
}