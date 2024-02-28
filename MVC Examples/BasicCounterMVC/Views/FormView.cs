
using BasicCounterMVC.Views;
using System;
using System.Windows.Forms;

namespace BasicCounterMVC {

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
        public event EventHandler IncrementChanged;

        // Method to update the label with the current increment value
        public void SetIncrementLabel(string value) {
            this.labelIncrement.Text = value;
        }

        #endregion

        #region Events

        // Event handler for the button click event
        private void buttonIncrement_Click(object sender, EventArgs e) {

            // Trigger the IncrementChanged event when the button is clicked
            this.IncrementChanged?.Invoke(this, EventArgs.Empty);
        }

        #endregion
    }

}
