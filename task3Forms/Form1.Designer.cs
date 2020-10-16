namespace task3Forms
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
            this.numericPeopleCount = new System.Windows.Forms.NumericUpDown();
            this.baggageCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.TextBox();
            this.trainLabel = new System.Windows.Forms.Label();
            this.getByPeopleBetween = new System.Windows.Forms.Button();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.Button();
            this.addPremiumCassButton = new System.Windows.Forms.Button();
            this.addSecondClassButton = new System.Windows.Forms.Button();
            this.addFirstClassButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.numericPeopleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.baggageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericPeopleCount
            // 
            this.numericPeopleCount.Location = new System.Drawing.Point(305, 84);
            this.numericPeopleCount.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.numericPeopleCount.Name = "numericPeopleCount";
            this.numericPeopleCount.Size = new System.Drawing.Size(223, 39);
            this.numericPeopleCount.TabIndex = 1;
            // 
            // baggageCount
            // 
            this.baggageCount.Location = new System.Drawing.Point(31, 84);
            this.baggageCount.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.baggageCount.Name = "baggageCount";
            this.baggageCount.Size = new System.Drawing.Size(223, 39);
            this.baggageCount.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "baggage count";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(305, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 49);
            this.label3.TabIndex = 5;
            this.label3.Text = "people count";
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(31, 404);
            this.train.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(1036, 39);
            this.train.TabIndex = 14;
            // 
            // trainLabel
            // 
            this.trainLabel.Location = new System.Drawing.Point(31, 354);
            this.trainLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(212, 42);
            this.trainLabel.TabIndex = 15;
            this.trainLabel.Text = "train";
            // 
            // getByPeopleBetween
            // 
            this.getByPeopleBetween.Location = new System.Drawing.Point(293, 261);
            this.getByPeopleBetween.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.getByPeopleBetween.Name = "getByPeopleBetween";
            this.getByPeopleBetween.Size = new System.Drawing.Size(228, 81);
            this.getByPeopleBetween.TabIndex = 16;
            this.getByPeopleBetween.Text = "get between";
            this.getByPeopleBetween.UseVisualStyleBackColor = true;
            this.getByPeopleBetween.Click += new System.EventHandler(this.getByPeopleBetween_Click);
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(535, 303);
            this.numericMax.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(158, 39);
            this.numericMax.TabIndex = 19;
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(707, 303);
            this.numericMin.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(158, 39);
            this.numericMin.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(535, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 34);
            this.label6.TabIndex = 21;
            this.label6.Text = "max";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(707, 261);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 34);
            this.label9.TabIndex = 22;
            this.label9.Text = "min";
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(31, 261);
            this.sort.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(212, 81);
            this.sort.TabIndex = 23;
            this.sort.Text = "sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // addPremiumCassButton
            // 
            this.addPremiumCassButton.Location = new System.Drawing.Point(31, 162);
            this.addPremiumCassButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addPremiumCassButton.Name = "addPremiumCassButton";
            this.addPremiumCassButton.Size = new System.Drawing.Size(336, 51);
            this.addPremiumCassButton.TabIndex = 24;
            this.addPremiumCassButton.Text = "add premium cass button";
            this.addPremiumCassButton.UseVisualStyleBackColor = true;
            this.addPremiumCassButton.Click += new System.EventHandler(this.addPremiumCassButton_Click);
            // 
            // addSecondClassButton
            // 
            this.addSecondClassButton.Location = new System.Drawing.Point(731, 162);
            this.addSecondClassButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addSecondClassButton.Name = "addSecondClassButton";
            this.addSecondClassButton.Size = new System.Drawing.Size(336, 51);
            this.addSecondClassButton.TabIndex = 25;
            this.addSecondClassButton.Text = "add second cass button";
            this.addSecondClassButton.UseVisualStyleBackColor = true;
            this.addSecondClassButton.Click += new System.EventHandler(this.addSecondClassButton_Click);
            // 
            // addFirstClassButton
            // 
            this.addFirstClassButton.Location = new System.Drawing.Point(381, 162);
            this.addFirstClassButton.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.addFirstClassButton.Name = "addFirstClassButton";
            this.addFirstClassButton.Size = new System.Drawing.Size(336, 51);
            this.addFirstClassButton.TabIndex = 26;
            this.addFirstClassButton.Text = "add first cass button";
            this.addFirstClassButton.UseVisualStyleBackColor = true;
            this.addFirstClassButton.Click += new System.EventHandler(this.addFirstClassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 928);
            this.Controls.Add(this.addFirstClassButton);
            this.Controls.Add(this.addSecondClassButton);
            this.Controls.Add(this.addPremiumCassButton);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericMin);
            this.Controls.Add(this.numericMax);
            this.Controls.Add(this.getByPeopleBetween);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.train);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.baggageCount);
            this.Controls.Add(this.numericPeopleCount);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.numericPeopleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.baggageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addFirstClassButton;
        private System.Windows.Forms.Button addPremiumCassButton;
        private System.Windows.Forms.Button addSecondClassButton;
        private System.Windows.Forms.NumericUpDown baggageCount;
        private System.Windows.Forms.Button getByPeopleBetween;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.NumericUpDown numericPeopleCount;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox train;
        private System.Windows.Forms.Label trainLabel;

        #endregion
    }
}