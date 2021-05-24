using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Labor_01_Teil1_Serielle_kommunikation
{
    internal class DemoDevice
    {
        private enum CommandBytes : byte
        {
            SetCounterZero = 0x7A,
            CounterIncrementDown = 0x7B,
            CounterIncrementUp = 0x7C,
            SendCounterNumber = 0x7D,
            SendSerialNumber = 0x7E,
            SendDeviceName = 0x7F,
        }

        public enum ConnectionStates
        {
            Connected,
            Disconnected,
            Connecting,
        }

        private string _SerialNumber;
        public string SerialNumber
        {
            get
            {
                return _SerialNumber;
            }
            set
            {
                _SerialNumber = value;
                OnPropertyChanged(_SerialNumber);
            }
        }

        private string _DeviceName;
        public string DeviceName
        {
            get
            {
                return _DeviceName;
            }
            set
            {
                _DeviceName = value;
                OnPropertyChanged(_DeviceName);
            }
        }

        private int _CurrentNumber;
        public int CurrentNumber
        {
            get
            {
                return _CurrentNumber;
            }
            set
            {
                _CurrentNumber = value;
                OnPropertyChanged(_CurrentNumber.ToString());
            }
        }

        private ConnectionStates _ConnectionState;
        public ConnectionStates ConnectionState
        {
            get
            {
                return _ConnectionState;
            }
            set
            {
                OnPropertyChanged(_ConnectionState.ToString());
                _ConnectionState = value;
            }
        }

        SerialPort serialPort = new SerialPort();

        public delegate void PropertyChangedHandler(DemoDevice source, string propertyName);
        public event PropertyChangedHandler PropertyChanged; 
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, propertyName);
            }
        }

        public void Connect(int portNumber)
        {
            try
            {
                string comname = "COM" + portNumber;
                serialPort.PortName = comname;
                serialPort.BaudRate = 9600;
                ConnectionState = ConnectionStates.Connecting;
                serialPort.Open();
                ConnectionState = ConnectionStates.Connected;
                Thread readDeviceInfoThread = new Thread(ReadDeviceInfo);
                readDeviceInfoThread.IsBackground = true;
                readDeviceInfoThread.Start();
            }
            catch (IndexOutOfRangeException)
            { 
                Console.WriteLine("Verbindung fehlgeschlagen");
                Disconnect();
            }
        }


        private void ReadDeviceInfo()
        {
            byte[] commandName = new byte[] {(byte) CommandBytes.SendDeviceName};
            byte[] commandSerialNumber = new byte[] {(byte) CommandBytes.SendSerialNumber};
            byte[] commandCounterNumber = new byte[] {(byte) CommandBytes.SendCounterNumber};
            serialPort.Write(commandName, 0, 1);
            DeviceName = serialPort.ReadLine();
            serialPort.Write(commandSerialNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();
            while (true)
            {
                serialPort.Write(commandCounterNumber, 0, 1);
                CurrentNumber = int.Parse(serialPort.ReadLine());
                Thread.Sleep(200);
            }
        }

        public void Disconnect()
        {
            serialPort.Close();
            ConnectionState = ConnectionStates.Disconnected;
        }

        public void Increment()
        {
            if (serialPort.IsOpen) 
            {
                byte[] command = new byte[] { (byte)CommandBytes.CounterIncrementUp };
                serialPort.Write(command, 0, 1); 
                command = new byte[] { (byte)CommandBytes.SendCounterNumber};
                serialPort.Write(command, 0, 1);
                CurrentNumber = int.Parse(serialPort.ReadLine());
            }
            else
            {
         
            }
        }

        public void Decrement()
        {
            if (serialPort.IsOpen)
            {
                byte[] command = new byte[] { (byte)CommandBytes.CounterIncrementDown };
                serialPort.Write(command, 0, 1);
                command = new byte[] { (byte)CommandBytes.SendCounterNumber};
                serialPort.Write(command, 0, 1);
                CurrentNumber = int.Parse(serialPort.ReadLine());
            }
            else
            {

            }
        }
        
        public void Reset()
        {
            if (serialPort.IsOpen)
            {
                byte[] command = new byte[] {(byte) CommandBytes.SetCounterZero};
                serialPort.Write(command, 0, 1);
                CurrentNumber = 0;
            }
            else
            {
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DemoDeviceTester());
        }
    }
}