#pragma once
#include "smartCandlestick.h"
#include <cliext/list>
#include "FormEntry.h"

namespace CIS4930Project2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Windows::Forms::DataVisualization::Charting;
	using namespace candlestick_Header;

	/// <summary>
	/// Summary for DisplayChartForms
	/// </summary>
	public ref class DisplayChartForms : public System::Windows::Forms::Form
	{
	public:
		// Constructor for the DisplayChartForms class that initializes the form
		// and displays a chart with candlestick data.
		DisplayChartForms(System::ComponentModel::BindingList<smartCandlestick^>^ candlestickList, System::ComponentModel::BindingList<smartCandlestick^>^ tempList, String^ filename)
		{
			// Assign the provided candlestickList and tempList to the class members
			this->candlestickList = candlestickList;
			this->tempList = tempList;

			// Initialize the form components
			InitializeComponent();

			// Show the form
			this->Show();

			// Extract the ticker symbol from the filename (excluding extension)
			String^ ticker = System::IO::Path::GetFileNameWithoutExtension(filename);

			// Set the form's title to the ticker symbol
			this->Text = ticker;

			// Add the ticker symbol as a title to the chart
			Chart_Candlestick->Titles->Add(ticker);

			// Set the candlestickList as the data source for the chart
			Chart_Candlestick->DataSource = candlestickList;

			// Bind and initiate the chart to reflect the candlestick data
			Chart_Candlestick->DataBind();
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~DisplayChartForms()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Button^ Button_UpdateStockData;
	private: System::Windows::Forms::Label^ Label_UpdateEndDate;
	private: System::Windows::Forms::Label^ Label_StartDate;
	private: System::Windows::Forms::DateTimePicker^ DateTimePicker_EndDate;
	private: System::Windows::Forms::DateTimePicker^ DateTimePicker_StartDate;
	private: System::Windows::Forms::DataVisualization::Charting::Chart^ Chart_Candlestick;
	private: System::Collections::Generic::List<smartCandlestick^>^ datedList;
	public: BindingList<smartCandlestick^>^ candlestickList;
	public: BindingList<smartCandlestick^>^ tempList;
	private: System::Windows::Forms::ComboBox^ DropDownMenu_PatternSelect;
	private: System::Windows::Forms::Label^ Label_SelectPattern;
	private: System::Windows::Forms::Button^ Button_ShowPattern;
	private: System::Windows::Forms::Button^ Button_ClearPattern;

	private: System::ComponentModel::Container^ components;

#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			System::Windows::Forms::DataVisualization::Charting::ChartArea^ chartArea3 = (gcnew System::Windows::Forms::DataVisualization::Charting::ChartArea());
			System::Windows::Forms::DataVisualization::Charting::ChartArea^ chartArea4 = (gcnew System::Windows::Forms::DataVisualization::Charting::ChartArea());
			System::Windows::Forms::DataVisualization::Charting::Legend^ legend2 = (gcnew System::Windows::Forms::DataVisualization::Charting::Legend());
			System::Windows::Forms::DataVisualization::Charting::Series^ series3 = (gcnew System::Windows::Forms::DataVisualization::Charting::Series());
			System::Windows::Forms::DataVisualization::Charting::Series^ series4 = (gcnew System::Windows::Forms::DataVisualization::Charting::Series());
			this->Button_UpdateStockData = (gcnew System::Windows::Forms::Button());
			this->Label_UpdateEndDate = (gcnew System::Windows::Forms::Label());
			this->Label_StartDate = (gcnew System::Windows::Forms::Label());
			this->DateTimePicker_EndDate = (gcnew System::Windows::Forms::DateTimePicker());
			this->DateTimePicker_StartDate = (gcnew System::Windows::Forms::DateTimePicker());
			this->Chart_Candlestick = (gcnew System::Windows::Forms::DataVisualization::Charting::Chart());
			this->DropDownMenu_PatternSelect = (gcnew System::Windows::Forms::ComboBox());
			this->Label_SelectPattern = (gcnew System::Windows::Forms::Label());
			this->Button_ShowPattern = (gcnew System::Windows::Forms::Button());
			this->Button_ClearPattern = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->Chart_Candlestick))->BeginInit();
			this->SuspendLayout();
			// 
			// Button_UpdateStockData
			// 
			this->Button_UpdateStockData->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Button_UpdateStockData->Location = System::Drawing::Point(781, 1056);
			this->Button_UpdateStockData->Margin = System::Windows::Forms::Padding(5, 6, 5, 6);
			this->Button_UpdateStockData->Name = L"Button_UpdateStockData";
			this->Button_UpdateStockData->Size = System::Drawing::Size(202, 92);
			this->Button_UpdateStockData->TabIndex = 13;
			this->Button_UpdateStockData->Text = L"Update Stock Data";
			this->Button_UpdateStockData->UseVisualStyleBackColor = true;
			this->Button_UpdateStockData->Click += gcnew System::EventHandler(this, &DisplayChartForms::updateButton_Click);
			// 
			// Label_UpdateEndDate
			// 
			this->Label_UpdateEndDate->AutoSize = true;
			this->Label_UpdateEndDate->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Label_UpdateEndDate->Location = System::Drawing::Point(394, 1056);
			this->Label_UpdateEndDate->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Label_UpdateEndDate->Name = L"Label_UpdateEndDate";
			this->Label_UpdateEndDate->Size = System::Drawing::Size(176, 25);
			this->Label_UpdateEndDate->TabIndex = 12;
			this->Label_UpdateEndDate->Text = L"Update End Date";
			// 
			// Label_StartDate
			// 
			this->Label_StartDate->AutoSize = true;
			this->Label_StartDate->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Label_StartDate->Location = System::Drawing::Point(13, 1056);
			this->Label_StartDate->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Label_StartDate->Name = L"Label_StartDate";
			this->Label_StartDate->Size = System::Drawing::Size(183, 25);
			this->Label_StartDate->TabIndex = 11;
			this->Label_StartDate->Text = L"Update Start Date";
			// 
			// DateTimePicker_EndDate
			// 
			this->DateTimePicker_EndDate->Location = System::Drawing::Point(399, 1094);
			this->DateTimePicker_EndDate->Margin = System::Windows::Forms::Padding(4);
			this->DateTimePicker_EndDate->Name = L"DateTimePicker_EndDate";
			this->DateTimePicker_EndDate->Size = System::Drawing::Size(373, 31);
			this->DateTimePicker_EndDate->TabIndex = 9;
			// 
			// DateTimePicker_StartDate
			// 
			this->DateTimePicker_StartDate->Location = System::Drawing::Point(13, 1094);
			this->DateTimePicker_StartDate->Margin = System::Windows::Forms::Padding(4);
			this->DateTimePicker_StartDate->Name = L"DateTimePicker_StartDate";
			this->DateTimePicker_StartDate->Size = System::Drawing::Size(378, 31);
			this->DateTimePicker_StartDate->TabIndex = 8;
			this->DateTimePicker_StartDate->Value = System::DateTime(2022, 1, 1, 0, 0, 0, 0);
			// 
			// Chart_Candlestick
			// 
			chartArea3->AxisX->Title = L"Date";
			chartArea3->AxisY->Title = L"Price";
			chartArea3->Name = L"Area_OHLC";
			chartArea4->AlignWithChartArea = L"Area_OHLC";
			chartArea4->AxisX->Title = L"Date";
			chartArea4->AxisY->Title = L"Volume";
			chartArea4->Name = L"Area_Volume";
			this->Chart_Candlestick->ChartAreas->Add(chartArea3);
			this->Chart_Candlestick->ChartAreas->Add(chartArea4);
			legend2->Name = L"Legend1";
			this->Chart_Candlestick->Legends->Add(legend2);
			this->Chart_Candlestick->Location = System::Drawing::Point(13, 6);
			this->Chart_Candlestick->Margin = System::Windows::Forms::Padding(4);
			this->Chart_Candlestick->Name = L"Chart_Candlestick";
			series3->ChartArea = L"Area_OHLC";
			series3->ChartType = System::Windows::Forms::DataVisualization::Charting::SeriesChartType::Candlestick;
			series3->CustomProperties = L"PriceDownColor=Red, PriceUpColor=Green";
			series3->Legend = L"Legend1";
			series3->Name = L"OHLC";
			series3->XValueMember = L"Date";
			series3->XValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Date;
			series3->YValueMembers = L"High, Low, Open, Close";
			series3->YValuesPerPoint = 4;
			series4->ChartArea = L"Area_Volume";
			series4->Legend = L"Legend1";
			series4->Name = L"Volume";
			series4->XValueMember = L"Date";
			series4->XValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Date;
			series4->YValueMembers = L"Volume";
			series4->YValueType = System::Windows::Forms::DataVisualization::Charting::ChartValueType::Int64;
			this->Chart_Candlestick->Series->Add(series3);
			this->Chart_Candlestick->Series->Add(series4);
			this->Chart_Candlestick->Size = System::Drawing::Size(1696, 946);
			this->Chart_Candlestick->TabIndex = 14;
			this->Chart_Candlestick->Text = L"Chart_Candlestick";
			// 
			// DropDownMenu_PatternSelect
			// 
			this->DropDownMenu_PatternSelect->FormattingEnabled = true;
			this->DropDownMenu_PatternSelect->Items->AddRange(gcnew cli::array< System::Object^  >(10) {
				L"Bullish", L"Bearish", L"Neutral",
					L"Marubozu", L"Doji", L"DragonFlyDoji", L"GravestoneDoji", L"InvertedGravestoneDoji", L"Hammer", L"InvertedHammer"
			});
			this->DropDownMenu_PatternSelect->Location = System::Drawing::Point(102, 969);
			this->DropDownMenu_PatternSelect->Margin = System::Windows::Forms::Padding(4);
			this->DropDownMenu_PatternSelect->Name = L"DropDownMenu_PatternSelect";
			this->DropDownMenu_PatternSelect->Size = System::Drawing::Size(304, 33);
			this->DropDownMenu_PatternSelect->TabIndex = 16;
			this->DropDownMenu_PatternSelect->Text = L"Choose Pattern";
			// 
			// Label_SelectPattern
			// 
			this->Label_SelectPattern->AutoSize = true;
			this->Label_SelectPattern->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Label_SelectPattern->Location = System::Drawing::Point(13, 972);
			this->Label_SelectPattern->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->Label_SelectPattern->Name = L"Label_SelectPattern";
			this->Label_SelectPattern->Size = System::Drawing::Size(81, 25);
			this->Label_SelectPattern->TabIndex = 17;
			this->Label_SelectPattern->Text = L"Pattern";
			// 
			// Button_ShowPattern
			// 
			this->Button_ShowPattern->BackColor = System::Drawing::SystemColors::ControlLight;
			this->Button_ShowPattern->ForeColor = System::Drawing::SystemColors::ActiveCaptionText;
			this->Button_ShowPattern->Location = System::Drawing::Point(414, 960);
			this->Button_ShowPattern->Margin = System::Windows::Forms::Padding(4);
			this->Button_ShowPattern->Name = L"Button_ShowPattern";
			this->Button_ShowPattern->Size = System::Drawing::Size(291, 44);
			this->Button_ShowPattern->TabIndex = 18;
			this->Button_ShowPattern->Text = L"Show Pattern";
			this->Button_ShowPattern->UseVisualStyleBackColor = false;
			this->Button_ShowPattern->Click += gcnew System::EventHandler(this, &DisplayChartForms::Button_SelectPattern_Click);
			// 
			// Button_ClearPattern
			// 
			this->Button_ClearPattern->ForeColor = System::Drawing::Color::Red;
			this->Button_ClearPattern->Location = System::Drawing::Point(713, 960);
			this->Button_ClearPattern->Margin = System::Windows::Forms::Padding(4);
			this->Button_ClearPattern->Name = L"Button_ClearPattern";
			this->Button_ClearPattern->Size = System::Drawing::Size(231, 44);
			this->Button_ClearPattern->TabIndex = 19;
			this->Button_ClearPattern->Text = L"Clear Pattern";
			this->Button_ClearPattern->UseVisualStyleBackColor = true;
			this->Button_ClearPattern->Click += gcnew System::EventHandler(this, &DisplayChartForms::Button_ClearPattern_Click);
			// 
			// DisplayChartForms
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(12, 25);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ControlLightLight;
			this->ClientSize = System::Drawing::Size(2340, 1688);
			this->Controls->Add(this->Button_ClearPattern);
			this->Controls->Add(this->Button_ShowPattern);
			this->Controls->Add(this->Label_SelectPattern);
			this->Controls->Add(this->DropDownMenu_PatternSelect);
			this->Controls->Add(this->Chart_Candlestick);
			this->Controls->Add(this->Button_UpdateStockData);
			this->Controls->Add(this->Label_UpdateEndDate);
			this->Controls->Add(this->Label_StartDate);
			this->Controls->Add(this->DateTimePicker_EndDate);
			this->Controls->Add(this->DateTimePicker_StartDate);
			this->ForeColor = System::Drawing::SystemColors::ActiveCaption;
			this->Margin = System::Windows::Forms::Padding(5, 6, 5, 6);
			this->Name = L"DisplayChartForms";
			this->Text = L"Stock Data Chart Form";
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->Chart_Candlestick))->EndInit();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion

		int DisplayChartForms::AnnotateArrow(int index_to_annotate, String^ label)
		{
			// Check index
			if (index_to_annotate < 0 || index_to_annotate >= candlestickList->Count)
				return -1;  // Return -1 if the index is out of bounds

			// Create Annotations with Arrows
			System::Windows::Forms::DataVisualization::Charting::Annotation^ annotation =
				gcnew System::Windows::Forms::DataVisualization::Charting::ArrowAnnotation;

			// Get candleStick at the index
			smartCandlestick^ tempStick = candlestickList[index_to_annotate];

			// Annotation area
			annotation->ClipToChartArea = "Area_OHLC";  // Change to the appropriate chart area name
			annotation->AxisY = Chart_Candlestick->ChartAreas["Area_OHLC"]->AxisY;

			// Annotation point
			System::Windows::Forms::DataVisualization::Charting::DataPoint^ point =
				Chart_Candlestick->Series["OHLC"]->Points[index_to_annotate];
			annotation->AnchorDataPoint = point;

			// Annotation design properties and Dimension
			annotation->LineColor = System::Drawing::Color::Black;
			annotation->ForeColor = System::Drawing::Color::Black;
			annotation->BackColor = System::Drawing::Color::Black;
			annotation->BackSecondaryColor = System::Drawing::Color::Black;
			annotation->ShadowColor = System::Drawing::Color::Transparent;
			annotation->Width = 0.5;
			annotation->Height = 10;
			annotation->LineWidth = 1;
			annotation->Alignment = System::Drawing::ContentAlignment::TopLeft;
			annotation->AnchorOffsetY = tempStick->range / 3;
			annotation->AxisY->IsStartedFromZero = false;
			// Add a label to the box annotation
			System::Windows::Forms::DataVisualization::Charting::TextAnnotation^ labelAnnotation =
				gcnew System::Windows::Forms::DataVisualization::Charting::TextAnnotation;

			labelAnnotation->AxisX = annotation->AxisX;
			labelAnnotation->AxisY = annotation->AxisY;
			labelAnnotation->Text = label;
			labelAnnotation->AnchorDataPoint = point;
			labelAnnotation->AnchorOffsetY = 10; // Adjust the offset as needed
			// Add single annotation to Annotation chart
			Chart_Candlestick->Annotations->Add(annotation);

			return 0;
		}

		// Function to highlight specific candlestick patterns on the chart
		void DisplayChartForms::HighlightPattern(String^ selectedPattern)
		{
			// Clear any existing annotations on the chart
			Chart_Candlestick->Annotations->Clear();

			// Iterate through the candlestickList to analyze and annotate patterns
			for (int i = 0; i < candlestickList->Count; ++i)
			{
				// Get the smartCandlestick object at the current index
				smartCandlestick^ candlestick = candlestickList[i];

				// Compute candlestick patterns for the current candlestick
				candlestick->PatternCompute();

				// Check for the selected pattern and annotate with an arrow if applicable
				if ((selectedPattern == "Bullish") && candlestick->IsBullish)
				{
					AnnotateArrow(i, "Bullish");
				}
				else if ((selectedPattern == "Bearish") && candlestick->IsBearish)
				{
					AnnotateArrow(i, "Bearish");
				}
				else if ((selectedPattern == "Neutral") && candlestick->IsNeutral)
				{
					AnnotateArrow(i, "Neutral");
				}
				else if ((selectedPattern == "Marubozu") && candlestick->IsMarubozu)
				{
					AnnotateArrow(i, "Marubozu");
				}
				else if ((selectedPattern == "Doji") && candlestick->IsDoji)
				{
					AnnotateArrow(i, "Doji");
				}
				else if ((selectedPattern == "DragonFlyDoji") && candlestick->IsDragonFlyDoji)
				{
					AnnotateArrow(i, "DragonFlyDoji");
				}
				else if ((selectedPattern == "GravestoneDoji") && candlestick->IsGravestoneDoji)
				{
					AnnotateArrow(i, "GravestoneDoji");
				}
				else if ((selectedPattern == "Hammer") && candlestick->IsHammer)
				{
					AnnotateArrow(i, "Hammer");
				}
				else if ((selectedPattern == "InvertedHammer") && candlestick->IsInvertedHammer)
				{
					AnnotateArrow(i, "InvertedHammer");
				}

			}
		}

	// Event handler for the Click event of the "Update" button
	private: System::Void updateButton_Click(System::Object^ sender, System::EventArgs^ e)
	{
		// Clear all annotations from the chart before updating
		Chart_Candlestick->Annotations->Clear();

		// Clear the candlestickList to prepare for new data
		candlestickList->Clear();

		// Retrieve the selected start and end dates from the DateTimePicker controls
		System::DateTime startDateValue = DateTimePicker_StartDate->Value; // Start date selected
		System::DateTime endDateValue = DateTimePicker_EndDate->Value;     // End date selected

		// Iterate through the tempList, which contains all the smartCandlestick data
		for each (smartCandlestick ^ candlestick in tempList)
		{
			// Get the date of the current candlestick
			System::DateTime dateOfCurrentStick = candlestick->date;

			// Compare the date of the current candlestick with the selected start and end dates
			if ((System::DateTime::Compare(dateOfCurrentStick, startDateValue) >= 0) &&
				(System::DateTime::Compare(dateOfCurrentStick, endDateValue) <= 0))
			{
				// Add the candlestick to the list if it falls within the selected date range
				candlestickList->Add(candlestick);
			}
		}

		// Set the candlestickList as the data source for the chart
		Chart_Candlestick->DataSource = candlestickList;

		// Bind and initiate the chart to reflect the updated data
		Chart_Candlestick->DataBind();
	}

	// Event handler for the IndexChanged event of the pattern selection drop-down menu
	private: System::Void DropDownMenu_SelectPattern_IndexChanged(System::Object^ sender, System::EventArgs^ e)
	{
		// Clear all annotations from the chart before highlighting a new pattern
		Chart_Candlestick->Annotations->Clear();

		// Retrieve the selected pattern from the drop-down menu
		String^ selectedPattern = DropDownMenu_PatternSelect->SelectedItem->ToString();

		// Call the HighlightPattern function to highlight the selected pattern on the chart
		HighlightPattern(selectedPattern);
	}

	// Event handler for the Click event of the "Select Pattern" button
	private: System::Void Button_SelectPattern_Click(System::Object^ sender, System::EventArgs^ e)
	{
		// Retrieve the selected pattern from the drop-down menu
		String^ selectedPattern = DropDownMenu_PatternSelect->SelectedItem->ToString();

		// Call the HighlightPattern function to highlight the selected pattern on the chart
		HighlightPattern(selectedPattern);
	}
	
	// Event handler for the Click event of the "Clear Pattern" button
	private: System::Void Button_ClearPattern_Click(System::Object^ sender, System::EventArgs^ e)
	{
		// Clear all annotations from the chart when the "Clear Pattern" button is clicked
		Chart_Candlestick->Annotations->Clear();
	}
	};
}