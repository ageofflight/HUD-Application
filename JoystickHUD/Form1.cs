using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;

namespace JoystickHUD
{
    public partial class Form1 : Form
    {

        public double k = 0;
        //可变字符串类，用于存储接收到的字符
        private StringBuilder Builder = new StringBuilder();

        //public USBJoystick.USBJoyStick JoyStick { get; set; }
        private JoystickInterface.Joystick jst;

        public Form1()
        {
            //JoyStick = new USBJoystick.USBJoyStick();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //k++;
            //statusChart1.Value = (int)(180 * Math.Sin((double)(k / 180) * Math.PI) + 180);

            // get status
            jst.UpdateStatus();

            statusChart1.Value = jst.AxisD;

            // update the axes positions
            textBoxYaw.Text = Convert.ToString(jst.AxisA);
            textBoxRoll.Text = Convert.ToString(jst.AxisC);
            textBoxPitch.Text = Convert.ToString(((float)(jst.AxisD-32767)/32767)*90);

            huD_Graphic1.Pitch = ((float)(jst.AxisD - 32767) / 32767) * 100;
            huD_Graphic1.Roll = ((float)(jst.AxisC - 32767) / 32767) * 90;
            huD_Graphic1.Heading = ((float)(jst.AxisA - 32767) / 32767) * 360;
            huD_Graphic1.Draw();

            compass1.Heading = ((float)(jst.AxisA - 32767) / 32767) * 360;
            compass1.DrawCompass();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region 初始化下拉串口名称列表框

            //获取单片机与计算机连接的端口号
            string[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            //将其显示到comboPorName控件中去
            comboBoxPortNum.Items.AddRange(ports);
            comboBoxPortNum.SelectedIndex = comboBoxPortNum.Items.Count > 0 ? 0 : -1;

            //波特率默认为9600bps，可以通过下拉选项进行调节
            comboBoxBundRate.SelectedIndex = comboBoxBundRate.Items.IndexOf("9600");

            #endregion

            //下面这句还不太懂，先照着做
            serialPort1.NewLine = "\r\n";

            //与设置RTS信号有关，虽不明，但觉厉，照着做
            serialPort1.RtsEnable = true;

            //注册对串口接收数据的响应方法
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

            // grab the joystick
            jst = new JoystickInterface.Joystick(this.Handle);
            string[] sticks = jst.FindJoysticks();
            jst.AcquireJoystick(sticks[0]);

            textBoxDevice.Text = jst.ToString();

            // start updating positions
            timer1.Enabled = true;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //获取接收缓冲区中数据的字节数
            int n = serialPort1.BytesToRead;
            byte[] buf = new byte[n];

            //将数据读入buf数组中
            serialPort1.Read(buf, 0, n);

            //先清空
            //Builder.Clear();

            //因为要访问ui资源，所以需要使用invoke方式同步ui
            this.Invoke((EventHandler)(delegate
            {
                //委托方法在txGet控件中显示接收到的字符
                Builder.Append(Encoding.ASCII.GetString(buf));
                this.textBox6.AppendText(Builder.ToString());

            }));
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //如果串口已经是打开状态，则此按钮关闭串口
            if (this.serialPort1.IsOpen)
            {
                this.serialPort1.Close();
            }
            //串口关闭状态，打开之
            else
            {
                //设置好端口名和波特率
                serialPort1.PortName = this.comboBoxPortNum.Text;
                serialPort1.BaudRate = int.Parse(this.comboBoxBundRate.Text);

                try
                {
                    serialPort1.Open();
                }
                //打开失败，抛出异常
                catch (Exception ex)
                {
                    serialPort1 = new SerialPort();
                    MessageBox.Show(ex.Message);
                }

            }

            //按钮显示文字转变
            this.buttonOpen.Text = serialPort1.IsOpen ? "关闭串口" : "打开串口";

            //发送按钮功能使能
            this.buttonOpen.Enabled = serialPort1.IsOpen;
        }
    }
}
