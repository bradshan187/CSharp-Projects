
using CounterMVC.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CounterMVC {

    // View class representing the graphical user interface
    public partial class FormView : Form, IView {
        #region Constructors

        // Constructor initializes the form
        public FormView() {
            InitializeComponent();
        }
        #endregion

        #region IView

        // Event in the View interface triggered when the increment button is clicked
        public event EventHandler Increment;

        // Event in the View interface triggered when the increment value has been changed in the combo box
        public event EventHandler IncrementChanged;

        // Event in the View interface triggered when the add button has changed its "checked" property
        public event EventHandler AddButtonChangedState;

        // Method to update the label with the current increment value
        public void SetIncrementLabel(string value) {
            this.labelIncrement.Text = value;
        }

        // Method to get the index currently selected in the combo box
        public int GetSelectedIncrement() {
            // Return the selected increment value from the ComboBox
            return Convert.ToInt32(comboBoxIncrement.SelectedItem);
        }

        // Method to set the original selection in the combo box
        public int StartingIndexInComboBox(int index) {
            return comboBoxIncrement.SelectedIndex = index;
        }

        // Method to determine which button is checked as default
        public bool ButtonSelected(bool isAddChecked) {
            if (isAddChecked) {
                return addButton.Checked = true;
            } else {
                return subtractButton.Checked = true;
            }
        }

        #endregion

        #region Events

        // Event handler for the button click event
        private void buttonIncrement_Click(object sender, EventArgs e) {

            // Trigger the Increment event when the button is clicked
            this.Increment?.Invoke(this, EventArgs.Empty);
        }

        // Event handler for the changing combo box item event. Notice how I don't use the "this" keyword here
        private void comboBoxIncrement_SelectedIndexChanged(object sender, EventArgs e) {
            // Trigger the IncrementChanged event when the ComboBox selection changes
            IncrementChanged?.Invoke(this, EventArgs.Empty);
        }

        private void comboBoxIncrement_SelectedValueChanged(object sender, EventArgs e) {
            //IncrementChanged?.Invoke(this, EventArgs.Empty); // can also use this for the same outcome
        }

        // Event handler for button change event
        private void addButton_CheckedChanged(object sender, EventArgs e) {
            AddButtonChangedState?.Invoke(this, EventArgs.Empty);
        }


        #endregion

    }

}
