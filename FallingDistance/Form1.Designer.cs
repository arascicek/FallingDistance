namespace FallingDistance
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtInput = new TextBox();
            btnCal = new Button();
            lblOutput = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 0;
            label1.Text = "Falling time(seconds)";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(12, 58);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(245, 27);
            txtInput.TabIndex = 1;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(306, 58);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(94, 29);
            btnCal.TabIndex = 2;
            btnCal.Text = "Calculate";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // lblOutput
            // 
            lblOutput.BorderStyle = BorderStyle.FixedSingle;
            lblOutput.Location = new Point(12, 109);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(388, 25);
            lblOutput.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 181);
            Controls.Add(lblOutput);
            Controls.Add(btnCal);
            Controls.Add(txtInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Falling Distance";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtInput;
        private Button btnCal;
        private Label lblOutput;
    }
}
