/*

Name: Deepey Panchal
U-Number: U80305771

This header file is the main form that is displayed first when the user runs the program.
*/

#pragma once
#include "candlestick.h"
#include "smartCandlestick.h"
#include <sstream>
#include "DisplayChartForms.h"
#include <cliext/list>
// Use the namespace specified in candlestick_Header
using namespace candlestick_Header;
// Use the specified namespaces for the current code file
namespace CIS4930Project2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;

	// Define a Windows Form class named FormEntry
	public ref class FormEntry : public System::Windows::Forms::Form
	{
	public:
		// Create a BindingList to store smartCandlestick objects
		BindingList<smartCandlestick^>^ candlestickList = gcnew BindingList<smartCandlestick^>();
	// Declare an OpenFileDialog for file selection
	private: System::Windows::Forms::OpenFileDialog^ openFileDialog1;
	public:
		// Create another BindingList for temporary storage of smartCandlestick objects
		BindingList<smartCandlestick^>^ tempList = gcnew BindingList<smartCandlestick^>();
		// Constructor for FormEntry
		FormEntry(void)
		{
			InitializeComponent();
		}

	protected:
		// Destructor for FormEntry
		~FormEntry()
		{
			if (components)
			{
				delete components;
			}
		}
		// Declare DateTimePicker controls, buttons, and labels
	private: System::Windows::Forms::DateTimePicker^ DateTimePicker_StartDate;
	private: System::Windows::Forms::DateTimePicker^ DateTimePicker_EndDate;
	private: System::Windows::Forms::Button^ Load;
	private: System::Windows::Forms::Button^ Update;
	private: System::Windows::Forms::Label^ Label_StartDate;
	private: System::Windows::Forms::Label^ Label_EndDate;
	private: System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			this->DateTimePicker_StartDate = (gcnew System::Windows::Forms::DateTimePicker());
			this->DateTimePicker_EndDate = (gcnew System::Windows::Forms::DateTimePicker());
			this->Load = (gcnew System::Windows::Forms::Button());
			this->Label_StartDate = (gcnew System::Windows::Forms::Label());
			this->Label_EndDate = (gcnew System::Windows::Forms::Label());
			this->openFileDialog1 = (gcnew System::Windows::Forms::OpenFileDialog());
			this->SuspendLayout();
			// 
			// DateTimePicker_StartDate
			// 
			this->DateTimePicker_StartDate->Location = System::Drawing::Point(154, 42);
			this->DateTimePicker_StartDate->Margin = System::Windows::Forms::Padding(4);
			this->DateTimePicker_StartDate->Name = L"DateTimePicker_StartDate";
			this->DateTimePicker_StartDate->Size = System::Drawing::Size(376, 31);
			this->DateTimePicker_StartDate->TabIndex = 0;
			this->DateTimePicker_StartDate->Value = System::DateTime(2022, 1, 1, 0, 0, 0, 0);
			// 
			// DateTimePicker_EndDate
			// 
			this->DateTimePicker_EndDate->Location = System::Drawing::Point(154, 90);
			this->DateTimePicker_EndDate->Margin = System::Windows::Forms::Padding(4);
			this->DateTimePicker_EndDate->Name = L"DateTimePicker_EndDate";
			this->DateTimePicker_EndDate->Size = System::Drawing::Size(376, 31);
			this->DateTimePicker_EndDate->TabIndex = 1;
			// 
			// Load
			// 
			this->Load->BackColor = System::Drawing::SystemColors::ActiveBorder;
			this->Load->Cursor = System::Windows::Forms::Cursors::AppStarting;
			this->Load->FlatStyle = System::Windows::Forms::FlatStyle::Popup;
			this->Load->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Load->Location = System::Drawing::Point(43, 146);
			this->Load->Margin = System::Windows::Forms::Padding(4);
			this->Load->Name = L"Load";
			this->Load->Size = System::Drawing::Size(487, 88);
			this->Load->TabIndex = 2;
			this->Load->Text = L"Load Stock Data";
			this->Load->UseVisualStyleBackColor = false;
			this->Load->Click += gcnew System::EventHandler(this, &FormEntry::Button_LoadStockData_Click);
			// 
			// Label_StartDate
			// 
			this->Label_StartDate->AutoSize = true;
			this->Label_StartDate->Location = System::Drawing::Point(38, 42);
			this->Label_StartDate->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Label_StartDate->Name = L"Label_StartDate";
			this->Label_StartDate->Size = System::Drawing::Size(108, 25);
			this->Label_StartDate->TabIndex = 4;
			this->Label_StartDate->Text = L"Start Date";
			// 
			// Label_EndDate
			// 
			this->Label_EndDate->AutoSize = true;
			this->Label_EndDate->Location = System::Drawing::Point(38, 90);
			this->Label_EndDate->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Label_EndDate->Name = L"Label_EndDate";
			this->Label_EndDate->Size = System::Drawing::Size(101, 25);
			this->Label_EndDate->TabIndex = 5;
			this->Label_EndDate->Text = L"End Date";
			// 
			// openFileDialog1
			// 
			this->openFileDialog1->FileName = L"*.csv";
			this->openFileDialog1->Filter = L"All Stock files| *.csv| Daily Stocks|*-Day.csv| Weekly Stocks|*-Week.csv|Monthly "
				L"Stocks|*-Month.csv";
			this->openFileDialog1->InitialDirectory = L"C:\\Users\\Deipey Paanchal\\Desktop\\CIS4930Project\\Stock Data";
			this->openFileDialog1->Multiselect = true;
			this->openFileDialog1->FileOk += gcnew System::ComponentModel::CancelEventHandler(this, &FormEntry::openFileDialog1_FileOk);
			// 
			// FormEntry
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(634, 294);
			this->Controls->Add(this->Label_EndDate);
			this->Controls->Add(this->Label_StartDate);
			this->Controls->Add(this->Load);
			this->Controls->Add(this->DateTimePicker_EndDate);
			this->Controls->Add(this->DateTimePicker_StartDate);
			this->Margin = System::Windows::Forms::Padding(4);
			this->Name = L"FormEntry";
			this->Text = L"Stock Data Analysis Platform";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

	private: System::Void Button_LoadStockData_Click(System::Object^ sender, System::EventArgs^ e)
	{
		// Show the openFileDialog to allow the user to select files
		openFileDialog1->ShowDialog();
		// This function typically serves to trigger the file dialog and is not responsible for handling the selected files directly.
	}

	private: System::Void openFileDialog1_FileOk(System::Object^ sender, System::ComponentModel::CancelEventArgs^ e)
	{
		// Clear the candlestickList before populating it with new data
		candlestickList->Clear();

		// Get the selected filenames from the openFileDialog
		array<String^>^ selectedFilenames;
		array<String^>^ filenames = this->openFileDialog1->FileNames;
		selectedFilenames = gcnew array<String^>(filenames->Length);

		// Extract the file names from the full paths
		for (int i = 0; i < filenames->Length; ++i)
		{
			selectedFilenames[i] = Path::GetFileName(filenames[i]);
		}

		// Loop through each selected file
		for each (System::String ^ filename in filenames) {

			// Clear the candlestickList for each file
			candlestickList->Clear();

			// Open and read the file using a StreamReader
			StreamReader^ reader = gcnew StreamReader(filename);

			// Loop through each line in the file
			while (!reader->EndOfStream) {
				// Get start and end date from DateTimePickers
				System::DateTime startDate = DateTimePicker_StartDate->Value;
				System::DateTime endDate = DateTimePicker_EndDate->Value;

				// Read a line from the file
				String^ line = reader->ReadLine();

				// Define delimiters and split the line into an array of strings
				array<System::String^>^ delims = { ",", " ", "\"" };
				array<System::String^>^ StringArray = line->Split(delims, System::StringSplitOptions::RemoveEmptyEntries);

				// Skip header line
				if (StringArray[2] == "Date") continue;

				// Construct the date string
				System::String^ dateString = StringArray[2] + " " + StringArray[3] + ", " + StringArray[4];

				// Parse the date string into a DateTime object
				System::DateTime currStickDate = System::DateTime::Parse(dateString);

				// Check if the date is within the specified range
				if ((System::DateTime::Compare(currStickDate, startDate) >= 0) && (System::DateTime::Compare(currStickDate, endDate) <= 0)) {
					// Create a smartCandlestick object and add it to the candlestickList
					smartCandlestick^ cs = gcnew smartCandlestick(line);
					candlestickList->Add(cs);
				}

				// Create a smartCandlestick object and add it to the tempList
				smartCandlestick^ cs = gcnew smartCandlestick(line);
				tempList->Add(cs);
			}

			// Create a new form and display the candlestick data using a chart
			Form^ newForm = gcnew DisplayChartForms(candlestickList, tempList, filename);
			newForm->Show();
		}
	}
	};
}