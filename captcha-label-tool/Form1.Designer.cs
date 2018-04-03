namespace captcha_label_tool
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.folderTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.captchaTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timesTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.progressLabel2 = new System.Windows.Forms.Label();
            this.progressLabel1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(789, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFolderToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFolderToolStripMenuItem
            // 
            this.openFolderToolStripMenuItem.Name = "openFolderToolStripMenuItem";
            this.openFolderToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.openFolderToolStripMenuItem.Text = "Open folder...";
            this.openFolderToolStripMenuItem.Click += new System.EventHandler(this.OpenFolderToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder Path:";
            // 
            // folderTextBox
            // 
            this.folderTextBox.Enabled = false;
            this.folderTextBox.Location = new System.Drawing.Point(193, 47);
            this.folderTextBox.Name = "folderTextBox";
            this.folderTextBox.Size = new System.Drawing.Size(467, 25);
            this.folderTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(16, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // captchaTextBox
            // 
            this.captchaTextBox.Font = new System.Drawing.Font("新細明體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.captchaTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.captchaTextBox.Location = new System.Drawing.Point(208, 191);
            this.captchaTextBox.MaxLength = 6;
            this.captchaTextBox.Name = "captchaTextBox";
            this.captchaTextBox.Size = new System.Drawing.Size(268, 79);
            this.captchaTextBox.TabIndex = 4;
            this.captchaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.captchaTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CaptchaTextBox_KeyDown);
            this.captchaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CaptchaTextBox_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.captchaTextBox);
            this.panel1.Location = new System.Drawing.Point(32, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 318);
            this.panel1.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(44, 212);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(118, 51);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "回到上一筆";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(226, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(230, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "完成輸入後請按Enter切換下一筆...";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.progressLabel2);
            this.panel2.Controls.Add(this.progressLabel1);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(14, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(759, 522);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.timesTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.startButton);
            this.panel3.Enabled = false;
            this.panel3.Location = new System.Drawing.Point(27, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(697, 78);
            this.panel3.TabIndex = 7;
            // 
            // timesTextBox
            // 
            this.timesTextBox.Location = new System.Drawing.Point(133, 26);
            this.timesTextBox.Name = "timesTextBox";
            this.timesTextBox.Size = new System.Drawing.Size(34, 25);
            this.timesTextBox.TabIndex = 8;
            this.timesTextBox.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "重複驗證次數:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(526, 9);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(140, 54);
            this.startButton.TabIndex = 11;
            this.startButton.Text = "開始標記";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // progressLabel2
            // 
            this.progressLabel2.AutoSize = true;
            this.progressLabel2.Location = new System.Drawing.Point(29, 490);
            this.progressLabel2.Name = "progressLabel2";
            this.progressLabel2.Size = new System.Drawing.Size(231, 15);
            this.progressLabel2.TabIndex = 13;
            this.progressLabel2.Text = "共要標記0次，目前正標記到第0次";
            // 
            // progressLabel1
            // 
            this.progressLabel1.AutoSize = true;
            this.progressLabel1.Location = new System.Drawing.Point(29, 465);
            this.progressLabel1.Name = "progressLabel1";
            this.progressLabel1.Size = new System.Drawing.Size(186, 15);
            this.progressLabel1.TabIndex = 12;
            this.progressLabel1.Text = "共0張，目前正處理到第0張";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(32, 414);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(687, 38);
            this.progressBar1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 612);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.folderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Captcha label tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFolderToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox folderTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox captchaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label progressLabel2;
        private System.Windows.Forms.Label progressLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox timesTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button backButton;
    }
}

