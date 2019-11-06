using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SuperSocket.SocketEngine;
using System.Configuration;
using DevExpress.XtraEditors;

namespace SuperServer.UIDX
{
    public partial class FormMain : DevExpress.XtraBars.Ribbon.RibbonForm, ILog
    {
        /// <summary>
        /// 日志信息
        /// </summary>
        public List<LogMessage> Messages { get; set; }
        public int Interval { get { return Convert.ToInt32(ConfigurationManager.AppSettings["interval"]); } }
        public int Max { get { return Convert.ToInt32(ConfigurationManager.AppSettings["max"]); } }
        public static object obj = new object();
        public Timer TimerRefresh { get; set; }
        public Timer TimerClear { get; set; }


        public FormMain()
        {
            InitializeComponent();
        }
        private void RibbonForm1_Load(object sender, EventArgs e)
        {
            Logger.LogForm = this;
            this.Messages = new List<LogMessage>();
            this.TimerClear = new Timer { Interval = this.Interval * 1000 };
            this.TimerRefresh = new Timer { Interval = this.Interval * 1000 };
            this.TimerClear.Tick += (m, n) => { RemoveData(); };
            this.TimerRefresh.Tick += (m, n) => { RefreshData(); };
            this.TimerClear.Start();
            this.TimerRefresh.Start();

            var bootstrap = BootstrapFactory.CreateBootstrap();

            if (!bootstrap.Initialize())
            {
                m_txtStatus.Caption = "失败";
                return;
            }
            var result = bootstrap.Start();
            m_txtStatus.Caption = "服务启动成功";

        }

        public void Error(string message)
        {

        }


        public void Log(LogMessage message)
        {
            Action<LogMessage> actionDelegate = (s) =>
            {
                lock (obj)
                {
                    if (this.Messages.Count > 10000)
                    {
                        this.Messages.RemoveRange(9000, 1000);
                    }
                }
                this.Messages.Insert(0, s);
                m_gridLog.DataSource = this.Messages;
                m_gridLog.RefreshDataSource();
            };
            // =
            this.m_gridLog.Invoke(actionDelegate, message);

        }

        private void m_btnRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshData();
        }

        public void RefreshData()
        {
            m_treeSockets.Nodes.Clear();
            var webNode = m_treeSockets.AppendNode(new[] { "Web" }, -1);
            MyAppServer.Sessions.Where(s => s.WebSocketSession != null).ToList().ForEach(s =>
            {
                var node = m_treeSockets.AppendNode(new[] { s.IP }, webNode, s);
            });

            var clientNode = m_treeSockets.AppendNode(new[] { "client" }, -1);
            MyAppServer.Sessions.Where(s => s.AppSession != null).ToList().ForEach(s =>
            {
                var node = m_treeSockets.AppendNode(new[] { s.IP }, clientNode, s);
                node.Tag = s;
            });

            m_treeSockets.ExpandAll();
        }


        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        //点击连接Socket
        private void m_treeSockets_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node == null) return;
            var data = e.Node.Tag as ConnectSession;
            if (data != null)
            {
                if (data.AppSession != null)
                {
                    //m_propSession.
                    m_propSession.SelectedObject = data;
                }
                else if (data.WebSocketSession != null)
                {
                    m_propSession.SelectedObject = data;
                }
            }
            else
            {
                m_propSession.SelectedObject = null;
            }


        }

        private void m_btnClear_ItemClick(object sender, ItemClickEventArgs e)
        {
            RemoveData();
        }

        /// <summary>
        /// 清空数据
        /// </summary>
        public void RemoveData()
        {
            this.Messages.Clear();
            m_gridLog.RefreshDataSource();
            //this.Messages.RemoveRange(this.Max, 100);
        }

        private void m_switchRefresh_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (m_switchRefresh.Checked)
            {
                this.TimerRefresh.Start();
            }
            else
            {
                this.TimerRefresh.Stop();
            }
        }

        private void m_switchClear_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (m_switchClear.Checked)
            {
                this.TimerClear.Start();
            }
            else
            {
                this.TimerClear.Stop();
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (XtraMessageBox.Show("是否关闭", "提醒", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}