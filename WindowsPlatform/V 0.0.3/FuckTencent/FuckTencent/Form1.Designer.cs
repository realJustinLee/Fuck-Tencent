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
            this.tabControlInstruction = new System.Windows.Forms.TabControl();
            this.tabPageSoftware = new System.Windows.Forms.TabPage();
            this.checkBoxQQ = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxPlayer = new System.Windows.Forms.CheckBox();
            this.checkBoxExplorer = new System.Windows.Forms.CheckBox();
            this.checkBoxDownload = new System.Windows.Forms.CheckBox();
            this.tabPageHardware = new System.Windows.Forms.TabPage();
            this.checkBoxBT = new System.Windows.Forms.CheckBox();
            this.checkBoxLan = new System.Windows.Forms.CheckBox();
            this.checkBoxWifi = new System.Windows.Forms.CheckBox();
            this.checkBoxUSB = new System.Windows.Forms.CheckBox();
            this.buttonHardware = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
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
            this.tabControlInstruction.Size = new System.Drawing.Size(446, 277);
            this.tabControlInstruction.TabIndex = 0;
            // 
            // tabPageSoftware
            // 
            this.tabPageSoftware.Controls.Add(this.checkBox1);
            this.tabPageSoftware.Controls.Add(this.checkBox9);
            this.tabPageSoftware.Controls.Add(this.checkBox10);
            this.tabPageSoftware.Controls.Add(this.checkBox11);
            this.tabPageSoftware.Controls.Add(this.checkBox8);
            this.tabPageSoftware.Controls.Add(this.checkBox5);
            this.tabPageSoftware.Controls.Add(this.checkBoxQQ);
            this.tabPageSoftware.Controls.Add(this.checkBox7);
            this.tabPageSoftware.Controls.Add(this.button1);
            this.tabPageSoftware.Controls.Add(this.checkBoxPlayer);
            this.tabPageSoftware.Controls.Add(this.checkBox6);
            this.tabPageSoftware.Controls.Add(this.checkBoxExplorer);
            this.tabPageSoftware.Controls.Add(this.checkBoxDownload);
            this.tabPageSoftware.Location = new System.Drawing.Point(4, 26);
            this.tabPageSoftware.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSoftware.Name = "tabPageSoftware";
            this.tabPageSoftware.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPageSoftware.Size = new System.Drawing.Size(438, 247);
            this.tabPageSoftware.TabIndex = 0;
            this.tabPageSoftware.Text = "禁用游戏和软件";
            this.tabPageSoftware.UseVisualStyleBackColor = true;
            this.tabPageSoftware.Click += new System.EventHandler(this.tabPageSoftware_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "保存生效";
            this.button1.UseVisualStyleBackColor = true;
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
            this.tabPageHardware.Size = new System.Drawing.Size(438, 247);
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
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(122, 50);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(86, 21);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(122, 77);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(85, 21);
            this.checkBox7.TabIndex = 7;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(122, 23);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(99, 21);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "禁用穿越火线";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(122, 104);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(86, 21);
            this.checkBox8.TabIndex = 8;
            this.checkBox8.Text = "checkBox8";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(221, 104);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(84, 21);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(221, 23);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(86, 21);
            this.checkBox9.TabIndex = 9;
            this.checkBox9.Text = "checkBox9";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(221, 77);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(91, 21);
            this.checkBox10.TabIndex = 11;
            this.checkBox10.Text = "checkBox10";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(221, 50);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(89, 21);
            this.checkBox11.TabIndex = 10;
            this.checkBox11.Text = "checkBox11";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // FuckTencent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(485, 337);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxLan;
        private System.Windows.Forms.CheckBox checkBoxWifi;
        private System.Windows.Forms.CheckBox checkBoxUSB;
        private System.Windows.Forms.Button buttonHardware;
        private System.Windows.Forms.CheckBox checkBoxBT;
        private System.Windows.Forms.CheckBox checkBoxPlayer;
        private System.Windows.Forms.CheckBox checkBoxDownload;
        private System.Windows.Forms.CheckBox checkBoxExplorer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
    }
}

