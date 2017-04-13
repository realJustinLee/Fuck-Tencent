namespace WindowsFormsApp1
{
    partial class FuckTencent
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
            this.tabControlInstruction = new System.Windows.Forms.TabControl();
            this.tabPageSoftware = new System.Windows.Forms.TabPage();
            this.checkBoxQQui = new System.Windows.Forms.CheckBox();
            this.checkBoxTGame = new System.Windows.Forms.CheckBox();
            this.checkBoxDNF = new System.Windows.Forms.CheckBox();
            this.checkBoxCF = new System.Windows.Forms.CheckBox();
            this.checkBoxQQ = new System.Windows.Forms.CheckBox();
            this.checkBoxQQSpd = new System.Windows.Forms.CheckBox();
            this.buttonSoftware = new System.Windows.Forms.Button();
            this.checkBoxPlayer = new System.Windows.Forms.CheckBox();
            this.checkBoxLOL = new System.Windows.Forms.CheckBox();
            this.checkBoxExplorer = new System.Windows.Forms.CheckBox();
            this.checkBoxDownload = new System.Windows.Forms.CheckBox();
            this.tabPageHardware = new System.Windows.Forms.TabPage();
            this.checkBoxBT = new System.Windows.Forms.CheckBox();
            this.checkBoxLan = new System.Windows.Forms.CheckBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBoxUSB = new System.Windows.Forms.CheckBox();
            this.buttonHardware = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.timerUSB = new System.Windows.Forms.Timer(this.components);
            this.timerBT = new System.Windows.Forms.Timer(this.components);
            this.timerWifi = new System.Windows.Forms.Timer(this.components);
            this.timerLan = new System.Windows.Forms.Timer(this.components);
            this.timerQQ = new System.Windows.Forms.Timer(this.components);
            this.timerBrowser = new System.Windows.Forms.Timer(this.components);
            this.timer6 = new System.Windows.Forms.Timer(this.components);
            this.timer7 = new System.Windows.Forms.Timer(this.components);
            this.timer8 = new System.Windows.Forms.Timer(this.components);
            this.timer9 = new System.Windows.Forms.Timer(this.components);
            this.timer10 = new System.Windows.Forms.Timer(this.components);
            this.timer11 = new System.Windows.Forms.Timer(this.components);
            this.timer12 = new System.Windows.Forms.Timer(this.components);
            this.tabControlInstruction.SuspendLayout();
            this.tabPageSoftware.SuspendLayout();
            this.tabPageHardware.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlInstruction
            // 
            this.tabControlInstruction.Controls.Add(this.tabPageSoftware);
            this.tabControlInstruction.Controls.Add(this.tabPageHardware);
            this.tabControlInstruction.Location = new System.Drawing.Point(19, 54);
            this.tabControlInstruction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlInstruction.Name = "tabControlInstruction";
            this.tabControlInstruction.SelectedIndex = 0;
            this.tabControlInstruction.Size = new System.Drawing.Size(277, 232);
            this.tabControlInstruction.TabIndex = 0;
            // 
            // tabPageSoftware
            // 
            this.tabPageSoftware.Controls.Add(this.checkBoxQQui);
            this.tabPageSoftware.Controls.Add(this.checkBoxTGame);
            this.tabPageSoftware.Controls.Add(this.checkBoxDNF);
            this.tabPageSoftware.Controls.Add(this.checkBoxCF);
            this.tabPageSoftware.Controls.Add(this.checkBoxQQ);
            this.tabPageSoftware.Controls.Add(this.checkBoxQQSpd);
            this.tabPageSoftware.Controls.Add(this.buttonSoftware);
            this.tabPageSoftware.Controls.Add(this.checkBoxPlayer);
            this.tabPageSoftware.Controls.Add(this.checkBoxLOL);
            this.tabPageSoftware.Controls.Add(this.checkBoxExplorer);
            this.tabPageSoftware.Controls.Add(this.checkBoxDownload);
            this.tabPageSoftware.Location = new System.Drawing.Point(4, 26);
            this.tabPageSoftware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSoftware.Name = "tabPageSoftware";
            this.tabPageSoftware.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSoftware.Size = new System.Drawing.Size(269, 202);
            this.tabPageSoftware.TabIndex = 0;
            this.tabPageSoftware.Text = "禁用游戏和软件";
            this.tabPageSoftware.UseVisualStyleBackColor = true;
            // 
            // checkBoxQQui
            // 
            this.checkBoxQQui.AutoSize = true;
            this.checkBoxQQui.Location = new System.Drawing.Point(128, 104);
            this.checkBoxQQui.Name = "checkBoxQQui";
            this.checkBoxQQui.Size = new System.Drawing.Size(95, 21);
            this.checkBoxQQui.TabIndex = 9;
            this.checkBoxQQui.Text = "禁用QQ炫舞";
            this.checkBoxQQui.UseVisualStyleBackColor = true;
            // 
            // checkBoxTGame
            // 
            this.checkBoxTGame.AutoSize = true;
            this.checkBoxTGame.Location = new System.Drawing.Point(128, 50);
            this.checkBoxTGame.Name = "checkBoxTGame";
            this.checkBoxTGame.Size = new System.Drawing.Size(75, 21);
            this.checkBoxTGame.TabIndex = 10;
            this.checkBoxTGame.Text = "禁用逆战";
            this.checkBoxTGame.UseVisualStyleBackColor = true;
            // 
            // checkBoxDNF
            // 
            this.checkBoxDNF.AutoSize = true;
            this.checkBoxDNF.Location = new System.Drawing.Point(128, 131);
            this.checkBoxDNF.Name = "checkBoxDNF";
            this.checkBoxDNF.Size = new System.Drawing.Size(123, 21);
            this.checkBoxDNF.TabIndex = 8;
            this.checkBoxDNF.Text = "禁用地下城与勇士";
            this.checkBoxDNF.UseVisualStyleBackColor = true;
            // 
            // checkBoxCF
            // 
            this.checkBoxCF.AutoSize = true;
            this.checkBoxCF.Location = new System.Drawing.Point(128, 23);
            this.checkBoxCF.Name = "checkBoxCF";
            this.checkBoxCF.Size = new System.Drawing.Size(99, 21);
            this.checkBoxCF.TabIndex = 5;
            this.checkBoxCF.Text = "禁用穿越火线";
            this.checkBoxCF.UseVisualStyleBackColor = true;
            // 
            // checkBoxQQ
            // 
            this.checkBoxQQ.AutoSize = true;
            this.checkBoxQQ.Location = new System.Drawing.Point(23, 23);
            this.checkBoxQQ.Name = "checkBoxQQ";
            this.checkBoxQQ.Size = new System.Drawing.Size(71, 21);
            this.checkBoxQQ.TabIndex = 1;
            this.checkBoxQQ.Text = "禁用QQ";
            this.checkBoxQQ.UseVisualStyleBackColor = true;
            // 
            // checkBoxQQSpd
            // 
            this.checkBoxQQSpd.AutoSize = true;
            this.checkBoxQQSpd.Location = new System.Drawing.Point(128, 77);
            this.checkBoxQQSpd.Name = "checkBoxQQSpd";
            this.checkBoxQQSpd.Size = new System.Drawing.Size(95, 21);
            this.checkBoxQQSpd.TabIndex = 7;
            this.checkBoxQQSpd.Text = "禁用QQ飞车";
            this.checkBoxQQSpd.UseVisualStyleBackColor = true;
            // 
            // buttonSoftware
            // 
            this.buttonSoftware.Location = new System.Drawing.Point(128, 158);
            this.buttonSoftware.Name = "buttonSoftware";
            this.buttonSoftware.Size = new System.Drawing.Size(75, 23);
            this.buttonSoftware.TabIndex = 0;
            this.buttonSoftware.Text = "保存生效";
            this.buttonSoftware.UseVisualStyleBackColor = true;
            this.buttonSoftware.Click += new System.EventHandler(this.buttonSoftware_Click);
            // 
            // checkBoxPlayer
            // 
            this.checkBoxPlayer.AutoSize = true;
            this.checkBoxPlayer.Location = new System.Drawing.Point(23, 104);
            this.checkBoxPlayer.Name = "checkBoxPlayer";
            this.checkBoxPlayer.Size = new System.Drawing.Size(87, 21);
            this.checkBoxPlayer.TabIndex = 4;
            this.checkBoxPlayer.Text = "禁用播放器";
            this.checkBoxPlayer.UseVisualStyleBackColor = true;
            // 
            // checkBoxLOL
            // 
            this.checkBoxLOL.AutoSize = true;
            this.checkBoxLOL.Location = new System.Drawing.Point(23, 131);
            this.checkBoxLOL.Name = "checkBoxLOL";
            this.checkBoxLOL.Size = new System.Drawing.Size(99, 21);
            this.checkBoxLOL.TabIndex = 6;
            this.checkBoxLOL.Text = "禁用英雄联盟";
            this.checkBoxLOL.UseVisualStyleBackColor = true;
            // 
            // checkBoxExplorer
            // 
            this.checkBoxExplorer.AutoSize = true;
            this.checkBoxExplorer.Location = new System.Drawing.Point(23, 50);
            this.checkBoxExplorer.Name = "checkBoxExplorer";
            this.checkBoxExplorer.Size = new System.Drawing.Size(87, 21);
            this.checkBoxExplorer.TabIndex = 2;
            this.checkBoxExplorer.Text = "禁用浏览器";
            this.checkBoxExplorer.UseVisualStyleBackColor = true;
            // 
            // checkBoxDownload
            // 
            this.checkBoxDownload.AutoSize = true;
            this.checkBoxDownload.Location = new System.Drawing.Point(23, 77);
            this.checkBoxDownload.Name = "checkBoxDownload";
            this.checkBoxDownload.Size = new System.Drawing.Size(87, 21);
            this.checkBoxDownload.TabIndex = 3;
            this.checkBoxDownload.Text = "禁用下载器";
            this.checkBoxDownload.UseVisualStyleBackColor = true;
            // 
            // tabPageHardware
            // 
            this.tabPageHardware.Controls.Add(this.checkBoxBT);
            this.tabPageHardware.Controls.Add(this.checkBoxLan);
            this.tabPageHardware.Controls.Add(this.checkBoxWifi);
            this.tabPageHardware.Controls.Add(this.checkBoxUSB);
            this.tabPageHardware.Controls.Add(this.buttonHardware);
            this.tabPageHardware.Location = new System.Drawing.Point(4, 26);
            this.tabPageHardware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageHardware.Name = "tabPageHardware";
            this.tabPageHardware.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageHardware.Size = new System.Drawing.Size(269, 202);
            this.tabPageHardware.TabIndex = 1;
            this.tabPageHardware.Text = "禁用USB和网卡";
            this.tabPageHardware.UseVisualStyleBackColor = true;
            // 
            // checkBoxBT
            // 
            this.checkBoxBT.AutoSize = true;
            this.checkBoxBT.Location = new System.Drawing.Point(23, 50);
            this.checkBoxBT.Name = "checkBoxBT";
            this.checkBoxBT.Size = new System.Drawing.Size(75, 21);
            this.checkBoxBT.TabIndex = 4;
            this.checkBoxBT.Text = "禁用蓝牙";
            this.checkBoxBT.UseVisualStyleBackColor = true;
            // 
            // checkBoxLan
            // 
            this.checkBoxLan.AutoSize = true;
            this.checkBoxLan.Location = new System.Drawing.Point(23, 104);
            this.checkBoxLan.Name = "checkBoxLan";
            this.checkBoxLan.Size = new System.Drawing.Size(99, 21);
            this.checkBoxLan.TabIndex = 3;
            this.checkBoxLan.Text = "禁用有线网卡";
            this.checkBoxLan.UseVisualStyleBackColor = true;
            // 
            // checkBoxWifi
            // 
            this.checkBoxWifi.AutoSize = true;
            this.checkBoxWifi.Location = new System.Drawing.Point(23, 77);
            this.checkBoxWifi.Name = "checkBoxWifi";
            this.checkBoxWifi.Size = new System.Drawing.Size(99, 21);
            this.checkBoxWifi.TabIndex = 2;
            this.checkBoxWifi.Text = "禁用无线网卡";
            this.checkBoxWifi.UseVisualStyleBackColor = true;
            // 
            // checkBoxUSB
            // 
            this.checkBoxUSB.AutoSize = true;
            this.checkBoxUSB.Location = new System.Drawing.Point(23, 23);
            this.checkBoxUSB.Name = "checkBoxUSB";
            this.checkBoxUSB.Size = new System.Drawing.Size(72, 21);
            this.checkBoxUSB.TabIndex = 1;
            this.checkBoxUSB.Text = "禁用USB";
            this.checkBoxUSB.UseVisualStyleBackColor = true;
            // 
            // buttonHardware
            // 
            this.buttonHardware.Location = new System.Drawing.Point(23, 131);
            this.buttonHardware.Name = "buttonHardware";
            this.buttonHardware.Size = new System.Drawing.Size(75, 23);
            this.buttonHardware.TabIndex = 0;
            this.buttonHardware.Text = "保存生效";
            this.buttonHardware.UseVisualStyleBackColor = true;
            this.buttonHardware.Click += new System.EventHandler(this.buttonHardware_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.Purple;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(219, 41);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Fuck Tencent";
            // 
            // timerUSB
            // 
            this.timerUSB.Tick += new System.EventHandler(this.timerUSB_Tick);
            // 
            // timerBT
            // 
            this.timerBT.Tick += new System.EventHandler(this.timerBT_Tick);
            // 
            // timerWifi
            // 
            this.timerWifi.Tick += new System.EventHandler(this.timerWifi_Tick);
            // 
            // timerLan
            // 
            this.timerLan.Tick += new System.EventHandler(this.timerLan_Tick);
            // 
            // FuckTencent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(316, 309);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.tabControlInstruction);
            this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FuckTencent";
            this.Text = "FuckTencent";
            this.tabControlInstruction.ResumeLayout(false);
            this.tabPageSoftware.ResumeLayout(false);
            this.tabPageSoftware.PerformLayout();
            this.tabPageHardware.ResumeLayout(false);
            this.tabPageHardware.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlInstruction;
        private System.Windows.Forms.TabPage tabPageSoftware;
        private System.Windows.Forms.TabPage tabPageHardware;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.CheckBox checkBoxQQ;
        private System.Windows.Forms.Button buttonSoftware;
        private System.Windows.Forms.CheckBox checkBoxLan;
        private System.Windows.Forms.CheckBox checkBoxWifi;
        private System.Windows.Forms.CheckBox checkBoxUSB;
        private System.Windows.Forms.Button buttonHardware;
        private System.Windows.Forms.CheckBox checkBoxBT;
        private System.Windows.Forms.CheckBox checkBoxPlayer;
        private System.Windows.Forms.CheckBox checkBoxDownload;
        private System.Windows.Forms.CheckBox checkBoxExplorer;
        private System.Windows.Forms.CheckBox checkBoxQQui;
        private System.Windows.Forms.CheckBox checkBoxTGame;
        private System.Windows.Forms.CheckBox checkBoxDNF;
        private System.Windows.Forms.CheckBox checkBoxCF;
        private System.Windows.Forms.CheckBox checkBoxQQSpd;
        private System.Windows.Forms.CheckBox checkBoxLOL;
        private System.Windows.Forms.Timer timerUSB;
        private System.Windows.Forms.Timer timerBT;
        private System.Windows.Forms.Timer timerWifi;
        private System.Windows.Forms.Timer timerLan;
        private System.Windows.Forms.Timer timerQQ;
        private System.Windows.Forms.Timer timerBrowser;
        private System.Windows.Forms.Timer timer6;
        private System.Windows.Forms.Timer timer7;
        private System.Windows.Forms.Timer timer8;
        private System.Windows.Forms.Timer timer9;
        private System.Windows.Forms.Timer timer10;
        private System.Windows.Forms.Timer timer11;
        private System.Windows.Forms.Timer timer12;
    }
}

