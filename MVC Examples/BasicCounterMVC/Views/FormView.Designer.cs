namespace BasicCounterMVC {
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
            this.SuspendLayout();
            // 
            // buttonIncrement
            // 
            this.buttonIncrement.Location = new System.Drawing.Point(71, 89);
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
            this.labelIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIncrement.Location = new System.Drawing.Point(227, 89);
            this.labelIncrement.Name = "labelIncrement";
            this.labelIncrement.Size = new System.Drawing.Size(69, 73);
            this.labelIncrement.TabIndex = 1;
            this.labelIncrement.Text = "0";
            // 
            // FormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 254);
            this.Controls.Add(this.labelIncrement);
            this.Controls.Add(this.buttonIncrement);
            this.Name = "FormView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonIncrement;
        private System.Windows.Forms.Label labelIncrement;
    }
}

