namespace SVNDiff
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnStart = new System.Windows.Forms.Button();
            this.txtRemotePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstRevision = new System.Windows.Forms.TextBox();
            this.txtSecondRevision = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbComparedEvery = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOutputPath = new System.Windows.Forms.TextBox();
            this.btnSelectOutPath = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.sfdSave = new System.Windows.Forms.SaveFileDialog();
            this.txtInclude = new System.Windows.Forms.TextBox();
            this.lbPath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbDontInclude = new System.Windows.Forms.RadioButton();
            this.rbInclude = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbWriteFirstRevision = new System.Windows.Forms.CheckBox();
            this.cbDontIncludeDelete = new System.Windows.Forms.CheckBox();
            this.cbWriteFirstAction = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(72, 323);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtRemotePath
            // 
            this.txtRemotePath.Location = new System.Drawing.Point(118, 20);
            this.txtRemotePath.Name = "txtRemotePath";
            this.txtRemotePath.Size = new System.Drawing.Size(416, 19);
            this.txtRemotePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "要比对的SVN目录";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "对比版本号";
            // 
            // txtFirstRevision
            // 
            this.txtFirstRevision.Location = new System.Drawing.Point(118, 56);
            this.txtFirstRevision.Name = "txtFirstRevision";
            this.txtFirstRevision.Size = new System.Drawing.Size(125, 19);
            this.txtFirstRevision.TabIndex = 4;
            // 
            // txtSecondRevision
            // 
            this.txtSecondRevision.Location = new System.Drawing.Point(307, 56);
            this.txtSecondRevision.Name = "txtSecondRevision";
            this.txtSecondRevision.Size = new System.Drawing.Size(104, 19);
            this.txtSecondRevision.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "-";
            // 
            // cbComparedEvery
            // 
            this.cbComparedEvery.AutoSize = true;
            this.cbComparedEvery.Location = new System.Drawing.Point(450, 58);
            this.cbComparedEvery.Name = "cbComparedEvery";
            this.cbComparedEvery.Size = new System.Drawing.Size(84, 16);
            this.cbComparedEvery.TabIndex = 7;
            this.cbComparedEvery.Text = "逐版本对比";
            this.cbComparedEvery.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "输出文件路径";
            // 
            // txtOutputPath
            // 
            this.txtOutputPath.Location = new System.Drawing.Point(118, 94);
            this.txtOutputPath.Name = "txtOutputPath";
            this.txtOutputPath.Size = new System.Drawing.Size(367, 19);
            this.txtOutputPath.TabIndex = 9;
            // 
            // btnSelectOutPath
            // 
            this.btnSelectOutPath.Location = new System.Drawing.Point(498, 92);
            this.btnSelectOutPath.Name = "btnSelectOutPath";
            this.btnSelectOutPath.Size = new System.Drawing.Size(36, 23);
            this.btnSelectOutPath.TabIndex = 10;
            this.btnSelectOutPath.Text = "...";
            this.btnSelectOutPath.UseVisualStyleBackColor = true;
            this.btnSelectOutPath.Click += new System.EventHandler(this.btnSelectOutPath_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 323);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "退出";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // sfdSave
            // 
            this.sfdSave.DefaultExt = "xlsx";
            this.sfdSave.Filter = "XLSX文件|*.xlsx|所有文件|*.*";
            // 
            // txtInclude
            // 
            this.txtInclude.Location = new System.Drawing.Point(118, 161);
            this.txtInclude.Multiline = true;
            this.txtInclude.Name = "txtInclude";
            this.txtInclude.Size = new System.Drawing.Size(416, 82);
            this.txtInclude.TabIndex = 12;
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Location = new System.Drawing.Point(12, 164);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(65, 12);
            this.lbPath.TabIndex = 13;
            this.lbPath.Text = "不包含路径";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "包含模式";
            // 
            // rbDontInclude
            // 
            this.rbDontInclude.AutoSize = true;
            this.rbDontInclude.Checked = true;
            this.rbDontInclude.Location = new System.Drawing.Point(118, 131);
            this.rbDontInclude.Name = "rbDontInclude";
            this.rbDontInclude.Size = new System.Drawing.Size(107, 16);
            this.rbDontInclude.TabIndex = 15;
            this.rbDontInclude.TabStop = true;
            this.rbDontInclude.Text = "不包含指定名称";
            this.rbDontInclude.UseVisualStyleBackColor = true;
            this.rbDontInclude.CheckedChanged += new System.EventHandler(this.rbDontInclude_CheckedChanged);
            // 
            // rbInclude
            // 
            this.rbInclude.AutoSize = true;
            this.rbInclude.Location = new System.Drawing.Point(281, 131);
            this.rbInclude.Name = "rbInclude";
            this.rbInclude.Size = new System.Drawing.Size(95, 16);
            this.rbInclude.TabIndex = 16;
            this.rbInclude.Text = "包含指定名称";
            this.rbInclude.UseVisualStyleBackColor = true;
            this.rbInclude.CheckedChanged += new System.EventHandler(this.rbInclude_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "（一行一个）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 18;
            this.label7.Text = "其他选项";
            // 
            // cbWriteFirstRevision
            // 
            this.cbWriteFirstRevision.AutoSize = true;
            this.cbWriteFirstRevision.Location = new System.Drawing.Point(118, 265);
            this.cbWriteFirstRevision.Name = "cbWriteFirstRevision";
            this.cbWriteFirstRevision.Size = new System.Drawing.Size(156, 16);
            this.cbWriteFirstRevision.TabIndex = 19;
            this.cbWriteFirstRevision.Text = "备注显示首次修改版本号";
            this.cbWriteFirstRevision.UseVisualStyleBackColor = true;
            // 
            // cbDontIncludeDelete
            // 
            this.cbDontIncludeDelete.AutoSize = true;
            this.cbDontIncludeDelete.Checked = true;
            this.cbDontIncludeDelete.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDontIncludeDelete.Location = new System.Drawing.Point(307, 265);
            this.cbDontIncludeDelete.Name = "cbDontIncludeDelete";
            this.cbDontIncludeDelete.Size = new System.Drawing.Size(120, 16);
            this.cbDontIncludeDelete.TabIndex = 20;
            this.cbDontIncludeDelete.Text = "不计入已删除文件";
            this.cbDontIncludeDelete.UseVisualStyleBackColor = true;
            // 
            // cbWriteFirstAction
            // 
            this.cbWriteFirstAction.AutoSize = true;
            this.cbWriteFirstAction.Location = new System.Drawing.Point(118, 287);
            this.cbWriteFirstAction.Name = "cbWriteFirstAction";
            this.cbWriteFirstAction.Size = new System.Drawing.Size(144, 16);
            this.cbWriteFirstAction.TabIndex = 21;
            this.cbWriteFirstAction.Text = "备注显示首次处理动作";
            this.cbWriteFirstAction.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 369);
            this.Controls.Add(this.cbWriteFirstAction);
            this.Controls.Add(this.cbDontIncludeDelete);
            this.Controls.Add(this.cbWriteFirstRevision);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rbInclude);
            this.Controls.Add(this.rbDontInclude);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.txtInclude);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSelectOutPath);
            this.Controls.Add(this.txtOutputPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbComparedEvery);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSecondRevision);
            this.Controls.Add(this.txtFirstRevision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRemotePath);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SVN版本对比工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtRemotePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstRevision;
        private System.Windows.Forms.TextBox txtSecondRevision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbComparedEvery;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOutputPath;
        private System.Windows.Forms.Button btnSelectOutPath;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.SaveFileDialog sfdSave;
        private System.Windows.Forms.TextBox txtInclude;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbDontInclude;
        private System.Windows.Forms.RadioButton rbInclude;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbWriteFirstRevision;
        private System.Windows.Forms.CheckBox cbDontIncludeDelete;
        private System.Windows.Forms.CheckBox cbWriteFirstAction;
    }
}

