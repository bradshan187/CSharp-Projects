
using System;

namespace CounterMVC.Models {

    // Model class representing the data (number) and associated logic
    internal class Model {
        #region Fields

        // Private fields to store the number, current increment and the add buttons checked state
        private int number;
        private int currentIncrement;
        private bool addButtonChecked;

        #endregion

        #region Constructors

        // Constructor initializes the number to 0, current increment to the starting increment value and the add the add button to active
        public Model() {
            number = 0;
            currentIncrement = StartingIncrementValue();
            addButtonChecked = true;
        }

        #endregion

        #region Methods

        // Method to handle the increment logic in the model
        public void Increment() {
            if (addButtonChecked) {
                number += currentIncrement;
            } else {
                number -= currentIncrement;
            }
        }

        // Method to set the value of the increment
        public int SetIncrement(int increment) {
            return currentIncrement = increment;
        }

        // Method to set the initial index value for the selection in the combo box 
        public int StartingIndexForComboBox() {
            return 0;
        }

        // Method to set the initial increment value from the starting index 
        public int StartingIncrementValue() {
            return StartingIndexForComboBox() + 1;
        }

        // Method to return the state of the add button
        public bool AddButtonChecked() {
            return addButtonChecked;
        }

        // Method to switch the active button
        public bool SwitchButton() {
            if (addButtonChecked) {
                return addButtonChecked = false;
            }
            else {
                return addButtonChecked = true;
            }
        }

        // Override ToString method to get the string representation of the number
        public override string ToString() {
            return number.ToString();
        }

        #endregion
    }
}
