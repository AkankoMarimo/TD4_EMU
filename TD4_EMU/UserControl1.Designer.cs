namespace TD4_EMU
{
    partial class TD4memCtrl
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(115, 3);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(14, 14);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "128";
            this.checkBox1.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(99, 3);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(14, 14);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "64";
            this.checkBox2.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(83, 3);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(14, 14);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "32";
            this.checkBox3.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.Location = new System.Drawing.Point(67, 3);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(14, 14);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "16";
            this.checkBox4.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox5
            // 
            this.checkBox5.Location = new System.Drawing.Point(51, 3);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(14, 14);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "8";
            this.checkBox5.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox6
            // 
            this.checkBox6.Location = new System.Drawing.Point(35, 3);
            this.checkBox6.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(14, 14);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "4";
            this.checkBox6.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox7
            // 
            this.checkBox7.Location = new System.Drawing.Point(19, 3);
            this.checkBox7.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(14, 14);
            this.checkBox7.TabIndex = 6;
            this.checkBox7.Text = "2";
            this.checkBox7.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // checkBox8
            // 
            this.checkBox8.Location = new System.Drawing.Point(3, 3);
            this.checkBox8.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(14, 14);
            this.checkBox8.TabIndex = 7;
            this.checkBox8.Text = "1";
            this.checkBox8.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // lblAddress
            // 
            this.lblAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddress.Location = new System.Drawing.Point(133, 1);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(70, 16);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address00";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(209, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "NOP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(298, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TD4memCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.checkBox8);
            this.Controls.Add(this.checkBox7);
            this.Controls.Add(this.checkBox6);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Name = "TD4memCtrl";
            this.Size = new System.Drawing.Size(330, 20);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
