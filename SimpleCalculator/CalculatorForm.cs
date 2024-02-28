namespace WinFormsCalculator {
    public partial class CalculatorForm : Form {
        public CalculatorForm() {
            InitializeComponent();
        }

        double firstValue, secondValue, result;
        string currentOperator = "";
        bool zeroDivisionError = false;

        private void resetButton_Click(object sender, EventArgs e) {
            answerTextBox.Text = "0";
        }

        private void negateButton_Click(Object sender, EventArgs e) {
            if (!answerTextBox.Text.Contains("-")) {
                if (!answerTextBox.Text.StartsWith("0")) {
                    answerTextBox.Text = "-" + answerTextBox.Text;
                }
            }
            else {
                answerTextBox.Text = answerTextBox.Text.Remove(0, 1);
            }
        }

        private void divideButton_Click(Object sender, EventArgs e) {
            firstValue = Double.Parse(answerTextBox.Text);
            currentOperator = "/";

            answerTextBox.Text = "0";
        }

        private void sevenButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "7";
            }
            else {
                answerTextBox.AppendText("7");
            }
        }

        private void eightButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "8";
            }
            else {
                answerTextBox.AppendText("8");
            }
        }

        private void nineButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "9";
            }
            else {
                answerTextBox.AppendText("9");
            }
        }

        private void multiplyButton_Click(Object sender, EventArgs e) {
            firstValue = Double.Parse(answerTextBox.Text);
            currentOperator = "*";

            answerTextBox.Text = "0";
        }

        private void fourButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "4";
            }
            else {
                answerTextBox.AppendText("4");
            }
        }

        private void fiveButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "5";
            }
            else {
                answerTextBox.AppendText("5");
            }
        }

        private void sixButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "6";
            }
            else {
                answerTextBox.AppendText("6");
            }
        }

        private void subtractButton_Click(Object sender, EventArgs e) {
            firstValue = Double.Parse(answerTextBox.Text);
            currentOperator = "-";

            answerTextBox.Text = "0";
        }

        private void oneButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "1";
            }
            else {
                answerTextBox.AppendText("1");
            }
        }

        private void twoButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "2";
            }
            else {
                answerTextBox.AppendText("2");
            }
        }

        private void threeButton_Click(Object sender, EventArgs e) {
            if (answerTextBox.Text == "0" || answerTextBox.Text == "Error") {
                answerTextBox.Text = "3";
            }
            else {
                answerTextBox.AppendText("3");
            }
        }

        private void addButton_Click(Object sender, EventArgs e) {
            firstValue = Double.Parse(answerTextBox.Text);
            currentOperator = "+";

            answerTextBox.Text = "0";
        }

        private void zeroButton_Click(object sender, EventArgs e) {
            if (answerTextBox.Text != "0" && answerTextBox.Text != "Error") {
                answerTextBox.AppendText("0");
            }
        }

        private void decimalButton_Click(Object sender, EventArgs e) {
            if (!answerTextBox.Text.Contains(".")) {
                answerTextBox.AppendText(".");
            }
        }

        private void equalsButton_Click(Object sender, EventArgs e) {
            if (!answerTextBox.Text.Equals(result.ToString())) {
                secondValue = Double.Parse(answerTextBox.Text);
            }

            switch (currentOperator) {
                case "+":
                    result = firstValue + secondValue;
                    break;
                case "-":
                    result = firstValue - secondValue;
                    break;
                case "*":
                    result = firstValue * secondValue;
                    break;
                case "/":
                    if (answerTextBox.Text != "0") {
                        result = firstValue / secondValue;
                    }
                    else {
                        zeroDivisionError = true;
                    }
                    break;
            }

            if (!zeroDivisionError) {
                answerTextBox.Text = result.ToString();
            }
            else {
                answerTextBox.Text = "Error";
                zeroDivisionError = false;
            }

            firstValue = result;

        }
    }
}
