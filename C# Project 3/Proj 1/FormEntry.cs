/*
Name: Deepey Panchal
U-Number: U80305771
*/

// This is the form entry class. User encounters this form when they first runs the program.

// Import necessary namespaces
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

// Define a namespace for the project
namespace Proj_1
{
    // Define a partial class named FormEntry, which inherits from Form
    public partial class FormEntry : Form
    {
        // Define a static reference string for the header
        private static String referenceString = "\"Ticker\",\"Period\",\"Date\",\"Open\",\"High\",\"Low\",\"Close\",\"Volume\"";

        // Constructor for FormEntry class
        public FormEntry()
        {
            InitializeComponent();
        }

        // Event handler for Load button's FileOk event
        private void LoadButtonOpenFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Load candlestick data from selected files and open display forms
            List<List<aCandleStick>> candlestickList = loadCandlesticks(LoadButtonOpenFileDialog.FileNames);
            openDisplayChartForms(LoadButtonOpenFileDialog.FileNames, candlestickList);
        }

        // Overloaded method to load candlesticks from an array of filenames
        private List<List<aCandleStick>> loadCandlesticks(string[] Filenames_Array)
        {
            List<string> Filenames_List = Filenames_Array.ToList<string>();
            return loadCandlesticks(Filenames_List);
        }

        // Method to load candlesticks from a list of filenames
        private List<List<aCandleStick>> loadCandlesticks(List<string> Filenames_list)
        {
            List<List<aCandleStick>> finalList = new List<List<aCandleStick>>(Filenames_list.Count());

            foreach (string filename in Filenames_list)
            {
                List<aCandleStick> candlesticks = loadStockFromFile(filename);
                finalList.Add(candlesticks);
            }
            // Returning the result
            return finalList;
        }

        // Method to load candlestick data from a file
        private List<aCandleStick> loadStockFromFile(string filename)
        {
            List<aCandleStick> tempList = new List<aCandleStick>(1024);
            // Using the streamreader to read data
            using (StreamReader sr = new StreamReader(filename))
            {
                string line;

                // Read the header from the file
                string header = sr.ReadLine();

                if (header == referenceString)
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        aCandleStick cs = new aCandleStick(line);
                        tempList.Add(cs);
                    }

                    // Reverse the list to maintain chronological order
                    tempList.Reverse();
                }
            }
            // Returning the tempList
            return tempList;
        }

        // Method to open display forms for loaded candlestick data
        private void openDisplayChartForms(string[] Filenames_Arrays, List<List<aCandleStick>> allCandlesticks)
        {
            for (int i = 0; i < Filenames_Arrays.Length; i++)
            {
                ChartDisplayForm newForm = new ChartDisplayForm(Filenames_Arrays[i], allCandlesticks[i], DateTimePicker_StartDate, DateTimePicker_EndDate);
                newForm.Show();
            }
        }

        // Event handler for Load button click
        private void button_Load_Click(object sender, EventArgs e)
        {
            // Show the OpenFileDialog to select files for loading data
            LoadButtonOpenFileDialog.ShowDialog();
        }
    }
}