/*
Name: Deepey Panchal
UNumber: U80305771

This is the candlestick file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_1
{
    // Class representing a financial candlestick with open, high, low, close prices, volume, and date
    internal class aCandleStick
    {
        // Properties representing the components of a candlestick
        public Decimal open { get; set; }
        public Decimal high { get; set; }
        public Decimal low { get; set; }
        public Decimal close { get; set; }
        public long volume { get; set; }
        public DateTime date { get; set; }

        // Constructor for creating aCandleStick instance with specified values
        public aCandleStick(DateTime date = default, decimal open = 0, decimal high = 0, decimal low = 0, decimal close = 0, long volume = 0)
        {
            this.date = date;
            this.open = open;
            this.high = high;
            this.low = low;
            this.close = close;
            this.volume = volume;
        }

        // Constructor for creating aCandleStick instance from a string of raw data
        public aCandleStick(String rowofData) : this()
        {
            // Define separators used to split the raw data string
            char[] separators = new char[] { ',', ' ', '"', '-' };
            string[] subs = rowofData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Map of month abbreviations to their corresponding numeric representation
            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;
            map.Add("Jan", i++);
            map.Add("Feb", i++);
            map.Add("Mar", i++);
            map.Add("Apr", i++);
            map.Add("May", i++);
            map.Add("Jun", i++);
            map.Add("Jul", i++);
            map.Add("Aug", i++);
            map.Add("Sep", i++);
            map.Add("Oct", i++);
            map.Add("Nov", i++);
            map.Add("Dec", i++);

            // Construct a formatted date string from the raw data
            String datestring = subs[4] + "/" + map[subs[2]] + "/" + subs[3];

            Decimal temp;
            DateTime tempDate;
            long tempVolume;

            // Attempt to parse and assign values from the raw data
            if (DateTime.TryParse(datestring, out tempDate) == true)
                date = tempDate; // Assign the parsed date value

            if (Decimal.TryParse(subs[5], out temp) == true)
                open = temp; // Assign the parsed open price value

            if (Decimal.TryParse(subs[6], out temp) == true)
                high = temp; // Assign the parsed high price value

            if (Decimal.TryParse(subs[7], out temp) == true)
                low = temp; // Assign the parsed low price value

            if (Decimal.TryParse(subs[8], out temp) == true)
                close = temp; // Assign the parsed close price value

            if (long.TryParse(subs[9], out tempVolume) == true)
                volume = tempVolume; // Assign the parsed volume value
        }
    }
}