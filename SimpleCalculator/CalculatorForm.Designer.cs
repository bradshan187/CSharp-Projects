namespace WinFormsCalculator {
    partial class CalculatorForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            answerTextBox = new TextBox();
            divideButton = new Button();
            multiplyButton = new Button();
            subtractButton = new Button();
            addButton = new Button();
            threeButton = new Button();
            twoButton = new Button();
            oneButton = new Button();
            resetButton = new Button();
            negateButton = new Button();
            sevenButton = new Button();
            eightButton = new Button();
            nineButton = new Button();
            fourButton = new Button();
            fiveButton = new Button();
            zeroButton = new Button();
            decimalButton = new Button();
            equalsButton = new Button();
            sixButton = new Button();
            SuspendLayout();
            // 
            // answerTextBox
            // 
            answerTextBox.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answerTextBox.Location = new Point(12, 12);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.ReadOnly = true;
            answerTextBox.Size = new Size(414, 93);
            answerTextBox.TabIndex = 0;
            answerTextBox.TabStop = false;
            answerTextBox.Text = "0";
            answerTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // divideButton
            // 
            divideButton.Location = new Point(327, 150);
            divideButton.Name = "divideButton";
            divideButton.Size = new Size(99, 90);
            divideButton.TabIndex = 3;
            divideButton.Text = "/";
            divideButton.UseVisualStyleBackColor = true;
            divideButton.Click += divideButton_Click;
            // 
            // multiplyButton
            // 
            multiplyButton.Location = new Point(327, 246);
            multiplyButton.Name = "multiplyButton";
            multiplyButton.Size = new Size(99, 90);
            multiplyButton.TabIndex = 7;
            multiplyButton.Text = "X";
            multiplyButton.UseVisualStyleBackColor = true;
            multiplyButton.Click += multiplyButton_Click;
            // 
            // subtractButton
            // 
            subtractButton.Location = new Point(327, 342);
            subtractButton.Name = "subtractButton";
            subtractButton.Size = new Size(99, 90);
            subtractButton.TabIndex = 11;
            subtractButton.Text = "-";
            subtractButton.UseVisualStyleBackColor = true;
            subtractButton.Click += subtractButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(327, 438);
            addButton.Name = "addButton";
            addButton.Size = new Size(99, 90);
            addButton.TabIndex = 15;
            addButton.Text = "+";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // threeButton
            // 
            threeButton.Location = new Point(222, 438);
            threeButton.Name = "threeButton";
            threeButton.Size = new Size(99, 90);
            threeButton.TabIndex = 14;
            threeButton.Text = "3";
            threeButton.UseVisualStyleBackColor = true;
            threeButton.Click += threeButton_Click;
            // 
            // twoButton
            // 
            twoButton.Location = new Point(117, 438);
            twoButton.Name = "twoButton";
            twoButton.Size = new Size(99, 90);
            twoButton.TabIndex = 13;
            twoButton.Text = "2";
            twoButton.UseVisualStyleBackColor = true;
            twoButton.Click += twoButton_Click;
            // 
            // oneButton
            // 
            oneButton.Location = new Point(12, 438);
            oneButton.Name = "oneButton";
            oneButton.Size = new Size(99, 90);
            oneButton.TabIndex = 12;
            oneButton.Text = "1";
            oneButton.UseVisualStyleBackColor = true;
            oneButton.Click += oneButton_Click;
            // 
            // resetButton
            // 
            resetButton.Location = new Point(12, 150);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(204, 90);
            resetButton.TabIndex = 1;
            resetButton.Text = "C";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // negateButton
            // 
            negateButton.Location = new Point(222, 150);
            negateButton.Name = "negateButton";
            negateButton.Size = new Size(99, 90);
            negateButton.TabIndex = 2;
            negateButton.Text = "+/-";
            negateButton.UseVisualStyleBackColor = true;
            negateButton.Click += negateButton_Click;
            // 
            // sevenButton
            // 
            sevenButton.Location = new Point(12, 246);
            sevenButton.Name = "sevenButton";
            sevenButton.Size = new Size(99, 90);
            sevenButton.TabIndex = 4;
            sevenButton.Text = "7";
            sevenButton.UseVisualStyleBackColor = true;
            sevenButton.Click += sevenButton_Click;
            // 
            // eightButton
            // 
            eightButton.Location = new Point(117, 246);
            eightButton.Name = "eightButton";
            eightButton.Size = new Size(99, 90);
            eightButton.TabIndex = 5;
            eightButton.Text = "8";
            eightButton.UseVisualStyleBackColor = true;
            eightButton.Click += eightButton_Click;
            // 
            // nineButton
            // 
            nineButton.Location = new Point(222, 246);
            nineButton.Name = "nineButton";
            nineButton.Size = new Size(99, 90);
            nineButton.TabIndex = 6;
            nineButton.Text = "9";
            nineButton.UseVisualStyleBackColor = true;
            nineButton.Click += nineButton_Click;
            // 
            // fourButton
            // 
            fourButton.Location = new Point(12, 342);
            fourButton.Name = "fourButton";
            fourButton.Size = new Size(99, 90);
            fourButton.TabIndex = 8;
            fourButton.Text = "4";
            fourButton.UseVisualStyleBackColor = true;
            fourButton.Click += fourButton_Click;
            // 
            // fiveButton
            // 
            fiveButton.Location = new Point(117, 342);
            fiveButton.Name = "fiveButton";
            fiveButton.Size = new Size(99, 90);
            fiveButton.TabIndex = 9;
            fiveButton.Text = "5";
            fiveButton.UseVisualStyleBackColor = true;
            fiveButton.Click += fiveButton_Click;
            // 
            // zeroButton
            // 
            zeroButton.Location = new Point(12, 534);
            zeroButton.Name = "zeroButton";
            zeroButton.Size = new Size(204, 90);
            zeroButton.TabIndex = 16;
            zeroButton.Text = "0";
            zeroButton.UseVisualStyleBackColor = true;
            zeroButton.Click += zeroButton_Click;
            // 
            // decimalButton
            // 
            decimalButton.Location = new Point(222, 534);
            decimalButton.Name = "decimalButton";
            decimalButton.Size = new Size(99, 90);
            decimalButton.TabIndex = 17;
            decimalButton.Text = ".";
            decimalButton.UseVisualStyleBackColor = true;
            decimalButton.Click += decimalButton_Click;
            // 
            // equalsButton
            // 
            equalsButton.Location = new Point(327, 533);
            equalsButton.Name = "equalsButton";
            equalsButton.Size = new Size(99, 90);
            equalsButton.TabIndex = 18;
            equalsButton.Text = "=";
            equalsButton.UseVisualStyleBackColor = true;
            equalsButton.Click += equalsButton_Click;
            // 
            // sixButton
            // 
            sixButton.Location = new Point(222, 342);
            sixButton.Name = "sixButton";
            sixButton.Size = new Size(99, 90);
            sixButton.TabIndex = 10;
            sixButton.Text = "6";
            sixButton.UseVisualStyleBackColor = true;
            sixButton.Click += sixButton_Click;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 635);
            Controls.Add(sixButton);
            Controls.Add(equalsButton);
            Controls.Add(decimalButton);
            Controls.Add(zeroButton);
            Controls.Add(fiveButton);
            Controls.Add(fourButton);
            Controls.Add(nineButton);
            Controls.Add(eightButton);
            Controls.Add(sevenButton);
            Controls.Add(negateButton);
            Controls.Add(resetButton);
            Controls.Add(oneButton);
            Controls.Add(twoButton);
            Controls.Add(threeButton);
            Controls.Add(addButton);
            Controls.Add(subtractButton);
            Controls.Add(multiplyButton);
            Controls.Add(divideButton);
            Controls.Add(answerTextBox);
            Name = "CalculatorForm";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox answerTextBox;
        private Button divideButton;
        private Button multiplyButton;
        private Button subtractButton;
        private Button addButton;
        private Button threeButton;
        private Button twoButton;
        private Button oneButton;
        private Button button8;
        private Button resetButton;
        private Button negateButton;
        private Button sevenButton;
        private Button eightButton;
        private Button nineButton;
        private Button fourButton;
        private Button fiveButton;
        private Button zeroButton;
        private Button decimalButton;
        private Button equalsButton;
        private Button sixButton;
    }
}
