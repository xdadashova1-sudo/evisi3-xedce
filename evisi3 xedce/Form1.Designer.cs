namespace evisi3_xedce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            yer = new TextBox();
            saat = new MaskedTextBox();
            tarix = new MaskedTextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            email = new TextBox();
            telefon = new MaskedTextBox();
            fin = new TextBox();
            adsoyad = new TextBox();
            button2 = new Button();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(285, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(755, 118);
            panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(492, -34);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(306, 219);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(306, 40);
            label1.Name = "label1";
            label1.Size = new Size(191, 40);
            label1.TabIndex = 1;
            label1.Text = "BMU Travel";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(yer);
            groupBox1.Controls.Add(saat);
            groupBox1.Controls.Add(tarix);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(12, 122);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(339, 294);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel information";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Location = new Point(294, 38);
            button1.Name = "button1";
            button1.Size = new Size(25, 74);
            button1.TabIndex = 10;
            button1.Text = "<>";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // yer
            // 
            yer.Location = new Point(143, 254);
            yer.Name = "yer";
            yer.Size = new Size(125, 27);
            yer.TabIndex = 9;
            // 
            // saat
            // 
            saat.Location = new Point(143, 197);
            saat.Mask = "00:00";
            saat.Name = "saat";
            saat.Size = new Size(125, 27);
            saat.TabIndex = 8;
            saat.ValidatingType = typeof(DateTime);
            // 
            // tarix
            // 
            tarix.Location = new Point(143, 139);
            tarix.Mask = "00/00/0000";
            tarix.Name = "tarix";
            tarix.Size = new Size(125, 27);
            tarix.TabIndex = 7;
            tarix.ValidatingType = typeof(DateTime);
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Şuşa", "Cəlilabad", "Qusar", "Naxçıvan", "Astara" });
            comboBox2.Location = new Point(143, 84);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(125, 28);
            comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Sumqayıt", "Bakı", "Xırdalan", "Abşeron" });
            comboBox1.Location = new Point(143, 35);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 28);
            comboBox1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 257);
            label6.Name = "label6";
            label6.Size = new Size(29, 20);
            label6.TabIndex = 4;
            label6.Text = "Yer";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 200);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 3;
            label5.Text = "Saat";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 142);
            label4.Name = "label4";
            label4.Size = new Size(39, 20);
            label4.TabIndex = 2;
            label4.Text = "Tarix";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 87);
            label3.Name = "label3";
            label3.Size = new Size(56, 20);
            label3.TabIndex = 1;
            label3.Text = "Haraya";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 38);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Hardan";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(email);
            groupBox2.Controls.Add(telefon);
            groupBox2.Controls.Add(fin);
            groupBox2.Controls.Add(adsoyad);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(398, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(345, 294);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Person information";
            // 
            // email
            // 
            email.Location = new Point(163, 194);
            email.Name = "email";
            email.Size = new Size(125, 27);
            email.TabIndex = 8;
            // 
            // telefon
            // 
            telefon.Location = new Point(163, 146);
            telefon.Mask = "(999) 00-000-00-00";
            telefon.Name = "telefon";
            telefon.Size = new Size(125, 27);
            telefon.TabIndex = 7;
            // 
            // fin
            // 
            fin.Location = new Point(163, 89);
            fin.Name = "fin";
            fin.Size = new Size(125, 27);
            fin.TabIndex = 6;
            // 
            // adsoyad
            // 
            adsoyad.Location = new Point(163, 35);
            adsoyad.Name = "adsoyad";
            adsoyad.Size = new Size(125, 27);
            adsoyad.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.HotTrack;
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(194, 248);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Bilet Al";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 197);
            label10.Name = "label10";
            label10.Size = new Size(46, 20);
            label10.TabIndex = 3;
            label10.Text = "Email";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 146);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 2;
            label9.Text = "Telefon";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(22, 92);
            label8.Name = "label8";
            label8.Size = new Size(28, 20);
            label8.TabIndex = 1;
            label8.Text = "Fin";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(22, 38);
            label7.Name = "label7";
            label7.Size = new Size(92, 20);
            label7.TabIndex = 0;
            label7.Text = "Ad ve Soyad";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(0, 422);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(755, 84);
            listBox1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Brown;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(29, 512);
            button3.Name = "button3";
            button3.Size = new Size(144, 36);
            button3.TabIndex = 5;
            button3.Text = "Delete Ticket";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(579, 512);
            button4.Name = "button4";
            button4.Size = new Size(144, 36);
            button4.TabIndex = 6;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(755, 560);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(listBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox listBox1;
        private TextBox yer;
        private MaskedTextBox saat;
        private MaskedTextBox tarix;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox email;
        private MaskedTextBox telefon;
        private TextBox fin;
        private TextBox adsoyad;
        private Button button3;
        private Button button4;
        private Button button1;
    }
}
