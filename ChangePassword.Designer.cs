namespace Diwas_Taneja
{
    partial class ChangePassword
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
            this.oldBox = new System.Windows.Forms.TextBox();
            this.oldLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.newBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldBox
            // 
            this.oldBox.Location = new System.Drawing.Point(106, 45);
            this.oldBox.Name = "oldBox";
            this.oldBox.PasswordChar = '*';
            this.oldBox.Size = new System.Drawing.Size(170, 20);
            this.oldBox.TabIndex = 0;
            // 
            // oldLabel
            // 
            this.oldLabel.AutoSize = true;
            this.oldLabel.Location = new System.Drawing.Point(13, 48);
            this.oldLabel.Name = "oldLabel";
            this.oldLabel.Size = new System.Drawing.Size(72, 13);
            this.oldLabel.TabIndex = 1;
            this.oldLabel.Text = "Old Password";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(16, 98);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(78, 13);
            this.newLabel.TabIndex = 2;
            this.newLabel.Text = "New Password";
            // 
            // newBox
            // 
            this.newBox.Location = new System.Drawing.Point(106, 98);
            this.newBox.Name = "newBox";
            this.newBox.PasswordChar = '*';
            this.newBox.Size = new System.Drawing.Size(170, 20);
            this.newBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(358, 42);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(358, 72);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ChangePassword
            // 
            this.AcceptButton = this.saveButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(460, 173);
            this.ControlBox = false;
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newBox);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.oldLabel);
            this.Controls.Add(this.oldBox);
            this.Name = "ChangePassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldBox;
        private System.Windows.Forms.Label oldLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox newBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}