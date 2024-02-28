
namespace BasicCounterMVC.Models {

    // Model class representing the data (number) and associated logic
    internal class Number {
        #region Fields

        // Private field to store the number
        private int number;

        #endregion

        #region Constructors

        // Constructor initializes the number to 0
        public Number() {
            this.number = 0;
        }

        #endregion

        #region Methods

        // Method to increment the number
        public void Increment() {
            this.number++;
        }

        // Override ToString method to get the string representation of the number
        public override string ToString() {
            return this.number.ToString();
        }

        #endregion
    }
}
