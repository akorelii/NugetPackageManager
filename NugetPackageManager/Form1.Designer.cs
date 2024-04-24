namespace NugetPackageManager
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
            goToUrlButton = new Button();
            urltextBox = new TextBox();
            SuspendLayout();
            // 
            // goToUrlButton
            // 
            goToUrlButton.BackColor = SystemColors.ActiveBorder;
            goToUrlButton.FlatStyle = FlatStyle.Flat;
            goToUrlButton.Location = new Point(12, 83);
            goToUrlButton.Name = "goToUrlButton";
            goToUrlButton.Size = new Size(388, 46);
            goToUrlButton.TabIndex = 0;
            goToUrlButton.Text = "Go To URL";
            goToUrlButton.UseVisualStyleBackColor = false;
            goToUrlButton.Click += goToUrlButton_Click;
            // 
            // urltextBox
            // 
            urltextBox.ForeColor = Color.Gray;
            urltextBox.Location = new Point(12, 33);
            urltextBox.Name = "urltextBox";
            urltextBox.Size = new Size(388, 27);
            urltextBox.TabIndex = 1;
            urltextBox.Text = "URL -->";
            urltextBox.Click += urltextBox_Click;
            urltextBox.TextChanged += urltextBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 146);
            Controls.Add(urltextBox);
            Controls.Add(goToUrlButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button goToUrlButton;
        private TextBox urltextBox;
    }
}
