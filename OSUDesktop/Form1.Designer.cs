namespace OSUDesktop
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartOSU = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReShowOSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infolabel2 = new System.Windows.Forms.Label();
            this.infolabel1 = new System.Windows.Forms.Label();
            this.StartCheckBtn = new System.Windows.Forms.Button();
            this.progNameBox = new System.Windows.Forms.TextBox();
            this.checkTimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartOSU
            // 
            this.StartOSU.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartOSU.Location = new System.Drawing.Point(12, 166);
            this.StartOSU.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartOSU.Name = "StartOSU";
            this.StartOSU.Size = new System.Drawing.Size(415, 51);
            this.StartOSU.TabIndex = 0;
            this.StartOSU.Text = "启动进程";
            this.StartOSU.UseVisualStyleBackColor = true;
            this.StartOSU.Click += new System.EventHandler(this.StartOSU_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "MuseDash主程序|MuseDash.exe|OSU!主程序|osu!.exe";
            this.openFileDialog1.Title = "请选择OSU!主程序";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "OSU!Desktop";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReShowOSUToolStripMenuItem,
            this.AsWallpaperToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(131, 70);
            // 
            // ReShowOSUToolStripMenuItem
            // 
            this.ReShowOSUToolStripMenuItem.Name = "ReShowOSUToolStripMenuItem";
            this.ReShowOSUToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ReShowOSUToolStripMenuItem.Text = "还原OSU!";
            this.ReShowOSUToolStripMenuItem.Click += new System.EventHandler(this.ReShowOSUToolStripMenuItem_Click);
            // 
            // AsWallpaperToolStripMenuItem
            // 
            this.AsWallpaperToolStripMenuItem.Name = "AsWallpaperToolStripMenuItem";
            this.AsWallpaperToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.AsWallpaperToolStripMenuItem.Text = "设置壁纸";
            this.AsWallpaperToolStripMenuItem.Click += new System.EventHandler(this.AsWallpaperToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // infolabel2
            // 
            this.infolabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infolabel2.AutoSize = true;
            this.infolabel2.Location = new System.Drawing.Point(12, 145);
            this.infolabel2.Name = "infolabel2";
            this.infolabel2.Size = new System.Drawing.Size(332, 17);
            this.infolabel2.TabIndex = 1;
            this.infolabel2.Text = "传统模式：通过下方按钮启动游戏（不兼容游戏平台的游戏）";
            // 
            // infolabel1
            // 
            this.infolabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.infolabel1.Location = new System.Drawing.Point(12, 9);
            this.infolabel1.Name = "infolabel1";
            this.infolabel1.Size = new System.Drawing.Size(415, 39);
            this.infolabel1.TabIndex = 2;
            this.infolabel1.Text = "兼容模式：填入游戏进程文件名，手动启动游戏后，点击“检测”按钮开始检测并自动开始";
            // 
            // StartCheckBtn
            // 
            this.StartCheckBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartCheckBtn.Location = new System.Drawing.Point(12, 81);
            this.StartCheckBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartCheckBtn.Name = "StartCheckBtn";
            this.StartCheckBtn.Size = new System.Drawing.Size(415, 51);
            this.StartCheckBtn.TabIndex = 3;
            this.StartCheckBtn.Text = "检测";
            this.StartCheckBtn.UseVisualStyleBackColor = true;
            this.StartCheckBtn.Click += new System.EventHandler(this.StartCheckBtn_Click);
            // 
            // progNameBox
            // 
            this.progNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progNameBox.Location = new System.Drawing.Point(12, 51);
            this.progNameBox.Name = "progNameBox";
            this.progNameBox.Size = new System.Drawing.Size(415, 23);
            this.progNameBox.TabIndex = 4;
            this.progNameBox.Text = "MuseDash.exe";
            // 
            // checkTimer
            // 
            this.checkTimer.Interval = 1000;
            this.checkTimer.Tick += new System.EventHandler(this.CheckTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 230);
            this.Controls.Add(this.progNameBox);
            this.Controls.Add(this.StartCheckBtn);
            this.Controls.Add(this.infolabel1);
            this.Controls.Add(this.infolabel2);
            this.Controls.Add(this.StartOSU);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "OSU!Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartOSU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AsWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReShowOSUToolStripMenuItem;
        private System.Windows.Forms.Label infolabel2;
        private System.Windows.Forms.Label infolabel1;
        private System.Windows.Forms.Button StartCheckBtn;
        private System.Windows.Forms.TextBox progNameBox;
        private System.Windows.Forms.Timer checkTimer;
    }
}

