
using BasicCounterMVC.Models;
using BasicCounterMVC.Views;
using System;

namespace BasicCounterMVC.Controllers {

    // Controller class connecting the Model and View
    public class Controller {
        #region Fields

        // Private fields for the View and Model
        private readonly IView view;
        private Number number;

        #endregion

        #region Constructors

        // Constructor initializes the Controller with a specific View
        public Controller(IView view) {
            this.view = view;
            this.number = new Number();

            // Subscribe to the View's IncrementChanged event
            this.view.IncrementChanged += View_IncrementChanged;
        }

        #endregion

        #region Events

        // Event handler for the IncrementChanged event in the View
        private void View_IncrementChanged(object sender, EventArgs e) {

            // Increment the number in the Model
            this.number.Increment();
            /*number.Increment();*/ // This also works

            // Update the View with the new number value
            this.view.SetIncrementLabel(number.ToString());
            /*view.SetIncrementLabel(number.ToString());*/ // This also works
        }

        #endregion
    }
}
