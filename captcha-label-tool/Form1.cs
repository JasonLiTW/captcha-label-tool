using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace captcha_label_tool
{

    public partial class Form1 : Form
    {
        string[] captchaArr; //標記答案
        string[] files; //檔案路徑
        string folderPath;
        int pmax = 0, pnow = 0; //檔案進度
        int tmax = 1, tnow = 1; //驗證次數進度
        bool hasError = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.Description = "選擇存放要標記的圖片的資料夾...";

            if(folderDialog.ShowDialog() == DialogResult.OK)
            {
                progressBar1.Value = 0;
                folderPath = folderDialog.SelectedPath;
                folderTextBox.Text = folderPath;
                files = Directory.GetFiles(folderPath, "*.jpg");
                if (files.Length >= 0)
                {
                    panel1.Enabled = false;
                    panel2.Enabled = true;
                    panel3.Enabled = true;
                    pnow = 1;
                    pmax = files.Length;
                    pictureBox1.Image = Image.FromFile(files[0]);
                    SetProgressLabel();
                    captchaArr = new string[files.Length];
                }
                else
                {
                    MessageBox.Show("Folder is empty.... (*.jpg)");
                    panel1.Enabled = false;
                    panel2.Enabled = false;
                    panel3.Enabled = false;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            bool checkOK;
            try
            {
                tmax = Convert.ToInt32(timesTextBox.Text) + 1;
                checkOK = true;
            }
            catch {checkOK = false; }
                

            if(checkOK && tmax >= 1)
            {
                tnow = 1;
                progressBar1.Maximum = pmax * tmax;
                SetTimeLabel();
                panel1.Enabled = true;
                panel3.Enabled = false;
                captchaTextBox.Focus();
            }
            else
            {
                MessageBox.Show("重複輸入次數值至少要為0或以上");
                timesTextBox.Text = "0";
            }
        }

        private void CaptchaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // 限制只能輸入英文&數字
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') | (e.KeyChar >= 'A' && e.KeyChar <= 'Z') | (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == 8))
                e.Handled = true;
        }

        private void CaptchaTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(captchaTextBox.Text.Length >= 5)
                {
                    captchaTextBox.Text = captchaTextBox.Text.ToUpper();
                    if(CheckSaveCaptcha())
                    {
                        SwitchToNextPic();
                        progressBar1.Value++;
                    }
                    else
                        MessageBox.Show("你輸入的跟前一次不同，請檢查後再送出確認的答案，答案將以這次送出的為主。");
                }
                else
                    MessageBox.Show("驗證碼至少有5字");
            }
        }

        void SetProgressLabel()
        {
            progressLabel1.Text = "共" + pmax.ToString() + "張，目前正處理到第" + pnow.ToString() + "張";
        }

        void SetTimeLabel()
        {
            progressLabel2.Text = "共要標記" + tmax.ToString() + "次，目前正標記到第" + tnow.ToString() + "次";
        }

        void SwitchToNextPic()
        {
            hasError = false;
            if(pnow == pmax)
            {
                if (tnow != tmax)
                    SwitchToNextTime(); //尚未結束，進行下一次驗證
                else
                    SaveToCsv(); //完成，儲存
            }
            else
            {
                //未完成 切下一張圖
                pnow++;
                SetProgressLabel();
                pictureBox1.Image = Image.FromFile(files[pnow - 1]);
                captchaTextBox.Text = "";
                captchaTextBox.Focus();
            }
        }
        
        void SwitchToNextTime()
        {
            tnow++;
            pnow = 1;
            pictureBox1.Image = Image.FromFile(files[0]);
            SetTimeLabel();
            SetProgressLabel();
            captchaTextBox.Text = "";
            captchaTextBox.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (pnow != 1)
            {
                pnow -= 2;
                SwitchToNextPic();
            }
            else
                MessageBox.Show("無法在第一張往前...");
        }

        bool CheckSaveCaptcha()
        {
            if (tnow == 1)
            {
                captchaArr[pnow - 1] = captchaTextBox.Text;
                return true;
            }
            else
            {
                if (captchaTextBox.Text == captchaArr[pnow - 1])
                    return true;
                else if (hasError)
                {
                    hasError = false;
                    captchaArr[pnow - 1] = captchaTextBox.Text;
                    return true;
                }
                else
                {
                    hasError = true;
                    return false;
                }
            }
        }
        
        void SaveToCsv()
        {
            while(true)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "csv(*.csv)|";
                saveFileDialog.FileName = "validate.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                    for(int i = 0; i < files.Length; i++)
                    {
                        string[] s = files[i].Split('\\');
                        string filename = s[s.Length - 1];
                        filename = filename.Substring(0, filename.Length - 4);
                        streamWriter.WriteLine(filename + "," + captchaArr[i]);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Finished!");
                    this.Dispose();
                    break;
                }
            }
        }
    }
}
