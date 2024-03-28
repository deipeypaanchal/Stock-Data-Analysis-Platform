/*
Name: Deepey Panchal
UNumber: U80305771
 */

// Importing necessary namespaces
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Defining a namespace for the project
namespace Proj_1
{
    // Declaring a partial class named FormEntry that inherits from Form
    public partial class FormEntry : Form
    {
        // String representing the reference header for the input file
        private static String referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

        // Constructor for the FormEntry class
        public FormEntry()
        {
            // Initializing the form components
            InitializeComponent();
        }

        // Event handler for the file dialog when a file is selected
        private void LoadButtonOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Load candlesticks from selected files and open chart display forms
            List<List<aCandleStick>> allCandlesticks = loadCandlesticks(LoadButtonOpenFileDialog.FileNames);
            openDisplayChartForms(LoadButtonOpenFileDialog.FileNames, allCandlesticks);
        }

        // Method to convert an array of filenames to a list and call the main loading method
        private List<List<aCandleStick>> loadCandlesticks(string[] arrayofFilenames)
        {
            List<string> listofFilenames = arrayofFilenames.ToList<string>();
            return loadCandlesticks(listofFilenames);
        }

        // Main method to load candlesticks from a list of filenames
        private List<List<aCandleStick>> loadCandlesticks(List<string> listofFilenames)
        {
            // List to store the resulting candlesticks
            List<List<aCandleStick>> resultingList = new List<List<aCandleStick>>(listofFilenames.Count());

            // Loop through each filename and load candlesticks
            foreach (string filename in listofFilenames)
            {
                List<aCandleStick> candlesticks = loadStockFromFile(filename);
                resultingList.Add(candlesticks);
            }

            return resultingList;
        }

        // Method to load a list of candlesticks from a stock file
        private List<aCandleStick> loadStockFromFile(string filename)
        {
            // List to store the loaded candlesticks
            List<aCandleStick> templist = new List<aCandleStick>(1024);

            // Using statement ensures that the StreamReader is properly disposed of
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                // First, read the header line
                string header = sr.ReadLine();

                // Check if the header matches the reference string
                if (header == referenceString)
                {
                    // Read each line and create a candlestick object, then add it to the list
                    while ((line = sr.ReadLine()) != null)
                    {
                        aCandleStick cs = new aCandleStick(line);
                        templist.Add(cs);
                    }

                    // Reverse the list to have the candles in chronological order
                    templist.Reverse();
                }
            }

            return templist;
        }

        // Method to open chart display forms for each loaded file
        private void openDisplayChartForms(string[] arrayofFilenames, List<List<aCandleStick>> allCandlesticks)
        {
            // Loop through each filename and create a new chart display form
            for (int i = 0; i < arrayofFilenames.Length; i++)
            {
                ChartDisplayForm newForm = new ChartDisplayForm(arrayofFilenames[i], allCandlesticks[i], DateTimePicker_StartDate, DateTimePicker_EndDate);
                newForm.Show();
            }
        }

        // Event handler for the Load button click, opens the file dialog
        private void button_Load_Click(object sender, EventArgs e)
        {
            LoadButtonOpenFileDialog.ShowDialog();
        }

        private void StartDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void FormEntry_Load(object sender, EventArgs e)
        {

        }
    }
}