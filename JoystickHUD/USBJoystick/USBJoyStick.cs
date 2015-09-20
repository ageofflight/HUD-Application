using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.DirectX.DirectInput;

namespace USBJoystick
{
	public class USBJoyStick : IDisposable, INotifyPropertyChanged
	{
		private Device joyStick = null;
		private Task joyTask = null;

		public USBJoyStick()
		{
			try
			{
				DeviceList joyList = Manager.GetDevices(DeviceClass.GameControl, EnumDevicesFlags.AttachedOnly);
				joyList.MoveNext();
				joyStick = new Device(((DeviceInstance)joyList.Current).InstanceGuid);
				joyStick.Acquire();
				JoystickState = new JoyState();
			}
			catch
			{
				throw new Exception("USB摇杆初始化失败");
			}
		}

		public void Start()
		{
			joyTask = new Task(() =>
			{
				while (true)
				{
					joyStick.Poll();
					var state = joyStick.CurrentJoystickState;
					JoystickState.X = state.X >> 8;
					JoystickState.Y = state.Y >> 8;
					JoystickState.A = state.GetSlider()[0] >> 8;
					OnPropertyChanged("JoystickState");
					Thread.Sleep(10);
				}
			});
			joyTask.Start();
		}

		public void Dispose()
		{
			if (joyStick != null)
				joyStick.Dispose();
		}

		public JoyState JoystickState { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
		private void OnPropertyChanged(string Name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(Name));
		}
	}

	public class JoyState
	{
		public int X { get; set; }
		public int Y { get; set; }
		public int A { get; set; }
		public double aX
		{
			get
			{
				if (X > 128)
				{
					return -(double)(X - 128) / 128.0 * 45;
				}
				if (X < 127)
				{
					return (double)(127 - X) / 128.0 * 45;
				}
				return 0;
			}
		}
		public double aY
		{
			get
			{
				if (Y > 128)
				{
					return (double)(Y - 128) / 128.0 * 45;
				}
				if (Y < 127)
				{
					return -(double)(127 - Y) / 128.0 * 45;
				}
				return 0;
			}
		}
	}
}
