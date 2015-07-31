using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UFOLEDController
{    
    public class UFOv1 : UFO
    {
        private Power statusPower;
        private readonly byte[] on_command = new byte[] { 0x71, 0x23, 0x94 };
        private readonly byte[] off_command = new byte[] { 0x71, 0x24, 0x95 };
        private int[] rgb_array = new int[] { 0x31, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public Power POWER
        {
            get { return statusPower; }
            set
            {
                statusPower = value;
                if (statusPower == Power.On)
                {
                    base.Send(on_command);
                }
                else
                {
                    base.Send(off_command);
                }
            }
        }

        public Power TogglePower()
        {
            if (statusPower == Power.On)
            {
                POWER = Power.Off;
            }
            else
            {
                POWER = Power.On;
            }
            return POWER;
        }

        public UFOv1(string name, string ip) : base(name, ip, 5577)
        {

        }

        public void SendRGB(int r, int g, int b, int i)
        {
            //Calculate the relative Factor for intensity
            double intensity_factor = i / 100.0;

            //Overwrite the values in the rgb_array with the chosen intensity (rounded down)
            rgb_array[1] = (int)(r * intensity_factor);
            rgb_array[2] = (int)(g * intensity_factor);
            rgb_array[3] = (int)(b * intensity_factor);

            rgb_array = base.GetChecksum(rgb_array);

            base.Send(GetByteArray(rgb_array));
        }
    }
}
