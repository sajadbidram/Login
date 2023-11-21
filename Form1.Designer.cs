namespace WindowsFormsApp326
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
            this.button1 = new System.Windows.Forms.Button();
            this.tx_n = new System.Windows.Forms.TextBox();
            this.tx_p = new System.Windows.Forms.TextBox();
            this.lb_pasword = new System.Windows.Forms.Label();
            this.lb2_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(170, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 95);
            this.button1.TabIndex = 0;
            this.button1.Text = "برسی ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tx_n
            // 
            this.tx_n.Location = new System.Drawing.Point(146, 58);
            this.tx_n.Multiline = true;
            this.tx_n.Name = "tx_n";
            this.tx_n.Size = new System.Drawing.Size(478, 84);
            this.tx_n.TabIndex = 1;
            // 
            // tx_p
            // 
            this.tx_p.Location = new System.Drawing.Point(146, 172);
            this.tx_p.Multiline = true;
            this.tx_p.Name = "tx_p";
            this.tx_p.Size = new System.Drawing.Size(478, 84);
            this.tx_p.TabIndex = 2;
            // 
            // lb_pasword
            // 
            this.lb_pasword.AutoSize = true;
            this.lb_pasword.Location = new System.Drawing.Point(655, 208);
            this.lb_pasword.Name = "lb_pasword";
            this.lb_pasword.Size = new System.Drawing.Size(40, 16);
            this.lb_pasword.TabIndex = 3;
            this.lb_pasword.Text = ":پسورد";
            this.lb_pasword.Click += new System.EventHandler(this.lb_pasword_Click);
            // 
            // lb2_user
            // 
            this.lb2_user.AutoSize = true;
            this.lb2_user.Location = new System.Drawing.Point(655, 97);
            this.lb2_user.Name = "lb2_user";
            this.lb2_user.Size = new System.Drawing.Size(66, 16);
            this.lb2_user.TabIndex = 4;
            this.lb2_user.Text = ":نام کاربری";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "sajad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "12345";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2_user);
            this.Controls.Add(this.lb_pasword);
            this.Controls.Add(this.tx_p);
            this.Controls.Add(this.tx_n);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tx_n;
        private System.Windows.Forms.TextBox tx_p;
        private System.Windows.Forms.Label lb_pasword;
        private System.Windows.Forms.Label lb2_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

