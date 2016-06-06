namespace CsgoDouble
{
    partial class Form1
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
            this.bt_checkRoll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLimitType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbBetType = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tbBalance = new System.Windows.Forms.TextBox();
            this.tbIni = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bt_Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_checkRoll
            // 
            this.bt_checkRoll.Location = new System.Drawing.Point(104, 4);
            this.bt_checkRoll.Name = "bt_checkRoll";
            this.bt_checkRoll.Size = new System.Drawing.Size(75, 23);
            this.bt_checkRoll.TabIndex = 0;
            this.bt_checkRoll.Text = "Check Roll";
            this.bt_checkRoll.UseVisualStyleBackColor = true;
            this.bt_checkRoll.Click += new System.EventHandler(this.bt_checkRoll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn option Bet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn màu";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "Đen",
            "Đỏ",
            "Random"});
            this.cbColor.Location = new System.Drawing.Point(72, 69);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(206, 21);
            this.cbColor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bet limit";
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(72, 97);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(206, 20);
            this.tbLimit.TabIndex = 3;
            this.tbLimit.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Limit type";
            // 
            // cbLimitType
            // 
            this.cbLimitType.FormattingEnabled = true;
            this.cbLimitType.Items.AddRange(new object[] {
            "Reset",
            "Ko reset"});
            this.cbLimitType.Location = new System.Drawing.Point(72, 128);
            this.cbLimitType.Name = "cbLimitType";
            this.cbLimitType.Size = new System.Drawing.Size(206, 21);
            this.cbLimitType.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Bet type";
            // 
            // cbBetType
            // 
            this.cbBetType.FormattingEnabled = true;
            this.cbBetType.Items.AddRange(new object[] {
            "Nhân đôi khi thắng",
            "Nhân đôi khi thua",
            "Mix"});
            this.cbBetType.Location = new System.Drawing.Point(72, 155);
            this.cbBetType.Name = "cbBetType";
            this.cbBetType.Size = new System.Drawing.Size(206, 21);
            this.cbBetType.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(286, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(261, 202);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // tbBalance
            // 
            this.tbBalance.Location = new System.Drawing.Point(209, 37);
            this.tbBalance.Name = "tbBalance";
            this.tbBalance.Size = new System.Drawing.Size(69, 20);
            this.tbBalance.TabIndex = 22;
            this.tbBalance.Text = "10000";
            // 
            // tbIni
            // 
            this.tbIni.Location = new System.Drawing.Point(72, 37);
            this.tbIni.Name = "tbIni";
            this.tbIni.Size = new System.Drawing.Size(69, 20);
            this.tbIni.TabIndex = 23;
            this.tbIni.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tài Khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Khởi điểm";
            // 
            // bt_Go
            // 
            this.bt_Go.Location = new System.Drawing.Point(190, 182);
            this.bt_Go.Name = "bt_Go";
            this.bt_Go.Size = new System.Drawing.Size(75, 23);
            this.bt_Go.TabIndex = 25;
            this.bt_Go.Text = "Go";
            this.bt_Go.UseVisualStyleBackColor = true;
            this.bt_Go.Click += new System.EventHandler(this.bt_Go_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 254);
            this.Controls.Add(this.bt_Go);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbBalance);
            this.Controls.Add(this.tbIni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbLimit);
            this.Controls.Add(this.cbBetType);
            this.Controls.Add(this.cbLimitType);
            this.Controls.Add(this.cbColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_checkRoll);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_checkRoll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLimitType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbBetType;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIni;
        private System.Windows.Forms.TextBox tbBalance;
        private System.Windows.Forms.Button bt_Go;
    }
}

