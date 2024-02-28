namespace CounterMVC {
    partial class FormView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonIncrement = new System.Windows.Forms.Button();
            this.labelIncrement = new System.Windows.Forms.Label();
            this.comboBoxIncrement = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.RadioButton();
            this.subtractButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(28, 35);
            this.buttonIncrement.Name = "buttonIncrement";
            this.buttonIncrement.Size = new System.Drawing.Size(112, 73);
            this.buttonIncrement.TabIndex = 0;
            this.buttonIncrement.Text = "Increment";
            this.buttonIncrement.UseVisualStyleBackColor = true;
            this.buttonIncrement.Click += new System.EventHandler(this.buttonIncrement_Click);
            // 
            // labelIncrement
            // 
            this.labelIncrement.AutoSize = true;
            this.labelIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncrement.Location = new System.Drawing.Point(199, 79);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(99, 108);
            this.labelIncrement.TabIndex = 1;
            this.labelIncrement.Text = "0";
            // 
            // comboBoxIncrement
            // 
            this.comboBoxIncrement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIncrement.FormattingEnabled = true;
            this.comboBoxIncrement.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxIncrement.Location = new System.Drawing.Point(39, 114);
            this.comboBoxIncrement.Name = "comboBoxIncrement";
            this.comboBoxIncrement.Size = new System.Drawing.Size(85, 21);
            this.comboBoxIncrement.TabIndex = 2;
            this.comboBoxIncrement.SelectedIndexChanged += new System.EventHandler(this.comboBoxIncrement_SelectedIndexChanged);
            this.comboBoxIncrement.SelectedValueChanged += new System.EventHandler(this.comboBoxIncrement_SelectedValueChanged);
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Location = new System.Drawing.Point(15, 19);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(31, 17);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.CheckedChanged += new System.EventHandler(this.addButton_CheckedChanged);
            // 
            // subtractButton
            // 
            this.subtractButton.AutoSize = true;
            this.subtractButton.Location = new System.Drawing.Point(15, 44);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(28, 17);
            this.subtractButton.TabIndex = 5;
            this.subtractButton.Text = "-";
            this.subtractButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.subtractButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Location = new System.Drawing.Point(28, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add or Subtract";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 279);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBoxIncrement);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.buttonIncrement);
            this.Name = "FormView";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Label labelIncrement;
        private System.Windows.Forms.ComboBox comboBoxIncrement;
        private System.Windows.Forms.RadioButton addButton;
        private System.Windows.Forms.RadioButton subtractButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

