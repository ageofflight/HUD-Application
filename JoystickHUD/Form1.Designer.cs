namespace JoystickHUD
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
            this.compass1 = new Simple_HUD.Compass();
            this.altimeter1 = new Simple_HUD.Altimeter();
            this.huD_Graphic1 = new Simple_HUD.HUD_Graphic();
            this.groupBoxComPort = new System.Windows.Forms.GroupBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.comboBoxBundRate = new System.Windows.Forms.ComboBox();
            this.comboBoxPortNum = new System.Windows.Forms.ComboBox();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelParity = new System.Windows.Forms.Label();
            this.labelBundRate = new System.Windows.Forms.Label();
            this.labelPortNum = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBoxJoystick = new System.Windows.Forms.GroupBox();
            this.textBoxYaw = new System.Windows.Forms.TextBox();
            this.textBoxRoll = new System.Windows.Forms.TextBox();
            this.textBoxPitch = new System.Windows.Forms.TextBox();
            this.textBoxDevice = new System.Windows.Forms.TextBox();
            this.labelYaw = new System.Windows.Forms.Label();
            this.labelRoll = new System.Windows.Forms.Label();
            this.labelPitch = new System.Windows.Forms.Label();
            this.labelDevice = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.statusChart1 = new UI.StatusChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxComPort.SuspendLayout();
            this.groupBoxJoystick.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // compass1
            // 
            this.compass1.Heading = 0F;
            this.compass1.Location = new System.Drawing.Point(12, 12);
            this.compass1.Name = "compass1";
            this.compass1.Size = new System.Drawing.Size(167, 160);
            this.compass1.TabIndex = 0;
            this.compass1.YawRate = 0F;
            // 
            // altimeter1
            // 
            this.altimeter1.Altitude = 0F;
            this.altimeter1.Location = new System.Drawing.Point(552, 12);
            this.altimeter1.Name = "altimeter1";
            this.altimeter1.Size = new System.Drawing.Size(154, 148);
            this.altimeter1.TabIndex = 1;
            // 
            // huD_Graphic1
            // 
            this.huD_Graphic1.Airspeed = 0F;
            this.huD_Graphic1.AlphaBrushColor = System.Drawing.Color.Black;
            this.huD_Graphic1.Altitude = 0F;
            this.huD_Graphic1.BrushAlpha = 70;
            this.huD_Graphic1.BrushTextBackgroundAlpha = 200;
            this.huD_Graphic1.Heading = 0F;
            this.huD_Graphic1.LinePenColor = System.Drawing.Color.White;
            this.huD_Graphic1.Location = new System.Drawing.Point(185, 12);
            this.huD_Graphic1.Name = "huD_Graphic1";
            this.huD_Graphic1.Pitch = 0F;
            this.huD_Graphic1.Roll = 0F;
            this.huD_Graphic1.Size = new System.Drawing.Size(361, 432);
            this.huD_Graphic1.TabIndex = 2;
            this.huD_Graphic1.TextBackgroundBrushColor = System.Drawing.Color.Black;
            this.huD_Graphic1.TextBrushColor = System.Drawing.Color.White;
            // 
            // groupBoxComPort
            // 
            this.groupBoxComPort.Controls.Add(this.comboBoxDataBits);
            this.groupBoxComPort.Controls.Add(this.comboBoxStopBits);
            this.groupBoxComPort.Controls.Add(this.comboBoxBundRate);
            this.groupBoxComPort.Controls.Add(this.comboBoxPortNum);
            this.groupBoxComPort.Controls.Add(this.comboBoxParity);
            this.groupBoxComPort.Controls.Add(this.buttonOpen);
            this.groupBoxComPort.Controls.Add(this.labelDataBits);
            this.groupBoxComPort.Controls.Add(this.labelStopBits);
            this.groupBoxComPort.Controls.Add(this.labelParity);
            this.groupBoxComPort.Controls.Add(this.labelBundRate);
            this.groupBoxComPort.Controls.Add(this.labelPortNum);
            this.groupBoxComPort.Location = new System.Drawing.Point(553, 167);
            this.groupBoxComPort.Name = "groupBoxComPort";
            this.groupBoxComPort.Size = new System.Drawing.Size(154, 183);
            this.groupBoxComPort.TabIndex = 4;
            this.groupBoxComPort.TabStop = false;
            this.groupBoxComPort.Text = "ComPort";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(7, 133);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(94, 20);
            this.comboBoxDataBits.TabIndex = 15;
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Location = new System.Drawing.Point(7, 105);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(94, 20);
            this.comboBoxStopBits.TabIndex = 14;
            // 
            // comboBoxBundRate
            // 
            this.comboBoxBundRate.FormattingEnabled = true;
            this.comboBoxBundRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38300",
            "43000",
            "56000",
            "57600",
            "115200"});
            this.comboBoxBundRate.Location = new System.Drawing.Point(7, 52);
            this.comboBoxBundRate.Name = "comboBoxBundRate";
            this.comboBoxBundRate.Size = new System.Drawing.Size(94, 20);
            this.comboBoxBundRate.TabIndex = 13;
            // 
            // comboBoxPortNum
            // 
            this.comboBoxPortNum.FormattingEnabled = true;
            this.comboBoxPortNum.Location = new System.Drawing.Point(7, 21);
            this.comboBoxPortNum.Name = "comboBoxPortNum";
            this.comboBoxPortNum.Size = new System.Drawing.Size(94, 20);
            this.comboBoxPortNum.TabIndex = 12;
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "Odd",
            "Even",
            "Mark",
            "None",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(7, 80);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(94, 20);
            this.comboBoxParity.TabIndex = 11;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(73, 157);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 20);
            this.buttonOpen.TabIndex = 10;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(103, 136);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(53, 12);
            this.labelDataBits.TabIndex = 9;
            this.labelDataBits.Text = "DataBits";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(103, 108);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(53, 12);
            this.labelStopBits.TabIndex = 7;
            this.labelStopBits.Text = "StopBits";
            // 
            // labelParity
            // 
            this.labelParity.AutoSize = true;
            this.labelParity.Location = new System.Drawing.Point(103, 80);
            this.labelParity.Name = "labelParity";
            this.labelParity.Size = new System.Drawing.Size(41, 12);
            this.labelParity.TabIndex = 6;
            this.labelParity.Text = "Parity";
            // 
            // labelBundRate
            // 
            this.labelBundRate.AutoSize = true;
            this.labelBundRate.Location = new System.Drawing.Point(103, 52);
            this.labelBundRate.Name = "labelBundRate";
            this.labelBundRate.Size = new System.Drawing.Size(53, 12);
            this.labelBundRate.TabIndex = 5;
            this.labelBundRate.Text = "BundRate";
            // 
            // labelPortNum
            // 
            this.labelPortNum.AutoSize = true;
            this.labelPortNum.Location = new System.Drawing.Point(103, 24);
            this.labelPortNum.Name = "labelPortNum";
            this.labelPortNum.Size = new System.Drawing.Size(47, 12);
            this.labelPortNum.TabIndex = 4;
            this.labelPortNum.Text = "PortNum";
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox6.Location = new System.Drawing.Point(560, 357);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox6.Size = new System.Drawing.Size(158, 87);
            this.textBox6.TabIndex = 5;
            // 
            // groupBoxJoystick
            // 
            this.groupBoxJoystick.Controls.Add(this.textBoxYaw);
            this.groupBoxJoystick.Controls.Add(this.textBoxRoll);
            this.groupBoxJoystick.Controls.Add(this.textBoxPitch);
            this.groupBoxJoystick.Controls.Add(this.textBoxDevice);
            this.groupBoxJoystick.Controls.Add(this.labelYaw);
            this.groupBoxJoystick.Controls.Add(this.labelRoll);
            this.groupBoxJoystick.Controls.Add(this.labelPitch);
            this.groupBoxJoystick.Controls.Add(this.labelDevice);
            this.groupBoxJoystick.Location = new System.Drawing.Point(12, 271);
            this.groupBoxJoystick.Name = "groupBoxJoystick";
            this.groupBoxJoystick.Size = new System.Drawing.Size(167, 142);
            this.groupBoxJoystick.TabIndex = 7;
            this.groupBoxJoystick.TabStop = false;
            this.groupBoxJoystick.Text = "Joystick";
            // 
            // textBoxYaw
            // 
            this.textBoxYaw.Location = new System.Drawing.Point(61, 114);
            this.textBoxYaw.Name = "textBoxYaw";
            this.textBoxYaw.Size = new System.Drawing.Size(100, 21);
            this.textBoxYaw.TabIndex = 7;
            // 
            // textBoxRoll
            // 
            this.textBoxRoll.Location = new System.Drawing.Point(61, 83);
            this.textBoxRoll.Name = "textBoxRoll";
            this.textBoxRoll.Size = new System.Drawing.Size(100, 21);
            this.textBoxRoll.TabIndex = 6;
            // 
            // textBoxPitch
            // 
            this.textBoxPitch.Location = new System.Drawing.Point(61, 50);
            this.textBoxPitch.Name = "textBoxPitch";
            this.textBoxPitch.Size = new System.Drawing.Size(100, 21);
            this.textBoxPitch.TabIndex = 5;
            // 
            // textBoxDevice
            // 
            this.textBoxDevice.Location = new System.Drawing.Point(61, 14);
            this.textBoxDevice.Name = "textBoxDevice";
            this.textBoxDevice.Size = new System.Drawing.Size(100, 21);
            this.textBoxDevice.TabIndex = 4;
            // 
            // labelYaw
            // 
            this.labelYaw.AutoSize = true;
            this.labelYaw.Location = new System.Drawing.Point(7, 117);
            this.labelYaw.Name = "labelYaw";
            this.labelYaw.Size = new System.Drawing.Size(23, 12);
            this.labelYaw.TabIndex = 3;
            this.labelYaw.Text = "Yaw";
            // 
            // labelRoll
            // 
            this.labelRoll.AutoSize = true;
            this.labelRoll.Location = new System.Drawing.Point(7, 86);
            this.labelRoll.Name = "labelRoll";
            this.labelRoll.Size = new System.Drawing.Size(29, 12);
            this.labelRoll.TabIndex = 2;
            this.labelRoll.Text = "Roll";
            // 
            // labelPitch
            // 
            this.labelPitch.AutoSize = true;
            this.labelPitch.Location = new System.Drawing.Point(7, 53);
            this.labelPitch.Name = "labelPitch";
            this.labelPitch.Size = new System.Drawing.Size(35, 12);
            this.labelPitch.TabIndex = 1;
            this.labelPitch.Text = "Pitch";
            // 
            // labelDevice
            // 
            this.labelDevice.AutoSize = true;
            this.labelDevice.Location = new System.Drawing.Point(7, 17);
            this.labelDevice.Name = "labelDevice";
            this.labelDevice.Size = new System.Drawing.Size(41, 12);
            this.labelDevice.TabIndex = 0;
            this.labelDevice.Text = "Device";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // statusChart1
            // 
            this.statusChart1.BackColor = System.Drawing.SystemColors.ControlText;
            this.statusChart1.Enabled = false;
            this.statusChart1.ForeColor = System.Drawing.Color.Red;
            this.statusChart1.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.statusChart1.Interval = 50;
            this.statusChart1.Location = new System.Drawing.Point(3, 3);
            this.statusChart1.Mode = UI.StatusChart.ChartMode.Waveform;
            this.statusChart1.Name = "statusChart1";
            this.statusChart1.Range = 65535;
            this.statusChart1.ShifttingIncrement = 5;
            this.statusChart1.Size = new System.Drawing.Size(688, 133);
            this.statusChart1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.statusChart1);
            this.panel1.ForeColor = System.Drawing.Color.Khaki;
            this.panel1.Location = new System.Drawing.Point(12, 450);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(695, 166);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "0   1   2   3   4   5   6   7   8   9   10  11  12  13  14  15  16  17  18  19  2" +
    "0  21  22  23  24  25  26  27";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 628);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBoxJoystick);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.groupBoxComPort);
            this.Controls.Add(this.huD_Graphic1);
            this.Controls.Add(this.altimeter1);
            this.Controls.Add(this.compass1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxComPort.ResumeLayout(false);
            this.groupBoxComPort.PerformLayout();
            this.groupBoxJoystick.ResumeLayout(false);
            this.groupBoxJoystick.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Simple_HUD.Compass compass1;
        private Simple_HUD.Altimeter altimeter1;
        private Simple_HUD.HUD_Graphic huD_Graphic1;
        private System.Windows.Forms.GroupBox groupBoxComPort;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelParity;
        private System.Windows.Forms.Label labelBundRate;
        private System.Windows.Forms.Label labelPortNum;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBoxJoystick;
        private System.Windows.Forms.TextBox textBoxYaw;
        private System.Windows.Forms.TextBox textBoxRoll;
        private System.Windows.Forms.TextBox textBoxPitch;
        private System.Windows.Forms.TextBox textBoxDevice;
        private System.Windows.Forms.Label labelYaw;
        private System.Windows.Forms.Label labelRoll;
        private System.Windows.Forms.Label labelPitch;
        private System.Windows.Forms.Label labelDevice;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.ComboBox comboBoxBundRate;
        private System.Windows.Forms.ComboBox comboBoxPortNum;
        private System.Windows.Forms.ComboBox comboBoxParity;
        private UI.StatusChart statusChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

