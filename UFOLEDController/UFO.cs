using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace UFOLEDController
{
    public class UFO
    {
        #region Attributdeklaration
        private string ip, name;
        private int port;
        private Socket socket;
        private IPEndPoint endPoint;
        #endregion

        #region Get- und Set-Methoden
        public string IP
        {
            get { return ip; }
            set
            {
                ip = value;
                UpdateSocket(ip, port);
            }
        }

        public string NAME
        {
            get { return name; }
            set { name = value; }
        }

        public int PORT
        {
            get { return port; }
            set
            {
                port = value;
                UpdateSocket(ip, port);
            }
        }
        #endregion

        public UFO(string name, string ip, int port)
        {
            NAME = name;
            this.ip = ip;
            this.port = port;
            UpdateSocket(ip, port);
        }

        internal string Send(byte[] command)
        {
            socket.Send(command);
            byte[] answer = new byte[1024];
            return Encoding.UTF8.GetString(answer);
        }

        internal bool UpdateSocket(string ip, int port)
        {
            try
            {
                endPoint = new IPEndPoint(IPAddress.Parse(ip), port);
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(endPoint);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Name: " + name + "; IP: " + ip + "; Port: " + port + ";";
        }

        internal byte[] GetByteArray(int[] int_array)
        {
            byte[] byte_array = new byte[int_array.Length];
            for (int j = 0; j < byte_array.Length; j++)
            {
                byte_array[j] = (byte)int_array[j];
            }
            return byte_array;
        }

        internal int[] GetChecksum(int[] int_array)
        {
            int checksum_in_int = 0;

            //Calculate the checksum
            for (int j = 0; j < int_array.Length - 1; j++)
            {
                checksum_in_int += int_array[j];
            }

            //HelpString for storing the checksum as a hex-value
            string checksum_in_hex = checksum_in_int.ToString("X");

            //store only the last two digits of the HelpString
            checksum_in_hex = checksum_in_hex.Substring(checksum_in_hex.Length - 2);

            //Covert the HelpString back to an integer
            checksum_in_int = int.Parse(checksum_in_hex, System.Globalization.NumberStyles.HexNumber);

            //write the needed checksum to the rgb_array
            int_array[int_array.Length - 1] = checksum_in_int;
            return int_array;
        }
    }
}

/* Every Command ist encoded via WireShark in Hex, you can convert them to int and add them to a byte array to send them.
     * This Method is easier to read in the RGB Values from 0 to 255 out of a textbox in the form.
     * Every command consists of an Operator, the value(s) and a checksum, which represents the total sum of all values,
     * converted to a hex-value and trimmed everything but the last 2 values. Reconvert this to an int and add it to the last
     * entry of your command array.
     * 
     * LD382: (UFOv1)
     * On/Off Command contains an Operator, Command and the Checksum
     * RGB Command contains an {Operator, Red-Value, Green-Value, Blue-Value,     0xff,     0x00,    0x00,   Checksum}
     *                                                                        [maybe for a White-LED-Strip?]
     * Examples:
     * -On:
     *                           {Operator, Command, Checksum}   
     *      Data from WireShark: {  0x71,     0x23,    0x94  } -> {113, 35, 148} 
     *      
     * Checksum: 0x71 + 0x23 = 113 + 35 = 148 = 0x94 as the last entry.
     * -Off:
     *                           {Operator, Command, Checksum}   
     *      Data from WireShark: {  0x71,     0x24,    0x95  } -> {113, 36, 149}
     *      
     * -RGB:
     *                           {Operator, Command, Command, Command, 0xff, 0x00, 0x00, Checksum}   
     *      Data from WireShark: {  0x31,     0xff,   0xff,    0xff,   0xff, 0x00, 0x00,   0x2d  } -> {49, 255, 255, 255, 255, 0, 0, 45}
     *      
     * Checksum: 0x31 + 0xff + 0xff+ 0xff + 0xff + 0x00 + 0x00 = 49+255+255+255+255+0+0 = 1069 = 0x42d -> last two values -> convert 2d to int -> 45, that is our checksum!
     * 
     * LD382A: (UFOv3)
     *  !!At the seventh position in the array there is a 0x0F instead of a 0x00!!

     * Have a great experience with my Data and Experiences and feel free to optimize.
     * 
     * Best Regards,
     * 
     * jikelmon
     * 
     * 
     * 
     * 
     * To-Do:
     * -Predefined-Fades
     * -White LED-Strips -> i do not own one, because of that i am not able to get the data at the moment, sorry
     * -Timer
     * -Exceptions etc. -> i am not familiar with that, because i am learning c# as a new language beside my bachelor as a hobby
     * -Clean-Up the code and make it C#-Standard conform...
     */
