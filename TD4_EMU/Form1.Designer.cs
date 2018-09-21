namespace TD4_EMU
{
    partial class frmMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GbClock = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RbClkManual = new System.Windows.Forms.RadioButton();
            this.RbCloc_10Hz = new System.Windows.Forms.RadioButton();
            this.RbCloc_01Hz = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblRegA = new System.Windows.Forms.Label();
            this.lblRegB = new System.Windows.Forms.Label();
            this.lblC_flg = new System.Windows.Forms.Label();
            this.lblPC = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblOutPort = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.ChkBeep = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ChkIn3 = new System.Windows.Forms.CheckBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.ChkIn2 = new System.Windows.Forms.CheckBox();
            this.label19 = new System.Windows.Forms.Label();
            this.ChkIn1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.ChkIn0 = new System.Windows.Forms.CheckBox();
            this.BtnReset = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tD4memCtrl15 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl14 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl13 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl12 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl11 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl10 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl9 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl8 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl7 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl6 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl5 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl4 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl3 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl2 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl1 = new TD4_EMU.TD4memCtrl();
            this.tD4memCtrl0 = new TD4_EMU.TD4memCtrl();
            this.menuStrip1.SuspendLayout();
            this.GbClock.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.endToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(40, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveAsToolStripMenuItem.Text = "SaveAs";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // endToolStripMenuItem
            // 
            this.endToolStripMenuItem.Name = "endToolStripMenuItem";
            this.endToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.endToolStripMenuItem.Text = "End";
            this.endToolStripMenuItem.Click += new System.EventHandler(this.endToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(54, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GbClock
            // 
            this.GbClock.Controls.Add(this.button1);
            this.GbClock.Controls.Add(this.RbClkManual);
            this.GbClock.Controls.Add(this.RbCloc_10Hz);
            this.GbClock.Controls.Add(this.RbCloc_01Hz);
            this.GbClock.Location = new System.Drawing.Point(6, 382);
            this.GbClock.Name = "GbClock";
            this.GbClock.Size = new System.Drawing.Size(143, 100);
            this.GbClock.TabIndex = 17;
            this.GbClock.TabStop = false;
            this.GbClock.Text = "Clock Generator";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clock";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RbClkManual
            // 
            this.RbClkManual.AutoSize = true;
            this.RbClkManual.Checked = true;
            this.RbClkManual.Location = new System.Drawing.Point(6, 62);
            this.RbClkManual.Name = "RbClkManual";
            this.RbClkManual.Size = new System.Drawing.Size(75, 16);
            this.RbClkManual.TabIndex = 2;
            this.RbClkManual.TabStop = true;
            this.RbClkManual.Text = "Manual →";
            this.RbClkManual.UseVisualStyleBackColor = true;
            this.RbClkManual.CheckedChanged += new System.EventHandler(this.RbClkManual_CheckedChanged);
            // 
            // RbCloc_10Hz
            // 
            this.RbCloc_10Hz.AutoSize = true;
            this.RbCloc_10Hz.Location = new System.Drawing.Point(6, 40);
            this.RbCloc_10Hz.Name = "RbCloc_10Hz";
            this.RbCloc_10Hz.Size = new System.Drawing.Size(48, 16);
            this.RbCloc_10Hz.TabIndex = 1;
            this.RbCloc_10Hz.Text = "10Hz";
            this.RbCloc_10Hz.UseVisualStyleBackColor = true;
            this.RbCloc_10Hz.CheckedChanged += new System.EventHandler(this.RbCloc_10Hz_CheckedChanged);
            // 
            // RbCloc_01Hz
            // 
            this.RbCloc_01Hz.AutoSize = true;
            this.RbCloc_01Hz.Location = new System.Drawing.Point(6, 18);
            this.RbCloc_01Hz.Name = "RbCloc_01Hz";
            this.RbCloc_01Hz.Size = new System.Drawing.Size(46, 16);
            this.RbCloc_01Hz.TabIndex = 0;
            this.RbCloc_01Hz.Text = " 1Hz";
            this.RbCloc_01Hz.UseVisualStyleBackColor = true;
            this.RbCloc_01Hz.CheckedChanged += new System.EventHandler(this.RbCloc_01Hz_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "D7";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 12);
            this.label2.TabIndex = 18;
            this.label2.Text = "D0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 12);
            this.label3.TabIndex = 19;
            this.label3.Text = "Program Memory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 12);
            this.label4.TabIndex = 20;
            this.label4.Text = "Operation Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(465, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "Im";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 12);
            this.label6.TabIndex = 23;
            this.label6.Text = "RegistorA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "RegistorB";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 12);
            this.label8.TabIndex = 25;
            this.label8.Text = "C Flag";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 12);
            this.label9.TabIndex = 26;
            this.label9.Text = "ProgramCounter";
            // 
            // lblRegA
            // 
            this.lblRegA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegA.Location = new System.Drawing.Point(110, 77);
            this.lblRegA.Name = "lblRegA";
            this.lblRegA.Size = new System.Drawing.Size(31, 14);
            this.lblRegA.TabIndex = 27;
            this.lblRegA.Text = "0000";
            // 
            // lblRegB
            // 
            this.lblRegB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRegB.Location = new System.Drawing.Point(110, 106);
            this.lblRegB.Name = "lblRegB";
            this.lblRegB.Size = new System.Drawing.Size(31, 14);
            this.lblRegB.TabIndex = 27;
            this.lblRegB.Text = "0000";
            // 
            // lblC_flg
            // 
            this.lblC_flg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblC_flg.Location = new System.Drawing.Point(110, 132);
            this.lblC_flg.Name = "lblC_flg";
            this.lblC_flg.Size = new System.Drawing.Size(31, 14);
            this.lblC_flg.TabIndex = 27;
            this.lblC_flg.Text = "0";
            this.lblC_flg.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblPC
            // 
            this.lblPC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPC.Location = new System.Drawing.Point(110, 158);
            this.lblPC.Name = "lblPC";
            this.lblPC.Size = new System.Drawing.Size(31, 14);
            this.lblPC.TabIndex = 27;
            this.lblPC.Text = "0000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "OUT Port";
            // 
            // LblOutPort
            // 
            this.LblOutPort.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblOutPort.ForeColor = System.Drawing.Color.Red;
            this.LblOutPort.Location = new System.Drawing.Point(69, 230);
            this.LblOutPort.Name = "LblOutPort";
            this.LblOutPort.Size = new System.Drawing.Size(72, 19);
            this.LblOutPort.TabIndex = 29;
            this.LblOutPort.Text = "○○○○";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 12);
            this.label15.TabIndex = 30;
            this.label15.Text = "Beep";
            // 
            // ChkBeep
            // 
            this.ChkBeep.AutoSize = true;
            this.ChkBeep.Location = new System.Drawing.Point(72, 261);
            this.ChkBeep.Name = "ChkBeep";
            this.ChkBeep.Size = new System.Drawing.Size(15, 14);
            this.ChkBeep.TabIndex = 31;
            this.ChkBeep.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 315);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(30, 12);
            this.label16.TabIndex = 32;
            this.label16.Text = "Input";
            // 
            // ChkIn3
            // 
            this.ChkIn3.AutoSize = true;
            this.ChkIn3.Location = new System.Drawing.Point(56, 315);
            this.ChkIn3.Name = "ChkIn3";
            this.ChkIn3.Size = new System.Drawing.Size(15, 14);
            this.ChkIn3.TabIndex = 33;
            this.ChkIn3.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(57, 300);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(11, 12);
            this.label17.TabIndex = 34;
            this.label17.Text = "3";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(78, 300);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(11, 12);
            this.label18.TabIndex = 36;
            this.label18.Text = "2";
            // 
            // ChkIn2
            // 
            this.ChkIn2.AutoSize = true;
            this.ChkIn2.Location = new System.Drawing.Point(77, 315);
            this.ChkIn2.Name = "ChkIn2";
            this.ChkIn2.Size = new System.Drawing.Size(15, 14);
            this.ChkIn2.TabIndex = 35;
            this.ChkIn2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(99, 300);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(11, 12);
            this.label19.TabIndex = 38;
            this.label19.Text = "1";
            // 
            // ChkIn1
            // 
            this.ChkIn1.AutoSize = true;
            this.ChkIn1.Location = new System.Drawing.Point(98, 315);
            this.ChkIn1.Name = "ChkIn1";
            this.ChkIn1.Size = new System.Drawing.Size(15, 14);
            this.ChkIn1.TabIndex = 37;
            this.ChkIn1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(120, 300);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(11, 12);
            this.label20.TabIndex = 40;
            this.label20.Text = "0";
            // 
            // ChkIn0
            // 
            this.ChkIn0.AutoSize = true;
            this.ChkIn0.Location = new System.Drawing.Point(119, 315);
            this.ChkIn0.Name = "ChkIn0";
            this.ChkIn0.Size = new System.Drawing.Size(15, 14);
            this.ChkIn0.TabIndex = 39;
            this.ChkIn0.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(6, 484);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(143, 23);
            this.BtnReset.TabIndex = 41;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(167, 484);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Program Reset";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(75, 218);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 12);
            this.label10.TabIndex = 34;
            this.label10.Text = "3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(124, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 12);
            this.label13.TabIndex = 40;
            this.label13.Text = "0";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(69, 245);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(20, 13);
            this.label21.TabIndex = 34;
            this.label21.Text = "↓";
            // 
            // tD4memCtrl15
            // 
            this.tD4memCtrl15.AddressText = "Address15";
            this.tD4memCtrl15.Location = new System.Drawing.Point(167, 460);
            this.tD4memCtrl15.Name = "tD4memCtrl15";
            this.tD4memCtrl15.selectAddress = false;
            this.tD4memCtrl15.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl15.TabIndex = 16;
            // 
            // tD4memCtrl14
            // 
            this.tD4memCtrl14.AddressText = "Address14";
            this.tD4memCtrl14.Location = new System.Drawing.Point(167, 434);
            this.tD4memCtrl14.Name = "tD4memCtrl14";
            this.tD4memCtrl14.selectAddress = false;
            this.tD4memCtrl14.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl14.TabIndex = 15;
            // 
            // tD4memCtrl13
            // 
            this.tD4memCtrl13.AddressText = "Address13";
            this.tD4memCtrl13.Location = new System.Drawing.Point(167, 408);
            this.tD4memCtrl13.Name = "tD4memCtrl13";
            this.tD4memCtrl13.selectAddress = false;
            this.tD4memCtrl13.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl13.TabIndex = 14;
            // 
            // tD4memCtrl12
            // 
            this.tD4memCtrl12.AddressText = "Address12";
            this.tD4memCtrl12.Location = new System.Drawing.Point(167, 382);
            this.tD4memCtrl12.Name = "tD4memCtrl12";
            this.tD4memCtrl12.selectAddress = false;
            this.tD4memCtrl12.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl12.TabIndex = 13;
            // 
            // tD4memCtrl11
            // 
            this.tD4memCtrl11.AddressText = "Address11";
            this.tD4memCtrl11.Location = new System.Drawing.Point(167, 356);
            this.tD4memCtrl11.Name = "tD4memCtrl11";
            this.tD4memCtrl11.selectAddress = false;
            this.tD4memCtrl11.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl11.TabIndex = 12;
            // 
            // tD4memCtrl10
            // 
            this.tD4memCtrl10.AddressText = "Address10";
            this.tD4memCtrl10.Location = new System.Drawing.Point(167, 330);
            this.tD4memCtrl10.Name = "tD4memCtrl10";
            this.tD4memCtrl10.selectAddress = false;
            this.tD4memCtrl10.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl10.TabIndex = 11;
            // 
            // tD4memCtrl9
            // 
            this.tD4memCtrl9.AddressText = "Address09";
            this.tD4memCtrl9.Location = new System.Drawing.Point(167, 304);
            this.tD4memCtrl9.Name = "tD4memCtrl9";
            this.tD4memCtrl9.selectAddress = false;
            this.tD4memCtrl9.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl9.TabIndex = 10;
            // 
            // tD4memCtrl8
            // 
            this.tD4memCtrl8.AddressText = "Address08";
            this.tD4memCtrl8.Location = new System.Drawing.Point(167, 278);
            this.tD4memCtrl8.Name = "tD4memCtrl8";
            this.tD4memCtrl8.selectAddress = false;
            this.tD4memCtrl8.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl8.TabIndex = 9;
            // 
            // tD4memCtrl7
            // 
            this.tD4memCtrl7.AddressText = "Address07";
            this.tD4memCtrl7.Location = new System.Drawing.Point(167, 252);
            this.tD4memCtrl7.Name = "tD4memCtrl7";
            this.tD4memCtrl7.selectAddress = false;
            this.tD4memCtrl7.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl7.TabIndex = 8;
            // 
            // tD4memCtrl6
            // 
            this.tD4memCtrl6.AddressText = "Address06";
            this.tD4memCtrl6.Location = new System.Drawing.Point(167, 226);
            this.tD4memCtrl6.Name = "tD4memCtrl6";
            this.tD4memCtrl6.selectAddress = false;
            this.tD4memCtrl6.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl6.TabIndex = 7;
            // 
            // tD4memCtrl5
            // 
            this.tD4memCtrl5.AddressText = "Address05";
            this.tD4memCtrl5.Location = new System.Drawing.Point(167, 200);
            this.tD4memCtrl5.Name = "tD4memCtrl5";
            this.tD4memCtrl5.selectAddress = false;
            this.tD4memCtrl5.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl5.TabIndex = 6;
            // 
            // tD4memCtrl4
            // 
            this.tD4memCtrl4.AddressText = "Address04";
            this.tD4memCtrl4.Location = new System.Drawing.Point(167, 174);
            this.tD4memCtrl4.Name = "tD4memCtrl4";
            this.tD4memCtrl4.selectAddress = false;
            this.tD4memCtrl4.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl4.TabIndex = 5;
            // 
            // tD4memCtrl3
            // 
            this.tD4memCtrl3.AddressText = "Address03";
            this.tD4memCtrl3.Location = new System.Drawing.Point(167, 148);
            this.tD4memCtrl3.Name = "tD4memCtrl3";
            this.tD4memCtrl3.selectAddress = false;
            this.tD4memCtrl3.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl3.TabIndex = 4;
            // 
            // tD4memCtrl2
            // 
            this.tD4memCtrl2.AddressText = "Address02";
            this.tD4memCtrl2.Location = new System.Drawing.Point(167, 122);
            this.tD4memCtrl2.Name = "tD4memCtrl2";
            this.tD4memCtrl2.selectAddress = false;
            this.tD4memCtrl2.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl2.TabIndex = 3;
            // 
            // tD4memCtrl1
            // 
            this.tD4memCtrl1.AddressText = "Address01";
            this.tD4memCtrl1.Location = new System.Drawing.Point(167, 96);
            this.tD4memCtrl1.Name = "tD4memCtrl1";
            this.tD4memCtrl1.selectAddress = false;
            this.tD4memCtrl1.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl1.TabIndex = 2;
            // 
            // tD4memCtrl0
            // 
            this.tD4memCtrl0.AddressText = "Address00";
            this.tD4memCtrl0.Location = new System.Drawing.Point(167, 70);
            this.tD4memCtrl0.Name = "tD4memCtrl0";
            this.tD4memCtrl0.selectAddress = true;
            this.tD4memCtrl0.Size = new System.Drawing.Size(330, 20);
            this.tD4memCtrl0.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(499, 519);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.ChkIn0);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.ChkIn1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ChkIn2);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.ChkIn3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ChkBeep);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LblOutPort);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblPC);
            this.Controls.Add(this.lblC_flg);
            this.Controls.Add(this.lblRegB);
            this.Controls.Add(this.lblRegA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbClock);
            this.Controls.Add(this.tD4memCtrl15);
            this.Controls.Add(this.tD4memCtrl14);
            this.Controls.Add(this.tD4memCtrl13);
            this.Controls.Add(this.tD4memCtrl12);
            this.Controls.Add(this.tD4memCtrl11);
            this.Controls.Add(this.tD4memCtrl10);
            this.Controls.Add(this.tD4memCtrl9);
            this.Controls.Add(this.tD4memCtrl8);
            this.Controls.Add(this.tD4memCtrl7);
            this.Controls.Add(this.tD4memCtrl6);
            this.Controls.Add(this.tD4memCtrl5);
            this.Controls.Add(this.tD4memCtrl4);
            this.Controls.Add(this.tD4memCtrl3);
            this.Controls.Add(this.tD4memCtrl2);
            this.Controls.Add(this.tD4memCtrl1);
            this.Controls.Add(this.tD4memCtrl0);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "TD4 エミュレータ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GbClock.ResumeLayout(false);
            this.GbClock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private TD4memCtrl tD4memCtrl0;
        private TD4memCtrl tD4memCtrl1;
        private TD4memCtrl tD4memCtrl2;
        private TD4memCtrl tD4memCtrl3;
        private TD4memCtrl tD4memCtrl4;
        private TD4memCtrl tD4memCtrl5;
        private TD4memCtrl tD4memCtrl6;
        private TD4memCtrl tD4memCtrl7;
        private TD4memCtrl tD4memCtrl8;
        private TD4memCtrl tD4memCtrl9;
        private TD4memCtrl tD4memCtrl10;
        private TD4memCtrl tD4memCtrl11;
        private TD4memCtrl tD4memCtrl12;
        private TD4memCtrl tD4memCtrl13;
        private TD4memCtrl tD4memCtrl14;
        private TD4memCtrl tD4memCtrl15;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox GbClock;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RbClkManual;
        private System.Windows.Forms.RadioButton RbCloc_10Hz;
        private System.Windows.Forms.RadioButton RbCloc_01Hz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblRegA;
        private System.Windows.Forms.Label lblRegB;
        private System.Windows.Forms.Label lblC_flg;
        private System.Windows.Forms.Label lblPC;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblOutPort;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox ChkBeep;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox ChkIn3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox ChkIn2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox ChkIn1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox ChkIn0;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label21;
    }
}

