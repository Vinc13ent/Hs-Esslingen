using System.IO.Ports;

namespace Labor_01_Teil1_Serielle_kommunikation
{
    internal class Program
    {
        private enum CommandBytes : byte
        {
            setCounterZero = 0x7A,
            counterIncrementDown = 0x7B,
            counterIncrementUp = 0x7C,
            sendCounterNumber = 0x7D,
            sendSerialNumber = 0x7E,
            SendDeviceName = 0x7F,
        }

        public enum ConnectionStates
        {
            connected = 1,
            disconnected = 0,
            connecting = -1,
        }

        public string SerialNumber;
        public string DeviceName;
        public int CurrentNumber;
        public ConnectionStates ConnectionState;

        SerialPort serialPort = new SerialPort();


        public void Connect(int portNumber)
        {
            string comname = "COM" + portNumber;
            serialPort.PortName = comname;
            serialPort.BaudRate = 9600;

            try
            {
                ConnectionState = ConnectionStates.connecting;
                serialPort.Open();
            }
            catch
            {
                ConnectionState = ConnectionStates.disconnected;
            }
            finally
            {
                ConnectionState = ConnectionStates.connected;
                ReadDeviceInfo();
            }
        }


        private void ReadDeviceInfo()
        {
            byte[] commandName = new byte[] { (byte)CommandBytes.SendDeviceName };
            byte[] commandSerialNumber = new byte[] { (byte)CommandBytes.SendDeviceName };
            byte[] commandCounterNumber = new byte[] { (byte)CommandBytes.SendDeviceName };
            serialPort.Write(commandName, 0, 1);
            DeviceName = serialPort.ReadLine();
            serialPort.Write(commandSerialNumber, 0, 1);
            SerialNumber = serialPort.ReadLine();
            serialPort.Write(commandCounterNumber, 0, 1);
            CurrentNumber = int.Parse(serialPort.ReadLine());
        }


           public void Disconnect()
        {
            serialPort.Close();
            ConnectionState = ConnectionStates.disconnected;
        }


        public void Increment()
        {
            if (serialPort.IsOpen) 
            {
                byte[] command = new byte[] { (byte)CommandBytes.counterIncrementUp };
                serialPort.Write(command, 0, 1);
            }
            else
            {
         
            }
        }


        public void Decrement()
        {
            if (serialPort.IsOpen)
            {
                byte[] command = new byte[] { (byte)CommandBytes.counterIncrementDown };
                serialPort.Write(command, 0, 1);
            }
            else
            {

            }
        }


        public void Reset()
        {
            if (serialPort.IsOpen)
            {
                byte[] command = new byte[] { (byte)CommandBytes.setCounterZero };
                serialPort.Write(command, 0, 1);
            }
            else
            {

            }
        }


        public static void Main(string[] args)
        {
            DemoDeviceTester;
        }
    }
}