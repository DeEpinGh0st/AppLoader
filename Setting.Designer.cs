namespace AppLoader
{
    partial class Setting
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.SettinggroupBox = new System.Windows.Forms.GroupBox();
            this.AppBroBtn = new System.Windows.Forms.Button();
            this.JavaBroBtn = new System.Windows.Forms.Button();
            this.HiddencheckBox = new System.Windows.Forms.CheckBox();
            this.ApptextBox = new System.Windows.Forms.TextBox();
            this.ArgtextBox = new System.Windows.Forms.TextBox();
            this.JavatextBox = new System.Windows.Forms.TextBox();
            this.Hiddenlabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.LaunchBtn = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectJdk_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Arg_comboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ToolKitcheckBox = new System.Windows.Forms.CheckBox();
            this.isToolkit_label = new System.Windows.Forms.Label();
            this.SettinggroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettinggroupBox
            // 
            this.SettinggroupBox.Controls.Add(this.isToolkit_label);
            this.SettinggroupBox.Controls.Add(this.ToolKitcheckBox);
            this.SettinggroupBox.Controls.Add(this.Arg_comboBox);
            this.SettinggroupBox.Controls.Add(this.label6);
            this.SettinggroupBox.Controls.Add(this.label5);
            this.SettinggroupBox.Controls.Add(this.SelectJdk_comboBox);
            this.SettinggroupBox.Controls.Add(this.AppBroBtn);
            this.SettinggroupBox.Controls.Add(this.JavaBroBtn);
            this.SettinggroupBox.Controls.Add(this.HiddencheckBox);
            this.SettinggroupBox.Controls.Add(this.ApptextBox);
            this.SettinggroupBox.Controls.Add(this.ArgtextBox);
            this.SettinggroupBox.Controls.Add(this.JavatextBox);
            this.SettinggroupBox.Controls.Add(this.Hiddenlabel);
            this.SettinggroupBox.Controls.Add(this.label3);
            this.SettinggroupBox.Controls.Add(this.label2);
            this.SettinggroupBox.Controls.Add(this.label1);
            this.SettinggroupBox.Location = new System.Drawing.Point(13, 13);
            this.SettinggroupBox.Name = "SettinggroupBox";
            this.SettinggroupBox.Size = new System.Drawing.Size(387, 271);
            this.SettinggroupBox.TabIndex = 0;
            this.SettinggroupBox.TabStop = false;
            this.SettinggroupBox.Text = "设置";
            // 
            // AppBroBtn
            // 
            this.AppBroBtn.Location = new System.Drawing.Point(324, 195);
            this.AppBroBtn.Name = "AppBroBtn";
            this.AppBroBtn.Size = new System.Drawing.Size(42, 23);
            this.AppBroBtn.TabIndex = 8;
            this.AppBroBtn.Text = "...";
            this.AppBroBtn.UseVisualStyleBackColor = true;
            this.AppBroBtn.Click += new System.EventHandler(this.AppBroBtn_Click);
            // 
            // JavaBroBtn
            // 
            this.JavaBroBtn.Enabled = false;
            this.JavaBroBtn.Location = new System.Drawing.Point(325, 20);
            this.JavaBroBtn.Name = "JavaBroBtn";
            this.JavaBroBtn.Size = new System.Drawing.Size(42, 23);
            this.JavaBroBtn.TabIndex = 8;
            this.JavaBroBtn.Text = "...";
            this.JavaBroBtn.UseVisualStyleBackColor = true;
            this.JavaBroBtn.Click += new System.EventHandler(this.JavaBroBtn_Click);
            // 
            // HiddencheckBox
            // 
            this.HiddencheckBox.AutoSize = true;
            this.HiddencheckBox.Location = new System.Drawing.Point(149, 237);
            this.HiddencheckBox.Name = "HiddencheckBox";
            this.HiddencheckBox.Size = new System.Drawing.Size(15, 14);
            this.HiddencheckBox.TabIndex = 7;
            this.HiddencheckBox.UseVisualStyleBackColor = true;
            // 
            // ApptextBox
            // 
            this.ApptextBox.Location = new System.Drawing.Point(67, 196);
            this.ApptextBox.Name = "ApptextBox";
            this.ApptextBox.Size = new System.Drawing.Size(251, 21);
            this.ApptextBox.TabIndex = 6;
            // 
            // ArgtextBox
            // 
            this.ArgtextBox.Location = new System.Drawing.Point(67, 130);
            this.ArgtextBox.Multiline = true;
            this.ArgtextBox.Name = "ArgtextBox";
            this.ArgtextBox.ReadOnly = true;
            this.ArgtextBox.Size = new System.Drawing.Size(251, 50);
            this.ArgtextBox.TabIndex = 5;
            // 
            // JavatextBox
            // 
            this.JavatextBox.Location = new System.Drawing.Point(67, 57);
            this.JavatextBox.Name = "JavatextBox";
            this.JavatextBox.ReadOnly = true;
            this.JavatextBox.Size = new System.Drawing.Size(299, 21);
            this.JavatextBox.TabIndex = 4;
            // 
            // Hiddenlabel
            // 
            this.Hiddenlabel.AutoSize = true;
            this.Hiddenlabel.Location = new System.Drawing.Point(83, 237);
            this.Hiddenlabel.Name = "Hiddenlabel";
            this.Hiddenlabel.Size = new System.Drawing.Size(65, 12);
            this.Hiddenlabel.TabIndex = 3;
            this.Hiddenlabel.Text = "隐藏窗口: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "启动程序: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "启动参数: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "加载器: ";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(32, 298);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(108, 35);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "仅保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // LaunchBtn
            // 
            this.LaunchBtn.Location = new System.Drawing.Point(223, 298);
            this.LaunchBtn.Name = "LaunchBtn";
            this.LaunchBtn.Size = new System.Drawing.Size(108, 35);
            this.LaunchBtn.TabIndex = 1;
            this.LaunchBtn.Text = "保存&&启动";
            this.LaunchBtn.UseVisualStyleBackColor = true;
            this.LaunchBtn.Click += new System.EventHandler(this.LaunchBtn_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "应用程序|*.exe|Jar程序|*.jar";
            // 
            // SelectJdk_comboBox
            // 
            this.SelectJdk_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectJdk_comboBox.FormattingEnabled = true;
            this.SelectJdk_comboBox.Items.AddRange(new object[] {
            "ToolKit-JDK8",
            "ToolKit-JDK11",
            "自定义"});
            this.SelectJdk_comboBox.Location = new System.Drawing.Point(67, 21);
            this.SelectJdk_comboBox.Name = "SelectJdk_comboBox";
            this.SelectJdk_comboBox.Size = new System.Drawing.Size(251, 20);
            this.SelectJdk_comboBox.TabIndex = 2;
            this.SelectJdk_comboBox.SelectedIndexChanged += new System.EventHandler(this.SelectJdk_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "配置值: ";
            // 
            // Arg_comboBox
            // 
            this.Arg_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Arg_comboBox.FormattingEnabled = true;
            this.Arg_comboBox.Items.AddRange(new object[] {
            "启动jar文件",
            "启动jar文件(UTF-8)",
            "启动CobaltStrike",
            "自定义"});
            this.Arg_comboBox.Location = new System.Drawing.Point(67, 94);
            this.Arg_comboBox.Name = "Arg_comboBox";
            this.Arg_comboBox.Size = new System.Drawing.Size(251, 20);
            this.Arg_comboBox.TabIndex = 12;
            this.Arg_comboBox.SelectedIndexChanged += new System.EventHandler(this.Arg_comboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "配置值: ";
            // 
            // ToolKitcheckBox
            // 
            this.ToolKitcheckBox.AutoSize = true;
            this.ToolKitcheckBox.Location = new System.Drawing.Point(277, 237);
            this.ToolKitcheckBox.Name = "ToolKitcheckBox";
            this.ToolKitcheckBox.Size = new System.Drawing.Size(15, 14);
            this.ToolKitcheckBox.TabIndex = 13;
            this.ToolKitcheckBox.UseVisualStyleBackColor = true;
            // 
            // isToolkit_label
            // 
            this.isToolkit_label.AutoSize = true;
            this.isToolkit_label.ForeColor = System.Drawing.Color.Red;
            this.isToolkit_label.Location = new System.Drawing.Point(199, 237);
            this.isToolkit_label.Name = "isToolkit_label";
            this.isToolkit_label.Size = new System.Drawing.Size(77, 12);
            this.isToolkit_label.TabIndex = 14;
            this.isToolkit_label.Text = "工具包模式: ";
            this.isToolkit_label.MouseHover += new System.EventHandler(this.isToolkit_label_MouseHover);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 354);
            this.Controls.Add(this.LaunchBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.SettinggroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(437, 393);
            this.MinimumSize = new System.Drawing.Size(437, 311);
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "启动参数设置";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.SettinggroupBox.ResumeLayout(false);
            this.SettinggroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SettinggroupBox;
        private System.Windows.Forms.Button AppBroBtn;
        private System.Windows.Forms.Button JavaBroBtn;
        private System.Windows.Forms.CheckBox HiddencheckBox;
        private System.Windows.Forms.TextBox ApptextBox;
        private System.Windows.Forms.TextBox ArgtextBox;
        private System.Windows.Forms.TextBox JavatextBox;
        private System.Windows.Forms.Label Hiddenlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button LaunchBtn;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.ComboBox SelectJdk_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Arg_comboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label isToolkit_label;
        private System.Windows.Forms.CheckBox ToolKitcheckBox;
    }
}

