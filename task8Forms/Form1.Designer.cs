namespace task8Forms
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.simpleBreakNumeric = new System.Windows.Forms.NumericUpDown();
            this.complexBreakNumeric = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize) (this.simpleBreakNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.complexBreakNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 457);
            this.panel1.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(15, 489);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(125, 47);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // simpleBreakNumeric
            // 
            this.simpleBreakNumeric.Location = new System.Drawing.Point(743, 82);
            this.simpleBreakNumeric.Name = "simpleBreakNumeric";
            this.simpleBreakNumeric.Size = new System.Drawing.Size(90, 22);
            this.simpleBreakNumeric.TabIndex = 2;
            // 
            // complexBreakNumeric
            // 
            this.complexBreakNumeric.Location = new System.Drawing.Point(743, 136);
            this.complexBreakNumeric.Name = "complexBreakNumeric";
            this.complexBreakNumeric.Size = new System.Drawing.Size(89, 22);
            this.complexBreakNumeric.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(743, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "simple break %";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(742, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "complex break %";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.complexBreakNumeric);
            this.Controls.Add(this.simpleBreakNumeric);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize) (this.simpleBreakNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.complexBreakNumeric)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.NumericUpDown complexBreakNumeric;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown simpleBreakNumeric;
        private System.Windows.Forms.Button startButton;

        #endregion
    }
}