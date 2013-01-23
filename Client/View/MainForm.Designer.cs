namespace View
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.newKeyTextBox = new System.Windows.Forms.TextBox();
            this.newValueTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.findKeyTextBox = new System.Windows.Forms.TextBox();
            this.foundValueTextBox = new System.Windows.Forms.TextBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.HtmlLoggerButton = new System.Windows.Forms.Button();
            this.PlainTextLoggerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newKeyTextBox
            // 
            this.newKeyTextBox.Location = new System.Drawing.Point(64, 69);
            this.newKeyTextBox.Name = "newKeyTextBox";
            this.newKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.newKeyTextBox.TabIndex = 0;
            // 
            // newValueTextBox
            // 
            this.newValueTextBox.Location = new System.Drawing.Point(64, 95);
            this.newValueTextBox.Name = "newValueTextBox";
            this.newValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.newValueTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(64, 139);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // findKeyTextBox
            // 
            this.findKeyTextBox.Location = new System.Drawing.Point(64, 192);
            this.findKeyTextBox.Name = "findKeyTextBox";
            this.findKeyTextBox.Size = new System.Drawing.Size(100, 20);
            this.findKeyTextBox.TabIndex = 3;
            // 
            // foundValueTextBox
            // 
            this.foundValueTextBox.Location = new System.Drawing.Point(64, 219);
            this.foundValueTextBox.Name = "foundValueTextBox";
            this.foundValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.foundValueTextBox.TabIndex = 4;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(64, 254);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(75, 23);
            this.FindButton.TabIndex = 5;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // HtmlLoggerButton
            // 
            this.HtmlLoggerButton.Location = new System.Drawing.Point(252, 91);
            this.HtmlLoggerButton.Name = "HtmlLoggerButton";
            this.HtmlLoggerButton.Size = new System.Drawing.Size(75, 23);
            this.HtmlLoggerButton.TabIndex = 6;
            this.HtmlLoggerButton.Text = "HTML";
            this.HtmlLoggerButton.UseVisualStyleBackColor = true;
            // 
            // PlainTextLoggerButton
            // 
            this.PlainTextLoggerButton.Location = new System.Drawing.Point(252, 121);
            this.PlainTextLoggerButton.Name = "PlainTextLoggerButton";
            this.PlainTextLoggerButton.Size = new System.Drawing.Size(75, 23);
            this.PlainTextLoggerButton.TabIndex = 7;
            this.PlainTextLoggerButton.Text = "Plain text";
            this.PlainTextLoggerButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 289);
            this.Controls.Add(this.PlainTextLoggerButton);
            this.Controls.Add(this.HtmlLoggerButton);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.foundValueTextBox);
            this.Controls.Add(this.findKeyTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.newValueTextBox);
            this.Controls.Add(this.newKeyTextBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox newKeyTextBox;
        private System.Windows.Forms.TextBox newValueTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox findKeyTextBox;
        private System.Windows.Forms.TextBox foundValueTextBox;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.Button HtmlLoggerButton;
        private System.Windows.Forms.Button PlainTextLoggerButton;
    }
}

