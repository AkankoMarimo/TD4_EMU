using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace TD4_EMU
{
    public partial class TD4memCtrl : UserControl
    {
        private String[,] stOpc = new String[,] {
            {"NOP       ","ADD A Im  "},
            {"MOV A B   ","MOV A B+Im"},
            {"IN  A     ","IN A IN+Im"},
            {"MOV A Im  ","MOV A Im  "},
            {"MOV B A   ","MOV B A   "},
            {"ADD B Im  ","ADD B Im  "},
            {"IN  B     ","IN  B     "},
            {"MOV B Im  ","MOV B Im  "},
            {"OUT B     ","OUT B+Im  "},
            {"OUT B     ","OUT B+Im  "},
            {"OUT Im    ","OUT Im    "},
            {"OUT Im    ","OUT Im    "},
            {"JNC B     ","JNC B+Im  "},
            {"JMP B     ","JMP B+Im  "},
            {"JNC Im    ","JNC Im    "},
            {"JMP Im    ","JMP Im    "}
        };

        private bool _selectAddress = false;

        public string AddressText
        {
            get
            {
                return lblAddress.Text;
            }
            set
            {
                lblAddress.Text = value;
            }
        }
        public bool selectAddress
        {
            get
            {
                return _selectAddress;
            }
            set
            {
                _selectAddress = value;
                if (_selectAddress == true)
                {
                    lblAddress.BackColor = Color.Red;
                }
                else
                {
                    lblAddress.BackColor = SystemColors.Control;
                }
            }
        }




        public TD4memCtrl()
        {
            InitializeComponent();
        }

        public TD4memCtrl(int No)
        {
            InitializeComponent();
            lblAddress.Text = "Address" + No.ToString("D02");
        }
        //
        // コントロール名が、chekcBox1 ～ 8 と連番になっている前提で、
        // コントロール名(String)で検索する。
        // コントロールのインデックス的数値から累積加算させることで値を求める。
        // C#では ＾ はxorなので、注意　orz VBならべき乗なのに、、、って　Cでもか。
        // C#の場合、Math.Powでべき乗演算。ただし、Doubleなのでキャスト必須。
        //
        public int check_num()
        {
            int chkNum = 0;
            Control c;
            for (int i = 1; ; i++)
            {
                c = this.Controls["checkBox" + i];
                if (c != null)
                {
                    if (((CheckBox)c).Checked == true)
                    {
                        chkNum += (int)Math.Pow(2,i-1);
                    }
                }
                else
                {
                    break;
                }
            }
            return chkNum;
        }

        public bool setNum(int setNum)
        {
            Control c;
            if (setNum >= 0 && setNum < 256)
            {
                for (int i = 1; ; i++)
                {
                    c = this.Controls["checkBox" + i];
                    if (c != null)
                    {
                        if ((setNum & (int)Math.Pow(2, i - 1)) != 0)
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
                setOpcIm();
            }
            else
            {
                return false;
            }

            return true;
        }


        private void checkBox_Click(object sender, EventArgs e)
        {
            setOpcIm();
        }

        private void setOpcIm()
        {
            int chkNum = check_num();
            int OpcNum = chkNum >> 4;
            int ImNum = chkNum & 0xF;
            int ImZero;

            if (ImNum == 0)
            {
                ImZero = 0;
            }
            else
            {
                ImZero = 1;
            }
            label1.Text = stOpc[OpcNum, ImZero];
            label2.Text = ImNum.ToString("D0");
        }

   }
}
