// candlestick.h - This is the header file for candlestick
#pragma once
#include <sstream>
/*
Name: Deepey Panchal
U-Number: U80305771
*/
// This is the candlestick header file

using namespace System;

namespace candlestick_Header
{
    // Define the candlestick class within the candlestick_Header namespace.
    ref class candlestick
    {
    public:
        // Static delimiters used for string parsing.
        static array<String^>^ delimiters = { ",", " ", "\"" };

        // Format used to parse dates.
        static String^ dateformat = "MMM dd, yyyy";

        // Reference string layout for a candlestick data entry.
        static String^ referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

    public:
        // Public member properties to hold the candlestick data.
        property DateTime date; // Date
        property double open;   // Open
        property double high;   // High
        property double low;    // Low
        property double close;  // Close
        property unsigned long volume;  // Volume

        // Default constructor that initializes the candlestick properties.
        candlestick()
        {
            open = 0;
            high = 0;
            low = 0;
            close = 0;
            volume = 0;
        }

        // Copy constructor to create a new instance from an existing candlestick.
        candlestick(candlestick^ cs) {
            open = cs->open;
            high = cs->high;
            low = cs->low;
            close = cs->close;
            volume = cs->volume;
            date = cs->date;
        }

        // Constructor to initialize a candlestick object from a string representation.
        candlestick(System::String^ candlestickString)
        {
            // Split the input string based on delimiters.
            array<String^>^ parts = candlestickString->Split(delimiters, StringSplitOptions::RemoveEmptyEntries);

            // Construct the date string and parse it.
            String^ dateString = parts[2] + " " + parts[3] + ", " + parts[4];
            date = DateTime::Parse(dateString);

            // Parse and assign the other candlestick properties.
            open = Double::Parse(parts[5]);
            high = Double::Parse(parts[6]);
            low = Double::Parse(parts[7]);
            close = Double::Parse(parts[8]);
            volume = Int64::Parse(parts[9]);
        }
    };
}