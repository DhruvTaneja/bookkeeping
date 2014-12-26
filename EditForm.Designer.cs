namespace Diwas_Taneja
{
    partial class EditForm
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
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.wrong1 = new System.Windows.Forms.Label();
            this.itemLabel = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.ComboBox();
            this.packetLabel = new System.Windows.Forms.Label();
            this.packetBox = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.rateBox = new System.Windows.Forms.TextBox();
            this.wrong3 = new System.Windows.Forms.Label();
            this.wrong4 = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.receivedLabel = new System.Windows.Forms.Label();
            this.receivedBox = new System.Windows.Forms.TextBox();
            this.netLabel = new System.Windows.Forms.Label();
            this.netValue = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.partyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(33, 75);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(57, 25);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            // 
            // dayBox
            // 
            this.dayBox.Location = new System.Drawing.Point(12, 103);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(21, 20);
            this.dayBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = " / ";
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(48, 103);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(21, 20);
            this.monthBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = " / ";
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(87, 103);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(35, 20);
            this.yearBox.TabIndex = 19;
            // 
            // wrong1
            // 
            this.wrong1.AutoSize = true;
            this.wrong1.ForeColor = System.Drawing.Color.Red;
            this.wrong1.Location = new System.Drawing.Point(35, 126);
            this.wrong1.Name = "wrong1";
            this.wrong1.Size = new System.Drawing.Size(66, 13);
            this.wrong1.TabIndex = 22;
            this.wrong1.Text = "Wrong Input";
            // 
            // itemLabel
            // 
            this.itemLabel.AutoSize = true;
            this.itemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemLabel.Location = new System.Drawing.Point(187, 74);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(52, 25);
            this.itemLabel.TabIndex = 23;
            this.itemLabel.Text = "Item";
            // 
            // itemBox
            // 
            this.itemBox.FormattingEnabled = true;
            this.itemBox.Location = new System.Drawing.Point(162, 102);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(100, 21);
            this.itemBox.TabIndex = 24;
            // 
            // packetLabel
            // 
            this.packetLabel.AutoSize = true;
            this.packetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.packetLabel.Location = new System.Drawing.Point(320, 75);
            this.packetLabel.Name = "packetLabel";
            this.packetLabel.Size = new System.Drawing.Size(89, 25);
            this.packetLabel.TabIndex = 25;
            this.packetLabel.Text = "Packets";
            // 
            // packetBox
            // 
            this.packetBox.Location = new System.Drawing.Point(317, 104);
            this.packetBox.Name = "packetBox";
            this.packetBox.Size = new System.Drawing.Size(100, 20);
            this.packetBox.TabIndex = 26;
            this.packetBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.packetBox_KeyUp);
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rateLabel.Location = new System.Drawing.Point(483, 75);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(57, 25);
            this.rateLabel.TabIndex = 27;
            this.rateLabel.Text = "Rate";
            // 
            // rateBox
            // 
            this.rateBox.Location = new System.Drawing.Point(462, 102);
            this.rateBox.Name = "rateBox";
            this.rateBox.Size = new System.Drawing.Size(100, 20);
            this.rateBox.TabIndex = 28;
            this.rateBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rateBox_KeyUp);
            // 
            // wrong3
            // 
            this.wrong3.AutoSize = true;
            this.wrong3.ForeColor = System.Drawing.Color.Red;
            this.wrong3.Location = new System.Drawing.Point(322, 127);
            this.wrong3.Name = "wrong3";
            this.wrong3.Size = new System.Drawing.Size(66, 13);
            this.wrong3.TabIndex = 29;
            this.wrong3.Text = "Wrong Input";
            // 
            // wrong4
            // 
            this.wrong4.AutoSize = true;
            this.wrong4.ForeColor = System.Drawing.Color.Red;
            this.wrong4.Location = new System.Drawing.Point(474, 125);
            this.wrong4.Name = "wrong4";
            this.wrong4.Size = new System.Drawing.Size(66, 13);
            this.wrong4.TabIndex = 30;
            this.wrong4.Text = "Wrong Input";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(600, 99);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(60, 25);
            this.totalLabel.TabIndex = 31;
            this.totalLabel.Text = "Total";
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.Location = new System.Drawing.Point(690, 93);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(29, 31);
            this.valueLabel.TabIndex = 32;
            this.valueLabel.Text = "#";
            this.valueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // receivedLabel
            // 
            this.receivedLabel.AutoSize = true;
            this.receivedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedLabel.Location = new System.Drawing.Point(483, 183);
            this.receivedLabel.Name = "receivedLabel";
            this.receivedLabel.Size = new System.Drawing.Size(102, 25);
            this.receivedLabel.TabIndex = 33;
            this.receivedLabel.Text = "Received";
            // 
            // receivedBox
            // 
            this.receivedBox.Location = new System.Drawing.Point(591, 188);
            this.receivedBox.Name = "receivedBox";
            this.receivedBox.Size = new System.Drawing.Size(143, 20);
            this.receivedBox.TabIndex = 34;
            this.receivedBox.Text = "0";
            // 
            // netLabel
            // 
            this.netLabel.AutoSize = true;
            this.netLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netLabel.Location = new System.Drawing.Point(615, 256);
            this.netLabel.Name = "netLabel";
            this.netLabel.Size = new System.Drawing.Size(45, 25);
            this.netLabel.TabIndex = 35;
            this.netLabel.Text = "Net";
            // 
            // netValue
            // 
            this.netValue.AutoSize = true;
            this.netValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.netValue.Location = new System.Drawing.Point(690, 256);
            this.netValue.Name = "netValue";
            this.netValue.Size = new System.Drawing.Size(29, 31);
            this.netValue.TabIndex = 36;
            this.netValue.Text = "#";
            this.netValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(646, 348);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 38);
            this.saveButton.TabIndex = 37;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyLabel.Location = new System.Drawing.Point(320, 9);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(119, 33);
            this.partyLabel.TabIndex = 38;
            this.partyLabel.Text = "Packets";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 398);
            this.Controls.Add(this.partyLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.netValue);
            this.Controls.Add(this.netLabel);
            this.Controls.Add(this.receivedBox);
            this.Controls.Add(this.receivedLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.wrong4);
            this.Controls.Add(this.wrong3);
            this.Controls.Add(this.rateBox);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.packetBox);
            this.Controls.Add(this.packetLabel);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.itemLabel);
            this.Controls.Add(this.wrong1);
            this.Controls.Add(this.yearBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayBox);
            this.Controls.Add(this.dateLabel);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EditForm_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.Label wrong1;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ComboBox itemBox;
        private System.Windows.Forms.Label packetLabel;
        private System.Windows.Forms.TextBox packetBox;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.TextBox rateBox;
        private System.Windows.Forms.Label wrong3;
        private System.Windows.Forms.Label wrong4;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label receivedLabel;
        private System.Windows.Forms.TextBox receivedBox;
        private System.Windows.Forms.Label netLabel;
        private System.Windows.Forms.Label netValue;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label partyLabel;
    }
}