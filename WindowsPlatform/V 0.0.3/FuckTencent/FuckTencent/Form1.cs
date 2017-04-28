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

        /// <summary>  
        /// 根据“精确进程名”结束进程  
        /// </summary>  
        /// <param name="strProcName">精确进程名</param>  
        public void KillProc(string strProcName)
        {
            try
            {
                //精确进程名  用GetProcessesByName  
                foreach (Process process in Process.GetProcessesByName(strProcName))
                {
                    if (!process.CloseMainWindow())
                    {
                        process.Kill();
                    }
                }
            }
            catch
            {

            }
        }

        private void timerQQ_Tick(object sender, EventArgs e)
        {
            KillProc("qq.exe");
            KillProc("txplatform.exe");
            KillProc("qqexternal.exe");
        }


        private void timerExplorer_Tick(object sender, EventArgs e)
        {
            KillProc("iexplore.exe");
            KillProc("sogouexplorer.exe");
            KillProc("The world.exe");
            KillProc("Firefox.exe");
            KillProc("opera.exe");
            KillProc("360SE.exe");
            KillProc("Chrome.exe");
            KillProc("Safari.exe");
            KillProc("Maxthon.exe");
            KillProc("Netscape.exe");
            KillProc("liebao.exe");
        }

        private void timerDownload_Tick(object sender, EventArgs e)
        {
            KillProc("Thunder.exe");
            KillProc("ThunderPlatform.exe");
            KillProc("QQDownload.exe");
            KillProc("flashget.exe");
        }

        private void timerPlayer_Tick(object sender, EventArgs e)
        {
            KillProc("KuGou.exe");
            KillProc("QQmusic.exe");
            KillProc("kwmusic.exe");
            KillProc("TTPlayer.exe");
            KillProc("DUOMI.exe");
        }

        private void timerLOL_Tick(object sender, EventArgs e)
        {
            KillProc("LolClient.exe");
        }

        private void timerCF_Tick(object sender, EventArgs e)
        {
            KillProc("crossfire.exe");
        }

        private void timerTGame_Tick(object sender, EventArgs e)
        {
            KillProc("TGame.exe");
        }

        private void timerQQSpd_Tick(object sender, EventArgs e)
        {
            KillProc("QQSpeed_loader.exe");
        }

        private void timerQQui_Tick(object sender, EventArgs e)
        {
            KillProc("ui_launch_dx.exe");
        }

        private void timerDNF_Tick(object sender, EventArgs e)
        {
            KillProc("DNFchina.exe");
        }

        #region Software
        private void buttonSoftware_Click(object sender, EventArgs e)
        {
            MessageBox.Show("设置已保存");
            if (checkBoxQQ.Checked)
            {
                timerQQ.Enabled = true;
            }
            else
            {
                timerQQ.Enabled = false;
            }
            if (checkBoxExplorer.Checked)
            {
                timerExplorer.Enabled = true;
            }
            else
            {
                timerExplorer.Enabled = false;
            }
            if (checkBoxDownload.Checked)
            {
                timerDownload.Enabled = true;
            }
            else
            {
                timerDownload.Enabled = false;
            }
            if (checkBoxPlayer.Checked)
            {
                timerPlayer.Enabled = true;
            }
            else
            {
                timerPlayer.Enabled = false;
            }
            if (checkBoxLOL.Checked)
            {
                timerLOL.Enabled = true;
            }
            else
            {
                timerLOL.Enabled = false;
            }
            if (checkBoxCF.Checked)
            {
                timerCF.Enabled = true;
            }
            else
            {
                timerCF.Enabled = false;
            }
            if (checkBoxTGame.Checked)
            {
                timerTGame.Enabled = true;
            }
            else
            {
                timerTGame.Enabled = false;
            }
            if (checkBoxQQSpd.Checked)
            {
                timerQQSpd.Enabled = true;
            }
            else
            {
                timerQQSpd.Enabled = false;
            }
            if (checkBoxQQui.Checked)
            {
                timerQQui.Enabled = true;
            }
            else
            {
                timerQQui.Enabled = false;
            }
            if (checkBoxDNF.Checked)
            {
                timerDNF.Enabled = true;
            }
            else
            {
                timerDNF.Enabled = false;
            }
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
            //STOP BT
        }

        private void timerWifi_Tick(object sender, EventArgs e)
        {
            //STOP Wi-Fi
        }

        private void timerLan_Tick(object sender, EventArgs e)
        {
            //STOP LAN
        }

        private void buttonHardware_Click(object sender, EventArgs e)
        {
            MessageBox.Show("设置已保存");
            if (checkBoxUSB.Checked)
            {
                timerUSB.Enabled = true;
            }
            else
            {
                timerUSB.Enabled = false;
                RegToRunUSB();
            }
            if (checkBoxBT.Checked)
            {
                timerBT.Enabled = true;
            }
            else
            {
                timerBT.Enabled = false;
                //Enable BT
            }
            if (checkBoxWifi.Checked)
            {
                timerWifi.Enabled = true;
            }
            else
            {
                timerWifi.Enabled = false;
                //Enable Wi-Fi
            }
            if (checkBoxLan.Checked)
            {
                timerLan.Enabled = true;
            }
            else
            {
                timerLan.Enabled = false;
                //Enable LAN
            }
        }

        #endregion
        //############################################################################################################
    }
}
