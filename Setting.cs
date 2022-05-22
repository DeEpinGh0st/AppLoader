using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Reflection;

namespace AppLoader
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private static string appPath = Directory.GetCurrentDirectory();
        private static string configPath = Path.Combine(appPath, "config.ini");
        private void Setting_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text += " Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                OperateIniFile.SetFilePath(configPath);
                runApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void JavaBroBtn_Click(object sender, EventArgs e)
        {
            //设置工作目录
            FileDialog.InitialDirectory = appPath;
            //设置选中exe格式文件
            FileDialog.FilterIndex = 1;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                JavatextBox.Text = FileDialog.FileName;
            }
        }

        private void AppBroBtn_Click(object sender, EventArgs e)
        {
            //设置工作目录
            FileDialog.InitialDirectory = appPath;
            //设置选中jar格式文件
            FileDialog.FilterIndex = 2;
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                ApptextBox.Text = FileDialog.FileName;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveConfig();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LaunchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                saveConfig();
                runApp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region 判断SettinggroupBox-TextBox是否为空
        private bool TextBoxCheckIsNull()
        {
            bool flag = true;
            foreach (Control control in this.SettinggroupBox.Controls)
            {
                if (control is TextBox)
                {
                    if (string.IsNullOrEmpty((control as TextBox).Text))
                    {
                        flag = false;
                        break;
                    }
                }
            }
            return flag;
        }
        #endregion

        private void runApp()
        {
            if (File.Exists(configPath) && new FileInfo(configPath).Length > 0)
            {
                List<string> keys = OperateIniFile.ReadKeys("setting");
                Dictionary<string, string> values = new Dictionary<string, string>();
                foreach (var key in keys)
                {
                    values.Add(key, OperateIniFile.ReadIniData("setting", key, ""));
                }
                Process process = new Process();
                process.StartInfo.RedirectStandardError = true;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.FileName = values["loader"];
                process.StartInfo.Arguments = " " + values["arg"] + " " + values["app"];
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(values["app"]);
                if (Convert.ToBoolean(values["hidden"]))
                {
                    process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process.StartInfo.CreateNoWindow = true;
                }
                process.Start();
                if (process.HasExited)
                {
                    string info = process.StandardError.ReadToEnd();
                    File.WriteAllText("error.log", info);
                    MessageBox.Show("启动失败,请查看日志文件");
                    return;
                }
                Application.Exit();
            }
        }

        private void saveConfig()
        {
            if (!TextBoxCheckIsNull())
            {
                MessageBox.Show("参数不完整!");
                return;
            }
            OperateIniFile.WriteIniData("setting", "loader", JavatextBox.Text);
            OperateIniFile.WriteIniData("setting", "arg", ArgtextBox.Text);
            OperateIniFile.WriteIniData("setting", "app", ApptextBox.Text);
            OperateIniFile.WriteIniData("setting", "hidden", HiddencheckBox.Checked.ToString());
            MessageBox.Show("保存成功");
        }
    }
}
