namespace CurrencyConverter
{
    partial class Converter
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultValueLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.amountValueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toValueTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fromValueTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ratesDataGridView = new System.Windows.Forms.DataGridView();
            this.IsoFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsoToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ratesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.convertButton);
            this.groupBox1.Controls.Add(this.resultValueLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.amountValueTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.toValueTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fromValueTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convert";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(127, 61);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButtonClick);
            // 
            // resultValueLabel
            // 
            this.resultValueLabel.AutoSize = true;
            this.resultValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultValueLabel.Location = new System.Drawing.Point(348, 35);
            this.resultValueLabel.Name = "resultValueLabel";
            this.resultValueLabel.Size = new System.Drawing.Size(49, 20);
            this.resultValueLabel.TabIndex = 8;
            this.resultValueLabel.Text = "####";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "=";
            // 
            // amountValueTextBox
            // 
            this.amountValueTextBox.Location = new System.Drawing.Point(221, 35);
            this.amountValueTextBox.Name = "amountValueTextBox";
            this.amountValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountValueTextBox.TabIndex = 6;
            this.amountValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountValueTextBoxKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // toValueTextBox
            // 
            this.toValueTextBox.Location = new System.Drawing.Point(115, 35);
            this.toValueTextBox.Name = "toValueTextBox";
            this.toValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.toValueTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // fromValueTextBox
            // 
            this.fromValueTextBox.Location = new System.Drawing.Point(9, 35);
            this.fromValueTextBox.Name = "fromValueTextBox";
            this.fromValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromValueTextBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.ratesDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(13, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 218);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rates";
            // 
            // ratesDataGridView
            // 
            this.ratesDataGridView.AllowUserToResizeRows = false;
            this.ratesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratesDataGridView.AutoGenerateColumns = false;
            this.ratesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ratesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsoFromColumn,
            this.IsoToColumn,
            this.RateColumn});
            this.ratesDataGridView.DataSource = this.bindingSource1;
            this.ratesDataGridView.Location = new System.Drawing.Point(6, 19);
            this.ratesDataGridView.Name = "ratesDataGridView";
            this.ratesDataGridView.Size = new System.Drawing.Size(504, 193);
            this.ratesDataGridView.TabIndex = 0;
            this.ratesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RatesDataGridViewRowHeaderMouseClick);
            // 
            // IsoFromColumn
            // 
            this.IsoFromColumn.DataPropertyName = "IsoFrom";
            this.IsoFromColumn.HeaderText = "ISO From";
            this.IsoFromColumn.Name = "IsoFromColumn";
            // 
            // IsoToColumn
            // 
            this.IsoToColumn.DataPropertyName = "IsoTo";
            this.IsoToColumn.HeaderText = "ISO To";
            this.IsoToColumn.Name = "IsoToColumn";
            // 
            // RateColumn
            // 
            this.RateColumn.DataPropertyName = "Rate";
            this.RateColumn.HeaderText = "Rate";
            this.RateColumn.Name = "RateColumn";
            // 
            // Converter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Converter";
            this.Text = "Converter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ratesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox toValueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fromValueTextBox;
        private System.Windows.Forms.TextBox amountValueTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label resultValueLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ratesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsoFromColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsoToColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RateColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

