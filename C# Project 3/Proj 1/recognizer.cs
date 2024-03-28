/*
Name: Deepey Panchal
U-Number: U80305771
*/
// This is the recognizer file which is used to recognize patterns. On top of this, individual files are created in the project as per the instructions.

// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a namespace for the project
namespace Proj_1
{
    // Define an abstract internal class named recognizer
    abstract internal class recognizer
    {
        // Define public properties for pattern size and pattern name
        public int patternSize;
        public string patternName;

        // Constructor for the recognizer class
        public recognizer(int patternSize, string patternName)
        {
            this.patternSize = patternSize;
            this.patternName = patternName;
        }

        // Abstract method to recognize a specific candlestick pattern
        protected abstract Boolean recognizePattern(List<smartCandleStick> scsl);

        // Method to recognize patterns in a list of smartCandleStick objects
        public List<int> recognizePatterns(List<smartCandleStick> scsl)
        {
            // Create a list to store recognized indexes
            List<int> recognizedIndexes = new List<int>();

            // Iterate through the candlesticks in the list
            for (int i = patternSize - 1; i < scsl.Count; i++)
            {
                // Extract a sub-list of candlesticks with the specified pattern size
                List<smartCandleStick> subscsl = scsl.GetRange(i - patternSize + 1, patternSize);

                // Check if the pattern is recognized for the sub-list
                if (recognizePattern(subscsl))
                {
                    // Add the index of the recognized pattern to the list
                    recognizedIndexes.Add(i);
                }
            }
            // Return the list of recognized indexes
            return recognizedIndexes;
        }
    }
}