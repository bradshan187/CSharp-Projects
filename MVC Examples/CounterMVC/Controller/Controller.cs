
using CounterMVC.Models;
using CounterMVC.Views;
using System;
using System.Reflection;

namespace CounterMVC.Controllers {

    // Controller class connecting the Model and View
    public class Controller {
        #region Fields

        // Private fields for the View and Model
        private readonly IView view;
        private Model model;

        #endregion

        #region Constructors

        // Constructor initializes the Controller with a specific View
        public Controller(IView view) {
            this.view = view;
            this.model = new Model();

            // Letting the view know the starting index selection for the combo box
            view.StartingIndexInComboBox(model.StartingIndexForComboBox());

            // Logic for determining whether the add or subract button is ticked
            if (model.AddButtonChecked()) {
                view.ButtonSelected(true);
            } else { 
                view.ButtonSelected(false); 
            }

            // Subscribe to the View's IncrementChanged and increment events
            this.view.IncrementChanged += View_IncrementChanged;
            this.view.Increment += View_UpdateIncrementLabel;
            this.view.AddButtonChangedState += View_ButtonChanged;
        }

        #endregion

        #region Events

        // Event handler for the IncrementChanged event in the View
        private void View_IncrementChanged(object sender, EventArgs e) {
            // Get the selected increment value from the View
            model.SetIncrement(view.GetSelectedIncrement());
        }

        // Event handler for the UpdateIncrementLabel event in the View
        private void View_UpdateIncrementLabel(object sender, EventArgs e) {
            // Call the new Increment method in the Model
            model.Increment();

            // Update the View with the new number value
            view.SetIncrementLabel(model.ToString());
        }

        // Event handler for the ButtonChanged event in the View
        private void View_ButtonChanged(object sender, EventArgs e) {
            model.SwitchButton();
        }
        #endregion
    }
}
