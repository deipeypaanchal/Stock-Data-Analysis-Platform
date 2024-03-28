/*
Name: Deepey Panchal
U-Number: U80305771
*/

// Include the headers for "DisplayChartForms" and "candlestick" classes
#include "FormEntry.h"
#include "candlestick.h"

// Use the namespaces related to the .NET System and Windows Forms
using namespace System;
using namespace System::Windows::Forms;

// The [STAThreadAttribute] is required for Windows Forms applications.
// It indicates that the COM threading model for the application is single-threaded apartment (STA).
[STAThreadAttribute]

// Main function of the application
void main(array<String^>^ args) {
	// Enable the visual styles for the application, this makes the app use modern OS-styling.
	Application::EnableVisualStyles();

	// Set the application to not use graphical text rendering, which can improve text rendering performance for older devices.
	Application::SetCompatibleTextRenderingDefault(false);

	// Create an instance of "DisplayChartForms" which was defined in the "DisplayChartForms.h" header
	CIS4930Project2::FormEntry form;

	// Run the application starting with "DisplayChartForms" as the main window
	Application::Run(% form);
}