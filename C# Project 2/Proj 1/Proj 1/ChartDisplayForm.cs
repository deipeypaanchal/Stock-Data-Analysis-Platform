/*
Name: Deepey Panchal
UNumber: U80305771
*/

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
    // Partial class representing a form for displaying a stock chart
    public partial class ChartDisplayForm : System.Windows.Forms.Form
    {
        // Private fields
        private Chart chart1;
        private BindingList<smartCandleStick> BindingCandleSticks { get; set; }
        private List<aCandleStick> templist;
        private string filename;

        // Default constructor
        public ChartDisplayForm()
        {
            // Initialize the form components
            InitializeComponent();
        }

        // Constructor with parameters to initialize the form with specific data
        internal ChartDisplayForm(string filename, List<aCandleStick> candlesticks, DateTimePicker start, DateTimePicker end)
        {
            // Initialize the form components
            InitializeComponent();

            // Initialize and assign values to fields
            templist = new List<aCandleStick>();
            templist = candlesticks;
            this.filename = filename;

            // Set the start and end date values in the DateTimePickers
            DateTimePicker_StartDate.Value = start.Value;
            DateTimePicker_EndDate.Value = end.Value;

            // Retrieve candlesticks within the specified date range
            getCandlesticksInDateRange(start.Value, end.Value);

            // Set the chart title to the filename (without extension)
            Chart_StockData.Titles.Clear();
            Chart_StockData.Titles.Add(Path.GetFileNameWithoutExtension(filename));
            Chart_StockData.Titles[0].Font = new Font("Microsoft Sans Serif", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            // Set the BindingCandleSticks as the data source for the StockData chart
            Chart_StockData.DataSource = BindingCandleSticks;

            // Update the data bindings for the StockData chart
            Chart_StockData.DataBind();
        }

    // Method to retrieve candlesticks within a specified date range
    private void getCandlesticksInDateRange(DateTime start, DateTime end)
        {
            // Create a new BindingList to store smartCandleStick objects
            BindingCandleSticks = new BindingList<smartCandleStick>();

            // Check if BindingCandleSticks is not null before clearing it
            if (BindingCandleSticks != null)
            {
                // Clear the BindingCandleSticks collection (redundant as it's just created)
                BindingCandleSticks.Clear();
            }

            // Loop through each aCandleStick in the templist
            for (int i = 0; i < templist.Count; i++)
            {
                // Get a reference to the current aCandleStick in the loop
                aCandleStick cs = templist[i];

                // Create a new smartCandleStick using the current aCandleStick
                smartCandleStick scs = new smartCandleStick(cs);

                // Check if the candlestick date is beyond the specified end date, exit the loop
                if (cs.date > end)
                    break;

                // Check if the candlestick date is on or after the specified start date
                if (cs.date >= start)
                {
                    // Add the smartCandleStick to the BindingCandleSticks collection
                    BindingCandleSticks.Add(scs);
                }
            }
        }

        // Event handler for the update button click event
        private void Button_Update_Click(object sender, EventArgs e)
        {
            // Check if BindingCandleSticks is not null before clearing it
            if (BindingCandleSticks != null)
            {
                // Clear the BindingCandleSticks collection
                BindingCandleSticks.Clear();
            }

            // Call a function to retrieve candlesticks within the specified date range
            getCandlesticksInDateRange(DateTimePicker_StartDate.Value, DateTimePicker_EndDate.Value);

            // Uncomment the following line if you want to update a DataGridView with BindingCandleSticks as its data source

            // Set the BindingCandleSticks as the data source for the StockData chart
            Chart_StockData.DataSource = BindingCandleSticks;

            // Update the data bindings for the StockData chart
            Chart_StockData.DataBind();
        }


        // Event handler for the pattern button to show the annotations
        private void Button_Pattern_Click(object sender, EventArgs e)
        {
            // Get the selected pattern from the dropdown menu
            String selectedPattern = DropDownMenu_SelectPattern.SelectedItem.ToString();

            // Clear any existing annotations on the stock data chart
            Chart_StockData.Annotations.Clear();

            // Loop through each smartCandleStick in the BindingCandleSticks collection
            foreach (smartCandleStick scs in BindingCandleSticks)
            {
                // Check the selected pattern and add an arrow annotation if the corresponding pattern is found

                // Bullish pattern
                switch (selectedPattern)
                {
                    case "Bullish":
                        if (scs.isBullish)
                        {
                            // Call a function to add an arrow annotation for Bullish pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Bullish");
                        }
                        break;

                    // Bearish pattern
                    case "Bearish":
                        if (scs.isBearish)
                        {
                            // Call a function to add an arrow annotation for Bearish pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Bearish");
                        }
                        break;

                    // Neutral pattern
                    case "Neutral":
                        if (scs.isNeutral)
                        {
                            // Call a function to add an arrow annotation for Neutral pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Neutral");
                        }
                        break;

                    // Marubozu pattern
                    case "Marubozu":
                        if (scs.isMarubozu)
                        {
                            // Call a function to add an arrow annotation for Marubozu pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Marubozu");
                        }
                        break;

                    // Doji pattern
                    case "Doji":
                        if (scs.isDoji)
                        {
                            // Call a function to add an arrow annotation for Doji pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Doji");
                        }
                        break;

                    // DragonFlyDoji pattern
                    case "DragonFlyDoji":
                        if (scs.isDragonFlyDoji)
                        {
                            // Call a function to add an arrow annotation for DragonFlyDoji pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "DragonFlyDoji");
                        }
                        break;

                    // GravestoneDoji pattern
                    case "GravestoneDoji":
                        if (scs.isGraveStoneDoji)
                        {
                            // Call a function to add an arrow annotation for GravestoneDoji pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "GravestoneDoji");
                        }
                        break;

                    // Hammer pattern
                    case "Hammer":
                        if (scs.isHammer)
                        {
                            // Call a function to add an arrow annotation for Hammer pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "Hammer");
                        }
                        break;

                    // InvertedHammer pattern
                    case "InvertedHammer":
                        if (scs.isInvertedHammer)
                        {
                            // Call a function to add an arrow annotation for InvertedHammer pattern
                            ArrowAnnotationFunc(BindingCandleSticks.IndexOf(scs), "InvertedHammer");
                        }
                        break;

                    // Default case for any other patterns not explicitly handled
                    default:
                        break;
                }
            }
        }

        // This method creates an arrow annotation for a given data point index and a string value.
        private void ArrowAnnotationFunc(int ind, String str)
        {
            // Uncommenting the following line would clear all existing annotations on the chart.
            // chart_stock.Annotations.Clear();

            // Create a new ArrowAnnotation object.
            System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation arrow = new System.Windows.Forms.DataVisualization.Charting.ArrowAnnotation();

            // Get the data point at the specified index from the "series_OHLC" series.
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint = Chart_StockData.Series["series_OHLC"].Points[ind];

            // Set the properties of the arrow annotation.
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
            arrow.Width = .2;
            arrow.LineWidth = 1;
            arrow.Alignment = ContentAlignment.TopLeft;

            // Set additional properties for the arrow annotation.
            arrow.AxisY.IsStartedFromZero = false;
            arrow.IsSizeAlwaysRelative = true;

            // Add the arrow annotation to the Annotations collection of the Chart_StockData control.
            Chart_StockData.Annotations.Add(arrow);
        }
    }
}