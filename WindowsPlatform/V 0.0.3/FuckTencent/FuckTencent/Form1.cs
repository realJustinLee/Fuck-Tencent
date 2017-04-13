using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;

namespace WindowsFormsApp1
{
    public partial class FuckTencent : Form
    {
        public FuckTencent()
        {
            InitializeComponent();
        }

        //############################################################################################################

        #region Software
        private void buttonSoftware_Click(object sender, EventArgs e)
        {

        }
        #endregion

        //############################################################################################################

        #region Hardware
        /// <summary>  
        /// 通过注册表启用USB  
        /// </summary>  
        /// <returns></returns>  
        public bool RegToRunUSB()
        {
            try
            {
                RegistryKey regKey = Registry.LocalMachine; //读取注册列表HKEY_LOCAL_MACHINE  
                string keyPath = @"SYSTEM\CurrentControlSet\Services\USBSTOR"; //USB 大容量存储驱动程序  
                RegistryKey openKey = regKey.OpenSubKey(keyPath, true);
                openKey.SetValue("Start", 3); //设置键值对（3）为开启USB（4）为关闭  
                openKey.Close(); //关闭注册列表读写流  
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>  
        /// 通过注册表禁用USB  
        /// </summary>  
        /// <returns></returns>  
        public bool RegToStopUSB()
        {
            try
            {
                RegistryKey regKey = Registry.LocalMachine;
                string keyPath = @"SYSTEM\CurrentControlSet\Services\USBSTOR";
                RegistryKey openKey = regKey.OpenSubKey(keyPath, true);
                openKey.SetValue("Start", 4);
                openKey.Close();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        private void timerUSB_Tick(object sender, EventArgs e)
        {
            RegToStopUSB();
        }

        private void timerBT_Tick(object sender, EventArgs e)
        {

        }

        private void timerWifi_Tick(object sender, EventArgs e)
        {

        }

        private void timerLan_Tick(object sender, EventArgs e)
        {

        }

        private void buttonHardware_Click(object sender, EventArgs e)
        {
            if (checkBoxUSB.Checked)
            {
                timerUSB.Enabled = true;
            }
            else
            {
                RegToRunUSB();
            }
            if (checkBoxBT.Checked)
            {

            }
            else
            {

            }
            if (checkBoxWifi.Checked)
            {

            }
            else
            {

            }
            if (checkBoxLan.Checked)
            {

            }
            else
            {

            }
        }

        #endregion
        //############################################################################################################
    }
}
