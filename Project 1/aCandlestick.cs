// Name: Deepey Panchal
// U-Number: U80305771
// This file is for the candlestick

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    // Define an internal class named aCandlestick.
    internal class aCandlestick
    {
        // Define a public property for the opening value of the candlestick.
        public Decimal open { get; set; }
        // Define a public property for the highest value of the candlestick.
        public Decimal high { get; set; }
        // Define a public property for the lowest value of the candlestick.
        public Decimal low { get; set; }
        // Define a public property for the closing value of the candlestick.
        public Decimal close { get; set; }
        // Define a public property for the volume.
        public long volume { get; set; }
        // Define a public property for the date.
        public DateTime date { get; set; }

        // Default constructor.
        public aCandlestick() { }

        // Overloaded constructor that takes date, open, high, low, close, and volume values.
        public aCandlestick(DateTime date, decimal open = 0, decimal high = 0, decimal low = 0, decimal close = 0, long volume = 0)
        {
            this.date = date;      // Set the date property.
            this.open = open;      // Set the open property.
            this.high = high;      // Set the high property.
            this.low = low;        // Set the low property.
            this.close = close;    // Set the close property.
            this.volume = volume;  // Set the volume property.
        }

        // Overloaded constructor that takes a string of data and parses it to populate the properties.
        public aCandlestick(String rowofData)
        {
            // Define characters that will be used as separators when splitting the string.
            char[] separators = new char[] { ',', ' ', '"', '-' };

            // Split the input string into substrings based on the defined separators.
            string[] subs = rowofData.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            // Create a dictionary to map month names to their respective integer values.
            Dictionary<string, int> map = new Dictionary<string, int>();
            int i = 1;

            // Populate the dictionary with month names and corresponding integer values.
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

            // Construct the date string using the extracted substrings and the month mapping.
            String datestring = subs[4] + "/" + map[subs[2]] + "/" + subs[3];

            // Temporary variables to hold parsed values.
            Decimal temp;
            Boolean success;
            DateTime tempDate;

            // Try to parse the date string into a DateTime object.
            success = DateTime.TryParse(datestring, out tempDate);
            date = tempDate;

            // Parse the open, high, low, and close values from the substrings.
            success = Decimal.TryParse(subs[5], out temp);
            open = temp;

            success = Decimal.TryParse(subs[6], out temp);
            high = temp;

            success = Decimal.TryParse(subs[7], out temp);
            low = temp;

            success = Decimal.TryParse(subs[8], out temp);
            close = temp;

            long tempVolume;

            // Parse the volume value from the substring.
            success = long.TryParse(subs[9], out tempVolume);
            volume = tempVolume;
        }
    }
}