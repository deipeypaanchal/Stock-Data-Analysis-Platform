/*
Name: Deepey Panchal
U-Number: U80305771
*/

// This is the chart display form which is used to display the charts and then further annotate the patterns

// Import necessary namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proj_1
{
    // Define a partial class named ChartDisplayForm, which inherits from Form
    public partial class ChartDisplayForm : System.Windows.Forms.Form
    {
        // Declare class-level fields and properties
        private Chart chart1;
        private BindingList<smartCandleStick> candlesticksBinded { get; set; }
        private List<aCandleStick> tempList;
        private string filename;
        private List<recognizer> recognizers;
        // Constructor for ChartDisplayForm
        public ChartDisplayForm()
        {
            InitializeComponent();
        }
        // Overloaded constructor for ChartDisplayForm that takes parameters
        internal ChartDisplayForm(string filename, List<aCandleStick> candlesticks, DateTimePicker start, DateTimePicker end)
        {
            InitializeComponent();
            // Initialize class-level variables and properties
            tempList = new List<aCandleStick>();
            tempList = candlesticks;
            this.filename = filename;
            // initializing the start and end date value
            UpdatedateTimePicker_startDate.Value = start.Value;
            UpdatedateTimePicker_endDate.Value = end.Value;
            // using the new start and end value
            getCandlesticksInDateRange(start.Value, end.Value);
            // Clearing the title from chart area
            Chart_StockData.Titles.Clear();
            // Adding the new title
            Chart_StockData.Titles.Add(Path.GetFileNameWithoutExtension(filename));
            // Font of the new title
            Chart_StockData.Titles[0].Font = new Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // Connect the chart to the BindingList
            Chart_StockData.DataSource = candlesticksBinded;
            Chart_StockData.DataBind();
            // Initialize and populate the list of recognizers
            recognizers = new List<recognizer>();
            recognizers.Add(new dojiRecognizer());
            recognizers.Add(new bullishRecognizer());
            recognizers.Add(new peakRecognizer());
            recognizers.Add(new engulfingBearishRecognizer());
            recognizers.Add(new engulfingBullishRecognizer());
            recognizers.Add(new hammerRecognizer());
            recognizers.Add(new invertedHammerRecognizer());
            recognizers.Add(new gravestoneDojiRecognizer());
            recognizers.Add(new dragonFlyDojiRecognizer());
            recognizers.Add(new bearishRecognizer());
            recognizers.Add(new neutralRecognizer());
            recognizers.Add(new valleyRecognizer());
            // Add recognizer pattern names to the combo box
            foreach (recognizer r in recognizers)
            {
                aCandleStickPatterns.Items.Add(r.patternName);
            }
        }
        // Method to get candlesticks within a specified date range
        private void getCandlesticksInDateRange(DateTime start, DateTime end)
        {
            // Binding list declaring for this part
            candlesticksBinded = new BindingList<smartCandleStick>();
            // Clearing a list when the binded list is null
            if (candlesticksBinded != null)
            {
                // Clearing the list of binded candlesticks
                candlesticksBinded.Clear();
            }
            // For loop to add the candlesticks
            for (int i = 0; i < tempList.Count; i++)
            {
                aCandleStick cs = tempList[i];
                // scs is smart candlestick
                smartCandleStick scs = new smartCandleStick(cs);
                // Making sure the candle stick is valid or not
                if (cs.date > end)
                    break;
                // When valid
                if (cs.date >= start)
                {
                    // Adding the candlesticks
                    candlesticksBinded.Add(scs);
                }
            }
        }
        // Event handler for the Update button click
        private void button_Update_Click(object sender, EventArgs e)
        {
            // Clearing the annotations
            Chart_StockData.Annotations.Clear();
            // When the binded list is not null
            if (candlesticksBinded != null)
            {
                // Clearing the list when not empty
                candlesticksBinded.Clear();
            }
            // Getting new start and end date values
            getCandlesticksInDateRange(UpdatedateTimePicker_startDate.Value, UpdatedateTimePicker_endDate.Value);
            // Binding the new candlesticks
            Chart_StockData.DataSource = candlesticksBinded;
            Chart_StockData.DataBind();
        }

        // Event handler for the Pattern button click
        private void PatternButton_Click(object sender, EventArgs e)
        {
            // Taking the selected pattern
            int selectedPatternIndex = aCandleStickPatterns.SelectedIndex;
            // Clearing the prev annotations
            Chart_StockData.Annotations.Clear();
            // Using the recogizers to recognize the pattern
            recognizer selectedRecognizer = recognizers[selectedPatternIndex];
            List<int> recognizedIndexes = selectedRecognizer.recognizePatterns(candlesticksBinded.ToList());
            // Adding the annotations for the recognized pattern for each candlestick
            foreach (int i in recognizedIndexes)
            {
                ArrowAnnotationFunc(i);
            }
        }

        // Method to add an arrow annotation to the chart
        private void ArrowAnnotationFunc(int ind)
        {
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrow = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint = Chart_StockData.Series["series_OHLC"].Points[ind];
            arrow.ClipToChartArea = "area_OHLC";
            arrow.AxisX = Chart_StockData.ChartAreas["area_OHLC"].AxisX;
            arrow.AxisY = Chart_StockData.ChartAreas["area_OHLC"].AxisY;
            arrow.AnchorDataPoint = dataPoint;
            arrow.LineColor = Color.Black;
            arrow.ForeColor = Color.Black;
            arrow.BackColor = Color.Black;
            arrow.BackSecondaryColor = Color.Black;
            arrow.ShadowColor = Color.Transparent;
            arrow.Height = -7;
            arrow.Width = .5;
            arrow.LineWidth = 1;
            arrow.Alignment = ContentAlignment.TopLeft;
            arrow.AxisY.IsStartedFromZero = false;
            arrow.IsSizeAlwaysRelative = true;
            Chart_StockData.Annotations.Add(arrow);
        }
    }
}