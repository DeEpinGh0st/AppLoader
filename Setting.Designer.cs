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
            SettinggroupBox = new System.Windows.Forms.GroupBox();
            isToolkit_label = new System.Windows.Forms.Label();
            ToolKitcheckBox = new System.Windows.Forms.CheckBox();
            Arg_comboBox = new System.Windows.Forms.ComboBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            SelectJdk_comboBox = new System.Windows.Forms.ComboBox();
            AppBroBtn = new System.Windows.Forms.Button();
            JavaBroBtn = new System.Windows.Forms.Button();
            HiddencheckBox = new System.Windows.Forms.CheckBox();
            ApptextBox = new System.Windows.Forms.TextBox();
            ArgtextBox = new System.Windows.Forms.TextBox();
            JavatextBox = new System.Windows.Forms.TextBox();
            Hiddenlabel = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            SaveBtn = new System.Windows.Forms.Button();
            LaunchBtn = new System.Windows.Forms.Button();
            FileDialog = new System.Windows.Forms.OpenFileDialog();
            SettinggroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SettinggroupBox
            // 
            SettinggroupBox.Controls.Add(isToolkit_label);
            SettinggroupBox.Controls.Add(ToolKitcheckBox);
            SettinggroupBox.Controls.Add(Arg_comboBox);
            SettinggroupBox.Controls.Add(label6);
            SettinggroupBox.Controls.Add(label5);
            SettinggroupBox.Controls.Add(SelectJdk_comboBox);
            SettinggroupBox.Controls.Add(AppBroBtn);
            SettinggroupBox.Controls.Add(JavaBroBtn);
            SettinggroupBox.Controls.Add(HiddencheckBox);
            SettinggroupBox.Controls.Add(ApptextBox);
            SettinggroupBox.Controls.Add(ArgtextBox);
            SettinggroupBox.Controls.Add(JavatextBox);
            SettinggroupBox.Controls.Add(Hiddenlabel);
            SettinggroupBox.Controls.Add(label3);
            SettinggroupBox.Controls.Add(label2);
            SettinggroupBox.Controls.Add(label1);
            SettinggroupBox.Location = new System.Drawing.Point(15, 18);
            SettinggroupBox.Margin = new System.Windows.Forms.Padding(4);
            SettinggroupBox.Name = "SettinggroupBox";
            SettinggroupBox.Padding = new System.Windows.Forms.Padding(4);
            SettinggroupBox.Size = new System.Drawing.Size(451, 384);
            SettinggroupBox.TabIndex = 0;
            SettinggroupBox.TabStop = false;
            SettinggroupBox.Text = "设置";
            // 
            // isToolkit_label
            // 
            isToolkit_label.AutoSize = true;
            isToolkit_label.ForeColor = System.Drawing.Color.Red;
            isToolkit_label.Location = new System.Drawing.Point(232, 346);
            isToolkit_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            isToolkit_label.Name = "isToolkit_label";
            isToolkit_label.Size = new System.Drawing.Size(75, 17);
            isToolkit_label.TabIndex = 14;
            isToolkit_label.Text = "工具包模式: ";
            isToolkit_label.MouseHover += isToolkit_label_MouseHover;
            // 
            // ToolKitcheckBox
            // 
            ToolKitcheckBox.AutoSize = true;
            ToolKitcheckBox.Location = new System.Drawing.Point(317, 349);
            ToolKitcheckBox.Margin = new System.Windows.Forms.Padding(4);
            ToolKitcheckBox.Name = "ToolKitcheckBox";
            ToolKitcheckBox.Size = new System.Drawing.Size(15, 14);
            ToolKitcheckBox.TabIndex = 13;
            ToolKitcheckBox.UseVisualStyleBackColor = true;
            // 
            // Arg_comboBox
            // 
            Arg_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            Arg_comboBox.FormattingEnabled = true;
            Arg_comboBox.Items.AddRange(new object[] { "启动jar文件", "启动jar文件(UTF-8)", "启动带javagent的jar文件", "启动CobaltStrike", "自定义" });
            Arg_comboBox.Location = new System.Drawing.Point(78, 116);
            Arg_comboBox.Margin = new System.Windows.Forms.Padding(4);
            Arg_comboBox.Name = "Arg_comboBox";
            Arg_comboBox.Size = new System.Drawing.Size(350, 25);
            Arg_comboBox.TabIndex = 12;
            Arg_comboBox.SelectedIndexChanged += Arg_comboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(24, 210);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(51, 17);
            label6.TabIndex = 11;
            label6.Text = "参数值: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(2, 78);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(75, 17);
            label5.TabIndex = 11;
            label5.Text = "运行时路径: ";
            // 
            // SelectJdk_comboBox
            // 
            SelectJdk_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            SelectJdk_comboBox.FormattingEnabled = true;
            SelectJdk_comboBox.Items.AddRange(new object[] { "ToolKit-JRE8", "ToolKit-JRE17-Openjfx", "自定义" });
            SelectJdk_comboBox.Location = new System.Drawing.Point(78, 30);
            SelectJdk_comboBox.Margin = new System.Windows.Forms.Padding(4);
            SelectJdk_comboBox.Name = "SelectJdk_comboBox";
            SelectJdk_comboBox.Size = new System.Drawing.Size(292, 25);
            SelectJdk_comboBox.TabIndex = 2;
            SelectJdk_comboBox.SelectedIndexChanged += SelectJdk_comboBox_SelectedIndexChanged;
            // 
            // AppBroBtn
            // 
            AppBroBtn.Location = new System.Drawing.Point(378, 296);
            AppBroBtn.Margin = new System.Windows.Forms.Padding(4);
            AppBroBtn.Name = "AppBroBtn";
            AppBroBtn.Size = new System.Drawing.Size(49, 33);
            AppBroBtn.TabIndex = 8;
            AppBroBtn.Text = "...";
            AppBroBtn.UseVisualStyleBackColor = true;
            AppBroBtn.Click += AppBroBtn_Click;
            // 
            // JavaBroBtn
            // 
            JavaBroBtn.Enabled = false;
            JavaBroBtn.Location = new System.Drawing.Point(379, 26);
            JavaBroBtn.Margin = new System.Windows.Forms.Padding(4);
            JavaBroBtn.Name = "JavaBroBtn";
            JavaBroBtn.Size = new System.Drawing.Size(49, 33);
            JavaBroBtn.TabIndex = 8;
            JavaBroBtn.Text = "...";
            JavaBroBtn.UseVisualStyleBackColor = true;
            JavaBroBtn.Click += JavaBroBtn_Click;
            // 
            // HiddencheckBox
            // 
            HiddencheckBox.AutoSize = true;
            HiddencheckBox.Location = new System.Drawing.Point(168, 348);
            HiddencheckBox.Margin = new System.Windows.Forms.Padding(4);
            HiddencheckBox.Name = "HiddencheckBox";
            HiddencheckBox.Size = new System.Drawing.Size(15, 14);
            HiddencheckBox.TabIndex = 7;
            HiddencheckBox.UseVisualStyleBackColor = true;
            // 
            // ApptextBox
            // 
            ApptextBox.Location = new System.Drawing.Point(78, 301);
            ApptextBox.Margin = new System.Windows.Forms.Padding(4);
            ApptextBox.Name = "ApptextBox";
            ApptextBox.Size = new System.Drawing.Size(292, 23);
            ApptextBox.TabIndex = 6;
            // 
            // ArgtextBox
            // 
            ArgtextBox.Location = new System.Drawing.Point(78, 157);
            ArgtextBox.Margin = new System.Windows.Forms.Padding(4);
            ArgtextBox.Multiline = true;
            ArgtextBox.Name = "ArgtextBox";
            ArgtextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            ArgtextBox.Size = new System.Drawing.Size(350, 128);
            ArgtextBox.TabIndex = 5;
            // 
            // JavatextBox
            // 
            JavatextBox.Location = new System.Drawing.Point(78, 75);
            JavatextBox.Margin = new System.Windows.Forms.Padding(4);
            JavatextBox.Name = "JavatextBox";
            JavatextBox.ReadOnly = true;
            JavatextBox.Size = new System.Drawing.Size(348, 23);
            JavatextBox.TabIndex = 4;
            // 
            // Hiddenlabel
            // 
            Hiddenlabel.AutoSize = true;
            Hiddenlabel.Location = new System.Drawing.Point(97, 346);
            Hiddenlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Hiddenlabel.Name = "Hiddenlabel";
            Hiddenlabel.Size = new System.Drawing.Size(63, 17);
            Hiddenlabel.TabIndex = 3;
            Hiddenlabel.Text = "隐藏窗口: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(12, 304);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(63, 17);
            label3.TabIndex = 2;
            label3.Text = "启动程序: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 120);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(63, 17);
            label2.TabIndex = 1;
            label2.Text = "启动类型: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(24, 34);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(51, 17);
            label1.TabIndex = 0;
            label1.Text = "运行时: ";
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new System.Drawing.Point(53, 422);
            SaveBtn.Margin = new System.Windows.Forms.Padding(4);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new System.Drawing.Size(126, 50);
            SaveBtn.TabIndex = 1;
            SaveBtn.Text = "仅保存";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LaunchBtn
            // 
            LaunchBtn.Location = new System.Drawing.Point(276, 422);
            LaunchBtn.Margin = new System.Windows.Forms.Padding(4);
            LaunchBtn.Name = "LaunchBtn";
            LaunchBtn.Size = new System.Drawing.Size(126, 50);
            LaunchBtn.TabIndex = 1;
            LaunchBtn.Text = "保存&&启动";
            LaunchBtn.UseVisualStyleBackColor = true;
            LaunchBtn.Click += LaunchBtn_Click;
            // 
            // FileDialog
            // 
            FileDialog.Filter = "应用程序|*.exe|Jar程序|*.jar";
            // 
            // Setting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(491, 502);
            Controls.Add(LaunchBtn);
            Controls.Add(SaveBtn);
            Controls.Add(SettinggroupBox);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MaximumSize = new System.Drawing.Size(507, 541);
            MinimumSize = new System.Drawing.Size(507, 541);
            Name = "Setting";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "启动参数设置 2025.02.23 .Net 8";
            Load += Setting_Load;
            SettinggroupBox.ResumeLayout(false);
            SettinggroupBox.PerformLayout();
            ResumeLayout(false);
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

