// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Define a namespace for the project
namespace Proj_1
{
    // Define an internal class named BearishRecognizer, which inherits from Recognizer
    internal class bearishRecognizer : recognizer
    {
        // Constructor for BearishRecognizer class
        public bearishRecognizer() : base(1, "Bearish")
        {
            // Constructor initializes the base class with parameters (1 and "Bearish")
        }

        // Override the protected method recognizePattern from the base class
        // This method takes a List of smartCandleStick objects (scsl) as input
        protected override Boolean recognizePattern(List<smartCandleStick> scsl)
        {
            // The implementation of this method checks if the first candlestick in the list (scsl[0]) is Bearish
            // It returns a Boolean value indicating whether the pattern is recognized as Bearish
            return scsl[0].isBearish;
        }
    }
}
