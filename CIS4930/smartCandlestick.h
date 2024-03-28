/*
Name: Deepey Panchal
U-Number: U80305771

This is the smart candlestick header file. This contains the declaration of certain patterns that are further used in the program.
*/

#pragma once

// Include the header file for the base class 'candlestick'
#include "candlestick.h"

// Include the math library
#include <math.h>

// Use the specified namespace for the current code file
namespace candlestick_Header
{
    // Define a derived class 'smartCandlestick' inheriting from 'candlestick'
    ref class smartCandlestick : candlestick
    {
    public:
        // Declare public properties for various candlestick attributes
        property float body;          // Body of the candlestick (absolute difference between open and close)
        property float range;         // Total range of the candlestick (absolute difference between high and low)
        property float top_price;     // Top price of the candlestick (maximum value between open and close)
        property float bottom_price;  // Bottom price of the candlestick (minimum value between open and close)
        property float top_tail;      // Length of the top tail (absolute difference between high and top_price)
        property float bottom_tail;   // Length of the bottom tail (absolute difference between low and bottom_price)

        // Define a constant buffer for doji detection
        const float dojiBuff = 0.05;

        // Declare boolean properties for various candlestick patterns
        property bool IsDragonFlyDoji;      // Dragonfly Doji pattern indicator
        property bool IsHammer;             // Hammer pattern indicator
        property bool IsInvertedHammer;     // Inverted Hammer pattern indicator
        property bool IsGravestoneDoji;     // Gravestone Doji pattern indicator
        property bool isInvertedGravestone; // Inverted Gravestone Doji pattern indicator
        property bool IsDoji;               // Doji pattern indicator
        property bool IsMarubozu;           // Marubozu pattern indicator
        property bool IsNeutral;            // Neutral pattern indicator
        property bool IsBearish;            // Bearish pattern indicator
        property bool IsBullish;            // Bullish pattern indicator

        // Default constructor initializes properties to zero
        smartCandlestick() : candlestick()
        {
            // Initialize the properties of the smartCandlestick object
            body = 0;              // Set the body to zero
            range = 0;             // Set the range to zero
            top_price = 0;         // Set the top_price to zero
            bottom_price = 0;      // Set the bottom_price to zero
            top_tail = 0;          // Set the top_tail to zero
            bottom_tail = 0;       // Set the bottom_tail to zero
        }

        // Copy constructor initializes properties based on another smartCandlestick object
        smartCandlestick(smartCandlestick^ cs) : candlestick(cs)
        {
            // Copy the properties from the provided smartCandlestick object 'cs'
            body = cs->body;              // Copy the 'body' property
            range = cs->range;            // Copy the 'range' property
            top_price = cs->top_price;    // Copy the 'top_price' property
            bottom_price = cs->bottom_price; // Copy the 'bottom_price' property
            top_tail = cs->top_tail;      // Copy the 'top_tail' property
            bottom_tail = cs->bottom_tail; // Copy the 'bottom_tail' property
        }


        // Constructor to initialize a smartCandlestick object from a candlestickString
        smartCandlestick(System::String^ candlestickString) : candlestick(candlestickString)
        {
            // Split the candlestickString into parts using specified delimiters
            array<String^>^ parts = candlestickString->Split(delimiters, StringSplitOptions::RemoveEmptyEntries);

            // Calculate the absolute difference between open and close as the body of the candlestick
            body = Math::Abs(open - close);

            // Calculate the absolute difference between high and low as the total range of the candlestick
            range = Math::Abs(high - low);

            // Determine the top price of the candlestick as the maximum value between open and close
            top_price = Math::Max(open, close);

            // Determine the bottom price of the candlestick as the minimum value between open and close
            bottom_price = Math::Min(open, close);

            // Calculate the absolute difference between high and top_price as the length of the top tail
            top_tail = Math::Abs(high - top_price);

            // Calculate the absolute difference between low and bottom_price as the length of the bottom tail
            bottom_tail = Math::Abs(low - bottom_price);
        }


        // Function to compute and set candlestick properties
        int setProperties()
        {
            // Calculate the absolute difference between open and close as the body of the candlestick
            body = Math::Abs(open - close);

            // Calculate the absolute difference between high and low as the total range of the candlestick
            range = Math::Abs(high - low);

            // Determine the top price of the candlestick as the maximum value between open and close
            top_price = Math::Max(open, close);

            // Determine the bottom price of the candlestick as the minimum value between open and close
            bottom_price = Math::Min(open, close);

            // Calculate the absolute difference between high and top_price as the length of the top tail
            top_tail = Math::Abs(high - top_price);

            // Calculate the absolute difference between low and bottom_price as the length of the bottom tail
            bottom_tail = Math::Abs(low - bottom_price);

            // Return 8 to indicate the number of properties set (consistent with the historical implementation)
            return 8;
        }


        // Function to compute and set candlestick pattern properties
        int PatternCompute()
        {
            // Check if the candlestick is Bullish (close is greater than open)
            IsBullish = (close > open);

            // Check if the candlestick is Bearish (open is greater than close)
            IsBearish = (open > close);

            // Check if the candlestick is a Dragonfly Doji
            IsDragonFlyDoji = (body < 0.1 * range) && (bottom_tail <= 0.1 * range) && (top_tail >= 2 * bottom_tail);

            // Check if the candlestick is a Hammer
            IsHammer = (body >= 0.6 * range) && (bottom_tail >= 2 * top_tail);

            // Check if the candlestick is an Inverted Hammer
            IsInvertedHammer = (body >= 0.6 * range) && (top_tail >= 2 * bottom_tail);

            // Check if the candlestick is a Gravestone Doji
            IsGravestoneDoji = (body < 0.1 * range) && (top_tail <= 0.1 * range) && (bottom_tail >= 2 * top_tail);

            // Check if the candlestick is an Inverted Gravestone Doji
            isInvertedGravestone = (body < 0.1 * range) && (bottom_tail <= 0.1 * range) && (top_tail >= 2 * bottom_tail);

            // Check if the candlestick is a Doji
            IsDoji = (body < 0.1 * range) && (range >= 2 * top_tail) && (range >= 2 * bottom_tail);

            // Check if the candlestick is a Marubozu (no tail)
            IsMarubozu = (body >= 0.9 * range);

            // Check if the candlestick is Neutral (small body and tails)
            IsNeutral = (body <= 0.5 * range) && (top_tail <= 0.1 * range) && (bottom_tail <= 0.1 * range);

            // Return 0 to indicate successful execution
            return 0;
        }

    };
}