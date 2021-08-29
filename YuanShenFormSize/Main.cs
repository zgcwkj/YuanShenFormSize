using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;

namespace YuanShenFormSize
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            FromBindData();
        }

        /// <summary>
        /// 确定修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Ok_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 获取注册表的对象
        /// </summary>
        /// <returns></returns>
        public RegistryKey GetRegistryKey()
        {
            string regeditPath = @"SOFTWARE\miHoYo\原神\";
            RegistryKey key = Registry.CurrentUser;
            RegistryKey software = key.OpenSubKey(regeditPath, true);
            return software;
        }

        /// <summary>
        /// 窗体与绑定注册表
        /// </summary>
        public void FromBindData()
        {
            RegistryKey software = GetRegistryKey();
            var valueNames = software.GetValueNames();
            var modeKey = valueNames.Where(W => W.Contains("Screenmanager Is Fullscreen mode_")).FirstOrDefault();
            if (string.IsNullOrEmpty(modeKey))
            {
                MessageBox.Show("未找到显示类型", "错误");
                this.Close();
            }
            Txt_ShowType.Tag = modeKey;
            Rb_fullScreen.Checked = software.GetValue(Txt_ShowType.Tag.ToString()).ToString() == "1";
            Rb_ShowForm.Checked = software.GetValue(Txt_ShowType.Tag.ToString()).ToString() == "0";
            var heightKey = valueNames.Where(W => W.Contains("Screenmanager Resolution Height_")).FirstOrDefault();
            if (string.IsNullOrEmpty(heightKey))
            {
                MessageBox.Show("未找到显示类型", "错误");
                this.Close();
            }
            Txt_Height.Tag = heightKey;
            Text_Height.Text = software.GetValue(Txt_Height.Tag.ToString()).ToString();
            var widthKey = valueNames.Where(W => W.Contains("Screenmanager Resolution Width_")).FirstOrDefault();
            if (string.IsNullOrEmpty(widthKey))
            {
                MessageBox.Show("未找到显示类型", "错误");
                this.Close();
            }
            Txt_Width.Tag = widthKey;
            Text_Width.Text = software.GetValue(Txt_Width.Tag.ToString()).ToString();
        }

        private void Btn_fullScreen_Click(object sender, EventArgs e)
        {
            IntPtr hdc = GetDC(IntPtr.Zero);
            Size size = new Size();
            size.Width = GetDeviceCaps(hdc, DESKTOPHORZRES);
            size.Height = GetDeviceCaps(hdc, DESKTOPVERTRES);
            ReleaseDC(IntPtr.Zero, hdc);

            Text_Width.Text = size.Width.ToString();
            Text_Height.Text = size.Height.ToString();
        }

        private void Btn_Show1080P_Click(object sender, EventArgs e)
        {
            Text_Width.Text = "1920";
            Text_Height.Text = "1080";
        }

        private void Btn_Show720P_Click(object sender, EventArgs e)
        {
            Text_Width.Text = "1280";
            Text_Height.Text = "720";
        }

        /// <summary>
        /// 获取 DC
        /// </summary>
        /// <param name="ptr"></param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        static extern IntPtr GetDC(IntPtr ptr);

        /// <summary>
        /// 获取设备 Caps
        /// </summary>
        /// <param name="hdc">handle to DC</param>
        /// <param name="nIndex">index of capability</param>
        /// <returns></returns>
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);

        /// <summary>
        /// 释放 DC
        /// </summary>
        /// <param name="hWnd"></param>
        /// <param name="hDc"></param>
        /// <returns></returns>
        [DllImport("user32.dll", EntryPoint = "ReleaseDC")]
        static extern IntPtr ReleaseDC(IntPtr hWnd, IntPtr hDc);

        /// <summary>
        /// DESKTOPVERTRES
        /// </summary>
        const int DESKTOPVERTRES = 117;

        /// <summary>
        /// DESKTOPHORZRES
        /// </summary>
        const int DESKTOPHORZRES = 118;
    }
}
