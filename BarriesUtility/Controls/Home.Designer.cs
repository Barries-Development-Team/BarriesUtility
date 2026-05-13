namespace BarriesUtility.Controls
{
    partial class Home
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TestLabel = new Label();
            TestButton = new Button();
            SuspendLayout();
            // 
            // TestLabel
            // 
            TestLabel.AutoSize = true;
            TestLabel.Location = new Point(80, 87);
            TestLabel.Name = "TestLabel";
            TestLabel.Size = new Size(71, 20);
            TestLabel.TabIndex = 0;
            TestLabel.Text = "TestLabel";
            // 
            // TestButton
            // 
            TestButton.Location = new Point(157, 83);
            TestButton.Name = "TestButton";
            TestButton.Size = new Size(94, 29);
            TestButton.TabIndex = 1;
            TestButton.Text = "button1";
            TestButton.UseVisualStyleBackColor = true;
            TestButton.Click += TestButton_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TestButton);
            Controls.Add(TestLabel);
            Name = "Home";
            Size = new Size(818, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TestLabel;
        private Button TestButton;
    }
}
