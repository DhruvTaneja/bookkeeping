namespace Diwas_Taneja
{
    partial class EditParty
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
            this.partyGrid = new System.Windows.Forms.DataGridView();
            this.partyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partyGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partyGrid
            // 
            this.partyGrid.AllowUserToAddRows = false;
            this.partyGrid.AllowUserToDeleteRows = false;
            this.partyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partyGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyName,
            this.balance});
            this.partyGrid.Location = new System.Drawing.Point(13, 13);
            this.partyGrid.Name = "partyGrid";
            this.partyGrid.Size = new System.Drawing.Size(387, 190);
            this.partyGrid.TabIndex = 0;
            this.partyGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.partyGrid_CellValueChanged);
            // 
            // partyName
            // 
            this.partyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partyName.HeaderText = "Party Name";
            this.partyName.Name = "partyName";
            // 
            // balance
            // 
            this.balance.HeaderText = "Balance";
            this.balance.Name = "balance";
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(166, 227);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditParty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(408, 258);
            this.ControlBox = false;
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.partyGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditParty";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditParty";
            ((System.ComponentModel.ISupportInitialize)(this.partyGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView partyGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
        private System.Windows.Forms.Button closeButton;
    }
}