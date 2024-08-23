namespace asm2.pro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbUname = new TextBox();
            tbPass = new TextBox();
            label3 = new Label();
            btlogin = new Button();
            btexit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(274, 177);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(274, 250);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // tbUname
            // 
            tbUname.Location = new Point(397, 177);
            tbUname.Name = "tbUname";
            tbUname.Size = new Size(190, 27);
            tbUname.TabIndex = 2;
            tbUname.TextChanged += textBox1_TextChanged;
            // 
            // tbPass
            // 
            tbPass.Location = new Point(397, 250);
            tbPass.Name = "tbPass";
            tbPass.Size = new Size(190, 27);
            tbPass.TabIndex = 3;
            tbPass.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(36, 62);
            label3.Name = "label3";
            label3.Size = new Size(812, 62);
            label3.TabIndex = 4;
            label3.Text = "WELCOME TO WATER CALCULATOR";
            // 
            // btlogin
            // 
            btlogin.Location = new Point(304, 336);
            btlogin.Name = "btlogin";
            btlogin.Size = new Size(94, 29);
            btlogin.TabIndex = 5;
            btlogin.Text = "Login";
            btlogin.UseVisualStyleBackColor = true;
            btlogin.Click += btlogin_Click;
            // 
            // btexit
            // 
            btexit.Location = new Point(465, 336);
            btexit.Name = "btexit";
            btexit.Size = new Size(96, 29);
            btexit.TabIndex = 6;
            btexit.Text = "Exit";
            btexit.UseVisualStyleBackColor = true;
            btexit.Click += btexit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_in_an_2;
            ClientSize = new Size(874, 437);
            Controls.Add(btexit);
            Controls.Add(btlogin);
            Controls.Add(label3);
            Controls.Add(tbPass);
            Controls.Add(tbUname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbUname;
        private TextBox tbPass;
        private Label label3;
        private Button btlogin;
        private Button btexit;
    }
}