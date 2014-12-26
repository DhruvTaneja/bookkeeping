namespace Diwas_Taneja
{
    partial class BigPic
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
            this.partyCheckList = new System.Windows.Forms.CheckedListBox();
            this.bigDataGrid = new System.Windows.Forms.DataGridView();
            this.partyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partyLabel = new System.Windows.Forms.Label();
            this.allParty = new System.Windows.Forms.LinkLabel();
            this.noneParty = new System.Windows.Forms.LinkLabel();
            this.monthCheckList = new System.Windows.Forms.CheckedListBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.allMonth = new System.Windows.Forms.LinkLabel();
            this.noneMonth = new System.Windows.Forms.LinkLabel();
            this.itemCheckList = new System.Windows.Forms.CheckedListBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.allItems = new System.Windows.Forms.LinkLabel();
            this.noneItems = new System.Windows.Forms.LinkLabel();
            this.viewButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bigDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // partyCheckList
            // 
            this.partyCheckList.FormattingEnabled = true;
            this.partyCheckList.Location = new System.Drawing.Point(12, 31);
            this.partyCheckList.Name = "partyCheckList";
            this.partyCheckList.Size = new System.Drawing.Size(184, 184);
            this.partyCheckList.TabIndex = 0;
            this.partyCheckList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.partyCheckList_ItemCheck);
            this.partyCheckList.Click += new System.EventHandler(this.partyCheckList_Click);
            this.partyCheckList.SelectedIndexChanged += new System.EventHandler(this.partyCheckList_SelectedIndexChanged);
            this.partyCheckList.DoubleClick += new System.EventHandler(this.partyCheckList_DoubleClick);
            // 
            // bigDataGrid
            // 
            this.bigDataGrid.AllowUserToDeleteRows = false;
            this.bigDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bigDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partyName,
            this.date,
            this.itemName});
            this.bigDataGrid.Location = new System.Drawing.Point(203, 12);
            this.bigDataGrid.Name = "bigDataGrid";
            this.bigDataGrid.ReadOnly = true;
            this.bigDataGrid.Size = new System.Drawing.Size(517, 580);
            this.bigDataGrid.TabIndex = 1;
            // 
            // partyName
            // 
            this.partyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.partyName.HeaderText = "Party Name";
            this.partyName.Name = "partyName";
            this.partyName.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // itemName
            // 
            this.itemName.HeaderText = "Item";
            this.itemName.Name = "itemName";
            this.itemName.ReadOnly = true;
            // 
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyLabel.Location = new System.Drawing.Point(12, 12);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(80, 16);
            this.partyLabel.TabIndex = 2;
            this.partyLabel.Text = "Select Party";
            // 
            // allParty
            // 
            this.allParty.ActiveLinkColor = System.Drawing.Color.Blue;
            this.allParty.AutoSize = true;
            this.allParty.Location = new System.Drawing.Point(9, 218);
            this.allParty.Name = "allParty";
            this.allParty.Size = new System.Drawing.Size(51, 13);
            this.allParty.TabIndex = 3;
            this.allParty.TabStop = true;
            this.allParty.Text = "Select All";
            this.allParty.VisitedLinkColor = System.Drawing.Color.Blue;
            this.allParty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allParty_LinkClicked);
            // 
            // noneParty
            // 
            this.noneParty.ActiveLinkColor = System.Drawing.Color.Blue;
            this.noneParty.AutoSize = true;
            this.noneParty.Location = new System.Drawing.Point(133, 218);
            this.noneParty.Name = "noneParty";
            this.noneParty.Size = new System.Drawing.Size(63, 13);
            this.noneParty.TabIndex = 4;
            this.noneParty.TabStop = true;
            this.noneParty.Text = "Deselect All";
            this.noneParty.VisitedLinkColor = System.Drawing.Color.Blue;
            this.noneParty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noneParty_LinkClicked);
            // 
            // monthCheckList
            // 
            this.monthCheckList.FormattingEnabled = true;
            this.monthCheckList.Location = new System.Drawing.Point(12, 279);
            this.monthCheckList.Name = "monthCheckList";
            this.monthCheckList.Size = new System.Drawing.Size(184, 124);
            this.monthCheckList.TabIndex = 5;
            this.monthCheckList.Click += new System.EventHandler(this.monthCheckList_Click);
            this.monthCheckList.SelectedIndexChanged += new System.EventHandler(this.monthCheckList_SelectedIndexChanged);
            this.monthCheckList.DoubleClick += new System.EventHandler(this.monthCheckList_DoubleClick);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(12, 260);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(85, 16);
            this.monthLabel.TabIndex = 6;
            this.monthLabel.Text = "Select Month";
            // 
            // allMonth
            // 
            this.allMonth.ActiveLinkColor = System.Drawing.Color.Blue;
            this.allMonth.AutoSize = true;
            this.allMonth.Location = new System.Drawing.Point(12, 406);
            this.allMonth.Name = "allMonth";
            this.allMonth.Size = new System.Drawing.Size(51, 13);
            this.allMonth.TabIndex = 7;
            this.allMonth.TabStop = true;
            this.allMonth.Text = "Select All";
            this.allMonth.VisitedLinkColor = System.Drawing.Color.Blue;
            this.allMonth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allMonth_LinkClicked);
            // 
            // noneMonth
            // 
            this.noneMonth.ActiveLinkColor = System.Drawing.Color.Blue;
            this.noneMonth.AutoSize = true;
            this.noneMonth.Location = new System.Drawing.Point(134, 406);
            this.noneMonth.Name = "noneMonth";
            this.noneMonth.Size = new System.Drawing.Size(63, 13);
            this.noneMonth.TabIndex = 8;
            this.noneMonth.TabStop = true;
            this.noneMonth.Text = "Deselect All";
            this.noneMonth.VisitedLinkColor = System.Drawing.Color.Blue;
            this.noneMonth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noneMonth_LinkClicked);
            // 
            // itemCheckList
            // 
            this.itemCheckList.FormattingEnabled = true;
            this.itemCheckList.Location = new System.Drawing.Point(12, 468);
            this.itemCheckList.Name = "itemCheckList";
            this.itemCheckList.Size = new System.Drawing.Size(184, 124);
            this.itemCheckList.TabIndex = 9;
            this.itemCheckList.Click += new System.EventHandler(this.itemCheckList_Click);
            this.itemCheckList.SelectedIndexChanged += new System.EventHandler(this.itemCheckList_SelectedIndexChanged);
            this.itemCheckList.DoubleClick += new System.EventHandler(this.itemCheckList_DoubleClick);
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(9, 449);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(74, 16);
            this.itemLabel.TabIndex = 10;
            this.itemLabel.Text = "Select Item";
            // 
            // allItems
            // 
            this.allItems.ActiveLinkColor = System.Drawing.Color.Blue;
            this.allItems.AutoSize = true;
            this.allItems.Location = new System.Drawing.Point(12, 595);
            this.allItems.Name = "allItems";
            this.allItems.Size = new System.Drawing.Size(51, 13);
            this.allItems.TabIndex = 11;
            this.allItems.TabStop = true;
            this.allItems.Text = "Select All";
            this.allItems.VisitedLinkColor = System.Drawing.Color.Blue;
            this.allItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.allItems_LinkClicked);
            // 
            // noneItems
            // 
            this.noneItems.ActiveLinkColor = System.Drawing.Color.Blue;
            this.noneItems.AutoSize = true;
            this.noneItems.Location = new System.Drawing.Point(134, 595);
            this.noneItems.Name = "noneItems";
            this.noneItems.Size = new System.Drawing.Size(63, 13);
            this.noneItems.TabIndex = 12;
            this.noneItems.TabStop = true;
            this.noneItems.Text = "Deselect All";
            this.noneItems.VisitedLinkColor = System.Drawing.Color.Blue;
            this.noneItems.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.noneItems_LinkClicked);
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(424, 598);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(75, 23);
            this.viewButton.TabIndex = 13;
            this.viewButton.Text = "View";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // BigPic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 631);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.noneItems);
            this.Controls.Add(this.allItems);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.itemCheckList);
            this.Controls.Add(this.noneMonth);
            this.Controls.Add(this.allMonth);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.monthCheckList);
            this.Controls.Add(this.noneParty);
            this.Controls.Add(this.allParty);
            this.Controls.Add(this.partyLabel);
            this.Controls.Add(this.bigDataGrid);
            this.Controls.Add(this.partyCheckList);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BigPic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Group View";
            this.Load += new System.EventHandler(this.BigPic_Load);
            this.Click += new System.EventHandler(this.BigPic_Click);
            this.DoubleClick += new System.EventHandler(this.BigPic_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.bigDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox partyCheckList;
        private System.Windows.Forms.DataGridView bigDataGrid;
        private System.Windows.Forms.Label partyLabel;
        private System.Windows.Forms.LinkLabel allParty;
        private System.Windows.Forms.LinkLabel noneParty;
        private System.Windows.Forms.CheckedListBox monthCheckList;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.LinkLabel allMonth;
        private System.Windows.Forms.LinkLabel noneMonth;
        private System.Windows.Forms.CheckedListBox itemCheckList;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.LinkLabel allItems;
        private System.Windows.Forms.LinkLabel noneItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn partyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemName;
        private System.Windows.Forms.Button viewButton;
    }
}