namespace Utku_Kalender_223908029_Tree
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
            this.ekleLabel = new System.Windows.Forms.Label();
            this.silmeLabel = new System.Windows.Forms.Label();
            this.duzeyLabel = new System.Windows.Forms.Label();
            this.ekleTextBox = new System.Windows.Forms.TextBox();
            this.silmeTextBox = new System.Windows.Forms.TextBox();
            this.bulmaTextBox = new System.Windows.Forms.TextBox();
            this.ekleButton = new System.Windows.Forms.Button();
            this.silButton = new System.Windows.Forms.Button();
            this.bulButton = new System.Windows.Forms.Button();
            this.gosterButton1 = new System.Windows.Forms.Button();
            this.gosterButton2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yapraklarBox = new System.Windows.Forms.TextBox();
            this.yukseklikBox = new System.Windows.Forms.TextBox();
            this.miktarBox = new System.Windows.Forms.TextBox();
            this.yapraklarLabel = new System.Windows.Forms.Label();
            this.yukseklikLabel = new System.Windows.Forms.Label();
            this.miktarLabel = new System.Windows.Forms.Label();
            this.postorderBox = new System.Windows.Forms.TextBox();
            this.inorderBox = new System.Windows.Forms.TextBox();
            this.preorderBox = new System.Windows.Forms.TextBox();
            this.PostorderLabel = new System.Windows.Forms.Label();
            this.InorderLabel = new System.Windows.Forms.Label();
            this.preorderLabel = new System.Windows.Forms.Label();
            this.duzeyLabel2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ekleLabel
            // 
            this.ekleLabel.AutoSize = true;
            this.ekleLabel.Location = new System.Drawing.Point(12, 18);
            this.ekleLabel.Name = "ekleLabel";
            this.ekleLabel.Size = new System.Drawing.Size(114, 16);
            this.ekleLabel.TabIndex = 0;
            this.ekleLabel.Text = "... düğümü eklendi";
            // 
            // silmeLabel
            // 
            this.silmeLabel.AutoSize = true;
            this.silmeLabel.Location = new System.Drawing.Point(12, 53);
            this.silmeLabel.Name = "silmeLabel";
            this.silmeLabel.Size = new System.Drawing.Size(106, 16);
            this.silmeLabel.TabIndex = 1;
            this.silmeLabel.Text = "... düğümü Silindi";
            // 
            // duzeyLabel
            // 
            this.duzeyLabel.AutoSize = true;
            this.duzeyLabel.Location = new System.Drawing.Point(12, 88);
            this.duzeyLabel.Name = "duzeyLabel";
            this.duzeyLabel.Size = new System.Drawing.Size(120, 16);
            this.duzeyLabel.TabIndex = 2;
            this.duzeyLabel.Text = "Düğümün Düzeyi ...";
            // 
            // ekleTextBox
            // 
            this.ekleTextBox.Location = new System.Drawing.Point(154, 18);
            this.ekleTextBox.Name = "ekleTextBox";
            this.ekleTextBox.Size = new System.Drawing.Size(176, 22);
            this.ekleTextBox.TabIndex = 3;
            // 
            // silmeTextBox
            // 
            this.silmeTextBox.Location = new System.Drawing.Point(154, 54);
            this.silmeTextBox.Name = "silmeTextBox";
            this.silmeTextBox.Size = new System.Drawing.Size(176, 22);
            this.silmeTextBox.TabIndex = 4;
            // 
            // bulmaTextBox
            // 
            this.bulmaTextBox.Location = new System.Drawing.Point(154, 89);
            this.bulmaTextBox.Name = "bulmaTextBox";
            this.bulmaTextBox.Size = new System.Drawing.Size(176, 22);
            this.bulmaTextBox.TabIndex = 5;
            // 
            // ekleButton
            // 
            this.ekleButton.Location = new System.Drawing.Point(368, 15);
            this.ekleButton.Name = "ekleButton";
            this.ekleButton.Size = new System.Drawing.Size(109, 23);
            this.ekleButton.TabIndex = 6;
            this.ekleButton.Text = "Düğüm Ekle";
            this.ekleButton.UseVisualStyleBackColor = true;
            this.ekleButton.Click += new System.EventHandler(this.ekleButton_Click);
            // 
            // silButton
            // 
            this.silButton.Location = new System.Drawing.Point(368, 53);
            this.silButton.Name = "silButton";
            this.silButton.Size = new System.Drawing.Size(109, 23);
            this.silButton.TabIndex = 7;
            this.silButton.Text = "Düğüm Silme";
            this.silButton.UseVisualStyleBackColor = true;
            this.silButton.Click += new System.EventHandler(this.silButton_Click);
            // 
            // bulButton
            // 
            this.bulButton.Location = new System.Drawing.Point(368, 88);
            this.bulButton.Name = "bulButton";
            this.bulButton.Size = new System.Drawing.Size(109, 23);
            this.bulButton.TabIndex = 8;
            this.bulButton.Text = "Düğüm Bul";
            this.bulButton.UseVisualStyleBackColor = true;
            this.bulButton.Click += new System.EventHandler(this.bulButton_Click);
            // 
            // gosterButton1
            // 
            this.gosterButton1.Location = new System.Drawing.Point(79, 177);
            this.gosterButton1.Name = "gosterButton1";
            this.gosterButton1.Size = new System.Drawing.Size(251, 23);
            this.gosterButton1.TabIndex = 9;
            this.gosterButton1.Text = "Ağaçtaki Düğümleri Göster";
            this.gosterButton1.UseVisualStyleBackColor = true;
            this.gosterButton1.Click += new System.EventHandler(this.gosterButton1_Click);
            // 
            // gosterButton2
            // 
            this.gosterButton2.Location = new System.Drawing.Point(557, 18);
            this.gosterButton2.Name = "gosterButton2";
            this.gosterButton2.Size = new System.Drawing.Size(407, 23);
            this.gosterButton2.TabIndex = 11;
            this.gosterButton2.Text = "Ağaç Bilgilerini Göster";
            this.gosterButton2.UseVisualStyleBackColor = true;
            this.gosterButton2.Click += new System.EventHandler(this.gosterButton2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.yapraklarBox);
            this.groupBox1.Controls.Add(this.yukseklikBox);
            this.groupBox1.Controls.Add(this.miktarBox);
            this.groupBox1.Controls.Add(this.yapraklarLabel);
            this.groupBox1.Controls.Add(this.yukseklikLabel);
            this.groupBox1.Controls.Add(this.miktarLabel);
            this.groupBox1.Controls.Add(this.postorderBox);
            this.groupBox1.Controls.Add(this.inorderBox);
            this.groupBox1.Controls.Add(this.preorderBox);
            this.groupBox1.Controls.Add(this.PostorderLabel);
            this.groupBox1.Controls.Add(this.InorderLabel);
            this.groupBox1.Controls.Add(this.preorderLabel);
            this.groupBox1.Location = new System.Drawing.Point(498, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 388);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ağaç Bilgileri";
            // 
            // yapraklarBox
            // 
            this.yapraklarBox.Location = new System.Drawing.Point(132, 321);
            this.yapraklarBox.Name = "yapraklarBox";
            this.yapraklarBox.Size = new System.Drawing.Size(379, 22);
            this.yapraklarBox.TabIndex = 11;
            // 
            // yukseklikBox
            // 
            this.yukseklikBox.Location = new System.Drawing.Point(132, 264);
            this.yukseklikBox.Name = "yukseklikBox";
            this.yukseklikBox.Size = new System.Drawing.Size(379, 22);
            this.yukseklikBox.TabIndex = 10;
            // 
            // miktarBox
            // 
            this.miktarBox.Location = new System.Drawing.Point(214, 207);
            this.miktarBox.Name = "miktarBox";
            this.miktarBox.Size = new System.Drawing.Size(298, 22);
            this.miktarBox.TabIndex = 9;
            // 
            // yapraklarLabel
            // 
            this.yapraklarLabel.AutoSize = true;
            this.yapraklarLabel.Location = new System.Drawing.Point(6, 321);
            this.yapraklarLabel.Name = "yapraklarLabel";
            this.yapraklarLabel.Size = new System.Drawing.Size(120, 16);
            this.yapraklarLabel.TabIndex = 8;
            this.yapraklarLabel.Text = "Ağacın Yaprakları: ";
            // 
            // yukseklikLabel
            // 
            this.yukseklikLabel.AutoSize = true;
            this.yukseklikLabel.Location = new System.Drawing.Point(6, 264);
            this.yukseklikLabel.Name = "yukseklikLabel";
            this.yukseklikLabel.Size = new System.Drawing.Size(120, 16);
            this.yukseklikLabel.TabIndex = 7;
            this.yukseklikLabel.Text = "Ağacın Yüksekliği: ";
            // 
            // miktarLabel
            // 
            this.miktarLabel.AutoSize = true;
            this.miktarLabel.Location = new System.Drawing.Point(6, 207);
            this.miktarLabel.Name = "miktarLabel";
            this.miktarLabel.Size = new System.Drawing.Size(202, 16);
            this.miktarLabel.TabIndex = 6;
            this.miktarLabel.Text = "Ağaçtaki Toplam Düğüm Sayısı: ";
            // 
            // postorderBox
            // 
            this.postorderBox.Location = new System.Drawing.Point(75, 147);
            this.postorderBox.Name = "postorderBox";
            this.postorderBox.Size = new System.Drawing.Size(436, 22);
            this.postorderBox.TabIndex = 5;
            // 
            // inorderBox
            // 
            this.inorderBox.Location = new System.Drawing.Point(75, 97);
            this.inorderBox.Name = "inorderBox";
            this.inorderBox.Size = new System.Drawing.Size(437, 22);
            this.inorderBox.TabIndex = 4;
            // 
            // preorderBox
            // 
            this.preorderBox.Location = new System.Drawing.Point(75, 45);
            this.preorderBox.Name = "preorderBox";
            this.preorderBox.Size = new System.Drawing.Size(437, 22);
            this.preorderBox.TabIndex = 3;
            // 
            // PostorderLabel
            // 
            this.PostorderLabel.AutoSize = true;
            this.PostorderLabel.Location = new System.Drawing.Point(6, 147);
            this.PostorderLabel.Name = "PostorderLabel";
            this.PostorderLabel.Size = new System.Drawing.Size(66, 16);
            this.PostorderLabel.TabIndex = 2;
            this.PostorderLabel.Text = "Postorder";
            // 
            // InorderLabel
            // 
            this.InorderLabel.AutoSize = true;
            this.InorderLabel.Location = new System.Drawing.Point(6, 97);
            this.InorderLabel.Name = "InorderLabel";
            this.InorderLabel.Size = new System.Drawing.Size(57, 16);
            this.InorderLabel.TabIndex = 1;
            this.InorderLabel.Text = "Ineorder";
            // 
            // preorderLabel
            // 
            this.preorderLabel.AutoSize = true;
            this.preorderLabel.Location = new System.Drawing.Point(6, 48);
            this.preorderLabel.Name = "preorderLabel";
            this.preorderLabel.Size = new System.Drawing.Size(60, 16);
            this.preorderLabel.TabIndex = 0;
            this.preorderLabel.Text = "Preorder";
            // 
            // duzeyLabel2
            // 
            this.duzeyLabel2.AutoSize = true;
            this.duzeyLabel2.Location = new System.Drawing.Point(12, 130);
            this.duzeyLabel2.Name = "duzeyLabel2";
            this.duzeyLabel2.Size = new System.Drawing.Size(105, 16);
            this.duzeyLabel2.TabIndex = 13;
            this.duzeyLabel2.Text = "Ağacın Düzeyi ...";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(79, 235);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(251, 287);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 543);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.duzeyLabel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gosterButton2);
            this.Controls.Add(this.gosterButton1);
            this.Controls.Add(this.bulButton);
            this.Controls.Add(this.silButton);
            this.Controls.Add(this.ekleButton);
            this.Controls.Add(this.bulmaTextBox);
            this.Controls.Add(this.silmeTextBox);
            this.Controls.Add(this.ekleTextBox);
            this.Controls.Add(this.duzeyLabel);
            this.Controls.Add(this.silmeLabel);
            this.Controls.Add(this.ekleLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ekleLabel;
        private System.Windows.Forms.Label silmeLabel;
        private System.Windows.Forms.Label duzeyLabel;
        private System.Windows.Forms.TextBox ekleTextBox;
        private System.Windows.Forms.TextBox silmeTextBox;
        private System.Windows.Forms.TextBox bulmaTextBox;
        private System.Windows.Forms.Button ekleButton;
        private System.Windows.Forms.Button silButton;
        private System.Windows.Forms.Button bulButton;
        private System.Windows.Forms.Button gosterButton1;
        private System.Windows.Forms.Button gosterButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox yapraklarBox;
        private System.Windows.Forms.TextBox yukseklikBox;
        private System.Windows.Forms.TextBox miktarBox;
        private System.Windows.Forms.Label yapraklarLabel;
        private System.Windows.Forms.Label yukseklikLabel;
        private System.Windows.Forms.Label miktarLabel;
        private System.Windows.Forms.TextBox postorderBox;
        private System.Windows.Forms.TextBox inorderBox;
        private System.Windows.Forms.TextBox preorderBox;
        private System.Windows.Forms.Label PostorderLabel;
        private System.Windows.Forms.Label InorderLabel;
        private System.Windows.Forms.Label preorderLabel;
        private System.Windows.Forms.Label duzeyLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

