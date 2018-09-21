using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD4_EMU
{
    public partial class frmMain : Form
    {
        private int RegA = 0;
        private int RegB = 0;
        private int CFlg = 0;
        private int PC = 0;
        private int OutP = 0;
        private int In_P = 0;

        public frmMain()
        {
            InitializeComponent();
            // 値初期化
            RegA = RegB = CFlg = PC = OutP = In_P = 0;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TD4 エミュレータ TN-CS\r\n Ver.1.00", "TD4", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TD4_Reset();
        }

        private void TD4_Reset()
        {
            TD4_EMU.TD4memCtrl c;

            RegA = RegB = CFlg = PC = OutP = In_P = 0;

            for (int i = 1; i < 16; i++)
            {
                c = (TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + i];
                if (c != null)
                {
                    c.selectAddress = false;
                }
                else
                {
                    break;
                }
            }
            tD4memCtrl0.selectAddress = true;
            lblRegA.Text = int2binString(RegA);
            lblRegB.Text = int2binString(RegB);
            lblC_flg.Text = CFlg.ToString();
            lblPC.Text = int2binString(PC);
            InputSet(In_P);
            LblOutPort.Text = int2OutString(OutP);
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Start();
            }
        }

        private void TD4_Prog_Reset()
        {
            TD4_EMU.TD4memCtrl c;
            for (int i = 0; i < 16; i++)
            {
                c = (TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + i];
                if (c != null)
                {
                    c.setNum(0);
                }
                else
                {
                    break;
                }
            }
        }

        private void TD4_Clock_In()
        {
            TD4_EMU.TD4memCtrl c = (TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + PC];
            int chkNum = c.check_num();
            int OpcNum = chkNum >> 4;
            int ImNum = chkNum & 0xF;
            int Input = InputCheck();

            switch (OpcNum)
            {
                case 0: // ADD A Im
                    RegA = RegA + ImNum;
                    if ((RegA & 0x10) != 0) { CFlg = 1; RegA &= 0xF; } else CFlg = 0;
                    this.lblRegA.Text = int2binString(RegA);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 1: // MOV A B (Im)
                    RegA = RegB + ImNum;
                    if ((RegA & 0x10) != 0) { CFlg = 1; RegA &= 0xF; } else CFlg = 0;
                    this.lblRegA.Text = int2binString(RegA);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 2: // IN A (Im)
                    RegA = Input + ImNum;
                    if ((RegA & 0x10) != 0) { CFlg = 1; RegA &= 0xF; } else CFlg = 0;
                    this.lblRegA.Text = int2binString(RegA);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 3: // MOV A Im
                    RegA = ImNum;
                    CFlg = 0;
                    this.lblRegA.Text = int2binString(RegA);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 4: // MOV B A (Im)
                    RegB = RegA + ImNum;
                    if ((RegB & 0x10) != 0) { CFlg = 1; RegB &= 0xF; } else CFlg = 0;
                    this.lblRegB.Text = int2binString(RegB);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 5: // ADD B Im
                    RegB = RegB + ImNum;
                    if ((RegB & 0x10) != 0) { CFlg = 1; RegB &= 0xF; } else CFlg = 0;
                    this.lblRegB.Text = int2binString(RegB);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 6: // IN B (Im)
                    RegB = Input + ImNum;
                    if ((RegB & 0x10) != 0) { CFlg = 1; RegB &= 0xF; } else CFlg = 0;
                    this.lblRegB.Text = int2binString(RegB);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 7: // MOV B Im
                    RegB = ImNum;
                    CFlg = 0;
                    this.lblRegB.Text = int2binString(RegB);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 8: // OUT B (Im)
                    OutP = RegB + ImNum;
                    if ((OutP & 0x10) != 0) { CFlg = 1; OutP &= 0xF; } else CFlg = 0;
                    this.LblOutPort.Text = int2OutString(OutP);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 9: //  OUT B (Im)
                    OutP = RegB + ImNum;
                    if ((OutP & 0x10) != 0) { CFlg = 1; OutP &= 0xF; } else CFlg = 0;
                    this.LblOutPort.Text = int2OutString(OutP);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 10: // OUT B (Im)
                    OutP = ImNum;
                    CFlg = 0;
                    this.LblOutPort.Text = int2OutString(OutP);
                    PC = (PC + 1) & 0xF;
                    break;
                case 11: // OUT B (Im)
                    OutP = ImNum;
                    CFlg = 0;
                    this.LblOutPort.Text = int2OutString(OutP);
                    PC = (PC + 1) & 0xF ;
                    break;
                case 12: // JNC B(Im)
                    if (CFlg == 1)
                    {
                        PC = (PC + 1) & 0xF;
                        CFlg = 0;
                    }
                    else
                    {
                        PC = RegB + ImNum;
                        if ((PC & 0x10) != 0) { CFlg = 1; PC &= 0xF; } else CFlg = 0;
                    }
                    break;
                case 13: // JNP B(Im)
                    PC = RegB + ImNum;
                    if ((PC & 0x10) != 0) { CFlg = 1; PC &= 0xF; } else CFlg = 0;
                    break;
                case 14: // JNC Im
                    if (CFlg == 1)
                    {
                        PC = (PC + 1) & 0xF;
                    }
                    else
                    {
                        PC = ImNum;
                    }
                    CFlg = 0;
                    break;
                case 15: // JNP Im
                    PC = ImNum;
                    CFlg = 0;
                    break;
                default:
                    /* 基本ありえない */
                    break;
            }
            this.lblC_flg.Text = CFlg.ToString();
            this.lblPC.Text = int2binString(PC);

            c.selectAddress = false;
            c = (TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + PC];
            c.selectAddress = true;
        }

        private string int2binString(int num)
        {
            string st = "";
            if ((num & 8) != 0) st += "1"; else st += "0";
            if ((num & 4) != 0) st += "1"; else st += "0";
            if ((num & 2) != 0) st += "1"; else st += "0";
            if ((num & 1) != 0) st += "1"; else st += "0";
            return st;
        }

        private string int2OutString(int num)
        {
            string st = "";
            if ((num & 8) != 0) st += "●"; else st += "○";
            if ((num & 4) != 0) st += "●"; else st += "○";
            if ((num & 2) != 0) st += "●"; else st += "○";
            if ((num & 1) != 0) st += "●"; else st += "○";
            return st;
        }

        private int InputCheck()
        {
            int Inum = 0;
            Control c;
            for (int i = 0; i < 4; i++)
            {
                c = this.Controls["ChkIn" + i];
                if (c != null)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        Inum += (int)Math.Pow(2, i);
                    }
                }
                else
                {
                    break;
                }
            }
            return Inum;
        }

        private void InputSet(int num)
        {
            Control c;
            for (int i = 1; i <= 4; i++)
            {
                c = this.Controls["ChkIn" + i];
                if (c != null)
                {
                    if ((num & (int)Math.Pow(2, i - 1)) != 0)
                    {
                        ((CheckBox)c).Checked = true;
                    }
                    else
                    {
                        ((CheckBox)c).Checked = false;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private void LoadTd4File(string Fname)
        {
            int readnum;
            int readtmp;
            string readst;
            TD4_Reset();
            using ( System.IO.StreamReader sr =
                    new System.IO.StreamReader(Fname, Encoding.GetEncoding("Shift_JIS")))
            {
                for (int i = 0; i < 16; i++)
                {
                    readnum = 0;
                    for (int j = 0; j < 8; j++)
                    {
                        readst = sr.ReadLine();
                        int.TryParse(readst, out readtmp);
                        readnum += readtmp * 1 << j;
                    }
                    ((TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + i]).setNum(readnum);
                }
                readst = sr.ReadLine();
                RbCloc_01Hz.Checked = str2bool(readst);
                readst = sr.ReadLine();
                RbCloc_10Hz.Checked = str2bool(readst);
                readst = sr.ReadLine();
                RbClkManual.Checked = str2bool(readst);
                readst = sr.ReadLine();
                ChkBeep.Checked = str2bool(readst);
            }
        }

        private void SaveTd4File(string Fname)
        {
            int writenum;
            string writest;
            using (System.IO.StreamWriter sw =
                    new System.IO.StreamWriter(Fname,false,Encoding.GetEncoding("Shift_JIS")))
            {
                for (int i = 0; i < 16; i++)
                {
                    writenum = ((TD4_EMU.TD4memCtrl)this.Controls["tD4memCtrl" + i]).check_num();
                    for (int j = 0; j < 8; j++)
                    {
                        if ((writenum & 1 << j) != 0) writest = "1"; else writest = "0";
                        sw.WriteLine(writest);
                    }
                }
                sw.WriteLine(bool2Str(RbCloc_01Hz.Checked));
                sw.WriteLine(bool2Str(RbCloc_10Hz.Checked));
                sw.WriteLine(bool2Str(RbClkManual.Checked));
                sw.WriteLine(ChkBeep.Checked == true ? "1":"0");
            }
        }

        private bool str2bool(string st)
        {
            bool rtn = false;
            if (st == "#TRUE#") rtn = true;
            if (st == "1") rtn = true;
            return rtn;
        }

        private string bool2Str(bool bl)
        {
            string rtn = "#FALSE#";
            if (bl) rtn = "#TRUE#";
            return rtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TD4_Clock_In();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TD4_Prog_Reset();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TD4_Clock_In();
        }

        private void RbCloc_01Hz_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 1000; // 1000mSec間隔 = 1Hz
            timer1.Start();
        }

        private void RbCloc_10Hz_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Interval = 100; // 100mSec間隔 = 10Hz
            timer1.Start();
        }

        private void RbClkManual_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "td4 files (*.td4)|*.td4|すべてのファイル(*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FilterIndex = 1;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                LoadTd4File(openFileDialog1.FileName);
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "td4 files (*.td4)|*.td4|すべてのファイル(*.*)|*.*";
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.CheckPathExists = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SaveTd4File(saveFileDialog1.FileName);
            }


        }
    }
}
