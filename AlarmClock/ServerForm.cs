using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;


namespace AlarmClock
{
    public partial class ServerForm : Form
    {
        private List<string> tasks = new List<string>();
        private string ip = "127.0.0.1";
        private int port = 1036;

        IPEndPoint tcpEndPoint;

        Socket tcpSocket;

        public ServerForm()
        {
            InitializeComponent();
            InitializeServer();
            WorkAsync();
        }

        private void InitializeServer()
        {
            tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
            tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            tcpSocket.Bind(tcpEndPoint);
            ConectionInfo.Text = ip + ':' + port;
        }

        private async void WorkAsync()
        {
            await Task.Run(() => Work());
        }

        private void Work()
        {
            tcpSocket.Listen(10);

            while (true)
            {
                byte[] buffer = new byte[256];
                int size = 0;
                string message;
                Socket listener = tcpSocket.Accept();

                size = listener.Receive(buffer);
                message = Encoding.UTF8.GetString(buffer, 0, size);
                if (message.Substring(0, 2) == "/i")
                {
                    IntervalSendAsync(message, listener);
                }
                else if (message.Substring(0, 2) == "/c")
                {
                    ClockSendAsync(message, listener);
                }
            }
        }

        private async void IntervalSendAsync(string message, Socket listener)
        {
            await Task.Run(() =>
            {
                try
                {
                    int interval = int.Parse(message.Substring(2, message.Length - 2));
                    if ( interval < 0)
                    {
                        interval = 0;
                    }
                    string task = "Alarm in " + interval + " seconds after " + DateTime.Now.ToString();
                    tasks.Add(task);
                    ChangeTasks();
                    Thread.Sleep(interval * 1000);

                    listener.Send(Encoding.UTF8.GetBytes("Alarm"));

                    tasks.Remove(task);
                    ChangeTasks();
                }
                catch
                {
                    listener.Send(Encoding.UTF8.GetBytes("Alarm"));
                }
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            });
        }

        private async void ClockSendAsync(string message, Socket listener)
        {
            await Task.Run(() =>
            {
                int interval = (DateTime.Parse(message.Substring(2, message.Length - 2)) - DateTime.Now).Seconds;
                interval = (interval < 0) ? 0 : interval;
                string task = "Alarm on " + message.Substring(2, message.Length - 2);
                tasks.Add(task);
                ChangeTasks();
                Thread.Sleep(interval * 1000);

                listener.Send(Encoding.UTF8.GetBytes("Alarm"));

                tasks.Remove(task);
                ChangeTasks();
                listener.Shutdown(SocketShutdown.Both);
                listener.Close();
            });
        }


        delegate void ChangeTasksCallback();

        private void ChangeTasks()
        {
            if (this.Tasks.InvokeRequired)
            {
                ChangeTasksCallback f = new ChangeTasksCallback(() =>
                {
                    Tasks.Clear();
                    string tasksText = "";
                    foreach (string s in tasks)
                    {
                        tasksText += s + '\n';
                    }
                    Tasks.Text = tasksText;
                });
                this.Invoke(f);
            }
            else
            {
                Tasks.Clear();
                string tasksText = "";
                foreach (string s in tasks)
                {
                    tasksText += s + '\n';
                }
                Tasks.Text = tasksText;
            }
        }
    }
}
