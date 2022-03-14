namespace GroceryStoreUserInterface
{
    partial class Login
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
            this.panel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_button = new System.Windows.Forms.Button();
            this.Password_label = new System.Windows.Forms.Label();
            this.Password_Text = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorMessage = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.Login_button);
            this.panel.Controls.Add(this.Password_label);
            this.panel.Controls.Add(this.Password_Text);
            this.panel.Controls.Add(this.Username_textBox);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(123, 125);
            this.panel.Margin = new System.Windows.Forms.Padding(5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(497, 415);
            this.panel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(194, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login";
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.Login_button.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_button.Location = new System.Drawing.Point(163, 318);
            this.Login_button.Margin = new System.Windows.Forms.Padding(5);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(134, 61);
            this.Login_button.TabIndex = 4;
            this.Login_button.Text = "Login";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_label.Location = new System.Drawing.Point(75, 202);
            this.Password_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(101, 28);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            // 
            // Password_Text
            // 
            this.Password_Text.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Password_Text.Location = new System.Drawing.Point(75, 247);
            this.Password_Text.Margin = new System.Windows.Forms.Padding(5);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.PasswordChar = 'X';
            this.Password_Text.PlaceholderText = "Enter Password";
            this.Password_Text.Size = new System.Drawing.Size(342, 34);
            this.Password_Text.TabIndex = 2;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Username_textBox.Location = new System.Drawing.Point(75, 139);
            this.Username_textBox.Margin = new System.Windows.Forms.Padding(5);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.PlaceholderText = "Enter username";
            this.Username_textBox.Size = new System.Drawing.Size(347, 34);
            this.Username_textBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // errorMessage
            // 
            this.errorMessage.BackColor = System.Drawing.SystemColors.HighlightText;
            this.errorMessage.ForeColor = System.Drawing.Color.Red;
            this.errorMessage.Location = new System.Drawing.Point(148, 56);
            this.errorMessage.Margin = new System.Windows.Forms.Padding(5);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(451, 39);
            this.errorMessage.TabIndex = 1;
            this.errorMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 620);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Login";
            this.Text = "Form1";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel;
        private Label label1;
        private Button Login_button;
        private Label Password_label;
        private TextBox Password_Text;
        private TextBox Username_textBox;
        private TextBox errorMessage;
        private Label label2;
    }
}