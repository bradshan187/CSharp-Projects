
using System;
using System.Collections.Generic;

namespace CounterMVC.Views {

    // Interface representing the View in the MVC pattern
    public interface IView {

        // Event triggered when the increment value is changed
        event EventHandler IncrementChanged;

        // Event triggered when the increment action occurs
        event EventHandler Increment;

        // Event triggered when the active button is changed
        event EventHandler AddButtonChangedState;

        // Method to update the display with the current increment value
        void SetIncrementLabel(string value);

        // Method to get the selected increment value from the ComboBox
        int GetSelectedIncrement();

        // Method to update the display with the starting selection in the combo box
        int StartingIndexInComboBox(int index);

        // Method to update the display with which button is checked as default
        bool ButtonSelected(bool isAddChecked);
    }
}
