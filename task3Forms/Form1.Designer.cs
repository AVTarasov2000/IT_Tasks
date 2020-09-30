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
            this.numericMaxWeight = new System.Windows.Forms.NumericUpDown();
            this.numericPeopleCount = new System.Windows.Forms.NumericUpDown();
            this.baggageCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.train = new System.Windows.Forms.TextBox();
            this.trainLabel = new System.Windows.Forms.Label();
            this.getByPeopleBetween = new System.Windows.Forms.Button();
            this.addPassengerCarButton = new System.Windows.Forms.Button();
            this.addBaggageCarButton = new System.Windows.Forms.Button();
            this.numericMax = new System.Windows.Forms.NumericUpDown();
            this.numericMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sort = new System.Windows.Forms.Button();
            this.addPremiumCassButton = new System.Windows.Forms.Button();
            this.addSecondClassButton = new System.Windows.Forms.Button();
            this.addFirstClassButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.numericMaxWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericPeopleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.baggageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMin)).BeginInit();
            this.SuspendLayout();
            // 
            // numericMaxWeight
            // 
            this.numericMaxWeight.Location = new System.Drawing.Point(159, 55);
            this.numericMaxWeight.Maximum = new decimal(new int[] {10000, 0, 0, 0});
            this.numericMaxWeight.Name = "numericMaxWeight";
            this.numericMaxWeight.Size = new System.Drawing.Size(104, 22);
            this.numericMaxWeight.TabIndex = 0;
            this.numericMaxWeight.Value = new decimal(new int[] {1000, 0, 0, 0});
            // 
            // numericPeopleCount
            // 
            this.numericPeopleCount.Location = new System.Drawing.Point(586, 55);
            this.numericPeopleCount.Name = "numericPeopleCount";
            this.numericPeopleCount.Size = new System.Drawing.Size(103, 22);
            this.numericPeopleCount.TabIndex = 1;
            // 
            // baggageCount
            // 
            this.baggageCount.Location = new System.Drawing.Point(373, 55);
            this.baggageCount.Name = "baggageCount";
            this.baggageCount.Size = new System.Drawing.Size(103, 22);
            this.baggageCount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "max weight";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(269, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "baggage count";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(482, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "people count";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "add passenger car";
            // 
            // train
            // 
            this.train.Location = new System.Drawing.Point(55, 268);
            this.train.Name = "train";
            this.train.Size = new System.Drawing.Size(783, 22);
            this.train.TabIndex = 14;
            // 
            // trainLabel
            // 
            this.trainLabel.Location = new System.Drawing.Point(55, 248);
            this.trainLabel.Name = "trainLabel";
            this.trainLabel.Size = new System.Drawing.Size(98, 17);
            this.trainLabel.TabIndex = 15;
            this.trainLabel.Text = "train";
            // 
            // getByPeopleBetween
            // 
            this.getByPeopleBetween.Location = new System.Drawing.Point(55, 315);
            this.getByPeopleBetween.Name = "getByPeopleBetween";
            this.getByPeopleBetween.Size = new System.Drawing.Size(105, 29);
            this.getByPeopleBetween.TabIndex = 16;
            this.getByPeopleBetween.Text = "get between";
            this.getByPeopleBetween.UseVisualStyleBackColor = true;
            this.getByPeopleBetween.Click += new System.EventHandler(this.getByPeopleBetween_Click);
            // 
            // addPassengerCarButton
            // 
            this.addPassengerCarButton.Location = new System.Drawing.Point(695, 55);
            this.addPassengerCarButton.Name = "addPassengerCarButton";
            this.addPassengerCarButton.Size = new System.Drawing.Size(108, 21);
            this.addPassengerCarButton.TabIndex = 17;
            this.addPassengerCarButton.Text = "add pasenger car";
            this.addPassengerCarButton.UseVisualStyleBackColor = true;
            this.addPassengerCarButton.Click += new System.EventHandler(this.addPassengerCarButton_Click);
            // 
            // addBaggageCarButton
            // 
            this.addBaggageCarButton.Location = new System.Drawing.Point(696, 82);
            this.addBaggageCarButton.Name = "addBaggageCarButton";
            this.addBaggageCarButton.Size = new System.Drawing.Size(107, 23);
            this.addBaggageCarButton.TabIndex = 18;
            this.addBaggageCarButton.Text = "add baggage car";
            this.addBaggageCarButton.UseVisualStyleBackColor = true;
            this.addBaggageCarButton.Click += new System.EventHandler(this.addBaggageCarButton_Click);
            // 
            // numericMax
            // 
            this.numericMax.Location = new System.Drawing.Point(232, 321);
            this.numericMax.Name = "numericMax";
            this.numericMax.Size = new System.Drawing.Size(73, 22);
            this.numericMax.TabIndex = 19;
            // 
            // numericMin
            // 
            this.numericMin.Location = new System.Drawing.Point(373, 321);
            this.numericMin.Name = "numericMin";
            this.numericMin.Size = new System.Drawing.Size(73, 22);
            this.numericMin.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(186, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "max";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(331, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "min";
            // 
            // sort
            // 
            this.sort.Location = new System.Drawing.Point(54, 214);
            this.sort.Name = "sort";
            this.sort.Size = new System.Drawing.Size(98, 25);
            this.sort.TabIndex = 23;
            this.sort.Text = "sort";
            this.sort.UseVisualStyleBackColor = true;
            this.sort.Click += new System.EventHandler(this.sort_Click);
            // 
            // addPremiumCassButton
            // 
            this.addPremiumCassButton.Location = new System.Drawing.Point(647, 121);
            this.addPremiumCassButton.Name = "addPremiumCassButton";
            this.addPremiumCassButton.Size = new System.Drawing.Size(155, 21);
            this.addPremiumCassButton.TabIndex = 24;
            this.addPremiumCassButton.Text = "add premium cass button";
            this.addPremiumCassButton.UseVisualStyleBackColor = true;
            this.addPremiumCassButton.Click += new System.EventHandler(this.addPremiumCassButton_Click);
            // 
            // addSecondClassButton
            // 
            this.addSecondClassButton.Location = new System.Drawing.Point(648, 175);
            this.addSecondClassButton.Name = "addSecondClassButton";
            this.addSecondClassButton.Size = new System.Drawing.Size(155, 21);
            this.addSecondClassButton.TabIndex = 25;
            this.addSecondClassButton.Text = "add second cass button";
            this.addSecondClassButton.UseVisualStyleBackColor = true;
            this.addSecondClassButton.Click += new System.EventHandler(this.addSecondClassButton_Click);
            // 
            // addFirstClassButton
            // 
            this.addFirstClassButton.Location = new System.Drawing.Point(648, 148);
            this.addFirstClassButton.Name = "addFirstClassButton";
            this.addFirstClassButton.Size = new System.Drawing.Size(155, 21);
            this.addFirstClassButton.TabIndex = 26;
            this.addFirstClassButton.Text = "add first cass button";
            this.addFirstClassButton.UseVisualStyleBackColor = true;
            this.addFirstClassButton.Click += new System.EventHandler(this.addFirstClassButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 377);
            this.Controls.Add(this.addFirstClassButton);
            this.Controls.Add(this.addSecondClassButton);
            this.Controls.Add(this.addPremiumCassButton);
            this.Controls.Add(this.sort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericMin);
            this.Controls.Add(this.numericMax);
            this.Controls.Add(this.addBaggageCarButton);
            this.Controls.Add(this.addPassengerCarButton);
            this.Controls.Add(this.getByPeopleBetween);
            this.Controls.Add(this.trainLabel);
            this.Controls.Add(this.train);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.baggageCount);
            this.Controls.Add(this.numericPeopleCount);
            this.Controls.Add(this.numericMaxWeight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize) (this.numericMaxWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericPeopleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.baggageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numericMin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button addBaggageCarButton;
        private System.Windows.Forms.Button addFirstClassButton;
        private System.Windows.Forms.Button addPassengerCarButton;
        private System.Windows.Forms.Button addPremiumCassButton;
        private System.Windows.Forms.Button addSecondClassButton;
        private System.Windows.Forms.NumericUpDown baggageCount;
        private System.Windows.Forms.Button getByPeopleBetween;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericMax;
        private System.Windows.Forms.NumericUpDown numericMaxWeight;
        private System.Windows.Forms.NumericUpDown numericMin;
        private System.Windows.Forms.NumericUpDown numericPeopleCount;
        private System.Windows.Forms.Button sort;
        private System.Windows.Forms.TextBox train;
        private System.Windows.Forms.Label trainLabel;

        #endregion
    }
}