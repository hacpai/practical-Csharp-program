namespace AutoScore
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lBxRst = new System.Windows.Forms.ListBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAns = new System.Windows.Forms.TextBox();
            this.BtnCmt = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lBxRst
            // 
            this.lBxRst.FormattingEnabled = true;
            this.lBxRst.ItemHeight = 21;
            this.lBxRst.Location = new System.Drawing.Point(25, 23);
            this.lBxRst.Name = "lBxRst";
            this.lBxRst.Size = new System.Drawing.Size(463, 214);
            this.lBxRst.TabIndex = 0;
            this.lBxRst.SelectedIndexChanged += new System.EventHandler(this.lBxRst_SelectedIndexChanged);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Location = new System.Drawing.Point(25, 294);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(0, 21);
            this.lblL.TabIndex = 1;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(125, 294);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 21);
            this.lblOp.TabIndex = 2;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(228, 294);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(0, 21);
            this.lblR.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "=";
            // 
            // txtAns
            // 
            this.txtAns.Location = new System.Drawing.Point(378, 291);
            this.txtAns.Name = "txtAns";
            this.txtAns.Size = new System.Drawing.Size(100, 31);
            this.txtAns.TabIndex = 5;
            // 
            // BtnCmt
            // 
            this.BtnCmt.Location = new System.Drawing.Point(187, 359);
            this.BtnCmt.Name = "BtnCmt";
            this.BtnCmt.Size = new System.Drawing.Size(101, 45);
            this.BtnCmt.TabIndex = 7;
            this.BtnCmt.Text = "提交";
            this.BtnCmt.UseVisualStyleBackColor = true;
            this.BtnCmt.Click += new System.EventHandler(this.BtnCmt_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 457);
            this.Controls.Add(this.BtnCmt);
            this.Controls.Add(this.txtAns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblL);
            this.Controls.Add(this.lBxRst);
            this.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBxRst;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAns;
        private System.Windows.Forms.Button BtnCmt;
        private System.Windows.Forms.Timer timer1;
    }
}

