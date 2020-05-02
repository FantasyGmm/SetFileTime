using System;
using System.IO;
using System.Windows.Forms;

namespace SetFileTime
{
    public partial class MainForm : Form
    {
        private string path;
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();
            path = fbd.SelectedPath;
            folderPath.Text = path;
            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("请选择文件夹");
            }else
            {
                seTime.Enabled = true;
                foreach (var fileName in Directory.GetFiles(path))
                {
                    fileBox.Items.Add(Path.GetFileName(fileName));
                }
            }
        }
        private void SetFileTime()
        {

            string Fpath = Path.Combine(path, fileBox.SelectedItem.ToString());
            DateTime dateTime = new DateTime(DateTimeOffset.Now.UtcDateTime.Year, DateTimeOffset.Now.UtcDateTime.Month, DateTimeOffset.Now.UtcDateTime.Day, Convert.ToInt32(hourSet.Value), Convert.ToInt32(minSet.Value), DateTimeOffset.Now.UtcDateTime.Second);
            MessageBox.Show(Fpath);
            FileInfo fileInfo = new FileInfo(Fpath)
            {
                LastWriteTime = dateTime
            };
            if(fileBox.SelectedIndex + 1 < fileBox.Items.Count)
            {
                fileBox.SelectedIndex++;
            }
            LogOut("修改成功");
            LogOut("文件日期:   " + fileInfo.LastAccessTimeUtc);
        }
        private void LogOut(string log)
        {
            logbox.AppendText(log + Environment.NewLine);
        }
        private void SeTime_Click(object sender, EventArgs e)
        {
            if (fileBox.SelectedIndex == -1) return;
            try
            {
                SetFileTime();
            }
            catch(Exception a)
            {
                LogOut("修改失败" + a.Message);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hourSet.Value = DateTimeOffset.Now.Hour;
            minSet.Value = DateTimeOffset.Now.Minute;
        }
    }
}
