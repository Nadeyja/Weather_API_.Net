namespace Weather_API
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
            button1 = new Button();
            cityTextBox = new TextBox();
            OutputTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            HourTextbox = new TextBox();
            label3 = new Label();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(619, 26);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(252, 64);
            button1.TabIndex = 0;
            button1.Text = "Check weather";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(11, 26);
            cityTextBox.Margin = new Padding(2);
            cityTextBox.Multiline = true;
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(603, 64);
            cityTextBox.TabIndex = 1;
            // 
            // OutputTextBox
            // 
            OutputTextBox.Location = new Point(11, 167);
            OutputTextBox.Margin = new Padding(2);
            OutputTextBox.Multiline = true;
            OutputTextBox.Name = "OutputTextBox";
            OutputTextBox.ReadOnly = true;
            OutputTextBox.Size = new Size(859, 264);
            OutputTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 150);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Temperature";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 9);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "City";
            // 
            // HourTextbox
            // 
            HourTextbox.Location = new Point(12, 124);
            HourTextbox.Name = "HourTextbox";
            HourTextbox.Size = new Size(111, 23);
            HourTextbox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 106);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 6;
            label3.Text = "Hours forward";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(181, 123);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(75, 23);
            ClearButton.TabIndex = 7;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(882, 442);
            Controls.Add(ClearButton);
            Controls.Add(label3);
            Controls.Add(HourTextbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OutputTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox cityTextBox;
        private TextBox OutputTextBox;
        private Label label1;
        private Label label2;
        private TextBox HourTextbox;
        private Label label3;
        private Button ClearButton;
    }
}