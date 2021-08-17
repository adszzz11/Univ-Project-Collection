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
            this.Orderbot = new System.Windows.Forms.Button();
            this.AllMenuList = new System.Windows.Forms.CheckedListBox();
            this.OptionList = new System.Windows.Forms.CheckedListBox();
            this.OrderMenuList = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Orderbot
            // 
            this.Orderbot.Location = new System.Drawing.Point(185, 477);
            this.Orderbot.Name = "Orderbot";
            this.Orderbot.Size = new System.Drawing.Size(132, 42);
            this.Orderbot.TabIndex = 1;
            this.Orderbot.Text = "주문하기";
            this.Orderbot.UseVisualStyleBackColor = true;
            // 
            // AllMenuList
            // 
            this.AllMenuList.FormattingEnabled = true;
            this.AllMenuList.Items.AddRange(new object[] {
            "아메리카노",
            "카푸치노",
            "카페라떼"});
            this.AllMenuList.Location = new System.Drawing.Point(103, 86);
            this.AllMenuList.Name = "AllMenuList";
            this.AllMenuList.Size = new System.Drawing.Size(131, 328);
            this.AllMenuList.TabIndex = 2;
            // 
            // OptionList
            // 
            this.OptionList.FormattingEnabled = true;
            this.OptionList.Items.AddRange(new object[] {
            "샷 추가 + 500\\",
            "샷 추가 2 +1000\\"});
            this.OptionList.Location = new System.Drawing.Point(330, 86);
            this.OptionList.Name = "OptionList";
            this.OptionList.Size = new System.Drawing.Size(131, 328);
            this.OptionList.TabIndex = 3;
            // 
            // OrderMenuList
            // 
            this.OrderMenuList.FormattingEnabled = true;
            this.OrderMenuList.Items.AddRange(new object[] {
            "카푸치노 / 샷추가 = 5200\\",
            "카페라떼 = 4600\\"});
            this.OrderMenuList.Location = new System.Drawing.Point(535, 86);
            this.OrderMenuList.Name = "OrderMenuList";
            this.OrderMenuList.Size = new System.Drawing.Size(172, 328);
            this.OrderMenuList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(376, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "옵션";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "전체 메뉴";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(585, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "주문 할 메뉴";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(444, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "캐시 충전";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OrderMenuList);
            this.Controls.Add(this.OptionList);
            this.Controls.Add(this.AllMenuList);
            this.Controls.Add(this.Orderbot);
            this.Font = new System.Drawing.Font("한컴산뜻돋움", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OrderForm";
            this.Text = "Orderform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Orderbot;
        private System.Windows.Forms.CheckedListBox AllMenuList;
        private System.Windows.Forms.CheckedListBox OptionList;
        private System.Windows.Forms.CheckedListBox OrderMenuList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}