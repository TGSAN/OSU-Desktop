using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Management;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OSUDesktop
{
    public partial class Form1 : Form
    {

        /*
        作者：TGSAN
        GITHUB：https://github.com/TGSAN
        License：此程序按照GPLv2协议开源
        若需要使用本程序源码，请保留License和作者信息，谢谢~
        */

        [Flags]
        public enum SendMessageTimeoutFlags : uint
        {
            SMTO_NORMAL = 0x0,
            SMTO_BLOCK = 0x1,
            SMTO_ABORTIFHUNG = 0x2,
            SMTO_NOTIMEOUTIFNOTHUNG = 0x8,
            SMTO_ERRORONEXIT = 0x20
        }

        internal const uint GW_OWNER = 4;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow([MarshalAs(UnmanagedType.LPTStr)] string lpClassName, [MarshalAs(UnmanagedType.LPTStr)] string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern int GetWindowThreadProcessId(IntPtr hWnd, out IntPtr lpdwProcessId);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        internal static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern int SendMessage(IntPtr hWnd, int msg, uint wParam, uint lParam);

        [DllImport("user32")]
        private static extern IntPtr FindWindowEx(IntPtr hWnd1, IntPtr hWnd2, string lpsz1, string lpsz2);

        [DllImport("user32.dll")]
        public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern IntPtr SendMessageTimeout(IntPtr windowHandle, uint Msg, IntPtr wParam, IntPtr lParam, SendMessageTimeoutFlags flags, uint timeout, out IntPtr result);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);
        public delegate bool EnumWindowsProc(IntPtr hwnd, IntPtr lParam);

        public Form1()
        {
            InitializeComponent();
        }

        private void StartOSU_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // 显示选取对话框
        }

        public static System.Diagnostics.Process p; // 定义进程p

        StartMode cmode;

        enum StartMode
        {
            ModeA, // 兼容模式
            ModeB, // 传统模式
        }

        int ModeA_PID = 0;
        string ModeA_Name = "";

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            MessageBox.Show("请先将游戏设置为无边框窗口全屏，然后在系统托盘设置壁纸即可~");
            cmode = StartMode.ModeB;
            p = System.Diagnostics.Process.Start(openFileDialog1.FileName); // 在进程p上运行OSU!
            Hide(); // 隐藏窗口
            notifyIcon1.Visible = true; // 显示托盘图标
        }

        public static Boolean winseven = false;

        IntPtr WorkerWIntPtr = fWorker(); // 定义句柄并设置为桌面WorkerW的句柄

        private void Form1_Load(object sender, EventArgs e)
        {
            // 系统检测
            Version currentVersion = Environment.OSVersion.Version;
            Version compareToVersion = new Version("6.2");
            if (currentVersion.CompareTo(compareToVersion) >= 0)
            {
                Console.WriteLine("当前系统是WIN8及以上版本系统。");
                winseven = false;
            }
            else
            {
                Console.WriteLine("当前系统不是WIN8及以上版本系统。");
                winseven = true;
            }
            // 冲突检测，是否运行了Teamviewer等程序导致桌面句柄消失
            if (WorkerWIntPtr.ToString() == "0")
            {
                MessageBox.Show("检测到桌面环境异常，请检查是否正在运行冲突的程序");
                Close();
            }
            else
            {
                Console.WriteLine("桌面句柄：" + WorkerWIntPtr.ToString());
            }
        }

        public static IntPtr fWorker()
        {

            IntPtr workerw = IntPtr.Zero;

            IntPtr progman = FindWindow("Progman", null);

            IntPtr result = IntPtr.Zero;

            SendMessageTimeout(progman,
                       0x052C,//用户码
                       new IntPtr(0),
                       IntPtr.Zero,
                       SendMessageTimeoutFlags.SMTO_NORMAL,
                       1000,
                       out result);

            if (winseven)
            {
                // 如果Win7则选定Progman的Program Manager（貌似不可行？）
                workerw = FindWindow("Progman", null);
            }
            else
            {
                EnumWindows(new EnumWindowsProc((tophandle, topparamhandle) =>
                {
                    IntPtr p = FindWindowEx(tophandle,
                                                IntPtr.Zero,
                                                "SHELLDLL_DefView",
                                                null);
                    if (p != IntPtr.Zero)
                    {
                        workerw = FindWindowEx(IntPtr.Zero,
                                                   tophandle,
                                                   "WorkerW",
                                                   null);
                    }
                    return true;
                }), IntPtr.Zero);
            }
            return workerw;
        }

        private List<int> GetPIDByPName(string processName)
        {
            List<int> list = new List<int>();
            using (ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(string.Format("select Handle from Win32_Process where Name='{0}'", processName)))
            {
                using (ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get())
                {
                    foreach (ManagementBaseObject managementBaseObject in managementObjectCollection)
                    {
                        ManagementObject managementObject = (ManagementObject)managementBaseObject;
                        int pid;
                        Int32.TryParse(managementObject["Handle"].ToString(), out pid);
                        list.Add(pid);
                    }
                }
            }
            return list;
            // Console.WriteLine(list[0]);
        }

        public static IntPtr GetMainWindowHandle(int processId)
        {
            IntPtr MainWindowHandle = IntPtr.Zero;
            EnumWindows(new EnumWindowsProc((hWnd, lParam) =>
            {
                IntPtr PID;
                GetWindowThreadProcessId(hWnd, out PID);
                Console.WriteLine("Pid: {0}, hWnd: {1}", PID, hWnd);
                if (PID == lParam &&
                    IsWindowVisible(hWnd) &&
                    GetWindow(hWnd, GW_OWNER) == IntPtr.Zero)
                {
                    MainWindowHandle = hWnd;
                    return false;
                }
                return true;
            }), new IntPtr(processId));
            Console.WriteLine("hWnd is " + MainWindowHandle.ToString() + " in " + processId.ToString());
            return MainWindowHandle;
        }

        private static void KillProcessAndChildren(int pid)
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher
              ("Select * From Win32_Process Where ParentProcessID=" + pid);
            ManagementObjectCollection moc = searcher.Get();
            foreach (ManagementObject mo in moc)
            {
                KillProcessAndChildren(Convert.ToInt32(mo["ProcessID"]));
            }
            try
            {
                Process proc = Process.GetProcessById(pid);
                proc.Kill();
            }
            catch (ArgumentException)
            {
                // Process already exited.
            }
        }

        private void AsWallpaperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetParent(p.MainWindowHandle, WorkerWIntPtr); // 设置父窗体为桌面（注入WorkerW）
        }

        public const int WM_CLOSE = 0x10;
        // ExitWindows函数

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendMessage(p.MainWindowHandle, WM_CLOSE, 0, 0); // 先关闭OSU!
            Application.Exit(); // 然后关闭辅助程序
            // GetMainWindowHandle(ModeA_PID);
        }

        private void ReShowOSUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetParent(p.MainWindowHandle, IntPtr.Zero); // 重置OSU!的父窗体为零指针，使其重新独立
        }

        private void StartCheckBtn_Click(object sender, EventArgs e)
        {
            ModeA_Name = progNameBox.Text;
            progNameBox.Enabled = false;
            StartCheckBtn.Enabled = false;
            StartCheckBtn.Text = "正在等待游戏启动";
            StartOSU.Enabled = false;
            checkTimer.Enabled = true;
        }

        private void CheckTimer_Tick(object sender, EventArgs e)
        {
            if (GetPIDByPName("MuseDash.exe").Count > 0)
            {
                checkTimer.Enabled = false;
                MessageBox.Show("请先将游戏设置为无边框窗口全屏，然后在系统托盘设置壁纸即可~");
                cmode = StartMode.ModeA;
                ModeA_PID = GetPIDByPName(ModeA_Name)[0];
                p = Process.GetProcessById(ModeA_PID);
                Hide(); // 隐藏窗口
                notifyIcon1.Visible = true; // 显示托盘图标
            }
        }
    }
}
