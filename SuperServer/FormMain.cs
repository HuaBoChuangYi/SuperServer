using SuperSocket.SocketEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperServer
{
    public partial class FormMain : Form
    {
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var bootstrap = BootstrapFactory.CreateBootstrap();

            if (!bootstrap.Initialize())
            {
                m_labelStatus.Text = "失败";
                return;
            }
            var result = bootstrap.Start();
            m_labelStatus.Text = "服务启动成功";


            RefreshData();
        }


        private void m_btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            m_tree.Nodes.Clear();
            var webNode = m_tree.Nodes.Add("web");
            MyAppServer.Sessions.Where(s => s.WebSocketSession != null).ToList().ForEach(s =>
            {
                var node = webNode.Nodes.Add(s.Ip);
                node.Tag = s;
            });

            var clientNode = m_tree.Nodes.Add("client");
            MyAppServer.Sessions.Where(s => s.AppSession != null).ToList().ForEach(s =>
            {
                var node = clientNode.Nodes.Add(s.Ip);
                node.Tag = s;
            });

            m_tree.ExpandAll();
        }

        private void m_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var data = e.Node.Tag as ConnectSession;
            if (data != null)
            {
                if (data.AppSession != null)
                {
                    m_richTextInfo.Text = string.Format("IP:{0};\r\n设备Id:{1};\r\n连接状态:{2};\r\n三方设备:{3}", data.Ip, data.DeviceId, data.SetIdState, data.IsThree ? "是" : "否");
                }
                else if (data.WebSocketSession != null)
                {
                    m_richTextInfo.Text = string.Format("IP:{0};\r\n设备Id:{1};\r\n连接状态:{2}", data.Ip, data.DeviceId, data.SetIdState);
                }
            }
        }

        public void Log(string message)
        {
            if (m_richTextLog.InvokeRequired)
            {
                // 当一个控件的InvokeRequired属性值为真时，说明有一个创建它以外的线程想访问它
                Action<string> actionDelegate = (x) =>
                {
                    m_richTextLog.AppendText(message);
                    m_richTextLog.Select(m_richTextLog.Text.Length, 0);
                    m_richTextLog.ScrollToCaret();
                };
                // =
                this.m_richTextLog.Invoke(actionDelegate, DateTime.Now + " " + message);
            }
            else
            {
                this.m_richTextLog.Text = message;
            }
            //m_richTextLog.Text += message + "\r\n";
        }

        private void m_btnClearLog_Click(object sender, EventArgs e)
        {
            m_richTextLog.Text = "";
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("是否关闭", "提醒", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void m_checkClear_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void m_checkRefresh_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
