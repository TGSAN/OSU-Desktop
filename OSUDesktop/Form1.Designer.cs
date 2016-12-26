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
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AsWallpaperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReShowOSUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartOSU
            // 
            this.StartOSU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StartOSU.Location = new System.Drawing.Point(0, 0);
            this.StartOSU.Name = "StartOSU";
            this.StartOSU.Size = new System.Drawing.Size(227, 70);
            this.StartOSU.TabIndex = 0;
            this.StartOSU.Text = "启动";
            this.StartOSU.UseVisualStyleBackColor = true;
            this.StartOSU.Click += new System.EventHandler(this.StartOSU_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "OSU!主程序|osu!.exe";
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 92);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // AsWallpaperToolStripMenuItem
            // 
            this.AsWallpaperToolStripMenuItem.Name = "AsWallpaperToolStripMenuItem";
            this.AsWallpaperToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.AsWallpaperToolStripMenuItem.Text = "设置壁纸";
            this.AsWallpaperToolStripMenuItem.Click += new System.EventHandler(this.AsWallpaperToolStripMenuItem_Click);
            // 
            // ReShowOSUToolStripMenuItem
            // 
            this.ReShowOSUToolStripMenuItem.Name = "ReShowOSUToolStripMenuItem";
            this.ReShowOSUToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ReShowOSUToolStripMenuItem.Text = "还原OSU!";
            this.ReShowOSUToolStripMenuItem.Click += new System.EventHandler(this.ReShowOSUToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 70);
            this.Controls.Add(this.StartOSU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "OSU!Desktop";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartOSU;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AsWallpaperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReShowOSUToolStripMenuItem;
    }
}

