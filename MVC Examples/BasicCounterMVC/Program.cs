using BasicCounterMVC.Controllers;
using System;
using System.Windows.Forms;

namespace BasicCounterMVC {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            // Enable visual styles for the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of the View (FormView)
            var form = new FormView();

            // Create an instance of the Controller, passing the View to establish the connection
            var controller = new Controller(form);

            // Run the application using the View as the main form
            Application.Run(form);
        }
    }
}
