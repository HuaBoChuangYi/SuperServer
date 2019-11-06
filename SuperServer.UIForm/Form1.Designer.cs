namespace SuperServer.UIForm
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
            this.m_btnClearLog = new System.Windows.Forms.Button();
            this.m_btnRefresh = new System.Windows.Forms.Button();
            this.m_tree = new System.Windows.Forms.TreeView();
            this.m_richTextInfo = new System.Windows.Forms.RichTextBox();
            this.m_richTextLog = new System.Windows.Forms.RichTextBox();
            this.m_labelStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_btnClearLog
            // 
            this.m_btnClearLog.Location = new System.Drawing.Point(372, 12);
            this.m_btnClearLog.Name = "m_btnClearLog";
            this.m_btnClearLog.Size = new System.Drawing.Size(92, 23);
            this.m_btnClearLog.TabIndex = 11;
            this.m_btnClearLog.Text = "清空传输信息";
            this.m_btnClearLog.UseVisualStyleBackColor = true;
            // 
            // m_btnRefresh
            // 
            this.m_btnRefresh.Location = new System.Drawing.Point(291, 12);
            this.m_btnRefresh.Name = "m_btnRefresh";
            this.m_btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.m_btnRefresh.TabIndex = 10;
            this.m_btnRefresh.Text = "刷新连接";
            this.m_btnRefresh.UseVisualStyleBackColor = true;
            // 
            // m_tree
            // 
            this.m_tree.Dock = System.Windows.Forms.DockStyle.Left;
            this.m_tree.Location = new System.Drawing.Point(0, 0);
            this.m_tree.Name = "m_tree";
            this.m_tree.Size = new System.Drawing.Size(268, 428);
            this.m_tree.TabIndex = 9;
            // 
            // m_richTextInfo
            // 
            this.m_richTextInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_richTextInfo.Location = new System.Drawing.Point(0, 0);
            this.m_richTextInfo.Name = "m_richTextInfo";
            this.m_richTextInfo.Size = new System.Drawing.Size(800, 428);
            this.m_richTextInfo.TabIndex = 6;
            this.m_richTextInfo.Text = "";
            // 
            // m_richTextLog
            // 
            this.m_richTextLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_richTextLog.Location = new System.Drawing.Point(0, 0);
            this.m_richTextLog.Name = "m_richTextLog";
            this.m_richTextLog.Size = new System.Drawing.Size(800, 428);
            this.m_richTextLog.TabIndex = 7;
            this.m_richTextLog.Text = "";
            // 
            // m_labelStatus
            // 
            this.m_labelStatus.Name = "m_labelStatus";
            this.m_labelStatus.Size = new System.Drawing.Size(42, 17);
            this.m_labelStatus.Text = "status";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m_labelStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.m_btnClearLog);
            this.Controls.Add(this.m_btnRefresh);
            this.Controls.Add(this.m_tree);
            this.Controls.Add(this.m_richTextInfo);
            this.Controls.Add(this.m_richTextLog);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btnClearLog;
        private System.Windows.Forms.Button m_btnRefresh;
        private System.Windows.Forms.TreeView m_tree;
        private System.Windows.Forms.RichTextBox m_richTextInfo;
        private System.Windows.Forms.RichTextBox m_richTextLog;
        private System.Windows.Forms.ToolStripStatusLabel m_labelStatus;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}

