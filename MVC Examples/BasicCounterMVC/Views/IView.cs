
using System;

namespace BasicCounterMVC.Views {

    // Interface representing the View in the MVC pattern
    public interface IView {

        // Event triggered when the increment action occurs
        event EventHandler IncrementChanged;

        // Method to update the display with the current increment value
        void SetIncrementLabel(string value);
    }
}
