namespace task6Forms
{
    partial class Form1
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
            this.InstrumentName = new System.Windows.Forms.TextBox();
            this.instrumentNameLabel = new System.Windows.Forms.Label();
            this.addInstrumentButton = new System.Windows.Forms.Button();
            this.listInstruments = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize) (this.listInstruments)).BeginInit();
            this.SuspendLayout();
            // 
            // InstrumentName
            // 
            this.InstrumentName.Location = new System.Drawing.Point(370, 368);
            this.InstrumentName.Name = "InstrumentName";
            this.InstrumentName.Size = new System.Drawing.Size(131, 22);
            this.InstrumentName.TabIndex = 1;
            // 
            // instrumentNameLabel
            // 
            this.instrumentNameLabel.Location = new System.Drawing.Point(370, 344);
            this.instrumentNameLabel.Name = "instrumentNameLabel";
            this.instrumentNameLabel.Size = new System.Drawing.Size(130, 21);
            this.instrumentNameLabel.TabIndex = 2;
            this.instrumentNameLabel.Text = "name";
            // 
            // addInstrumentButton
            // 
            this.addInstrumentButton.Location = new System.Drawing.Point(370, 396);
            this.addInstrumentButton.Name = "addInstrumentButton";
            this.addInstrumentButton.Size = new System.Drawing.Size(131, 23);
            this.addInstrumentButton.TabIndex = 3;
            this.addInstrumentButton.Text = "button1";
            this.addInstrumentButton.UseVisualStyleBackColor = true;
            this.addInstrumentButton.Click += new System.EventHandler(this.addInstrumentButton_Click);
            // 
            // listInstruments
            // 
            this.listInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listInstruments.Location = new System.Drawing.Point(6, 8);
            this.listInstruments.Name = "listInstruments";
            this.listInstruments.RowTemplate.Height = 24;
            this.listInstruments.Size = new System.Drawing.Size(338, 410);
            this.listInstruments.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 446);
            this.Controls.Add(this.listInstruments);
            this.Controls.Add(this.addInstrumentButton);
            this.Controls.Add(this.instrumentNameLabel);
            this.Controls.Add(this.InstrumentName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.listInstruments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addInstrumentButton;
        private System.Windows.Forms.TextBox InstrumentName;
        private System.Windows.Forms.Label instrumentNameLabel;
        private System.Windows.Forms.DataGridView listInstruments;

        #endregion
    }
}