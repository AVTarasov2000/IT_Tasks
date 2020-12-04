namespace task7Forms
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(207, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(195, 381);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.FunctionName, this.ButtonColumn});
            this.dataGridView1.Location = new System.Drawing.Point(628, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(265, 381);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FunctionName
            // 
            this.FunctionName.HeaderText = "Function";
            this.FunctionName.Name = "FunctionName";
            this.FunctionName.ReadOnly = true;
            // 
            // ButtonColumn
            // 
            this.ButtonColumn.HeaderText = "Execute";
            this.ButtonColumn.Name = "ButtonColumn";
            this.ButtonColumn.ReadOnly = true;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(10, 12);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(191, 194);
            this.chooseFileButton.TabIndex = 2;
            this.chooseFileButton.Text = "button1";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(408, 13);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(214, 381);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(901, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1047, 405);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.listBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridViewButtonColumn ButtonColumn;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FunctionName;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}