namespace SuperServer
{
    partial class FormMain
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.m_labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.m_tree = new System.Windows.Forms.TreeView();
            this.m_btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.m_richTextInfo = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_richTextLog = new System.Windows.Forms.RichTextBox();
            this.m_btnClearLog = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // m_labelStatus
            // 
            this.m_labelStatus.Name = "m_labelStatus";
            this.m_labelStatus.Size = new System.Drawing.Size(42, 17);
            this.m_labelStatus.Text = "status";
            // 
            // m_tree
            // 
            this.m_tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_tree.Location = new System.Drawing.Point(0, 0);
            this.m_tree.Name = "m_tree";
            this.m_tree.Size = new System.Drawing.Size(268, 400);
            this.m_tree.TabIndex = 1;
            this.m_tree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.m_tree_AfterSelect);
            // 
            // m_btnRefresh
            // 
            this.m_btnRefresh.Location = new System.Drawing.Point(291, 12);
            this.m_btnRefresh.Name = "m_btnRefresh";
            this.m_btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.m_btnRefresh.TabIndex = 2;
            this.m_btnRefresh.Text = "刷新连接";
            this.m_btnRefresh.UseVisualStyleBackColor = true;
            this.m_btnRefresh.Click += new System.EventHandler(this.m_btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.m_richTextInfo);
            this.groupBox1.Location = new System.Drawing.Point(275, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 129);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户端信息";
            // 
            // m_richTextInfo
            // 
            this.m_richTextInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_richTextInfo.Location = new System.Drawing.Point(3, 17);
            this.m_richTextInfo.Name = "m_richTextInfo";
            this.m_richTextInfo.Size = new System.Drawing.Size(580, 109);
            this.m_richTextInfo.TabIndex = 0;
            this.m_richTextInfo.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.m_richTextLog);
            this.groupBox2.Location = new System.Drawing.Point(275, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 204);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "传输信息";
            // 
            // m_richTextLog
            // 
            this.m_richTextLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_richTextLog.Location = new System.Drawing.Point(3, 17);
            this.m_richTextLog.Name = "m_richTextLog";
            this.m_richTextLog.Size = new System.Drawing.Size(580, 184);
            this.m_richTextLog.TabIndex = 0;
            this.m_richTextLog.Text = "";
            // 
            // m_btnClearLog
            // 
            this.m_btnClearLog.Location = new System.Drawing.Point(372, 12);
            this.m_btnClearLog.Name = "m_btnClearLog";
            this.m_btnClearLog.Size = new System.Drawing.Size(92, 23);
            this.m_btnClearLog.TabIndex = 5;
            this.m_btnClearLog.Text = "清空传输信息";
            this.m_btnClearLog.UseVisualStyleBackColor = true;
            this.m_btnClearLog.Click += new System.EventHandler(this.m_btnClearLog_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 422);
            this.Controls.Add(this.m_btnClearLog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.m_btnRefresh);
            this.Controls.Add(this.m_tree);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FormMain";
            this.Text = "消息服务器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel m_labelStatus;
        private System.Windows.Forms.TreeView m_tree;
        private System.Windows.Forms.Button m_btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox m_richTextInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox m_richTextLog;
        private System.Windows.Forms.Button m_btnClearLog;
    }
}

