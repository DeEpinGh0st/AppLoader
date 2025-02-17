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
                if (File.Exists(configPath))
                {
                    OperateIniFile.SetFilePath(configPath);
                    DialogResult dialogResult =  MessageBox.Show("已存在配置文件,启动(Y)或修改(N)", "提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.No)
                    {
                        JavatextBox.Text = OperateIniFile.ReadIniData("setting", "loader","");
                        ArgtextBox.Text = OperateIniFile.ReadIniData("setting", "arg", "");
                        ApptextBox.Text = OperateIniFile.ReadIniData("setting", "app", "");
                        bool hidden = Convert.ToBoolean(OperateIniFile.ReadIniData("setting", "hidden", ""));
                        if (hidden)
                        {
                            HiddencheckBox.Checked = true;
                        }
                        bool toolkit = Convert.ToBoolean(OperateIniFile.ReadIniData("setting", "toolkit", ""));
                        if (toolkit)
                        {
                            ToolKitcheckBox.Checked = true;
                        }
                        //this.Text += " Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
                        this.Show();
                        return;
                    }
                }
                //this.Text += " Version: " + Assembly.GetExecutingAssembly().GetName().Version.ToString();
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
                process.StartInfo.FileName = values["loader"].Replace("%mp%",appPath);
                process.StartInfo.Arguments = " " + values["arg"] + " " + values["app"];
                process.StartInfo.WorkingDirectory = Path.GetDirectoryName(values["app"]);
                if (Convert.ToBoolean(values["hidden"]))
                {
                    //process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
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
            string loaderBinPath, appBinPath;
            loaderBinPath = JavatextBox.Text;
            appBinPath = ApptextBox.Text;
            if (ToolKitcheckBox.Checked)
            {
                string appRelativePath;
                appRelativePath = loaderBinPath.Substring(loaderBinPath.LastIndexOf("environment"));
                loaderBinPath = "%mp%\\..\\..\\" + appRelativePath;
                appBinPath = appBinPath.Replace(appPath + "\\", "");
            }
            OperateIniFile.WriteIniData("setting", "loader", "\"" + loaderBinPath + "\"");
            OperateIniFile.WriteIniData("setting", "arg", ArgtextBox.Text);
            OperateIniFile.WriteIniData("setting", "app", "\"" + appBinPath + "\"");
            OperateIniFile.WriteIniData("setting", "hidden", HiddencheckBox.Checked.ToString());
            OperateIniFile.WriteIniData("setting", "toolkit", ToolKitcheckBox.Checked.ToString());
            MessageBox.Show("保存成功");
        }

        private void SelectJdk_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            JavatextBox.Text = string.Empty;
            if (SelectJdk_comboBox.SelectedIndex!=1)
            {
                JavatextBox.ReadOnly = true;
                JavaBroBtn.Enabled = false;
            }
            switch (SelectJdk_comboBox.SelectedIndex)
            {
                /*case 0:
                    JavatextBox.Text = @"%mp%\..\..\environment\jdk8\bin\java.exe";
                    break;
                case 1:
                    JavatextBox.Text = @"%mp%\..\..\environment\jdk11\bin\java.exe";
                    break;*/
                case 0:
                    JavatextBox.Text = @"%mp%\..\..\environment\jre17\bin\java.exe";
                    break;
                case 1:
                    JavatextBox.ReadOnly = false;
                    if (!JavaBroBtn.Enabled)
                    {
                        JavaBroBtn.Enabled = true;
                    }
                    break;
                default:
                    break;
            }
        }

        private void Arg_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ArgtextBox.Text = string.Empty;
            /*if (Arg_comboBox.SelectedIndex != 3)
            {
                ArgtextBox.ReadOnly = true;
            }*/
            switch (Arg_comboBox.SelectedIndex)
            {
                case 0:
                    ArgtextBox.Text = @"-jar";
                    break;
                case 1:
                    ArgtextBox.Text = @"-Dfile.encoding=utf-8 -jar";
                    break;
                case 2:
                    ArgtextBox.ReadOnly = false;
                    ArgtextBox.Text = @"-javaagent:  -jar";
                    break;
                case 3:
                    ArgtextBox.Text = @"-Dfile.encoding=utf-8 -XX:ParallelGCThreads=4 -XX:+AggressiveHeap -XX:+UseParallelGC -jar";
                    break;
                case 4:
                    ArgtextBox.ReadOnly = false;
                    break;
                default:
                    break;
            }
        }

        private void isToolkit_label_MouseHover(object sender, EventArgs e)
        {
            string tip = @"如果你是在作者提供的工具包内使用此程序,请勾选此选项";
            ToolTip toolTip = new ToolTip();
            toolTip.ToolTipTitle = "注意";
            toolTip.IsBalloon = true;
            toolTip.SetToolTip(this.isToolkit_label,tip);
        }
    }
}
