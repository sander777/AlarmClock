using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class ClientForm : Form
    {
        private string ip = "127.0.0.1";
        private int port = 1036;

        public ClientForm()
        {
            InitializeComponent();
        }

        private async void AlarmAsync(int seconds)
        {
            await Task.Run(() => Alarm(seconds));
        }

        private void Alarm(int seconds)
        {
            for (int i = 0; i / 2 < seconds; i++)
            {
                AlarmLabel.ForeColor = Color.Red;
                Thread.Sleep(250);
                AlarmLabel.ForeColor = Color.LightGray;
                Thread.Sleep(500);
            }
        }

        private void TimerForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private async void IntervalWait()
        {
            await Task.Run(() =>
            {
                try
                {
                    IPEndPoint tcpEndPoint;
                    Socket tcpSocket;
                    tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                    tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    tcpSocket.Connect(tcpEndPoint);
                    try
                    {
                        tcpSocket.Send(Encoding.UTF8.GetBytes("/i" + int.Parse(TimerForm.Text)));
                    }
                    catch
                    {
                        tcpSocket.Send(Encoding.UTF8.GetBytes("/i" + 0));
                    }
                    byte[] buffer = new byte[256];
                    int size = 0;
                    string message;

                    size = tcpSocket.Receive(buffer);
                    message = Encoding.UTF8.GetString(buffer, 0, size);
                    if (message == "Alarm")
                    {
                        AlarmAsync(3);
                    }
                    tcpSocket.Shutdown(SocketShutdown.Both);
                    tcpSocket.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private async void ClockWait()
        {
            await Task.Run(() =>
            {
                try
                {
                    IPEndPoint tcpEndPoint;
                    Socket tcpSocket;
                    tcpEndPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                    tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    tcpSocket.Connect(tcpEndPoint);

                    tcpSocket.Send(Encoding.UTF8.GetBytes("/c" + dateTimePicker.Value.ToString()));
                    byte[] buffer = new byte[256];
                    int size = 0;
                    string message;

                    size = tcpSocket.Receive(buffer);
                    message = Encoding.UTF8.GetString(buffer, 0, size);
                    if (message == "Alarm")
                    {
                        AlarmAsync(3);
                    }
                    tcpSocket.Shutdown(SocketShutdown.Both);
                    tcpSocket.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            });
        }

        private void SetAlarmClock_Click(object sender, EventArgs e)
        { 
            ClockWait();
        }

        private void SetTimer_Click(object sender, EventArgs e)
        {
            IntervalWait();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateTimePicker.Value = DateTime.Now;
        }

        private void dateTimePicker_Enter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
