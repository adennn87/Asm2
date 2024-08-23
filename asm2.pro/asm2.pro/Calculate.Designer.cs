namespace asm2.pro
{
    partial class Calculate
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
            dataCus = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btSearch = new Button();
            tbName = new TextBox();
            tbID = new TextBox();
            tbPeople = new TextBox();
            tbLM = new TextBox();
            tbTM = new TextBox();
            tbConsumed = new TextBox();
            tbTotal = new TextBox();
            cbbtype = new ComboBox();
            tbSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataCus).BeginInit();
            SuspendLayout();
            // 
            // dataCus
            // 
            dataCus.BackgroundColor = SystemColors.ButtonHighlight;
            dataCus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataCus.Location = new Point(-1, 491);
            dataCus.Name = "dataCus";
            dataCus.ReadOnly = true;
            dataCus.RowHeadersWidth = 51;
            dataCus.RowTemplate.Height = 29;
            dataCus.Size = new Size(1333, 215);
            dataCus.TabIndex = 0;
            dataCus.CellContentClick += dataCus_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(268, 40);
            label3.Name = "label3";
            label3.Size = new Size(812, 62);
            label3.TabIndex = 5;
            label3.Text = "WELCOME TO WATER CALCULATOR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 150);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(57, 265);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 8;
            label4.Text = "Type customer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 323);
            label5.Name = "label5";
            label5.Size = new Size(141, 20);
            label5.TabIndex = 9;
            label5.Text = "Number of member";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 204);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 10;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 149);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 11;
            label7.Text = "Last month water";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(489, 219);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 12;
            label8.Text = "This month water";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(489, 291);
            label9.Name = "label9";
            label9.Size = new Size(138, 20);
            label9.TabIndex = 13;
            label9.Text = "Water consumption";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(489, 366);
            label10.Name = "label10";
            label10.Size = new Size(67, 20);
            label10.TabIndex = 14;
            label10.Text = "Total bill";
            // 
            // button1
            // 
            button1.Location = new Point(164, 429);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 429);
            button2.Name = "button2";
            button2.Size = new Size(85, 30);
            button2.TabIndex = 16;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(518, 431);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 17;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(704, 431);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 18;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // btSearch
            // 
            btSearch.Location = new Point(870, 431);
            btSearch.Name = "btSearch";
            btSearch.Size = new Size(158, 29);
            btSearch.TabIndex = 19;
            btSearch.Text = "Search information";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += button5_Click;
            // 
            // tbName
            // 
            tbName.Location = new Point(133, 147);
            tbName.Name = "tbName";
            tbName.Size = new Size(183, 27);
            tbName.TabIndex = 20;
            // 
            // tbID
            // 
            tbID.Location = new Point(133, 197);
            tbID.Name = "tbID";
            tbID.Size = new Size(183, 27);
            tbID.TabIndex = 21;
            // 
            // tbPeople
            // 
            tbPeople.Location = new Point(204, 316);
            tbPeople.Name = "tbPeople";
            tbPeople.ReadOnly = true;
            tbPeople.Size = new Size(149, 27);
            tbPeople.TabIndex = 23;
            tbPeople.TextChanged += tbPeople_TextChanged;
            // 
            // tbLM
            // 
            tbLM.Location = new Point(652, 149);
            tbLM.Name = "tbLM";
            tbLM.Size = new Size(159, 27);
            tbLM.TabIndex = 24;
            // 
            // tbTM
            // 
            tbTM.Location = new Point(652, 216);
            tbTM.Name = "tbTM";
            tbTM.Size = new Size(159, 27);
            tbTM.TabIndex = 25;
            // 
            // tbConsumed
            // 
            tbConsumed.Location = new Point(652, 284);
            tbConsumed.Name = "tbConsumed";
            tbConsumed.ReadOnly = true;
            tbConsumed.Size = new Size(159, 27);
            tbConsumed.TabIndex = 26;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(652, 363);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(159, 27);
            tbTotal.TabIndex = 27;
            // 
            // cbbtype
            // 
            cbbtype.FormattingEnabled = true;
            cbbtype.Items.AddRange(new object[] { "House Hold", "Administrative and public services", "Production units", "Business services" });
            cbbtype.Location = new Point(202, 257);
            cbbtype.Name = "cbbtype";
            cbbtype.Size = new Size(151, 28);
            cbbtype.TabIndex = 28;
            cbbtype.SelectedIndexChanged += cbbtype_SelectedIndexChanged;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(1051, 429);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(125, 27);
            tbSearch.TabIndex = 29;
            // 
            // Calculate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background_in_an_2;
            ClientSize = new Size(1332, 708);
            Controls.Add(tbSearch);
            Controls.Add(cbbtype);
            Controls.Add(tbTotal);
            Controls.Add(tbConsumed);
            Controls.Add(tbTM);
            Controls.Add(tbLM);
            Controls.Add(tbPeople);
            Controls.Add(tbID);
            Controls.Add(tbName);
            Controls.Add(btSearch);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(dataCus);
            Name = "Calculate";
            Text = "Calculate";
            Load += Calculate_Load;
            ((System.ComponentModel.ISupportInitialize)dataCus).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataCus;
        private Label label3;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btSearch;
        private TextBox tbName;
        private TextBox tbID;
        private TextBox tbPeople;
        private TextBox tbLM;
        private TextBox tbTM;
        private TextBox tbConsumed;
        private TextBox tbTotal;
        private ComboBox cbbtype;
        private TextBox tbSearch;
    }
}